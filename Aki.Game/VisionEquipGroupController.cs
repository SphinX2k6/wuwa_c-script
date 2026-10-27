using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;

// Token: 0x02002444 RID: 9284
[Controller(0)]
public class VisionEquipGroupController : UiControllerBase
{
	// Token: 0x060129D6 RID: 76246 RVA: 0x00498032 File Offset: 0x00496232
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x060129D7 RID: 76247 RVA: 0x00498050 File Offset: 0x00496250
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x060129D8 RID: 76248 RVA: 0x0049806E File Offset: 0x0049626E
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomEquipGroupInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomEquipGroupInfoNotify));
	}

	// Token: 0x060129D9 RID: 76249 RVA: 0x0049808C File Offset: 0x0049628C
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomEquipGroupInfoNotify);
	}

	// Token: 0x060129DA RID: 76250 RVA: 0x004980A0 File Offset: 0x004962A0
	[NullableContext(2)]
	private void OnPhantomEquipGroupInfoNotify(IMessage msg, Net.CallbackStatus status)
	{
		PhantomEquipGroupInfoNotify phantomEquipGroupInfoNotify = (PhantomEquipGroupInfoNotify)msg;
		List<string> list = new List<string>();
		foreach (PhantomEquipGroupInfo phantomEquipGroupInfo in phantomEquipGroupInfoNotify.PhantomEquipGroupInfos)
		{
			string value = (phantomEquipGroupInfo.IncId != null) ? string.Join<int>("|", phantomEquipGroupInfo.IncId) : "";
			List<string> list2 = list;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(list.Count);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		VisionEquipGroupModel.Instance.RefreshVisionEquipGroupData(phantomEquipGroupInfoNotify.PhantomEquipGroupInfos.ToList<PhantomEquipGroupInfo>());
	}

	// Token: 0x060129DB RID: 76251 RVA: 0x00498164 File Offset: 0x00496364
	private void OnDataDone()
	{
		this.RequestVisionEquipGroupInfo();
	}

	// Token: 0x060129DC RID: 76252 RVA: 0x00498170 File Offset: 0x00496370
	public UniTask RequestVisionEquipGroupInfo()
	{
		VisionEquipGroupController.<RequestVisionEquipGroupInfo>d__6 <RequestVisionEquipGroupInfo>d__;
		<RequestVisionEquipGroupInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestVisionEquipGroupInfo>d__.<>1__state = -1;
		<RequestVisionEquipGroupInfo>d__.<>t__builder.Start<VisionEquipGroupController.<RequestVisionEquipGroupInfo>d__6>(ref <RequestVisionEquipGroupInfo>d__);
		return <RequestVisionEquipGroupInfo>d__.<>t__builder.Task;
	}

	// Token: 0x060129DD RID: 76253 RVA: 0x004981AC File Offset: 0x004963AC
	public UniTask<ErrorCode> RequestAddVisionEquipGroup(int roleId, [Nullable(1)] string name)
	{
		VisionEquipGroupController.<RequestAddVisionEquipGroup>d__7 <RequestAddVisionEquipGroup>d__;
		<RequestAddVisionEquipGroup>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<RequestAddVisionEquipGroup>d__.roleId = roleId;
		<RequestAddVisionEquipGroup>d__.name = name;
		<RequestAddVisionEquipGroup>d__.<>1__state = -1;
		<RequestAddVisionEquipGroup>d__.<>t__builder.Start<VisionEquipGroupController.<RequestAddVisionEquipGroup>d__7>(ref <RequestAddVisionEquipGroup>d__);
		return <RequestAddVisionEquipGroup>d__.<>t__builder.Task;
	}

	// Token: 0x060129DE RID: 76254 RVA: 0x004981F8 File Offset: 0x004963F8
	public void RequestDeleteVisionEquipGroup(int index)
	{
		DeletePhantomEquipGroupRequest deletePhantomEquipGroupRequest = DeletePhantomEquipGroupRequest.Create();
		deletePhantomEquipGroupRequest.Index = index;
		Net.Instance.Call(ERequestMessageId.DeletePhantomEquipGroupRequest, deletePhantomEquipGroupRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			DeletePhantomEquipGroupResponse deletePhantomEquipGroupResponse = (DeletePhantomEquipGroupResponse)msg;
			if (deletePhantomEquipGroupResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(deletePhantomEquipGroupResponse.ErrorCode, 26711, null, true, true);
				return;
			}
			VisionEquipGroupModel.Instance.RefreshVisionEquipGroupData(deletePhantomEquipGroupResponse.PhantomEquipGroupInfos.ToList<PhantomEquipGroupInfo>());
			EventSystem.Instance.Emit(EEventName.OnVisionGroupDataDelete);
		}, 0);
	}

	// Token: 0x060129DF RID: 76255 RVA: 0x00498244 File Offset: 0x00496444
	public void RequestPutVisionGroupToTop(int index)
	{
		if (index == 0)
		{
			EventSystem.Instance.Emit(EEventName.OnVisionGroupDataToTop);
			return;
		}
		TopPhantomEquipGroupRequest topPhantomEquipGroupRequest = TopPhantomEquipGroupRequest.Create();
		topPhantomEquipGroupRequest.Index = index;
		Net.Instance.Call(ERequestMessageId.TopPhantomEquipGroupRequest, topPhantomEquipGroupRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			TopPhantomEquipGroupResponse topPhantomEquipGroupResponse = (TopPhantomEquipGroupResponse)msg;
			if (topPhantomEquipGroupResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(topPhantomEquipGroupResponse.ErrorCode, 27536, null, true, true);
				return;
			}
			VisionEquipGroupModel.Instance.RefreshVisionEquipGroupData(topPhantomEquipGroupResponse.PhantomEquipGroupInfos.ToList<PhantomEquipGroupInfo>());
			EventSystem.Instance.Emit(EEventName.OnVisionGroupDataToTop);
		}, 0);
	}

	// Token: 0x060129E0 RID: 76256 RVA: 0x004982A4 File Offset: 0x004964A4
	public UniTask<ErrorCode> RequestChangeVisionGroupName(int index, [Nullable(1)] string name)
	{
		VisionEquipGroupController.<RequestChangeVisionGroupName>d__10 <RequestChangeVisionGroupName>d__;
		<RequestChangeVisionGroupName>d__.<>t__builder = AsyncUniTaskMethodBuilder<ErrorCode>.Create();
		<RequestChangeVisionGroupName>d__.index = index;
		<RequestChangeVisionGroupName>d__.name = name;
		<RequestChangeVisionGroupName>d__.<>1__state = -1;
		<RequestChangeVisionGroupName>d__.<>t__builder.Start<VisionEquipGroupController.<RequestChangeVisionGroupName>d__10>(ref <RequestChangeVisionGroupName>d__);
		return <RequestChangeVisionGroupName>d__.<>t__builder.Task;
	}

	// Token: 0x060129E1 RID: 76257 RVA: 0x004982F0 File Offset: 0x004964F0
	public void RequestApplyVisionGroup(int index, int roleId)
	{
		if (SceneTeamModel.Instance.GetCurrentEntity.Entity.GetComponent<BaseTagComponent>().HasTag(GameplayTagDefine.EGameplayTagId["幻象.Common.技能中"]))
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		if (PhantomUtil.IsInVisionSkill())
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		bool flag = false;
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(EntitySystem.Instance.Get(SceneTeamModel.Instance.GetCurrentEntity.Id), ESummonType.ConcomitantVision, 1);
		if (summonedEntity != null && summonedEntity.Entity.Active)
		{
			flag = true;
		}
		if (flag)
		{
			GenericPromptController.Instance.ShowPromptByCode("VisionSkilling", Array.Empty<object>());
			return;
		}
		if (RoleController.Instance.CheckCharacterInBattleTagAndShowTips(true))
		{
			return;
		}
		UsePhantomEquipGroupRequest usePhantomEquipGroupRequest = UsePhantomEquipGroupRequest.Create();
		usePhantomEquipGroupRequest.Index = index;
		usePhantomEquipGroupRequest.RoleId = roleId;
		Net.Instance.Call(ERequestMessageId.UsePhantomEquipGroupRequest, usePhantomEquipGroupRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			UsePhantomEquipGroupResponse usePhantomEquipGroupResponse = (UsePhantomEquipGroupResponse)msg;
			if (usePhantomEquipGroupResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(usePhantomEquipGroupResponse.ErrorCode, 21750, null, true, true);
				return;
			}
			RepeatedField<RolePhantomEquipInfo> equipInfoList = usePhantomEquipGroupResponse.EquipInfoList;
			InventoryController.Instance.ApplyPhantomStackSplitAndMerge(usePhantomEquipGroupResponse.StackSplitInfos, usePhantomEquipGroupResponse.StackMergeInfos, "UseEquipGroup");
			foreach (RolePhantomEquipInfo rolePhantomEquipInfo in equipInfoList)
			{
				PhantomBattleModel.Instance.UpdateRoleEquipmentData(rolePhantomEquipInfo);
				PhantomBattleModel.Instance.UpdateFetterList(rolePhantomEquipInfo.RoleId);
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("VisionAssembleHasUseTips", Array.Empty<object>());
			EventSystem.Instance.Emit(EEventName.PhantomEquip);
		}, 0);
	}

	// Token: 0x17001823 RID: 6179
	// (get) Token: 0x060129E2 RID: 76258 RVA: 0x004983F7 File Offset: 0x004965F7
	[Nullable(1)]
	public static VisionEquipGroupController Instance
	{
		[NullableContext(1)]
		get
		{
			return VisionEquipGroupController._Instance;
		}
	}

	// Token: 0x060129E3 RID: 76259 RVA: 0x004983FE File Offset: 0x004965FE
	[NullableContext(1)]
	public static VisionEquipGroupController GetOrCreateInstance()
	{
		if (VisionEquipGroupController._Instance == null)
		{
			VisionEquipGroupController.CreateInstance();
		}
		return VisionEquipGroupController._Instance;
	}

	// Token: 0x060129E4 RID: 76260 RVA: 0x00498412 File Offset: 0x00496612
	public static bool CreateInstance()
	{
		if (VisionEquipGroupController._Instance != null)
		{
			return true;
		}
		VisionEquipGroupController._Instance = new VisionEquipGroupController();
		return true;
	}

	// Token: 0x060129E5 RID: 76261 RVA: 0x00498428 File Offset: 0x00496628
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060129E6 RID: 76262 RVA: 0x0049842A File Offset: 0x0049662A
	public static void ResetStaticDefaultValue()
	{
		VisionEquipGroupController._Instance = null;
	}

	// Token: 0x060129E7 RID: 76263 RVA: 0x00498432 File Offset: 0x00496632
	static VisionEquipGroupController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionEquipGroupController.CreateStaticDefaultValue), new Action(VisionEquipGroupController.ResetStaticDefaultValue));
	}

	// Token: 0x04008C54 RID: 35924
	[Nullable(2)]
	private static VisionEquipGroupController _Instance;
}
