using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Plot.Flow;
using Cysharp.Threading.Tasks;

// Token: 0x020030A4 RID: 12452
[NullableContext(1)]
[Nullable(0)]
public class CharacterFlowLogic
{
	// Token: 0x170024A7 RID: 9383
	// (get) Token: 0x0601AAED RID: 109293 RVA: 0x0072FCAD File Offset: 0x0072DEAD
	// (set) Token: 0x0601AAEE RID: 109294 RVA: 0x0072FCB5 File Offset: 0x0072DEB5
	protected bool IsExecuteFlowEnd
	{
		get
		{
			return this.IsExecuteFlowEndInternal;
		}
		set
		{
			if (this.IsExecuteFlowEndInternal == value)
			{
				return;
			}
			this.IsExecuteFlowEndInternal = value;
			PawnHeadInfoComponent headInfoComp = this.HeadInfoComp;
			if (headInfoComp == null)
			{
				return;
			}
			headInfoComp.UpdateDialogUseState(!value);
		}
	}

	// Token: 0x0601AAEF RID: 109295 RVA: 0x0072FCDC File Offset: 0x0072DEDC
	public bool IsShowDialogue()
	{
		return !this.IsExecuteFlowEnd && this.EnableUpdate && this.WaitSecondsRemain > 0.0 && !this.IsWaitForDialogueUi;
	}

	// Token: 0x170024A8 RID: 9384
	// (get) Token: 0x0601AAF0 RID: 109296 RVA: 0x0072FD0A File Offset: 0x0072DF0A
	public bool IsPlaying
	{
		get
		{
			return !this.IsExecuteFlowEnd;
		}
	}

	// Token: 0x0601AAF1 RID: 109297 RVA: 0x0072FD18 File Offset: 0x0072DF18
	public CharacterFlowLogic(BaseActorComponent actorComp, BubbleComponent bubbleData)
	{
		this.ActorComp = actorComp;
		this.HeadInfoComp = actorComp.Entity.GetComponent<PawnHeadInfoComponent>();
		this.TempFlowInfoList = new List<IConditionBubbleData>();
		this.EntityConfigId = this.ActorComp.CreatureData.GetPbDataId();
		if (bubbleData != null)
		{
			this.EntityList = bubbleData.NpcIds;
			this.FlowInfoList = bubbleData.Flows;
			this.StaticIsAudioOccludedByScene = bubbleData.IsAudioOccludedByScene;
		}
	}

	// Token: 0x170024A9 RID: 9385
	// (get) Token: 0x0601AAF2 RID: 109298 RVA: 0x0072FDBC File Offset: 0x0072DFBC
	protected bool IsAudioOccludedByScene
	{
		get
		{
			AddPlayBubble dynamicFlowData = this.DynamicFlowData;
			bool? flag = (dynamicFlowData != null) ? dynamicFlowData.IsAudioOccludedByScene : null;
			if (flag == null)
			{
				return this.StaticIsAudioOccludedByScene.GetValueOrDefault();
			}
			return flag.GetValueOrDefault();
		}
	}

	// Token: 0x0601AAF3 RID: 109299 RVA: 0x0072FE00 File Offset: 0x0072E000
	public virtual void Tick(float deltaSeconds)
	{
		if (!this.EnableUpdate)
		{
			return;
		}
		if (this.IsWaitForDialogueUi)
		{
			return;
		}
		this.WaitSecondsRemain -= (double)deltaSeconds;
		if (this.WaitSecondsRemain <= 0.0)
		{
			if (this.IsExecuteFlowEnd)
			{
				if (!this.IsPause)
				{
					this.StartFlow();
					return;
				}
				this.EnableUpdate = false;
				return;
			}
			else
			{
				this.PlayTalk(this.CurrentTalkId + 1);
			}
		}
	}

	// Token: 0x0601AAF4 RID: 109300 RVA: 0x0072FE6C File Offset: 0x0072E06C
	public void StartFlow()
	{
		this.FindRandomFlow();
		this.PlayFlow();
	}

	// Token: 0x0601AAF5 RID: 109301 RVA: 0x0072FE7C File Offset: 0x0072E07C
	public void StopFlow()
	{
		this.IsExecuteFlowEnd = true;
		this.WaitSecondsRemain = 0.0;
		List<int> list;
		if (this.DynamicFlowData != null)
		{
			list = this.DynamicFlowData.EntityIds;
		}
		else
		{
			list = this.EntityList;
		}
		if (list != null && list.Count >= 2)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				Entity entity = this.GetEntity(list[i]);
				if (entity != null)
				{
					CharacterFlowComponent component = entity.GetComponent<CharacterFlowComponent>();
					if (component != null)
					{
						component.RemoveFlowActions();
					}
				}
				i++;
			}
			return;
		}
		CharacterFlowComponent component2 = this.ActorComp.Entity.GetComponent<CharacterFlowComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.RemoveFlowActions();
	}

	// Token: 0x0601AAF6 RID: 109302 RVA: 0x0072FF1C File Offset: 0x0072E11C
	protected void PlayFlow()
	{
		if (this.CurrentFlowInfo == null && this.DynamicFlowData == null)
		{
			this.HandleFlowEnd();
			return;
		}
		if (!this.IsFlowActorsReady())
		{
			return;
		}
		IBubbleIndex bubbleIndex = null;
		int value = 0;
		if (this.DynamicFlowData != null)
		{
			bubbleIndex = this.DynamicFlowData.Flow;
			IBubbleIndex flow = this.DynamicFlowData.Flow;
			value = ((flow != null) ? flow.StateId : null).GetValueOrDefault();
		}
		else
		{
			IBubbleData flow2 = this.CurrentFlowInfo.Flow;
			if (flow2 != null)
			{
				bubbleIndex = flow2.FlowIndex;
				IBubbleIndex flowIndex = flow2.FlowIndex;
				value = ((flowIndex != null) ? flowIndex.StateId : null).GetValueOrDefault();
			}
		}
		if (bubbleIndex == null)
		{
			this.HandleFlowEnd();
			return;
		}
		ShowTalk randomFlow = FlowConfig.Instance.GetRandomFlow(bubbleIndex.FlowListName, bubbleIndex.FlowId, this.ActorComp.Owner.GetName(), new int?(value));
		if (randomFlow != null)
		{
			this.CurrentTalkItems = randomFlow.TalkItems;
			this.IsExecuteFlowEnd = false;
			this.PlayTalk(0);
			this.TryToSendLogReport(bubbleIndex);
			return;
		}
		this.HandleFlowEnd();
	}

	// Token: 0x0601AAF7 RID: 109303 RVA: 0x0073002C File Offset: 0x0072E22C
	protected unsafe virtual void PlayTalk(int id)
	{
		this.CurrentTalkId = id;
		List<ITalkItem> currentTalkItems = this.CurrentTalkItems;
		if (id >= currentTalkItems.Count)
		{
			this.HandleFlowEnd();
			return;
		}
		IBubbleIndex bubbleIndex;
		if (this.DynamicFlowData == null)
		{
			IConditionBubbleData currentFlowInfo = this.CurrentFlowInfo;
			bubbleIndex = ((currentFlowInfo != null) ? currentFlowInfo.Flow.FlowIndex : null);
		}
		else
		{
			bubbleIndex = this.DynamicFlowData.Flow;
		}
		IBubbleIndex bubbleIndex2 = bubbleIndex;
		List<int> list = (this.DynamicFlowData != null) ? this.DynamicFlowData.EntityIds : this.EntityList;
		ITalkItem talkItem = currentTalkItems[id];
		Entity entity = this.ActorComp.Entity;
		if (list != null && list.Count >= 2)
		{
			int flowActorIndex = SimpleNpcFlowConditionChecker.GetFlowActorIndex(talkItem.WhoId.Value);
			if (flowActorIndex == -1)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "请配置演出目标";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FlowName", (bubbleIndex2 != null) ? bubbleIndex2.FlowListName : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", (bubbleIndex2 != null) ? new int?(bubbleIndex2.FlowId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("StateId", (bubbleIndex2 != null) ? bubbleIndex2.StateId : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("TalkId", id);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				this.PlayTalk(id + 1);
				return;
			}
			if (flowActorIndex >= list.Count)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.YJX;
				string message2 = "演出目标索引越界";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FlowName", (bubbleIndex2 != null) ? bubbleIndex2.FlowListName : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("FlowId", (bubbleIndex2 != null) ? new int?(bubbleIndex2.FlowId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("StateId", (bubbleIndex2 != null) ? bubbleIndex2.StateId : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("Index", flowActorIndex);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
				this.PlayTalk(id + 1);
				return;
			}
			int num = list[flowActorIndex];
			entity = this.GetEntity(num);
			if (entity == null)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Level;
				ELogAuthor author3 = ELogAuthor.YJX;
				string message3 = "播放多人冒泡时找不到演员,停止冒泡";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("MasterPbDataId", this.ActorComp.CreatureData.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("ActorPbDataId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("FlowName", (bubbleIndex2 != null) ? bubbleIndex2.FlowListName : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("FlowId", (bubbleIndex2 != null) ? new int?(bubbleIndex2.FlowId) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("StateId", (bubbleIndex2 != null) ? bubbleIndex2.StateId : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 5) = new ValueTuple<string, object>("Index", flowActorIndex);
				instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 6));
				this.HandleFlowEnd();
				return;
			}
		}
		if (this.HandleTalkAction(entity, talkItem))
		{
			this.IsExecuteFlowEnd = false;
			if (this.WaitSecondsRemain <= 0.0)
			{
				this.WaitSecondsRemain = (double)this.GetWaitSeconds(talkItem, 0f);
			}
			this.ActorComp.CreatureData.GetPbDataId();
			this.GetFlowText(talkItem.TidTalk);
			return;
		}
		this.PlayTalk(id + 1);
	}

	// Token: 0x0601AAF8 RID: 109304 RVA: 0x00730488 File Offset: 0x0072E688
	protected virtual bool HandleTalkAction(Entity entity, ITalkItem config)
	{
		if (entity == null)
		{
			return false;
		}
		bool result = false;
		string flowText = this.GetFlowText(config.TidTalk);
		if (flowText != null)
		{
			result = true;
			this.WaitSecondsRemain = (double)this.GetWaitSeconds(config, 0f);
			double num = this.WaitSecondsRemain + 0.05000000074505806;
			this.IsWaitForDialogueUi = true;
			PawnHeadInfoComponent component = entity.GetComponent<PawnHeadInfoComponent>();
			if (component != null)
			{
				component.SetDialogueText(flowText, (float)num, false).ContinueWith(() => this.IsWaitForDialogueUi = false);
			}
		}
		return result;
	}

	// Token: 0x0601AAF9 RID: 109305 RVA: 0x00730504 File Offset: 0x0072E704
	protected void HandleFlowEnd()
	{
		this.IsExecuteFlowEnd = true;
		this.IsWaitForDialogueUi = false;
		if (this.DynamicFlowData != null)
		{
			int? waitTime = this.DynamicFlowData.WaitTime;
			this.WaitSecondsRemain = (double)((waitTime != null) ? ((float)waitTime.GetValueOrDefault()) : 10f);
			DynamicFlowActorInfo dynamicFlowActorInfo = new DynamicFlowActorInfo();
			dynamicFlowActorInfo.PbDataId = this.ActorComp.CreatureData.GetPbDataId();
			dynamicFlowActorInfo.CreatureId = this.ActorComp.CreatureData.GetCreatureDataId();
			Action callback = DynamicFlowController.Instance.GetDynamicFlowByMasterActorInfo(dynamicFlowActorInfo).Callback;
			if (callback != null)
			{
				callback();
			}
		}
		else if (this.CurrentFlowInfo != null)
		{
			IBubbleData flow = this.CurrentFlowInfo.Flow;
			float num = 10f;
			if (flow != null && flow.WaitTime != 0)
			{
				num = (float)flow.WaitTime;
			}
			this.WaitSecondsRemain = (double)num;
		}
		this.ResetFlowState();
	}

	// Token: 0x0601AAFA RID: 109306 RVA: 0x007305DC File Offset: 0x0072E7DC
	protected virtual void ResetFlowState()
	{
		this.CurrentTalkItems = null;
		this.CurrentTalkId = 0;
		this.CurrentFlowInfo = null;
		this.DynamicFlowData = null;
	}

	// Token: 0x0601AAFB RID: 109307 RVA: 0x007305FC File Offset: 0x0072E7FC
	protected void FindRandomFlow()
	{
		if (this.FindDynamicFlow())
		{
			return;
		}
		this.TempFlowInfoList.Clear();
		this.CurrentFlowInfo = null;
		foreach (IConditionBubbleData conditionBubbleData in this.FlowInfoList)
		{
			if (LevelGeneralController.Instance.CheckConditionNew(conditionBubbleData.Condition, this.ActorComp.Owner, EntityContext.Create(this.ActorComp.Entity.Id, null), null))
			{
				this.TempFlowInfoList.Add(conditionBubbleData);
			}
		}
		this.CurrentFlowInfo = ObjectUtils.GetRandomArrayItem<IConditionBubbleData>(this.TempFlowInfoList);
	}

	// Token: 0x0601AAFC RID: 109308 RVA: 0x007306C4 File Offset: 0x0072E8C4
	public void ResetWaitTime()
	{
		this.WaitSecondsRemain = 0.0;
	}

	// Token: 0x0601AAFD RID: 109309 RVA: 0x007306D5 File Offset: 0x0072E8D5
	public bool HasValidFlow()
	{
		return this.FlowInfoList.Count > 0;
	}

	// Token: 0x0601AAFE RID: 109310 RVA: 0x007306E5 File Offset: 0x0072E8E5
	[NullableContext(2)]
	protected Entity GetEntity(int pbDataId)
	{
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
		if (entityByPbDataId == null)
		{
			return null;
		}
		return entityByPbDataId.Entity;
	}

	// Token: 0x0601AAFF RID: 109311 RVA: 0x00730700 File Offset: 0x0072E900
	protected float GetWaitSeconds(ITalkItem config, float offset = 0f)
	{
		return config.WaitTime.GetValueOrDefault(3f) + offset;
	}

	// Token: 0x0601AB00 RID: 109312 RVA: 0x00730722 File Offset: 0x0072E922
	[NullableContext(2)]
	protected string GetFlowText(string textId)
	{
		if (!string.IsNullOrEmpty(textId))
		{
			return PublicUtil.Instance.GetFlowConfigLocalText(textId);
		}
		return null;
	}

	// Token: 0x0601AB01 RID: 109313 RVA: 0x0073073C File Offset: 0x0072E93C
	private void TryToSendLogReport(IBubbleIndex flowIndex)
	{
		PlayFlowLogData playFlowLogData = new PlayFlowLogData();
		playFlowLogData.i_bubble_type = ((this.DynamicFlowData != null) ? 2 : 1);
		playFlowLogData.s_flow_file = flowIndex.FlowListName;
		playFlowLogData.i_flow_id = flowIndex.FlowId;
		playFlowLogData.i_flow_status_id = flowIndex.StateId.GetValueOrDefault();
		playFlowLogData.i_config_id = this.EntityConfigId;
		playFlowLogData.i_area_id = AreaModel.Instance.GetCurrentAreaId(null);
		playFlowLogData.i_father_area_id = AreaModel.Instance.AreaInfo.Value.Father;
		Vector actorLocationProxy = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
		playFlowLogData.f_pos_x = (float)actorLocationProxy.X;
		playFlowLogData.f_pos_y = (float)actorLocationProxy.Y;
		playFlowLogData.f_pos_z = (float)actorLocationProxy.Z;
		LogReportController.Instance.LogReport(playFlowLogData);
	}

	// Token: 0x0601AB02 RID: 109314 RVA: 0x00730816 File Offset: 0x0072EA16
	public void HideDialogueText()
	{
		this.IsWaitForDialogueUi = false;
		PawnHeadInfoComponent headInfoComp = this.HeadInfoComp;
		if (headInfoComp == null)
		{
			return;
		}
		headInfoComp.HideDialogueText();
	}

	// Token: 0x0601AB03 RID: 109315 RVA: 0x0073082F File Offset: 0x0072EA2F
	public bool HasDynamicFlow()
	{
		return this.DynamicFlowData != null;
	}

	// Token: 0x0601AB04 RID: 109316 RVA: 0x0073083C File Offset: 0x0072EA3C
	protected bool FindDynamicFlow()
	{
		DynamicFlowActorInfo dynamicFlowActorInfo = new DynamicFlowActorInfo();
		dynamicFlowActorInfo.PbDataId = this.ActorComp.CreatureData.GetPbDataId();
		dynamicFlowActorInfo.CreatureId = this.ActorComp.CreatureData.GetCreatureDataId();
		CharacterDynamicFlowData dynamicFlowByMasterActorInfo = DynamicFlowController.Instance.GetDynamicFlowByMasterActorInfo(dynamicFlowActorInfo);
		this.DynamicFlowData = ((dynamicFlowByMasterActorInfo != null) ? dynamicFlowByMasterActorInfo.BubbleData : null);
		return dynamicFlowByMasterActorInfo != null;
	}

	// Token: 0x0601AB05 RID: 109317 RVA: 0x007308A0 File Offset: 0x0072EAA0
	protected bool IsFlowActorsReady()
	{
		List<int> list;
		if (this.DynamicFlowData != null)
		{
			list = this.DynamicFlowData.EntityIds;
		}
		else
		{
			list = this.EntityList;
		}
		if (list == null || list.Count == 0)
		{
			BaseActorComponent actorComp = this.ActorComp;
			return actorComp != null && actorComp.Entity.IsInit;
		}
		foreach (int pbDataId in list)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (entityByPbDataId == null || !entityByPbDataId.IsInit)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CDD8 RID: 52696
	private const float DEFAULT_WAIT_TIME = 3f;

	// Token: 0x0400CDD9 RID: 52697
	private const float DEFAULT_LOOP_TIME = 10f;

	// Token: 0x0400CDDA RID: 52698
	private readonly int EntityConfigId;

	// Token: 0x0400CDDB RID: 52699
	[Nullable(2)]
	protected readonly BaseActorComponent ActorComp;

	// Token: 0x0400CDDC RID: 52700
	[Nullable(2)]
	protected readonly PawnHeadInfoComponent HeadInfoComp;

	// Token: 0x0400CDDD RID: 52701
	protected readonly List<IConditionBubbleData> FlowInfoList = new List<IConditionBubbleData>();

	// Token: 0x0400CDDE RID: 52702
	protected readonly List<IConditionBubbleData> TempFlowInfoList = new List<IConditionBubbleData>();

	// Token: 0x0400CDDF RID: 52703
	[Nullable(2)]
	protected IConditionBubbleData CurrentFlowInfo;

	// Token: 0x0400CDE0 RID: 52704
	protected List<int> EntityList = new List<int>();

	// Token: 0x0400CDE1 RID: 52705
	private bool? StaticIsAudioOccludedByScene;

	// Token: 0x0400CDE2 RID: 52706
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<ITalkItem> CurrentTalkItems;

	// Token: 0x0400CDE3 RID: 52707
	protected int CurrentTalkId;

	// Token: 0x0400CDE4 RID: 52708
	[Nullable(2)]
	protected AddPlayBubble DynamicFlowData;

	// Token: 0x0400CDE5 RID: 52709
	public bool IsPause = true;

	// Token: 0x0400CDE6 RID: 52710
	public bool EnableUpdate;

	// Token: 0x0400CDE7 RID: 52711
	protected bool IsExecuteFlowEndInternal = true;

	// Token: 0x0400CDE8 RID: 52712
	protected double WaitSecondsRemain;

	// Token: 0x0400CDE9 RID: 52713
	protected bool IsWaitForDialogueUi;
}
