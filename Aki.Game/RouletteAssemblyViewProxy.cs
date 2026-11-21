using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Roulette.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001EB6 RID: 7862
[NullableContext(1)]
[Nullable(0)]
public class RouletteAssemblyViewProxy
{
	// Token: 0x17001D97 RID: 7575
	// (get) Token: 0x06013698 RID: 79512 RVA: 0x005AA3E0 File Offset: 0x005A85E0
	public RouletteListDataBase CurrentRouletteDataList
	{
		get
		{
			RouletteListDataBase result;
			if (RouletteModel.Instance.RouletteListDataMap.TryGetValue(this.CurrentRouletteType, out result))
			{
				return result;
			}
			return null;
		}
	}

	// Token: 0x06013699 RID: 79513 RVA: 0x005AA409 File Offset: 0x005A8609
	public void RegisterView(RouletteAssemblyView view)
	{
		this.View = view;
	}

	// Token: 0x0601369A RID: 79514 RVA: 0x005AA414 File Offset: 0x005A8614
	public UniTask OnBeforeStartAsync()
	{
		RouletteAssemblyViewProxy.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteAssemblyViewProxy.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601369B RID: 79515 RVA: 0x005AA457 File Offset: 0x005A8657
	public void Start()
	{
	}

	// Token: 0x0601369C RID: 79516 RVA: 0x005AA45C File Offset: 0x005A865C
	public void BeforeShow()
	{
		this.OpenParam.SelectGridId = null;
		this.OpenParam.SelectGridIndex = null;
	}

	// Token: 0x0601369D RID: 79517 RVA: 0x005AA494 File Offset: 0x005A8694
	public void OnRouletteTypeSwitch(ERouletteType rouletteType)
	{
		this.CurrentRouletteType = rouletteType;
		this.AssemblyGridDataMap = this.CurrentRouletteDataList.CreateAssemblyGridData();
		foreach (KeyValuePair<ERouletteType, RouletteComponentAssembly> keyValuePair in this.RouletteComponentMap)
		{
			ERouletteType key = keyValuePair.Key;
			RouletteComponentAssembly value = keyValuePair.Value;
			if (key != this.CurrentRouletteType)
			{
				value.DeactivateGridToggleChangeEvent();
			}
		}
		this.CurrentRouletteListSaveData = this.CurrentRouletteDataList.GetRouletteListSaveData();
	}

	// Token: 0x0601369E RID: 79518 RVA: 0x005AA528 File Offset: 0x005A8728
	public RouletteComponentAssembly GetRouletteComponent()
	{
		RouletteComponentAssembly result;
		if (this.RouletteComponentMap.TryGetValue(this.CurrentRouletteType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601369F RID: 79519 RVA: 0x005AA54D File Offset: 0x005A874D
	[return: Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	public List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteDataMap()
	{
		return this.CurrentRouletteDataList.GetRouletteDataMap();
	}

	// Token: 0x060136A0 RID: 79520 RVA: 0x005AA55C File Offset: 0x005A875C
	public int GetRouletteGridId(int index, ERouletteGridType gridType)
	{
		return this.CurrentRouletteDataList.GetRouletteGridId(index, gridType, false).GetValueOrDefault();
	}

	// Token: 0x060136A1 RID: 79521 RVA: 0x005AA580 File Offset: 0x005A8780
	public void Destroy()
	{
		foreach (RouletteComponentAssembly rouletteComponentAssembly in this.RouletteComponentMap.Values)
		{
			rouletteComponentAssembly.Destroy(null);
		}
		this.RouletteComponentMap.Clear();
	}

	// Token: 0x060136A2 RID: 79522 RVA: 0x005AA5E4 File Offset: 0x005A87E4
	public bool CanOpenView()
	{
		return this.GetTabTypeList().Count > 0;
	}

	// Token: 0x060136A3 RID: 79523 RVA: 0x005AA5F4 File Offset: 0x005A87F4
	private List<ERouletteType> GetTabTypeList()
	{
		List<IRouletteAssemblyTabData> list = new List<IRouletteAssemblyTabData>();
		foreach (KeyValuePair<ERouletteType, RouletteListDataBase> keyValuePair in RouletteModel.Instance.RouletteListDataMap)
		{
			ERouletteType key = keyValuePair.Key;
			if (keyValuePair.Value.IsRouletteOpen())
			{
				ExploreRouletteType? exploreRouletteTypeById = RouletteConfig.Instance.GetExploreRouletteTypeById((int)key);
				if (exploreRouletteTypeById != null)
				{
					ExploreRouletteType value = exploreRouletteTypeById.Value;
					if (value.ShowInPad || Info.Instance.OperationType != EOperationType.Pad)
					{
						list.Add(new RouletteAssemblyTabData
						{
							Type = key,
							SortId = value.SortId
						});
					}
				}
			}
		}
		list.Sort((IRouletteAssemblyTabData a, IRouletteAssemblyTabData b) => a.SortId - b.SortId);
		List<ERouletteType> list2 = new List<ERouletteType>();
		foreach (IRouletteAssemblyTabData rouletteAssemblyTabData in list)
		{
			list2.Add(rouletteAssemblyTabData.Type);
		}
		return list2;
	}

	// Token: 0x0400A62B RID: 42539
	private readonly Dictionary<ERouletteType, RouletteComponentAssembly> RouletteComponentMap = new Dictionary<ERouletteType, RouletteComponentAssembly>();

	// Token: 0x0400A62C RID: 42540
	protected RouletteAssemblyView View;

	// Token: 0x0400A62D RID: 42541
	public IRouletteAssemblyOpenParam OpenParam;

	// Token: 0x0400A62E RID: 42542
	public List<ERouletteType> TypeList = new List<ERouletteType>();

	// Token: 0x0400A62F RID: 42543
	public Dictionary<ERouletteType, RouletteListDataBase> RouletteListDataMap = new Dictionary<ERouletteType, RouletteListDataBase>();

	// Token: 0x0400A630 RID: 42544
	public ERouletteType CurrentRouletteType;

	// Token: 0x0400A631 RID: 42545
	public Dictionary<ERouletteGridType, List<AssemblyGridData>> AssemblyGridDataMap = new Dictionary<ERouletteGridType, List<AssemblyGridData>>();

	// Token: 0x0400A632 RID: 42546
	public IRouletteListSaveData CurrentRouletteListSaveData;
}
