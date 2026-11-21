using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Data.NPC.SimpleNpcFlow;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Plot.Flow;
using UnrealEngine;

// Token: 0x020027D4 RID: 10196
[NullableContext(1)]
[Nullable(0)]
public class SimpleNpcMultiplyLogic : IStaticVariableResetter
{
	// Token: 0x060199EB RID: 104939 RVA: 0x007DE3D3 File Offset: 0x007DC5D3
	static SimpleNpcMultiplyLogic()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SimpleNpcMultiplyLogic.CreateStaticDefaultValue), new Action(SimpleNpcMultiplyLogic.ResetStaticDefaultValue));
	}

	// Token: 0x060199EC RID: 104940 RVA: 0x007DE3F4 File Offset: 0x007DC5F4
	public SimpleNpcMultiplyLogic(SimpleNpcFlowComponent_C flowComponent)
	{
		this.FlowComponent = flowComponent;
		this.InstanceId = ++SimpleNpcMultiplyLogic.Instance;
		this.FlowConfigListResult = new List<SimpleNpcFlowData>();
	}

	// Token: 0x060199ED RID: 104941 RVA: 0x007DE45B File Offset: 0x007DC65B
	public void StartFlow()
	{
		this.IsPause = false;
		this.InitFlowDisplayState();
		this.HandlePlayFlow();
	}

	// Token: 0x060199EE RID: 104942 RVA: 0x007DE470 File Offset: 0x007DC670
	private void HandlePlayFlow()
	{
		this.FlowConfigListResult.Clear();
		SimpleNpcFlowData simpleNpcFlowData = null;
		TArray<SimpleNpcFlowData> flowList = this.FlowComponent.FlowList;
		int i = 0;
		int num = flowList.Num();
		while (i < num)
		{
			SimpleNpcFlowData simpleNpcFlowData2 = flowList.Get(i);
			if (this.CurrentWorldStateFlow[i])
			{
				if (simpleNpcFlowData2.CheckType == 9)
				{
					if (SimpleNpcFlowConditionChecker.CheckFirstEnter(this.InstanceId))
					{
						this.FlowConfigListResult.Add(simpleNpcFlowData2);
						simpleNpcFlowData = simpleNpcFlowData2;
						SimpleNpcFlowConditionChecker.SetFirstEnter(this.InstanceId);
						break;
					}
				}
				else if (SimpleNpcFlowConditionChecker.CheckCondition(simpleNpcFlowData2))
				{
					this.FlowConfigListResult.Add(simpleNpcFlowData2);
				}
			}
			i++;
		}
		if (simpleNpcFlowData != null)
		{
			this.ExecuteTargetFlow(simpleNpcFlowData);
			return;
		}
		SimpleNpcFlowData randomArrayItem = ObjectUtils.GetRandomArrayItem<SimpleNpcFlowData>(this.FlowConfigListResult);
		if (randomArrayItem != null)
		{
			this.ExecuteTargetFlow(randomArrayItem);
		}
	}

	// Token: 0x060199EF RID: 104943 RVA: 0x007DE540 File Offset: 0x007DC740
	private void InitFlowDisplayState()
	{
		if (this.CurrentWorldStateFlow.Count < this.FlowComponent.FlowList.Num())
		{
			this.FilterFlowWorldState();
		}
	}

	// Token: 0x060199F0 RID: 104944 RVA: 0x007DE568 File Offset: 0x007DC768
	public void FilterFlowWorldState()
	{
		int num = this.FlowComponent.FlowList.Num();
		this.CurrentWorldStateFlow.EnsureCapacity(num);
		while (this.CurrentWorldStateFlow.Count < num)
		{
			this.CurrentWorldStateFlow.Add(true);
		}
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		for (int i = 0; i < num; i++)
		{
			TMap<TEnumAsByte<ESimpleNpcWorldState>, int> worldStateMap = this.FlowComponent.FlowList.Get(i).WorldState.WorldStateMap;
			if (worldStateMap.Num() == 1 && worldStateMap.IsValidIndex(0))
			{
				int key = (int)worldStateMap.GetKey(0);
				List<int> list;
				if (!dictionary.TryGetValue(key, out list))
				{
					list = (dictionary[key] = new List<int>());
				}
				list.Add(i);
			}
		}
		List<int> list2 = new List<int>();
		for (int j = 0; j < num; j++)
		{
			list2.Add(this.CheckFlowWorldState(j));
		}
		Dictionary<int, int> dictionary2 = new Dictionary<int, int>();
		foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
		{
			int key2 = keyValuePair.Key;
			dictionary2[key2] = -1;
			int num2 = dictionary2[key2];
			foreach (int index in keyValuePair.Value)
			{
				if (list2[index] >= 0 && (num2 < 0 || num2 > list2[index]))
				{
					dictionary2[key2] = list2[index];
				}
			}
		}
		for (int k = 0; k < num; k++)
		{
			TMap<TEnumAsByte<ESimpleNpcWorldState>, int> worldStateMap2 = this.FlowComponent.FlowList.Get(k).WorldState.WorldStateMap;
			if (worldStateMap2.Num() == 0)
			{
				this.CurrentWorldStateFlow[k] = true;
			}
			else if (worldStateMap2.Num() == 1)
			{
				int key3 = (int)worldStateMap2.GetKey(0);
				int? valueOrNull = dictionary2.GetValueOrNull(key3);
				int num3 = list2[k];
				if (valueOrNull != null)
				{
					int? num4 = valueOrNull;
					int num5 = 0;
					if (num4.GetValueOrDefault() >= num5 & num4 != null)
					{
						int num6 = num3;
						num4 = valueOrNull;
						if (num6 == num4.GetValueOrDefault() & num4 != null)
						{
							this.CurrentWorldStateFlow[k] = true;
							goto IL_277;
						}
					}
				}
				this.CurrentWorldStateFlow[k] = false;
			}
			else
			{
				this.CurrentWorldStateFlow[k] = (list2[k] == 0);
			}
			IL_277:;
		}
	}

	// Token: 0x060199F1 RID: 104945 RVA: 0x007DE818 File Offset: 0x007DCA18
	private int CheckFlowWorldState(int index)
	{
		SimpleNpcFlowData simpleNpcFlowData = this.FlowComponent.FlowList.Get(index);
		TMap<TEnumAsByte<ESimpleNpcWorldState>, int> worldStateMap = simpleNpcFlowData.WorldState.WorldStateMap;
		if (worldStateMap.Num() == 0)
		{
			return 0;
		}
		if (worldStateMap.Num() == 1)
		{
			TEnumAsByte<ESimpleNpcWorldState> key = worldStateMap.GetKey(0);
			string worldStateEnum = this.GetWorldStateEnum(key);
			if (worldStateEnum == null)
			{
				return -1;
			}
			OneOf<bool, string, double> worldState = WorldModel.Instance.GetWorldState(worldStateEnum);
			if (!worldState.HasValue)
			{
				return -1;
			}
			int num = worldStateMap.Get(key);
			return (int)worldState.AsT3 - num;
		}
		else
		{
			bool meetAllConditions = simpleNpcFlowData.WorldState.MeetAllConditions;
			bool flag = meetAllConditions;
			foreach (KeyValuePair<TEnumAsByte<ESimpleNpcWorldState>, int> keyValuePair in worldStateMap)
			{
				TEnumAsByte<ESimpleNpcWorldState> tenumAsByte;
				int num2;
				keyValuePair.Deconstruct(out tenumAsByte, out num2);
				TEnumAsByte<ESimpleNpcWorldState> value = tenumAsByte;
				int num3 = num2;
				string worldStateEnum2 = this.GetWorldStateEnum(value);
				int? num4 = null;
				if (worldStateEnum2 != null)
				{
					num4 = new int?((int)WorldModel.Instance.GetWorldState(worldStateEnum2).AsT3);
				}
				if (num4 != null)
				{
					bool flag2;
					if (!meetAllConditions)
					{
						if (!flag)
						{
							int? num5 = num4;
							num2 = num3;
							flag2 = (num5.GetValueOrDefault() >= num2 & num5 != null);
						}
						else
						{
							flag2 = true;
						}
					}
					else if (flag)
					{
						int? num5 = num4;
						num2 = num3;
						flag2 = (num5.GetValueOrDefault() >= num2 & num5 != null);
					}
					else
					{
						flag2 = false;
					}
					flag = flag2;
				}
				else
				{
					flag = (!meetAllConditions && flag);
				}
			}
			if (!flag)
			{
				return -1;
			}
			return 0;
		}
	}

	// Token: 0x060199F2 RID: 104946 RVA: 0x007DE9A8 File Offset: 0x007DCBA8
	private void ExecuteTargetFlow(SimpleNpcFlowData flowConfig)
	{
		this.TempFlowData = flowConfig;
		ShowTalk randomFlow = FlowConfig.Instance.GetRandomFlow(flowConfig.FlowListName, int.Parse(flowConfig.FlowSubTitle), null, null);
		if (randomFlow != null)
		{
			this.TempTalkItems = randomFlow.TalkItems;
			this.HandleFlowAction(0);
			return;
		}
		this.HandleFlowEnd();
	}

	// Token: 0x060199F3 RID: 104947 RVA: 0x007DEA00 File Offset: 0x007DCC00
	private unsafe void HandleFlowAction(int index)
	{
		this.TempFlowIndex = index;
		if (this.TempTalkItems.Count <= index)
		{
			this.HandleFlowEnd();
			return;
		}
		ITalkItem talkItem = this.TempTalkItems[index];
		TArray<TsSimpleNpc> npcList = this.FlowComponent.NpcList;
		if (npcList.Num() < 2)
		{
			bool flag = false;
			TsSimpleNpc tsSimpleNpc = this.FlowComponent.GetOwner() as TsSimpleNpc;
			if (tsSimpleNpc != null)
			{
				flag = this.ExecuteNpcFlow(tsSimpleNpc, talkItem);
			}
			if (flag)
			{
				this.IsExecuteFlowEnd = false;
				this.WaitTimeRemain = this.GetWaitTime(talkItem, 0f);
				return;
			}
			this.HandleFlowAction(index + 1);
			return;
		}
		else
		{
			int num;
			if (this.TempFlowData.Pawn == 0)
			{
				num = SimpleNpcFlowConditionChecker.GetFlowActorIndex(talkItem.WhoId.Value);
			}
			else
			{
				num = (int)(this.TempFlowData.Pawn - 1);
			}
			if (num == -1)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.CJH;
				string message = "请选择指定的演出目标ID";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", talkItem.WhoId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", this.FlowComponent.GetOwner());
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.HandleFlowAction(index + 1);
				return;
			}
			if (npcList.Num() <= num)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Level;
				ELogAuthor author2 = ELogAuthor.CJH;
				string message2 = "找不到演出目标";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Index", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Name", this.FlowComponent.GetOwner());
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				this.HandleFlowAction(index + 1);
				return;
			}
			TsSimpleNpc npc = npcList.Get(num);
			if (this.ExecuteNpcFlow(npc, talkItem))
			{
				this.IsExecuteFlowEnd = false;
				this.WaitTimeRemain = this.GetWaitTime(talkItem, 0f);
				return;
			}
			this.HandleFlowAction(index + 1);
			return;
		}
	}

	// Token: 0x060199F4 RID: 104948 RVA: 0x007DEC00 File Offset: 0x007DCE00
	private bool ExecuteNpcFlow(TsSimpleNpc npc, ITalkItem config)
	{
		bool result = false;
		string flowText = this.GetFlowText(config.TidTalk);
		if (flowText != null)
		{
			result = true;
			float waitTime = this.GetWaitTime(config, 0.05f);
			npc.ShowDialog(flowText, waitTime);
		}
		if (config.Montage != null && npc.TryPlayMontage(config.Montage.ActionMontage.Path))
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060199F5 RID: 104949 RVA: 0x007DEC59 File Offset: 0x007DCE59
	[return: Nullable(2)]
	private string GetFlowText(string textId)
	{
		if (!string.IsNullOrEmpty(textId))
		{
			return ConfigMultiTextLang.GetLocalTextNew(textId, null);
		}
		return null;
	}

	// Token: 0x060199F6 RID: 104950 RVA: 0x007DEC6C File Offset: 0x007DCE6C
	private float GetWaitTime(ITalkItem config, float offset = 0f)
	{
		float num = config.WaitTime.GetValueOrDefault();
		if (num == 0f)
		{
			num = 3f;
		}
		return num + offset;
	}

	// Token: 0x060199F7 RID: 104951 RVA: 0x007DEC9C File Offset: 0x007DCE9C
	private void HandleFlowEnd()
	{
		this.IsExecuteFlowEnd = true;
		float waitTimeRemain = 10f;
		if (this.TempFlowData != null)
		{
			waitTimeRemain = this.TempFlowData.LoopTime;
		}
		this.WaitTimeRemain = waitTimeRemain;
	}

	// Token: 0x060199F8 RID: 104952 RVA: 0x007DECD8 File Offset: 0x007DCED8
	public void Tick(float deltaSeconds)
	{
		if (this.WaitTimeRemain > 0f)
		{
			this.WaitTimeRemain -= deltaSeconds;
			if (this.WaitTimeRemain <= 0f)
			{
				if (this.IsExecuteFlowEnd)
				{
					if (!this.IsPause)
					{
						this.HandlePlayFlow();
						return;
					}
				}
				else
				{
					this.HandleFlowAction(this.TempFlowIndex + 1);
				}
			}
		}
	}

	// Token: 0x060199F9 RID: 104953 RVA: 0x007DED34 File Offset: 0x007DCF34
	public void StopFlow()
	{
		this.IsExecuteFlowEnd = true;
		this.WaitTimeRemain = 0f;
		SimpleNpcFlowComponent_C flowComponent = this.FlowComponent;
		TArray<TsSimpleNpc> tarray = (flowComponent != null) ? flowComponent.NpcList : null;
		if (tarray != null && tarray.Num() > 2)
		{
			int i = 0;
			int num = tarray.Num();
			while (i < num)
			{
				TsSimpleNpc tsSimpleNpc = tarray.Get(i);
				tsSimpleNpc.HideDialog();
				tsSimpleNpc.StopMontage();
				i++;
			}
			return;
		}
		TsSimpleNpc tsSimpleNpc2 = this.FlowComponent.GetOwner() as TsSimpleNpc;
		if (tsSimpleNpc2 != null)
		{
			tsSimpleNpc2.HideDialog();
			tsSimpleNpc2.StopMontage();
		}
	}

	// Token: 0x170028F4 RID: 10484
	// (get) Token: 0x060199FA RID: 104954 RVA: 0x007DEDB8 File Offset: 0x007DCFB8
	public bool IsPlaying
	{
		get
		{
			return !this.IsExecuteFlowEnd;
		}
	}

	// Token: 0x060199FB RID: 104955 RVA: 0x007DEDC3 File Offset: 0x007DCFC3
	[NullableContext(2)]
	public string GetWorldStateEnum(ESimpleNpcWorldState inState)
	{
		if (inState == ESimpleNpcWorldState.DefaultState)
		{
			return "DefaultState";
		}
		if (inState - ESimpleNpcWorldState.FirstState > 1)
		{
			return null;
		}
		return "NpcWorldState";
	}

	// Token: 0x060199FC RID: 104956 RVA: 0x007DEDDD File Offset: 0x007DCFDD
	public static void CreateStaticDefaultValue()
	{
		SimpleNpcMultiplyLogic.Instance = 0;
	}

	// Token: 0x060199FD RID: 104957 RVA: 0x007DEDE5 File Offset: 0x007DCFE5
	public static void ResetStaticDefaultValue()
	{
		SimpleNpcMultiplyLogic.Instance = 0;
	}

	// Token: 0x0400E094 RID: 57492
	private const float DEFAULT_WAIT_TIME = 3f;

	// Token: 0x0400E095 RID: 57493
	private const float DEFAULT_LOOP_TIME = 10f;

	// Token: 0x0400E096 RID: 57494
	private static int Instance;

	// Token: 0x0400E097 RID: 57495
	[Nullable(2)]
	private SimpleNpcFlowComponent_C FlowComponent;

	// Token: 0x0400E098 RID: 57496
	private List<bool> CurrentWorldStateFlow = new List<bool>();

	// Token: 0x0400E099 RID: 57497
	private List<SimpleNpcFlowData> FlowConfigListResult = new List<SimpleNpcFlowData>();

	// Token: 0x0400E09A RID: 57498
	private readonly int InstanceId;

	// Token: 0x0400E09B RID: 57499
	[Nullable(2)]
	private SimpleNpcFlowData TempFlowData;

	// Token: 0x0400E09C RID: 57500
	private List<ITalkItem> TempTalkItems = new List<ITalkItem>();

	// Token: 0x0400E09D RID: 57501
	private int TempFlowIndex;

	// Token: 0x0400E09E RID: 57502
	private float WaitTimeRemain;

	// Token: 0x0400E09F RID: 57503
	private bool IsExecuteFlowEnd = true;

	// Token: 0x0400E0A0 RID: 57504
	public bool IsPause = true;
}
