using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02002282 RID: 8834
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class MotorcycleDiyController : ControllerBase
{
	// Token: 0x06011401 RID: 70657 RVA: 0x004360E4 File Offset: 0x004342E4
	protected override bool OnInit()
	{
		this.OnRegisterNetEvent();
		return true;
	}

	// Token: 0x06011402 RID: 70658 RVA: 0x004360ED File Offset: 0x004342ED
	protected override bool OnClear()
	{
		this.OnUnRegisterNetEvent();
		return true;
	}

	// Token: 0x06011403 RID: 70659 RVA: 0x004360F8 File Offset: 0x004342F8
	protected void OnRegisterNetEvent()
	{
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenSet));
		EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		Net.Instance.Register(ENotifyMessageId.MotorOutlookRegionInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorOutlookRegionInfoNotify));
		Net.Instance.Register(ENotifyMessageId.MotorOutlookAddNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorOutlookAddNotify));
		Net.Instance.Register(ENotifyMessageId.MotorOutlookOwnedChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorOutlookOwnedChangeNotify));
		Net.Instance.Register(ENotifyMessageId.MotorOutlookEquippedChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorOutlookEquippedChangeNotify));
		Net.Instance.Register(ENotifyMessageId.MotorOutlookFullChangeNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorOutlookFullChangeNotify));
	}

	// Token: 0x06011404 RID: 70660 RVA: 0x004361E8 File Offset: 0x004343E8
	protected void OnUnRegisterNetEvent()
	{
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenSet));
		EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnAddCommonItemList));
		Net.Instance.UnRegister(ENotifyMessageId.MotorOutlookRegionInfoNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MotorOutlookAddNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MotorOutlookOwnedChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MotorOutlookEquippedChangeNotify);
		Net.Instance.UnRegister(ENotifyMessageId.MotorOutlookFullChangeNotify);
	}

	// Token: 0x06011405 RID: 70661 RVA: 0x00436299 File Offset: 0x00434499
	private void OnFunctionOpenSet(EFunctionType functionType, bool isOpen)
	{
		if (!isOpen)
		{
			return;
		}
		if (functionType == EFunctionType.MotorDevelop)
		{
			this.MotorDiyInfoRequest();
		}
	}

	// Token: 0x06011406 RID: 70662 RVA: 0x004362AD File Offset: 0x004344AD
	private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
	{
		if (!isOpen)
		{
			return;
		}
		if (functionType == EFunctionType.MotorDevelop)
		{
			this.MotorDiyInfoRequest();
		}
	}

	// Token: 0x06011407 RID: 70663 RVA: 0x004362C4 File Offset: 0x004344C4
	private void OnAddCommonItemList(IReadOnlyList<IProto_NormalItem> normalItemList)
	{
		foreach (IProto_NormalItem proto_NormalItem in normalItemList)
		{
			if (MotorcycleDiyModel.Instance.IsSceneItemId(proto_NormalItem.Id))
			{
				EventSystem.Instance.Emit(EEventName.MotorDiySceneItemUpdate);
				break;
			}
		}
	}

	// Token: 0x06011408 RID: 70664 RVA: 0x0043632C File Offset: 0x0043452C
	[NullableContext(2)]
	private void OnMotorOutlookRegionInfoNotify(IMessage msg, Net.CallbackStatus _)
	{
		MotorOutlookRegionInfoNotify motorOutlookRegionInfoNotify = (MotorOutlookRegionInfoNotify)msg;
		if (motorOutlookRegionInfoNotify != null)
		{
			MotorcycleDiyModel.Instance.UpdateMotorCanUseOutlookInfo(motorOutlookRegionInfoNotify);
		}
	}

	// Token: 0x06011409 RID: 70665 RVA: 0x00436350 File Offset: 0x00434550
	[NullableContext(2)]
	private void OnMotorOutlookAddNotify(IMessage msg, Net.CallbackStatus _)
	{
		MotorOutlookAddNotify motorOutlookAddNotify = (MotorOutlookAddNotify)msg;
		if (motorOutlookAddNotify != null)
		{
			MotorcycleDiyModel.Instance.AddMotorOutlookInfo(motorOutlookAddNotify);
			EventSystem.Instance.Emit(EEventName.MotorDiyInfoUpdate);
		}
	}

	// Token: 0x0601140A RID: 70666 RVA: 0x00436384 File Offset: 0x00434584
	[NullableContext(2)]
	private void OnMotorOutlookOwnedChangeNotify(IMessage msg, Net.CallbackStatus _)
	{
		MotorOutlookOwnedChangeNotify motorOutlookOwnedChangeNotify = (MotorOutlookOwnedChangeNotify)msg;
		if (motorOutlookOwnedChangeNotify != null)
		{
			MotorcycleDiyModel.Instance.UpdateMotorOutlookOwnedChange(motorOutlookOwnedChangeNotify);
			EventSystem.Instance.Emit(EEventName.MotorDiyInfoUpdate);
		}
	}

	// Token: 0x0601140B RID: 70667 RVA: 0x004363B8 File Offset: 0x004345B8
	[NullableContext(2)]
	private void OnMotorOutlookEquippedChangeNotify(IMessage msg, Net.CallbackStatus _)
	{
		MotorOutlookEquippedChangeNotify motorOutlookEquippedChangeNotify = (MotorOutlookEquippedChangeNotify)msg;
		if (motorOutlookEquippedChangeNotify != null)
		{
			MotorcycleDiyModel.Instance.UpdateMotorOutlookEquippedChange(motorOutlookEquippedChangeNotify);
			EventSystem.Instance.Emit(EEventName.MotorDiyInfoUpdate);
		}
	}

	// Token: 0x0601140C RID: 70668 RVA: 0x004363EC File Offset: 0x004345EC
	[NullableContext(2)]
	private void OnMotorOutlookFullChangeNotify(IMessage msg, Net.CallbackStatus _)
	{
		MotorOutlookFullChangeNotify motorOutlookFullChangeNotify = (MotorOutlookFullChangeNotify)msg;
		if (motorOutlookFullChangeNotify != null)
		{
			MotorcycleDiyModel.Instance.UpdateMotorOutlookFullChange(motorOutlookFullChangeNotify);
			EventSystem.Instance.Emit(EEventName.MotorDiyInfoUpdate);
			EventSystem.Instance.Emit(EEventName.MotorDiyFullOutlookUpdate);
		}
	}

	// Token: 0x0601140D RID: 70669 RVA: 0x00436430 File Offset: 0x00434630
	public void MotorDiyInfoRequest()
	{
		MotorOutlookInfoRequest message = MotorOutlookInfoRequest.Create();
		Net.Instance.Call(ERequestMessageId.MotorOutlookInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorOutlookInfoResponse motorOutlookInfoResponse = (MotorOutlookInfoResponse)msg;
			if (motorOutlookInfoResponse == null)
			{
				return;
			}
			if (motorOutlookInfoResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
			{
				MotorcycleDiyModel.Instance.UpdateMotorOutlookInfo(motorOutlookInfoResponse);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(motorOutlookInfoResponse.ErrorCode, 15636, null, true, true);
		}, 0);
	}

	// Token: 0x0601140E RID: 70670 RVA: 0x00436474 File Offset: 0x00434674
	[NullableContext(2)]
	public void EquipMotorSkinRequest(int skinId, Action callBack = null)
	{
		MotorUseSkinRequest motorUseSkinRequest = MotorUseSkinRequest.Create();
		motorUseSkinRequest.SkinId = skinId;
		Net.Instance.Call(ERequestMessageId.MotorUseSkinRequest, motorUseSkinRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorUseSkinResponse motorUseSkinResponse = (MotorUseSkinResponse)msg;
			if (motorUseSkinResponse == null)
			{
				return;
			}
			if (motorUseSkinResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(motorUseSkinResponse.ErrorCode, 18288, null, true, true);
				return;
			}
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, 0);
	}

	// Token: 0x0601140F RID: 70671 RVA: 0x004364B8 File Offset: 0x004346B8
	public void EquipMotorOutLookRequest(List<int> stickerIds, List<int> decorateIds, int frameId, [Nullable(2)] Action callBack = null)
	{
		MotorChangeOutlookRequest motorChangeOutlookRequest = MotorChangeOutlookRequest.Create();
		motorChangeOutlookRequest.StickerEquipped.AddRange(stickerIds);
		motorChangeOutlookRequest.DecorationsEquipped.AddRange(decorateIds);
		motorChangeOutlookRequest.FrameEquipped = frameId;
		Net.Instance.Call(ERequestMessageId.MotorChangeOutlookRequest, motorChangeOutlookRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorChangeOutlookResponse motorChangeOutlookResponse = (MotorChangeOutlookResponse)msg;
			if (motorChangeOutlookResponse == null)
			{
				return;
			}
			if (motorChangeOutlookResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(motorChangeOutlookResponse.ErrorCode, 21672, null, true, true);
				return;
			}
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, 0);
	}

	// Token: 0x06011410 RID: 70672 RVA: 0x00436518 File Offset: 0x00434718
	public void CreateMotorOutlookPresetRequest(List<int> stickerIds, List<int> decorateIds, int frameId, string name, [Nullable(new byte[]
	{
		2,
		1,
		1
	})] Action<List<MotorOutlookPresetPlanPb>> callBack = null)
	{
		MotorOutlookCreatePresetRequest motorOutlookCreatePresetRequest = MotorOutlookCreatePresetRequest.Create();
		MotorOutlookEquippedPb motorOutlookEquippedPb = MotorOutlookEquippedPb.Create();
		motorOutlookEquippedPb.StickerEquipped.AddRange(stickerIds);
		motorOutlookEquippedPb.DecorationsEquipped.AddRange(decorateIds);
		motorOutlookEquippedPb.FrameEquipped = frameId;
		motorOutlookCreatePresetRequest.Preset = motorOutlookEquippedPb;
		motorOutlookCreatePresetRequest.Name = name;
		Net.Instance.Call(ERequestMessageId.MotorOutlookCreatePresetRequest, motorOutlookCreatePresetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorOutlookCreatePresetResponse motorOutlookCreatePresetResponse = (MotorOutlookCreatePresetResponse)msg;
			if (motorOutlookCreatePresetResponse == null)
			{
				return;
			}
			if (motorOutlookCreatePresetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(motorOutlookCreatePresetResponse.ErrorCode, 17753, null, true, true);
				return;
			}
			MotorOutlookPlayerPresetPb motorOutlookPreset = motorOutlookCreatePresetResponse.MotorOutlookPreset;
			RepeatedField<MotorOutlookPresetPlanPb> plan = motorOutlookPreset.Plan;
			MotorcycleDiyModel.Instance.UpdateCustomPresetInfo(motorOutlookPreset);
			Action<List<MotorOutlookPresetPlanPb>> callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2((plan != null) ? plan.ToList<MotorOutlookPresetPlanPb>() : new List<MotorOutlookPresetPlanPb>());
		}, 0);
	}

	// Token: 0x06011411 RID: 70673 RVA: 0x0043658C File Offset: 0x0043478C
	[return: Nullable(0)]
	public UniTask<Aki.Protocol.ErrorCode> CreateMotorOutlookPresetRequestAsync(List<int> stickerIds, List<int> decorateIds, int frameId, string name)
	{
		MotorcycleDiyController.<CreateMotorOutlookPresetRequestAsync>d__16 <CreateMotorOutlookPresetRequestAsync>d__;
		<CreateMotorOutlookPresetRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
		<CreateMotorOutlookPresetRequestAsync>d__.stickerIds = stickerIds;
		<CreateMotorOutlookPresetRequestAsync>d__.decorateIds = decorateIds;
		<CreateMotorOutlookPresetRequestAsync>d__.frameId = frameId;
		<CreateMotorOutlookPresetRequestAsync>d__.name = name;
		<CreateMotorOutlookPresetRequestAsync>d__.<>1__state = -1;
		<CreateMotorOutlookPresetRequestAsync>d__.<>t__builder.Start<MotorcycleDiyController.<CreateMotorOutlookPresetRequestAsync>d__16>(ref <CreateMotorOutlookPresetRequestAsync>d__);
		return <CreateMotorOutlookPresetRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011412 RID: 70674 RVA: 0x004365E8 File Offset: 0x004347E8
	[NullableContext(2)]
	public void DeleteMotorOutlookPresetRequest(int presetId, Action callBack = null)
	{
		MotorOutlookDeletePresetRequest motorOutlookDeletePresetRequest = MotorOutlookDeletePresetRequest.Create();
		motorOutlookDeletePresetRequest.Id = presetId;
		Net.Instance.Call(ERequestMessageId.MotorOutlookDeletePresetRequest, motorOutlookDeletePresetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorOutlookDeletePresetResponse motorOutlookDeletePresetResponse = (MotorOutlookDeletePresetResponse)msg;
			if (motorOutlookDeletePresetResponse == null)
			{
				return;
			}
			if (motorOutlookDeletePresetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(motorOutlookDeletePresetResponse.ErrorCode, 28770, null, true, true);
				return;
			}
			MotorcycleDiyModel.Instance.RemoveSingleCustomPresetInfo(presetId);
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, 0);
	}

	// Token: 0x06011413 RID: 70675 RVA: 0x00436638 File Offset: 0x00434838
	[return: Nullable(0)]
	public UniTask<Aki.Protocol.ErrorCode> EditMotorOutlookPresetRequestAsync(int presetId, List<int> stickerIds, List<int> decorateIds, int frameId, string name)
	{
		MotorcycleDiyController.<EditMotorOutlookPresetRequestAsync>d__18 <EditMotorOutlookPresetRequestAsync>d__;
		<EditMotorOutlookPresetRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
		<EditMotorOutlookPresetRequestAsync>d__.presetId = presetId;
		<EditMotorOutlookPresetRequestAsync>d__.stickerIds = stickerIds;
		<EditMotorOutlookPresetRequestAsync>d__.decorateIds = decorateIds;
		<EditMotorOutlookPresetRequestAsync>d__.frameId = frameId;
		<EditMotorOutlookPresetRequestAsync>d__.name = name;
		<EditMotorOutlookPresetRequestAsync>d__.<>1__state = -1;
		<EditMotorOutlookPresetRequestAsync>d__.<>t__builder.Start<MotorcycleDiyController.<EditMotorOutlookPresetRequestAsync>d__18>(ref <EditMotorOutlookPresetRequestAsync>d__);
		return <EditMotorOutlookPresetRequestAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011414 RID: 70676 RVA: 0x004366A0 File Offset: 0x004348A0
	public void EditMotorOutlookPresetRequest(int presetId, List<int> stickerIds, List<int> decorateIds, int frameId, string name, [Nullable(2)] Action callBack = null)
	{
		MotorOutlookEditPresetRequest motorOutlookEditPresetRequest = MotorOutlookEditPresetRequest.Create();
		MotorOutlookEquippedPb motorOutlookEquippedPb = MotorOutlookEquippedPb.Create();
		motorOutlookEquippedPb.StickerEquipped.AddRange(stickerIds);
		motorOutlookEquippedPb.DecorationsEquipped.AddRange(decorateIds);
		motorOutlookEquippedPb.FrameEquipped = frameId;
		MotorOutlookPresetPlanPb motorOutlookPresetPlanPb = MotorOutlookPresetPlanPb.Create();
		motorOutlookPresetPlanPb.Id = presetId;
		motorOutlookPresetPlanPb.Preset = motorOutlookEquippedPb;
		motorOutlookPresetPlanPb.Name = name;
		motorOutlookEditPresetRequest.PresetPlan = motorOutlookPresetPlanPb;
		Net.Instance.Call(ERequestMessageId.MotorOutlookEditPresetRequest, motorOutlookEditPresetRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorOutlookEditPresetResponse motorOutlookEditPresetResponse = (MotorOutlookEditPresetResponse)msg;
			if (motorOutlookEditPresetResponse == null)
			{
				return;
			}
			if (motorOutlookEditPresetResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(motorOutlookEditPresetResponse.ErrorCode, 24760, null, true, true);
				return;
			}
			MotorcycleDiyModel.Instance.UpdateCustomPresetInfo(motorOutlookEditPresetResponse.MotorOutlookPreset);
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, 0);
	}

	// Token: 0x06011415 RID: 70677 RVA: 0x00436728 File Offset: 0x00434928
	public void EquipMotorStickerRequest(List<int> stickerIds, [Nullable(2)] Action callBack = null)
	{
		int equippedFrameId = MotorcycleDiyModel.Instance.GetEquippedFrameId();
		List<int> equippedDecorationIdList = MotorcycleDiyModel.Instance.GetEquippedDecorationIdList();
		this.EquipMotorOutLookRequest(stickerIds, equippedDecorationIdList, equippedFrameId, callBack);
	}

	// Token: 0x06011416 RID: 70678 RVA: 0x00436758 File Offset: 0x00434958
	[NullableContext(2)]
	public void EquipMotorFrameRequest(int frameId, Action callBack = null)
	{
		List<int> equippedStickerIdList = MotorcycleDiyModel.Instance.GetEquippedStickerIdList();
		List<int> equippedDecorationIdList = MotorcycleDiyModel.Instance.GetEquippedDecorationIdList();
		this.EquipMotorOutLookRequest(equippedStickerIdList, equippedDecorationIdList, frameId, callBack);
	}

	// Token: 0x06011417 RID: 70679 RVA: 0x00436788 File Offset: 0x00434988
	public void EquipMotorDecorationRequest(List<int> decorateIds, [Nullable(2)] Action callBack = null)
	{
		List<int> equippedStickerIdList = MotorcycleDiyModel.Instance.GetEquippedStickerIdList();
		int equippedFrameId = MotorcycleDiyModel.Instance.GetEquippedFrameId();
		this.EquipMotorOutLookRequest(equippedStickerIdList, decorateIds, equippedFrameId, callBack);
	}

	// Token: 0x06011418 RID: 70680 RVA: 0x004367B8 File Offset: 0x004349B8
	[NullableContext(2)]
	public void UseMotorSceneRequest(int sceneId, Action callBack = null)
	{
		MotorUseSceneRequest motorUseSceneRequest = MotorUseSceneRequest.Create();
		motorUseSceneRequest.SceneId = sceneId;
		Net.Instance.Call(ERequestMessageId.MotorUseSceneRequest, motorUseSceneRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			MotorUseSceneResponse motorUseSceneResponse = (MotorUseSceneResponse)msg;
			if (motorUseSceneResponse == null)
			{
				return;
			}
			if (motorUseSceneResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(motorUseSceneResponse.ErrorCode, 23495, null, true, true);
				return;
			}
			int currentSceneId = (motorUseSceneResponse.SceneInUse > 0) ? motorUseSceneResponse.SceneInUse : sceneId;
			MotorcycleDiyModel.Instance.SetCurrentSceneId(currentSceneId);
			Action callBack2 = callBack;
			if (callBack2 == null)
			{
				return;
			}
			callBack2();
		}, 0);
	}

	// Token: 0x06011419 RID: 70681 RVA: 0x00436808 File Offset: 0x00434A08
	[NullableContext(0)]
	public UniTask<bool> OpenRootView()
	{
		MotorcycleDiyController.<OpenRootView>d__24 <OpenRootView>d__;
		<OpenRootView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenRootView>d__.<>1__state = -1;
		<OpenRootView>d__.<>t__builder.Start<MotorcycleDiyController.<OpenRootView>d__24>(ref <OpenRootView>d__);
		return <OpenRootView>d__.<>t__builder.Task;
	}

	// Token: 0x0601141A RID: 70682 RVA: 0x00436844 File Offset: 0x00434A44
	public void OpenTargetViewByReward(List<RewardItemData> motorItemDataList, int jumpDiyType = 0)
	{
		if (motorItemDataList.Count == 0)
		{
			return;
		}
		int motorSkinId = 0;
		foreach (RewardItemData rewardItemData in motorItemDataList)
		{
			if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(rewardItemData.ConfigId)) == InventoryDefine.EItemDataType.MotorSkinItem)
			{
				motorSkinId = rewardItemData.ConfigId;
				break;
			}
		}
		if (motorSkinId == 0)
		{
			this.OpenRootViewByReward(motorItemDataList, jumpDiyType);
			return;
		}
		if (MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorSkin_Tips03", Array.Empty<object>());
			return;
		}
		this.EquipMotorSkinRequest(motorSkinId, delegate
		{
			UiManager.Instance.OpenView(EUiViewName.MotorcycleDiySkinView, null, null);
			MotorcycleDiyModel.Instance.CheckRedDotForAnyItem(motorSkinId);
		});
	}

	// Token: 0x0601141B RID: 70683 RVA: 0x00436914 File Offset: 0x00434B14
	public void OpenRootViewByReward(List<RewardItemData> motorItemDataList, int jumpDiyType = 0)
	{
		List<int> list = new List<int>();
		List<int> list2 = new List<int>();
		int num = MotorcycleDiyModel.Instance.GetEquippedFrameId();
		int num2 = num;
		EUiTabViewName openTabView = EUiTabViewName.MotorcycleDiyFrameTabView;
		switch (jumpDiyType)
		{
		case 1:
			openTabView = EUiTabViewName.MotorcycleDiyFrameTabView;
			break;
		case 2:
			openTabView = EUiTabViewName.MotorcycleDiyStickerTabView;
			break;
		case 3:
			openTabView = EUiTabViewName.MotorcycleDiyDecorationTabView;
			break;
		}
		foreach (RewardItemData rewardItemData in motorItemDataList)
		{
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(rewardItemData.ConfigId));
			if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorFrameItem)
			{
				num2 = rewardItemData.ConfigId;
			}
			else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorStickerItem)
			{
				list.Add(rewardItemData.ConfigId);
			}
			else if (itemDataTypeByConfigId == InventoryDefine.EItemDataType.MotorDecorationItem)
			{
				list2.Add(rewardItemData.ConfigId);
			}
		}
		if (num != num2 && MotorcycleDiyModel.Instance.IsEquipFrameLockedByPlayer())
		{
			MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
			ScrollingTipsController.Instance.ShowTipsByTextId("MotorDIYWarning02", Array.Empty<object>());
			return;
		}
		num = num2;
		List<int> list3 = new List<int>
		{
			0,
			0,
			0
		};
		foreach (int num3 in list)
		{
			MotorSticker? motorStickerConfig = MotorDiyConfig.Instance.GetMotorStickerConfig(num3);
			if (motorStickerConfig != null)
			{
				int partId = motorStickerConfig.Value.PartId;
				int num4 = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_STICKER_PART, partId);
				if (num4 != -1)
				{
					list3[num4] = num3;
				}
			}
		}
		List<int> defaultDecorationIdList = MotorcycleDiyModel.Instance.GetDefaultDecorationIdList();
		foreach (int num5 in list2)
		{
			MotorDecorations? motorDecorationConfig = MotorDiyConfig.Instance.GetMotorDecorationConfig(num5);
			if (motorDecorationConfig != null)
			{
				int partId2 = motorDecorationConfig.Value.PartId;
				int num6 = Array.IndexOf<int>(MotorcycleDiyDefine.MOTORCYCLE_DIY_DECORATION_PART, partId2);
				if (num6 != -1)
				{
					defaultDecorationIdList[num6] = num5;
				}
			}
		}
		this.EquipMotorOutLookRequest(list3, defaultDecorationIdList, num, delegate
		{
			MotorcycleDiyModel.Instance.ResetSelectedItemInfo();
			IOpenMotorcycleDiyRootViewData param = new OpenMotorcycleDiyRootViewData
			{
				OpenTabView = new EUiTabViewName?(openTabView)
			};
			UiManager.Instance.OpenView(EUiViewName.MotorcycleDiyRootView, param, null);
		});
	}

	// Token: 0x0601141C RID: 70684 RVA: 0x00436B84 File Offset: 0x00434D84
	public void OpenMotorGeneralPreviewView(int previewId)
	{
		MotorGeneralPreview? motorGeneralPreviewConfig = MotorDiyConfig.Instance.GetMotorGeneralPreviewConfig(previewId);
		if (motorGeneralPreviewConfig == null)
		{
			return;
		}
		EUiViewName? euiViewName = null;
		if (motorGeneralPreviewConfig.Value.GetStickerArray() != null && motorGeneralPreviewConfig.Value.GetStickerArray().Length != 0)
		{
			euiViewName = new EUiViewName?(EUiViewName.MotorcycleDiyStickerPreviewView);
		}
		else if ((motorGeneralPreviewConfig.Value.GetDecorationsArray() != null && motorGeneralPreviewConfig.Value.GetDecorationsArray().Length != 0) || motorGeneralPreviewConfig.Value.Frame > 0)
		{
			euiViewName = new EUiViewName?(EUiViewName.MotorcycleDiyDecorationPreviewView);
		}
		if (euiViewName == null)
		{
			return;
		}
		UiManager.Instance.OpenView(euiViewName.Value, previewId, null);
	}

	// Token: 0x0601141D RID: 70685 RVA: 0x00436C44 File Offset: 0x00434E44
	[NullableContext(0)]
	public UniTask<bool> OpenMotorcycleScenePopupView()
	{
		MotorcycleDiyController.<OpenMotorcycleScenePopupView>d__28 <OpenMotorcycleScenePopupView>d__;
		<OpenMotorcycleScenePopupView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenMotorcycleScenePopupView>d__.<>1__state = -1;
		<OpenMotorcycleScenePopupView>d__.<>t__builder.Start<MotorcycleDiyController.<OpenMotorcycleScenePopupView>d__28>(ref <OpenMotorcycleScenePopupView>d__);
		return <OpenMotorcycleScenePopupView>d__.<>t__builder.Task;
	}

	// Token: 0x170015F6 RID: 5622
	// (get) Token: 0x0601141E RID: 70686 RVA: 0x00436C7F File Offset: 0x00434E7F
	public static MotorcycleDiyController Instance
	{
		get
		{
			return MotorcycleDiyController._Instance;
		}
	}

	// Token: 0x0601141F RID: 70687 RVA: 0x00436C86 File Offset: 0x00434E86
	public static MotorcycleDiyController GetOrCreateInstance()
	{
		if (MotorcycleDiyController._Instance == null)
		{
			MotorcycleDiyController.CreateInstance();
		}
		return MotorcycleDiyController._Instance;
	}

	// Token: 0x06011420 RID: 70688 RVA: 0x00436C9A File Offset: 0x00434E9A
	public static bool CreateInstance()
	{
		if (MotorcycleDiyController._Instance != null)
		{
			return true;
		}
		MotorcycleDiyController._Instance = new MotorcycleDiyController();
		return true;
	}

	// Token: 0x06011421 RID: 70689 RVA: 0x00436CB0 File Offset: 0x00434EB0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011422 RID: 70690 RVA: 0x00436CB2 File Offset: 0x00434EB2
	public static void ResetStaticDefaultValue()
	{
		MotorcycleDiyController._Instance = null;
	}

	// Token: 0x06011423 RID: 70691 RVA: 0x00436CBA File Offset: 0x00434EBA
	static MotorcycleDiyController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleDiyController.CreateStaticDefaultValue), new Action(MotorcycleDiyController.ResetStaticDefaultValue));
	}

	// Token: 0x04008337 RID: 33591
	[Nullable(2)]
	private static MotorcycleDiyController _Instance;
}
