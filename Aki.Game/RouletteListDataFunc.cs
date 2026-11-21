using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RecallQuest.Model;

// Token: 0x02001E95 RID: 7829
[NullableContext(1)]
[Nullable(0)]
public class RouletteListDataFunc : RouletteListDataBase
{
	// Token: 0x17001D87 RID: 7559
	// (get) Token: 0x06013532 RID: 79154 RVA: 0x005A4530 File Offset: 0x005A2730
	public override ERoulettePriority Priority
	{
		get
		{
			return ERoulettePriority.Function;
		}
	}

	// Token: 0x06013533 RID: 79155 RVA: 0x005A4534 File Offset: 0x005A2734
	public override List<int> GetRouletteIdList()
	{
		if (this.IsRouletteReplace())
		{
			return this.RouletteIdListReplace;
		}
		return this.RouletteIdListServer;
	}

	// Token: 0x06013534 RID: 79156 RVA: 0x005A454B File Offset: 0x005A274B
	public override int GetExtraItemId()
	{
		return 0;
	}

	// Token: 0x06013535 RID: 79157 RVA: 0x005A454E File Offset: 0x005A274E
	public override int GetEquipExploreSkillId()
	{
		return 0;
	}

	// Token: 0x06013536 RID: 79158 RVA: 0x005A4551 File Offset: 0x005A2751
	public override bool IsActivate()
	{
		return true;
	}

	// Token: 0x17001D88 RID: 7560
	// (get) Token: 0x06013537 RID: 79159 RVA: 0x005A4554 File Offset: 0x005A2754
	public override ERouletteType RouletteType
	{
		get
		{
			return ERouletteType.Function;
		}
	}

	// Token: 0x06013538 RID: 79160 RVA: 0x005A4557 File Offset: 0x005A2757
	public override void Init()
	{
		this.InitFunctionRouletteReplaceConfig();
		this.OnAddEvents();
	}

	// Token: 0x06013539 RID: 79161 RVA: 0x005A4565 File Offset: 0x005A2765
	public override void Clear()
	{
		this.OnRemoveEvents();
	}

	// Token: 0x0601353A RID: 79162 RVA: 0x005A456D File Offset: 0x005A276D
	public override bool IsRouletteReplace()
	{
		return this.FuncReplaceId != null;
	}

	// Token: 0x0601353B RID: 79163 RVA: 0x005A457F File Offset: 0x005A277F
	public override bool IsRouletteOpen()
	{
		return FunctionModel.Instance.IsOpen(10056);
	}

	// Token: 0x0601353C RID: 79164 RVA: 0x005A4590 File Offset: 0x005A2790
	public override bool IsMainRouletteCanOpenView(bool checkTips)
	{
		return RouletteModel.Instance.IsFunctionRouletteOpen();
	}

	// Token: 0x0601353D RID: 79165 RVA: 0x005A459C File Offset: 0x005A279C
	public override Dictionary<ERouletteGridType, List<AssemblyGridData>> CreateAssemblyGridData()
	{
		return new Dictionary<ERouletteGridType, List<AssemblyGridData>>
		{
			{
				ERouletteGridType.Function,
				this.CreateAllAssemblyDataFunction()
			}
		};
	}

	// Token: 0x0601353E RID: 79166 RVA: 0x005A45B0 File Offset: 0x005A27B0
	public override int? GetRouletteGridId(int index, ERouletteGridType type, bool useDisplay)
	{
		if (type != ERouletteGridType.Function)
		{
			return null;
		}
		if (useDisplay)
		{
			List<int> rouletteIdList = this.GetRouletteIdList();
			if (index >= 0 && index < rouletteIdList.Count)
			{
				int num = rouletteIdList[index];
				if (num != 0 && RecallQuestModel.Instance.IsInRecallInstance())
				{
					FuncMenuWheel? funcConfigById = RouletteConfig.Instance.GetFuncConfigById(num);
					if (funcConfigById != null && funcConfigById.Value.UnlockCondition > 0 && !RecallQuestModel.Instance.CheckRecallRouletteFunction(funcConfigById.Value.UnlockCondition))
					{
						return new int?(0);
					}
				}
				return new int?(num);
			}
			return null;
		}
		else
		{
			if (index >= 0 && index < this.RouletteIdListServer.Count)
			{
				return new int?(this.RouletteIdListServer[index]);
			}
			return null;
		}
	}

	// Token: 0x0601353F RID: 79167 RVA: 0x005A4689 File Offset: 0x005A2889
	public override RouletteMainViewProxyBase GetRouletteMainViewProxy()
	{
		return new RouletteMainViewProxy();
	}

	// Token: 0x06013540 RID: 79168 RVA: 0x005A4690 File Offset: 0x005A2890
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteDataMap()
	{
		return this.FunctionRouletteMap;
	}

	// Token: 0x06013541 RID: 79169 RVA: 0x005A4698 File Offset: 0x005A2898
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06013542 RID: 79170 RVA: 0x005A46B6 File Offset: 0x005A28B6
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06013543 RID: 79171 RVA: 0x005A46D4 File Offset: 0x005A28D4
	private void InitFunctionRouletteReplaceConfig()
	{
		this.InstSubTypeWithReplaceList.Clear();
		this.InstId2ReplaceId.Clear();
		foreach (FuncMenuReplace funcMenuReplace in RouletteConfig.Instance.GetAllFuncReplaceConfig())
		{
			if (funcMenuReplace.InstIdListLength > 0)
			{
				foreach (int key in funcMenuReplace.GetInstIdListArray())
				{
					this.InstId2ReplaceId.Add(key, funcMenuReplace.Id);
				}
			}
			else if (funcMenuReplace.InstSubType != 0)
			{
				this.InstSubTypeWithReplaceList.Add(funcMenuReplace.InstSubType);
			}
		}
	}

	// Token: 0x06013544 RID: 79172 RVA: 0x005A478C File Offset: 0x005A298C
	private void OnWorldDone()
	{
		int instanceId = CreatureModel.Instance.GetInstanceId();
		bool flag = this.InstId2ReplaceId.ContainsKey(instanceId);
		if (!GameModeController.Instance.IsInInstance() && !flag)
		{
			this.DisActiveFunctionRouletteReplaceConfig();
			return;
		}
		InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
		if (config == null)
		{
			return;
		}
		this.TryActiveFunctionRouletteReplaceConfig(instanceId, config.Value.InstSubType);
	}

	// Token: 0x06013545 RID: 79173 RVA: 0x005A47F4 File Offset: 0x005A29F4
	private void TryActiveFunctionRouletteReplaceConfig(int instId, int instSubType)
	{
		FuncMenuReplace? funcMenuReplace = null;
		int num = 0;
		int num2;
		if (this.InstId2ReplaceId.TryGetValue(instId, out num2))
		{
			funcMenuReplace = RouletteConfig.Instance.GetFuncReplaceConfigById(num2);
			num = num2;
		}
		else if (this.InstSubTypeWithReplaceList.Contains(instSubType))
		{
			funcMenuReplace = RouletteConfig.Instance.GetFuncReplaceConfig(instSubType);
			num = ((funcMenuReplace != null) ? funcMenuReplace.GetValueOrDefault().Id : 0);
		}
		if (num == 0 || funcMenuReplace == null)
		{
			this.DisActiveFunctionRouletteReplaceConfig();
			return;
		}
		int? funcReplaceId = this.FuncReplaceId;
		int num3 = num;
		if (funcReplaceId.GetValueOrDefault() == num3 & funcReplaceId != null)
		{
			return;
		}
		this.FuncReplaceId = new int?(num);
		if (funcMenuReplace.Value.FuncMenuIdListLength != 8)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[FunctionRoulette] 替换配置功能轮盘Id数量错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ReplaceId", num);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.RouletteIdListReplace.Clear();
		this.RouletteIdListReplace.AddRange(funcMenuReplace.Value.GetFuncMenuIdListArray());
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Phantom;
		ELogAuthor author2 = ELogAuthor.YYZ;
		string message2 = "[FunctionRoulette] 功能轮盘进入替换模式";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ReplaceId", this.FuncReplaceId);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
	}

	// Token: 0x06013546 RID: 79174 RVA: 0x005A493C File Offset: 0x005A2B3C
	private void DisActiveFunctionRouletteReplaceConfig()
	{
		if (this.FuncReplaceId == null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Phantom;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[FunctionRoulette] 功能轮盘退出替换模式";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LastReplaceId", this.FuncReplaceId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.FuncReplaceId = null;
	}

	// Token: 0x06013547 RID: 79175 RVA: 0x005A4994 File Offset: 0x005A2B94
	private List<AssemblyGridData> CreateAllAssemblyDataFunction()
	{
		List<AssemblyFunctionGridData> list = new List<AssemblyFunctionGridData>();
		foreach (KeyValuePair<int, FuncMenuWheel> keyValuePair in RouletteModel.Instance.UnlockFunctionDataMap)
		{
			int key = keyValuePair.Key;
			FuncMenuWheel value = keyValuePair.Value;
			if (value.ShowInAssembly)
			{
				list.Add(new AssemblyFunctionGridData
				{
					GridType = ERouletteGridType.Function,
					IconPath = RouletteConfig.Instance.GetFuncMenuIconPathByConfig(value),
					Name = value.FuncName,
					Id = key,
					SortId = value.FuncMenuSequence
				});
			}
		}
		list.Sort((AssemblyFunctionGridData dataA, AssemblyFunctionGridData dataB) => dataA.SortId - dataB.SortId);
		return new List<AssemblyGridData>(list);
	}

	// Token: 0x0400A59E RID: 42398
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> FunctionRouletteMap = new List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>>
	{
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			1
		}, ERouletteComponentNode.RouletteItem1, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			2
		}, ERouletteComponentNode.RouletteItem2, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			3
		}, ERouletteComponentNode.RouletteItem3, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			4
		}, ERouletteComponentNode.RouletteItem4, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			5
		}, ERouletteComponentNode.RouletteItem5, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			6
		}, ERouletteComponentNode.RouletteItem6, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			7
		}, ERouletteComponentNode.RouletteItem7, ERouletteGridType.Function),
		new ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>(new List<int>
		{
			8
		}, ERouletteComponentNode.RouletteItem8, ERouletteGridType.Function)
	};

	// Token: 0x0400A59F RID: 42399
	private int? FuncReplaceId;

	// Token: 0x0400A5A0 RID: 42400
	private readonly List<int> InstSubTypeWithReplaceList = new List<int>();

	// Token: 0x0400A5A1 RID: 42401
	private readonly Dictionary<int, int> InstId2ReplaceId = new Dictionary<int, int>();

	// Token: 0x0400A5A2 RID: 42402
	private readonly List<int> RouletteIdListReplace = new List<int>();
}
