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

// Token: 0x020025FB RID: 9723
[NullableContext(1)]
[Nullable(0)]
public class CharacterFlowLogic
{
	// Token: 0x17002629 RID: 9769
	// (get) Token: 0x060184FA RID: 99578 RVA: 0x0075515F File Offset: 0x0075335F
	// (set) Token: 0x060184FB RID: 99579 RVA: 0x00755167 File Offset: 0x00753367
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

	// Token: 0x060184FC RID: 99580 RVA: 0x0075518E File Offset: 0x0075338E
	public bool IsShowDialogue()
	{
		return !this.IsExecuteFlowEnd && this.EnableUpdate && this.WaitSecondsRemain > 0.0 && !this.IsWaitForDialogueUi;
	}

	// Token: 0x1700262A RID: 9770
	// (get) Token: 0x060184FD RID: 99581 RVA: 0x007551BC File Offset: 0x007533BC
	public bool IsPlaying
	{
		get
		{
			return !this.IsExecuteFlowEnd;
		}
	}

	// Token: 0x060184FE RID: 99582 RVA: 0x007551C8 File Offset: 0x007533C8
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
			this.StaticIsPlayMouthAnim = bubbleData.IsPlayMouthAnim;
		}
	}

	// Token: 0x1700262B RID: 9771
	// (get) Token: 0x060184FF RID: 99583 RVA: 0x00755278 File Offset: 0x00753478
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

	// Token: 0x1700262C RID: 9772
	// (get) Token: 0x06018500 RID: 99584 RVA: 0x007552BC File Offset: 0x007534BC
	protected bool IsPlayMouthAnim
	{
		get
		{
			AddPlayBubble dynamicFlowData = this.DynamicFlowData;
			bool? flag = (dynamicFlowData != null) ? dynamicFlowData.IsPlayMouthAnim : null;
			if (flag == null)
			{
				return this.StaticIsPlayMouthAnim.GetValueOrDefault();
			}
			return flag.GetValueOrDefault();
		}
	}

	// Token: 0x06018501 RID: 99585 RVA: 0x00755300 File Offset: 0x00753500
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

	// Token: 0x06018502 RID: 99586 RVA: 0x0075536C File Offset: 0x0075356C
	public void StartFlow()
	{
		this.FindRandomFlow();
		this.PlayFlow();
	}

	// Token: 0x06018503 RID: 99587 RVA: 0x0075537C File Offset: 0x0075357C
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

	// Token: 0x06018504 RID: 99588 RVA: 0x0075541C File Offset: 0x0075361C
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

	// Token: 0x06018505 RID: 99589 RVA: 0x0075552C File Offset: 0x0075372C
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

	// Token: 0x06018506 RID: 99590 RVA: 0x00755988 File Offset: 0x00753B88
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

	// Token: 0x06018507 RID: 99591 RVA: 0x00755A04 File Offset: 0x00753C04
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

	// Token: 0x06018508 RID: 99592 RVA: 0x00755ADC File Offset: 0x00753CDC
	protected virtual void ResetFlowState()
	{
		this.CurrentTalkItems = null;
		this.CurrentTalkId = 0;
		this.CurrentFlowInfo = null;
		this.DynamicFlowData = null;
	}

	// Token: 0x06018509 RID: 99593 RVA: 0x00755AFC File Offset: 0x00753CFC
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

	// Token: 0x0601850A RID: 99594 RVA: 0x00755BC4 File Offset: 0x00753DC4
	public void ResetWaitTime()
	{
		this.WaitSecondsRemain = 0.0;
	}

	// Token: 0x0601850B RID: 99595 RVA: 0x00755BD5 File Offset: 0x00753DD5
	public bool HasValidFlow()
	{
		return this.FlowInfoList.Count > 0;
	}

	// Token: 0x0601850C RID: 99596 RVA: 0x00755BE5 File Offset: 0x00753DE5
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

	// Token: 0x0601850D RID: 99597 RVA: 0x00755C00 File Offset: 0x00753E00
	protected float GetWaitSeconds(ITalkItem config, float offset = 0f)
	{
		return config.WaitTime.GetValueOrDefault(3f) + offset;
	}

	// Token: 0x0601850E RID: 99598 RVA: 0x00755C22 File Offset: 0x00753E22
	[NullableContext(2)]
	protected string GetFlowText(string textId)
	{
		if (!string.IsNullOrEmpty(textId))
		{
			return PublicUtil.Instance.GetFlowConfigLocalText(textId);
		}
		return null;
	}

	// Token: 0x0601850F RID: 99599 RVA: 0x00755C3C File Offset: 0x00753E3C
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

	// Token: 0x06018510 RID: 99600 RVA: 0x00755D16 File Offset: 0x00753F16
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

	// Token: 0x06018511 RID: 99601 RVA: 0x00755D2F File Offset: 0x00753F2F
	public bool HasDynamicFlow()
	{
		return this.DynamicFlowData != null;
	}

	// Token: 0x06018512 RID: 99602 RVA: 0x00755D3C File Offset: 0x00753F3C
	protected bool FindDynamicFlow()
	{
		DynamicFlowActorInfo dynamicFlowActorInfo = new DynamicFlowActorInfo();
		dynamicFlowActorInfo.PbDataId = this.ActorComp.CreatureData.GetPbDataId();
		dynamicFlowActorInfo.CreatureId = this.ActorComp.CreatureData.GetCreatureDataId();
		CharacterDynamicFlowData dynamicFlowByMasterActorInfo = DynamicFlowController.Instance.GetDynamicFlowByMasterActorInfo(dynamicFlowActorInfo);
		this.DynamicFlowData = ((dynamicFlowByMasterActorInfo != null) ? dynamicFlowByMasterActorInfo.BubbleData : null);
		return dynamicFlowByMasterActorInfo != null;
	}

	// Token: 0x06018513 RID: 99603 RVA: 0x00755DA0 File Offset: 0x00753FA0
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

	// Token: 0x0400D1BB RID: 53691
	private const float DEFAULT_WAIT_TIME = 3f;

	// Token: 0x0400D1BC RID: 53692
	private const float DEFAULT_LOOP_TIME = 10f;

	// Token: 0x0400D1BD RID: 53693
	private readonly int EntityConfigId;

	// Token: 0x0400D1BE RID: 53694
	[Nullable(2)]
	protected readonly BaseActorComponent ActorComp;

	// Token: 0x0400D1BF RID: 53695
	[Nullable(2)]
	protected readonly PawnHeadInfoComponent HeadInfoComp;

	// Token: 0x0400D1C0 RID: 53696
	protected readonly List<IConditionBubbleData> FlowInfoList = new List<IConditionBubbleData>();

	// Token: 0x0400D1C1 RID: 53697
	protected readonly List<IConditionBubbleData> TempFlowInfoList = new List<IConditionBubbleData>();

	// Token: 0x0400D1C2 RID: 53698
	[Nullable(2)]
	protected IConditionBubbleData CurrentFlowInfo;

	// Token: 0x0400D1C3 RID: 53699
	protected List<int> EntityList = new List<int>();

	// Token: 0x0400D1C4 RID: 53700
	private bool? StaticIsAudioOccludedByScene;

	// Token: 0x0400D1C5 RID: 53701
	private bool? StaticIsPlayMouthAnim;

	// Token: 0x0400D1C6 RID: 53702
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<ITalkItem> CurrentTalkItems;

	// Token: 0x0400D1C7 RID: 53703
	protected int CurrentTalkId;

	// Token: 0x0400D1C8 RID: 53704
	[Nullable(2)]
	protected AddPlayBubble DynamicFlowData;

	// Token: 0x0400D1C9 RID: 53705
	public bool IsPause = true;

	// Token: 0x0400D1CA RID: 53706
	public bool EnableUpdate;

	// Token: 0x0400D1CB RID: 53707
	protected bool IsExecuteFlowEndInternal = true;

	// Token: 0x0400D1CC RID: 53708
	protected double WaitSecondsRemain;

	// Token: 0x0400D1CD RID: 53709
	protected bool IsWaitForDialogueUi;
}
