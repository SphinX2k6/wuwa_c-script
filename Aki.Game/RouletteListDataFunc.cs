using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x0200291A RID: 10522
[NullableContext(1)]
[Nullable(0)]
public class RouletteListDataFunc : RouletteListDataBase
{
	// Token: 0x17001D2D RID: 7469
	// (get) Token: 0x06015B2E RID: 88878 RVA: 0x0057960C File Offset: 0x0057780C
	public override ERoulettePriority Priority
	{
		get
		{
			return ERoulettePriority.Function;
		}
	}

	// Token: 0x06015B2F RID: 88879 RVA: 0x00579610 File Offset: 0x00577810
	public override List<int> GetRouletteIdList()
	{
		if (this.IsRouletteReplace())
		{
			return this.RouletteIdListReplace;
		}
		return this.RouletteIdListServer;
	}

	// Token: 0x06015B30 RID: 88880 RVA: 0x00579627 File Offset: 0x00577827
	public override int GetExtraItemId()
	{
		return 0;
	}

	// Token: 0x06015B31 RID: 88881 RVA: 0x0057962A File Offset: 0x0057782A
	public override int GetEquipExploreSkillId()
	{
		return 0;
	}

	// Token: 0x06015B32 RID: 88882 RVA: 0x0057962D File Offset: 0x0057782D
	public override bool IsActivate()
	{
		return true;
	}

	// Token: 0x17001D2E RID: 7470
	// (get) Token: 0x06015B33 RID: 88883 RVA: 0x00579630 File Offset: 0x00577830
	public override ERouletteType RouletteType
	{
		get
		{
			return ERouletteType.Function;
		}
	}

	// Token: 0x06015B34 RID: 88884 RVA: 0x00579633 File Offset: 0x00577833
	public override void Init()
	{
		this.InitFunctionRouletteReplaceConfig();
		this.OnAddEvents();
	}

	// Token: 0x06015B35 RID: 88885 RVA: 0x00579641 File Offset: 0x00577841
	public override void Clear()
	{
		this.OnRemoveEvents();
	}

	// Token: 0x06015B36 RID: 88886 RVA: 0x00579649 File Offset: 0x00577849
	public override bool IsRouletteReplace()
	{
		return this.FuncReplaceId != null;
	}

	// Token: 0x06015B37 RID: 88887 RVA: 0x0057965B File Offset: 0x0057785B
	public override bool IsRouletteOpen()
	{
		return FunctionModel.Instance.IsOpen(10056);
	}

	// Token: 0x06015B38 RID: 88888 RVA: 0x0057966C File Offset: 0x0057786C
	public override bool IsMainRouletteCanOpenView(bool checkTips)
	{
		return RouletteModel.Instance.IsFunctionRouletteOpen();
	}

	// Token: 0x06015B39 RID: 88889 RVA: 0x00579678 File Offset: 0x00577878
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

	// Token: 0x06015B3A RID: 88890 RVA: 0x0057968C File Offset: 0x0057788C
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
				return new int?(rouletteIdList[index]);
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

	// Token: 0x06015B3B RID: 88891 RVA: 0x00579702 File Offset: 0x00577902
	public override RouletteMainViewProxyBase GetRouletteMainViewProxy()
	{
		return new RouletteMainViewProxy();
	}

	// Token: 0x06015B3C RID: 88892 RVA: 0x00579709 File Offset: 0x00577909
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

	// Token: 0x06015B3D RID: 88893 RVA: 0x00579711 File Offset: 0x00577911
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06015B3E RID: 88894 RVA: 0x0057972F File Offset: 0x0057792F
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
	}

	// Token: 0x06015B3F RID: 88895 RVA: 0x00579750 File Offset: 0x00577950
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

	// Token: 0x06015B40 RID: 88896 RVA: 0x00579808 File Offset: 0x00577A08
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

	// Token: 0x06015B41 RID: 88897 RVA: 0x00579870 File Offset: 0x00577A70
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

	// Token: 0x06015B42 RID: 88898 RVA: 0x005799B8 File Offset: 0x00577BB8
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

	// Token: 0x06015B43 RID: 88899 RVA: 0x00579A10 File Offset: 0x00577C10
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
		return list.Cast<AssemblyGridData>().ToList<AssemblyGridData>();
	}

	// Token: 0x0400A1B3 RID: 41395
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

	// Token: 0x0400A1B4 RID: 41396
	private int? FuncReplaceId;

	// Token: 0x0400A1B5 RID: 41397
	private readonly List<int> InstSubTypeWithReplaceList = new List<int>();

	// Token: 0x0400A1B6 RID: 41398
	private readonly Dictionary<int, int> InstId2ReplaceId = new Dictionary<int, int>();

	// Token: 0x0400A1B7 RID: 41399
	private readonly List<int> RouletteIdListReplace = new List<int>();
}
