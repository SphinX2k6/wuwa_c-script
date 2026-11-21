using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02001FC1 RID: 8129
[NullableContext(2)]
[Nullable(0)]
public class FlySkinController : UiControllerBase
{
	// Token: 0x060142E5 RID: 82661 RVA: 0x005E352C File Offset: 0x005E172C
	protected override void OnAddEvents()
	{
	}

	// Token: 0x060142E6 RID: 82662 RVA: 0x005E352E File Offset: 0x005E172E
	protected override void OnRemoveEvents()
	{
	}

	// Token: 0x060142E7 RID: 82663 RVA: 0x005E3530 File Offset: 0x005E1730
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.RoleFlyEquipNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleFlyEquipNotify));
		Net.Instance.Register(ENotifyMessageId.RoleFlyEquipChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleFlyEquipChangeNotify));
		Net.Instance.Register(ENotifyMessageId.FlyEquipAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnFlyEquipAddNotifyNotify));
	}

	// Token: 0x060142E8 RID: 82664 RVA: 0x005E3591 File Offset: 0x005E1791
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.RoleFlyEquipNotify);
		Net.Instance.UnRegister(ENotifyMessageId.RoleFlyEquipChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.FlyEquipAddNotify);
	}

	// Token: 0x060142E9 RID: 82665 RVA: 0x005E35C4 File Offset: 0x005E17C4
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

	// Token: 0x060142EA RID: 82666 RVA: 0x005E3630 File Offset: 0x005E1830
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

	// Token: 0x060142EB RID: 82667 RVA: 0x005E36AC File Offset: 0x005E18AC
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

	// Token: 0x060142EC RID: 82668 RVA: 0x005E3744 File Offset: 0x005E1944
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinWearResponse.ErrorCode, 25179, null, true, true);
		}, 0);
	}

	// Token: 0x060142ED RID: 82669 RVA: 0x005E37B0 File Offset: 0x005E19B0
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinWearAllRoleResponse.ErrorCode, 15632, null, true, true);
		}, 0);
	}

	// Token: 0x060142EE RID: 82670 RVA: 0x005E3808 File Offset: 0x005E1A08
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinUnLoadResponse.ErrorCode, 29892, null, true, true);
		}, 0);
	}

	// Token: 0x060142EF RID: 82671 RVA: 0x005E3874 File Offset: 0x005E1A74
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(flySkinAllUnLoadResponse.ErrorCode, 29892, null, true, true);
		}, 0);
	}

	// Token: 0x060142F0 RID: 82672 RVA: 0x005E38CA File Offset: 0x005E1ACA
	public void UpdateAllRoleSkinRedDot()
	{
		RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.RoleSkin);
		if (redDot == null)
		{
			return;
		}
		redDot.UpdateAllRedDotData();
	}

	// Token: 0x17001E3D RID: 7741
	// (get) Token: 0x060142F1 RID: 82673 RVA: 0x005E38E2 File Offset: 0x005E1AE2
	[Nullable(1)]
	public static FlySkinController Instance
	{
		[NullableContext(1)]
		get
		{
			return FlySkinController._Instance;
		}
	}

	// Token: 0x060142F2 RID: 82674 RVA: 0x005E38E9 File Offset: 0x005E1AE9
	[NullableContext(1)]
	public static FlySkinController GetOrCreateInstance()
	{
		if (FlySkinController._Instance == null)
		{
			FlySkinController.CreateInstance();
		}
		return FlySkinController._Instance;
	}

	// Token: 0x060142F3 RID: 82675 RVA: 0x005E38FD File Offset: 0x005E1AFD
	public static bool CreateInstance()
	{
		if (FlySkinController._Instance != null)
		{
			return true;
		}
		FlySkinController._Instance = new FlySkinController();
		return true;
	}

	// Token: 0x060142F4 RID: 82676 RVA: 0x005E3913 File Offset: 0x005E1B13
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060142F5 RID: 82677 RVA: 0x005E3915 File Offset: 0x005E1B15
	public static void ResetStaticDefaultValue()
	{
		FlySkinController._Instance = null;
	}

	// Token: 0x060142F6 RID: 82678 RVA: 0x005E391D File Offset: 0x005E1B1D
	static FlySkinController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FlySkinController.CreateStaticDefaultValue), new Action(FlySkinController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AB63 RID: 43875
	private static FlySkinController _Instance;
}
