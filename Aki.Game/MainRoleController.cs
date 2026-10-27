using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x020027A0 RID: 10144
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MainRoleController : UiControllerBase
{
	// Token: 0x06014D44 RID: 85316 RVA: 0x00548FE2 File Offset: 0x005471E2
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleGenderChangeView, new Func<EUiViewName, object, bool>(this.CanOpenView), "MainRoleController.CanOpenView");
	}

	// Token: 0x06014D45 RID: 85317 RVA: 0x00549004 File Offset: 0x00547204
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleGenderChangeView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x06014D46 RID: 85318 RVA: 0x00549024 File Offset: 0x00547224
	[NullableContext(2)]
	private bool CanOpenView(EUiViewName viewName, object param)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		bool? flag;
		if (baseCharacter == null)
		{
			flag = null;
		}
		else
		{
			BaseTagComponent component = baseCharacter.CharacterActorComponent.Entity.GetComponent<BaseTagComponent>();
			flag = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"])) : null);
		}
		bool? flag2 = flag;
		bool flag3 = GameModeController.Instance.IsInInstance();
		if (flag2.GetValueOrDefault())
		{
			ScrollingTipsController.Instance.ShowTipsByText(TextConfig.Instance.GetTextById("CanNotTransferInFight"));
			return false;
		}
		if (flag3)
		{
			ScrollingTipsController.Instance.ShowTipsByText(TextConfig.Instance.GetTextById("CanNotTransferInInstance"));
			return false;
		}
		return SubPackageDownLoadModel.Instance.CheckGenderHaveSubPackage();
	}

	// Token: 0x06014D47 RID: 85319 RVA: 0x005490DC File Offset: 0x005472DC
	public bool IsCanChangeRole(int roleId)
	{
		int[] canChangeRoleIdList = RoleModel.Instance.GetCanChangeRoleIdList();
		int num = canChangeRoleIdList.Length;
		for (int i = 0; i < num; i++)
		{
			if (canChangeRoleIdList[i] == roleId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06014D48 RID: 85320 RVA: 0x0054910D File Offset: 0x0054730D
	public bool IsMainRole(int roleId)
	{
		return RoleModel.Instance.IsMainRole(roleId);
	}

	// Token: 0x06014D49 RID: 85321 RVA: 0x00549120 File Offset: 0x00547320
	public void SendRoleSexChangeRequest(int sex)
	{
		RoleSexChangeRequest roleSexChangeRequest = RoleSexChangeRequest.Create();
		roleSexChangeRequest.Sex = sex;
		Net.Instance.Call(ERequestMessageId.RoleSexChangeRequest, roleSexChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleSexChangeResponse roleSexChangeResponse = (RoleSexChangeResponse)msg;
			if (roleSexChangeResponse == null)
			{
				return;
			}
			if (roleSexChangeResponse.ErrorCode == ErrorCode.Success)
			{
				WorldLevelModel.Instance.Sex = roleSexChangeResponse.Sex;
				this.RequestNewRoleInfo();
				EventSystem.Instance.Emit(EEventName.OnRoleChangeEnd);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleSexChangeResponse.ErrorCode, 18787, null, true, true);
		}, 0);
	}

	// Token: 0x06014D4A RID: 85322 RVA: 0x00549158 File Offset: 0x00547358
	public void SendRoleElementChangeRequest(int elementType)
	{
		RoleElementChangeRequest roleElementChangeRequest = RoleElementChangeRequest.Create();
		roleElementChangeRequest.ElementType = elementType;
		Net.Instance.Call(ERequestMessageId.RoleElementChangeRequest, roleElementChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleElementChangeResponse roleElementChangeResponse = (RoleElementChangeResponse)msg;
			if (roleElementChangeResponse == null)
			{
				return;
			}
			if (roleElementChangeResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleElementChangeResponse.ErrorCode, 17259, null, true, true);
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnRoleChangeEnd);
			this.RequestNewRoleInfo();
		}, 0);
	}

	// Token: 0x06014D4B RID: 85323 RVA: 0x0054918F File Offset: 0x0054738F
	private void RequestNewRoleInfo()
	{
		FormationController.Instance.RefreshMainRoleInfo();
	}

	// Token: 0x06014D4C RID: 85324 RVA: 0x0054919C File Offset: 0x0054739C
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleChangeNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleChangeNotify roleChangeNotify = (RoleChangeNotify)msg;
			int sourceRoleId = roleChangeNotify.SourceRoleId;
			roleInfo roleInfo = roleChangeNotify.RoleInfo;
			PhantomBattleModel.Instance.DeleteBattleData(sourceRoleId);
			RoleModel.Instance.RoleChange(sourceRoleId, roleInfo);
		});
		Net.Instance.Register(ENotifyMessageId.RoleChangeUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleChangeUnlockNotify roleChangeUnlockNotify = (RoleChangeUnlockNotify)msg;
			if (roleChangeUnlockNotify != null)
			{
				int[] array = new int[roleChangeUnlockNotify.UnlockRoleIds.Count];
				for (int i = 0; i < roleChangeUnlockNotify.UnlockRoleIds.Count; i++)
				{
					array[i] = roleChangeUnlockNotify.UnlockRoleIds[i];
				}
				RoleModel.Instance.UpdateCanChangeRoleIdList(array);
				MainRoleModel.Instance.UpdateCanChangeSexTime(roleChangeUnlockNotify.CanChangeSexTime);
			}
		});
	}

	// Token: 0x06014D4D RID: 85325 RVA: 0x00549207 File Offset: 0x00547407
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleChangeUnlockNotify);
	}

	// Token: 0x17001B25 RID: 6949
	// (get) Token: 0x06014D4E RID: 85326 RVA: 0x00549229 File Offset: 0x00547429
	public static MainRoleController Instance
	{
		get
		{
			return MainRoleController._Instance;
		}
	}

	// Token: 0x06014D4F RID: 85327 RVA: 0x00549230 File Offset: 0x00547430
	public static MainRoleController GetOrCreateInstance()
	{
		if (MainRoleController._Instance == null)
		{
			MainRoleController.CreateInstance();
		}
		return MainRoleController._Instance;
	}

	// Token: 0x06014D50 RID: 85328 RVA: 0x00549244 File Offset: 0x00547444
	public static bool CreateInstance()
	{
		if (MainRoleController._Instance != null)
		{
			return true;
		}
		MainRoleController._Instance = new MainRoleController();
		return true;
	}

	// Token: 0x06014D51 RID: 85329 RVA: 0x0054925A File Offset: 0x0054745A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014D52 RID: 85330 RVA: 0x0054925C File Offset: 0x0054745C
	public static void ResetStaticDefaultValue()
	{
		MainRoleController._Instance = null;
	}

	// Token: 0x06014D53 RID: 85331 RVA: 0x00549264 File Offset: 0x00547464
	static MainRoleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MainRoleController.CreateStaticDefaultValue), new Action(MainRoleController.ResetStaticDefaultValue));
	}

	// Token: 0x04009CC6 RID: 40134
	[Nullable(2)]
	private static MainRoleController _Instance;
}
