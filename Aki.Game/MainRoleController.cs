using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;

// Token: 0x02001D1A RID: 7450
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MainRoleController : UiControllerBase
{
	// Token: 0x06012719 RID: 75545 RVA: 0x0057313E File Offset: 0x0057133E
	protected override void OnAddOpenViewCheckFunction()
	{
		UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.RoleGenderChangeView, new Func<EUiViewName, object, bool>(this.CanOpenView), "MainRoleController.CanOpenView");
	}

	// Token: 0x0601271A RID: 75546 RVA: 0x00573160 File Offset: 0x00571360
	protected override void OnRemoveOpenViewCheckFunction()
	{
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.RoleGenderChangeView, new Func<EUiViewName, object, bool>(this.CanOpenView));
	}

	// Token: 0x0601271B RID: 75547 RVA: 0x00573180 File Offset: 0x00571380
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

	// Token: 0x0601271C RID: 75548 RVA: 0x00573238 File Offset: 0x00571438
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

	// Token: 0x0601271D RID: 75549 RVA: 0x00573269 File Offset: 0x00571469
	public bool IsMainRole(int roleId)
	{
		return RoleModel.Instance.IsMainRole(roleId);
	}

	// Token: 0x0601271E RID: 75550 RVA: 0x0057327C File Offset: 0x0057147C
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(roleSexChangeResponse.ErrorCode, 23208, null, true, true);
		}, 0);
	}

	// Token: 0x0601271F RID: 75551 RVA: 0x005732B4 File Offset: 0x005714B4
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(roleElementChangeResponse.ErrorCode, 17531, null, true, true);
				return;
			}
			EventSystem.Instance.Emit(EEventName.OnRoleChangeEnd);
			this.RequestNewRoleInfo();
		}, 0);
	}

	// Token: 0x06012720 RID: 75552 RVA: 0x005732EB File Offset: 0x005714EB
	private void RequestNewRoleInfo()
	{
		FormationController.Instance.RefreshMainRoleInfo();
	}

	// Token: 0x06012721 RID: 75553 RVA: 0x005732F8 File Offset: 0x005714F8
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleChangeNotify, delegate(IMessage msg, Net.CallbackStatus _)
		{
			RoleChangeNotify roleChangeNotify = (RoleChangeNotify)msg;
			int sourceRoleId = roleChangeNotify.SourceRoleId;
			roleInfo roleInfo = roleChangeNotify.RoleInfo;
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

	// Token: 0x06012722 RID: 75554 RVA: 0x00573363 File Offset: 0x00571563
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleChangeUnlockNotify);
	}

	// Token: 0x17001B7C RID: 7036
	// (get) Token: 0x06012723 RID: 75555 RVA: 0x00573385 File Offset: 0x00571585
	public static MainRoleController Instance
	{
		get
		{
			return MainRoleController._Instance;
		}
	}

	// Token: 0x06012724 RID: 75556 RVA: 0x0057338C File Offset: 0x0057158C
	public static MainRoleController GetOrCreateInstance()
	{
		if (MainRoleController._Instance == null)
		{
			MainRoleController.CreateInstance();
		}
		return MainRoleController._Instance;
	}

	// Token: 0x06012725 RID: 75557 RVA: 0x005733A0 File Offset: 0x005715A0
	public static bool CreateInstance()
	{
		if (MainRoleController._Instance != null)
		{
			return true;
		}
		MainRoleController._Instance = new MainRoleController();
		return true;
	}

	// Token: 0x06012726 RID: 75558 RVA: 0x005733B6 File Offset: 0x005715B6
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012727 RID: 75559 RVA: 0x005733B8 File Offset: 0x005715B8
	public static void ResetStaticDefaultValue()
	{
		MainRoleController._Instance = null;
	}

	// Token: 0x06012728 RID: 75560 RVA: 0x005733C0 File Offset: 0x005715C0
	static MainRoleController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MainRoleController.CreateStaticDefaultValue), new Action(MainRoleController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A094 RID: 41108
	[Nullable(2)]
	private static MainRoleController _Instance;
}
