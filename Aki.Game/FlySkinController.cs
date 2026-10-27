using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02002A46 RID: 10822
[NullableContext(2)]
[Nullable(0)]
public class FlySkinController : UiControllerBase
{
	// Token: 0x060168C4 RID: 92356 RVA: 0x005B73E8 File Offset: 0x005B55E8
	protected override void OnAddEvents()
	{
	}

	// Token: 0x060168C5 RID: 92357 RVA: 0x005B73EA File Offset: 0x005B55EA
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x060168C6 RID: 92358 RVA: 0x005B73EC File Offset: 0x005B55EC
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleFlyEquipNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleFlyEquipNotify));
		Net.Instance.Register(ENotifyMessageId.RoleFlyEquipChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleFlyEquipChangeNotify));
		Net.Instance.Register(ENotifyMessageId.FlyEquipAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFlyEquipAddNotifyNotify));
	}

	// Token: 0x060168C7 RID: 92359 RVA: 0x005B744D File Offset: 0x005B564D
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleFlyEquipNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFlyEquipChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FlyEquipAddNotify);
	}

	// Token: 0x060168C8 RID: 92360 RVA: 0x005B7480 File Offset: 0x005B5680
	private void OnRoleFlyEquipNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleFlyEquipNotify roleFlyEquipNotify = (RoleFlyEquipNotify)msg;
		if (roleFlyEquipNotify == null)
		{
			return;
		}
		FlySkinModel.Instance.UpdateFlySkinEquipDataList(roleFlyEquipNotify.DataList);
		EventSystem.Instance.Emit(EEventName.OnRoleFlyEquipNotify);
		EventSystem.Instance.Emit(EEventName.RefreshFlySkinTabRedDot);
		EventSystem.Instance.Emit<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, EFlySkinType.Paragliding);
		EventSystem.Instance.Emit<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, EFlySkinType.SoarWing);
	}

	// Token: 0x060168C9 RID: 92361 RVA: 0x005B74EC File Offset: 0x005B56EC
	private void OnRoleFlyEquipChangeNotify(IMessage msg, Net.CallbackStatus status)
	{
		RoleFlyEquipChangeNotify roleFlyEquipChangeNotify = (RoleFlyEquipChangeNotify)msg;
		if (roleFlyEquipChangeNotify == null)
		{
			return;
		}
		RepeatedField<RoleFlySkinChange> skinChanges = roleFlyEquipChangeNotify.SkinChanges;
		foreach (RoleFlySkinChange roleFlySkinChange in skinChanges)
		{
			FlySkinModel.Instance.EquipFlySkin(roleFlySkinChange.RoleId, roleFlySkinChange.SkinId);
		}
		EventSystem.Instance.Emit<IReadOnlyList<RoleFlySkinChange>>(EEventName.OnRoleFlyEquipChangeNotify, skinChanges);
	}

	// Token: 0x060168CA RID: 92362 RVA: 0x005B7568 File Offset: 0x005B5768
	private void OnFlyEquipAddNotifyNotify(IMessage msg, Net.CallbackStatus status)
	{
		FlyEquipAddNotify flyEquipAddNotify = (FlyEquipAddNotify)msg;
		if (flyEquipAddNotify == null)
		{
			return;
		}
		RepeatedField<int> flySkins = flyEquipAddNotify.FlySkins;
		foreach (int skinId in flySkins)
		{
			FlySkinModel.Instance.AddUnlockSkinId(skinId);
		}
		this.UpdateAllRoleSkinRedDot();
		EventSystem.Instance.Emit<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, EFlySkinType.Paragliding);
		EventSystem.Instance.Emit<EFlySkinType>(EEventName.RefreshFlySkinChildTabRed, EFlySkinType.SoarWing);
		EventSystem.Instance.Emit<IReadOnlyList<int>>(EEventName.OnFlyEquipAddNotify, flySkins);
	}

	// Token: 0x060168CB RID: 92363 RVA: 0x005B7600 File Offset: 0x005B5800
	public void FlySkinWearRequest(int roleDataId, int skinId)
	{
		if (!SkinController.Instance.CheckCanWearSkinAndShowTip())
		{
			return;
		}
		FlySkinWearRequest flySkinWearRequest = Aki.Protocol.FlySkinWearRequest.Create();
		flySkinWearRequest.RoleId = roleDataId;
		flySkinWearRequest.SkinId = skinId;
		Net.Instance.Call(ERequestMessageId.FlySkinWearRequest, flySkinWearRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FlySkinWearResponse flySkinWearResponse = (FlySkinWearResponse)msg;
			if (flySkinWearResponse == null)
			{
				return;
			}
			if (flySkinWearResponse.ErrorCode == ErrorCode.Success)
			{
				FlySkinModel.Instance.EquipFlySkin(roleDataId, skinId);
				EventSystem.Instance.Emit<int, int>(EEventName.OnFlySkinEquipResponse, roleDataId, skinId);
				ScrollingTipsController.Instance.ShowTipsByTextId("FlySkinReplaceTip", Array.Empty<object>());
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinWearResponse.ErrorCode, 17717, null, true, true);
		}, 0);
	}

	// Token: 0x060168CC RID: 92364 RVA: 0x005B766C File Offset: 0x005B586C
	public void FlySkinWearAllRoleRequest(int skinId)
	{
		if (!SkinController.Instance.CheckCanWearSkinAndShowTip())
		{
			return;
		}
		FlySkinWearAllRoleRequest flySkinWearAllRoleRequest = Aki.Protocol.FlySkinWearAllRoleRequest.Create();
		flySkinWearAllRoleRequest.SkinId = skinId;
		Net.Instance.Call(ERequestMessageId.FlySkinWearAllRoleRequest, flySkinWearAllRoleRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FlySkinWearAllRoleResponse flySkinWearAllRoleResponse = (FlySkinWearAllRoleResponse)msg;
			if (flySkinWearAllRoleResponse == null)
			{
				return;
			}
			if (flySkinWearAllRoleResponse.ErrorCode == ErrorCode.Success)
			{
				RepeatedField<RoleFlySkinChange> skinChanges = flySkinWearAllRoleResponse.SkinChanges;
				foreach (RoleFlySkinChange roleFlySkinChange in skinChanges)
				{
					FlySkinModel.Instance.EquipFlySkin(roleFlySkinChange.RoleId, roleFlySkinChange.SkinId);
				}
				EventSystem.Instance.Emit<IReadOnlyList<RoleFlySkinChange>>(EEventName.OnFlySkinEquipToAllRoleResponse, skinChanges);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinWearAllRoleResponse.ErrorCode, 25354, null, true, true);
		}, 0);
	}

	// Token: 0x060168CD RID: 92365 RVA: 0x005B76C4 File Offset: 0x005B58C4
	public void FlySkinUnLoadRequest(int roleDataId, int skinId)
	{
		if (!SkinController.Instance.CheckCanWearSkinAndShowTip())
		{
			return;
		}
		FlySkinUnLoadRequest flySkinUnLoadRequest = Aki.Protocol.FlySkinUnLoadRequest.Create();
		flySkinUnLoadRequest.RoleId = roleDataId;
		flySkinUnLoadRequest.SkinId = skinId;
		Net.Instance.Call(ERequestMessageId.FlySkinUnLoadRequest, flySkinUnLoadRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FlySkinUnLoadResponse flySkinUnLoadResponse = (FlySkinUnLoadResponse)msg;
			if (flySkinUnLoadResponse == null)
			{
				return;
			}
			if (flySkinUnLoadResponse.ErrorCode == ErrorCode.Success)
			{
				FlySkinModel.Instance.UnLoadRoleFlySkinBySkinId(roleDataId, skinId);
				EventSystem.Instance.Emit<int, int>(EEventName.OnFlySkinUnLoadResponse, roleDataId, skinId);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinUnLoadResponse.ErrorCode, 23595, null, true, true);
		}, 0);
	}

	// Token: 0x060168CE RID: 92366 RVA: 0x005B7730 File Offset: 0x005B5930
	public void FlySkinAllUnLoadRequest(EFlySkinType skinType)
	{
		if (!SkinController.Instance.CheckCanWearSkinAndShowTip())
		{
			return;
		}
		FlySkinAllUnLoadRequest flySkinAllUnLoadRequest = Aki.Protocol.FlySkinAllUnLoadRequest.Create();
		flySkinAllUnLoadRequest.SkinType = (int)skinType;
		Net.Instance.Call(ERequestMessageId.FlySkinAllUnLoadRequest, flySkinAllUnLoadRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			FlySkinAllUnLoadResponse flySkinAllUnLoadResponse = (FlySkinAllUnLoadResponse)msg;
			if (flySkinAllUnLoadResponse == null)
			{
				return;
			}
			if (flySkinAllUnLoadResponse.ErrorCode == ErrorCode.Success)
			{
				foreach (int roleDataId in flySkinAllUnLoadResponse.UnLoadSkinRoles)
				{
					FlySkinModel.Instance.UnLoadRoleFlySkinBySkinType(roleDataId, skinType);
				}
				EventSystem.Instance.Emit<EFlySkinType>(EEventName.OnFlySkinAllUnLoadResponse, skinType);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinAllUnLoadResponse.ErrorCode, 23595, null, true, true);
		}, 0);
	}

	// Token: 0x060168CF RID: 92367 RVA: 0x005B7786 File Offset: 0x005B5986
	public void UpdateAllRoleSkinRedDot()
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.RoleSkin);
		if (redDot == null)
		{
			return;
		}
		redDot.UpdateAllRedDotData();
	}

	// Token: 0x17001DE5 RID: 7653
	// (get) Token: 0x060168D0 RID: 92368 RVA: 0x005B779E File Offset: 0x005B599E
	[Nullable(1)]
	public static FlySkinController Instance
	{
		[NullableContext(1)]
		get
		{
			return FlySkinController._Instance;
		}
	}

	// Token: 0x060168D1 RID: 92369 RVA: 0x005B77A5 File Offset: 0x005B59A5
	[NullableContext(1)]
	public static FlySkinController GetOrCreateInstance()
	{
		if (FlySkinController._Instance == null)
		{
			FlySkinController.CreateInstance();
		}
		return FlySkinController._Instance;
	}

	// Token: 0x060168D2 RID: 92370 RVA: 0x005B77B9 File Offset: 0x005B59B9
	public static bool CreateInstance()
	{
		if (FlySkinController._Instance != null)
		{
			return true;
		}
		FlySkinController._Instance = new FlySkinController();
		return true;
	}

	// Token: 0x060168D3 RID: 92371 RVA: 0x005B77CF File Offset: 0x005B59CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060168D4 RID: 92372 RVA: 0x005B77D1 File Offset: 0x005B59D1
	public static void ResetStaticDefaultValue()
	{
		FlySkinController._Instance = null;
	}

	// Token: 0x060168D5 RID: 92373 RVA: 0x005B77D9 File Offset: 0x005B59D9
	static FlySkinController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FlySkinController.CreateStaticDefaultValue), new Action(FlySkinController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A75F RID: 42847
	private static FlySkinController _Instance;
}
