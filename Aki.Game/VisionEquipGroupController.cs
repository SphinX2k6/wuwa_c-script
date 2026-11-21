using System;
using System.Collections.Generic;
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

// Token: 0x02001929 RID: 6441
[Controller(0)]
public class VisionEquipGroupController : UiControllerBase
{
	// Token: 0x0600FE8C RID: 65164 RVA: 0x004A5606 File Offset: 0x004A3806
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0600FE8D RID: 65165 RVA: 0x004A5624 File Offset: 0x004A3824
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
	}

	// Token: 0x0600FE8E RID: 65166 RVA: 0x004A5642 File Offset: 0x004A3842
	protected override void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.PhantomEquipGroupInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPhantomEquipGroupInfoNotify));
	}

	// Token: 0x0600FE8F RID: 65167 RVA: 0x004A5660 File Offset: 0x004A3860
	protected override void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.PhantomEquipGroupInfoNotify);
	}

	// Token: 0x0600FE90 RID: 65168 RVA: 0x004A5674 File Offset: 0x004A3874
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
		VisionEquipGroupModel.Instance.RefreshVisionEquipGroupData(phantomEquipGroupInfoNotify.PhantomEquipGroupInfos);
	}

	// Token: 0x0600FE91 RID: 65169 RVA: 0x004A5730 File Offset: 0x004A3930
	private void OnDataDone()
	{
		this.RequestVisionEquipGroupInfo();
	}

	// Token: 0x0600FE92 RID: 65170 RVA: 0x004A573C File Offset: 0x004A393C
	public UniTask RequestVisionEquipGroupInfo()
	{
		VisionEquipGroupController.<RequestVisionEquipGroupInfo>d__6 <RequestVisionEquipGroupInfo>d__;
		<RequestVisionEquipGroupInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestVisionEquipGroupInfo>d__.<>1__state = -1;
		<RequestVisionEquipGroupInfo>d__.<>t__builder.Start<VisionEquipGroupController.<RequestVisionEquipGroupInfo>d__6>(ref <RequestVisionEquipGroupInfo>d__);
		return <RequestVisionEquipGroupInfo>d__.<>t__builder.Task;
	}

	// Token: 0x0600FE93 RID: 65171 RVA: 0x004A5778 File Offset: 0x004A3978
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

	// Token: 0x0600FE94 RID: 65172 RVA: 0x004A57C4 File Offset: 0x004A39C4
	public void RequestDeleteVisionEquipGroup(int index)
	{
		DeletePhantomEquipGroupRequest deletePhantomEquipGroupRequest = DeletePhantomEquipGroupRequest.Create();
		deletePhantomEquipGroupRequest.Index = index;
		Net.Instance.Call(ERequestMessageId.DeletePhantomEquipGroupRequest, deletePhantomEquipGroupRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			DeletePhantomEquipGroupResponse deletePhantomEquipGroupResponse = (DeletePhantomEquipGroupResponse)msg;
			if (deletePhantomEquipGroupResponse.ErrorCode != ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(deletePhantomEquipGroupResponse.ErrorCode, 16721, null, true, true);
				return;
			}
			VisionEquipGroupModel.Instance.RefreshVisionEquipGroupData(deletePhantomEquipGroupResponse.PhantomEquipGroupInfos);
			EventSystem.Instance.Emit(EEventName.OnVisionGroupDataDelete);
		}, 0);
	}

	// Token: 0x0600FE95 RID: 65173 RVA: 0x004A5810 File Offset: 0x004A3A10
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(topPhantomEquipGroupResponse.ErrorCode, 24824, null, true, true);
				return;
			}
			VisionEquipGroupModel.Instance.RefreshVisionEquipGroupData(topPhantomEquipGroupResponse.PhantomEquipGroupInfos);
			EventSystem.Instance.Emit(EEventName.OnVisionGroupDataToTop);
		}, 0);
	}

	// Token: 0x0600FE96 RID: 65174 RVA: 0x004A5870 File Offset: 0x004A3A70
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

	// Token: 0x0600FE97 RID: 65175 RVA: 0x004A58BC File Offset: 0x004A3ABC
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
				ErrorCodeController.Instance.OpenErrorCodeTipView(usePhantomEquipGroupResponse.ErrorCode, 19113, null, true, true);
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

	// Token: 0x1700185D RID: 6237
	// (get) Token: 0x0600FE98 RID: 65176 RVA: 0x004A59C3 File Offset: 0x004A3BC3
	[Nullable(1)]
	public static VisionEquipGroupController Instance
	{
		[NullableContext(1)]
		get
		{
			return VisionEquipGroupController._Instance;
		}
	}

	// Token: 0x0600FE99 RID: 65177 RVA: 0x004A59CA File Offset: 0x004A3BCA
	[NullableContext(1)]
	public static VisionEquipGroupController GetOrCreateInstance()
	{
		if (VisionEquipGroupController._Instance == null)
		{
			VisionEquipGroupController.CreateInstance();
		}
		return VisionEquipGroupController._Instance;
	}

	// Token: 0x0600FE9A RID: 65178 RVA: 0x004A59DE File Offset: 0x004A3BDE
	public static bool CreateInstance()
	{
		if (VisionEquipGroupController._Instance != null)
		{
			return true;
		}
		VisionEquipGroupController._Instance = new VisionEquipGroupController();
		return true;
	}

	// Token: 0x0600FE9B RID: 65179 RVA: 0x004A59F4 File Offset: 0x004A3BF4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FE9C RID: 65180 RVA: 0x004A59F6 File Offset: 0x004A3BF6
	public static void ResetStaticDefaultValue()
	{
		VisionEquipGroupController._Instance = null;
	}

	// Token: 0x0600FE9D RID: 65181 RVA: 0x004A59FE File Offset: 0x004A3BFE
	static VisionEquipGroupController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(VisionEquipGroupController.CreateStaticDefaultValue), new Action(VisionEquipGroupController.ResetStaticDefaultValue));
	}

	// Token: 0x04008D9B RID: 36251
	[Nullable(2)]
	private static VisionEquipGroupController _Instance;
}
