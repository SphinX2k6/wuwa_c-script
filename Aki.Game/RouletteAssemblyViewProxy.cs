using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Roulette.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200293B RID: 10555
[NullableContext(1)]
[Nullable(0)]
public class RouletteAssemblyViewProxy
{
	// Token: 0x17001D3D RID: 7485
	// (get) Token: 0x06015C93 RID: 89235 RVA: 0x0057F3A8 File Offset: 0x0057D5A8
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

	// Token: 0x06015C94 RID: 89236 RVA: 0x0057F3D1 File Offset: 0x0057D5D1
	public void RegisterView(RouletteAssemblyView view)
	{
		this.View = view;
	}

	// Token: 0x06015C95 RID: 89237 RVA: 0x0057F3DC File Offset: 0x0057D5DC
	public UniTask OnBeforeStartAsync()
	{
		RouletteAssemblyViewProxy.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteAssemblyViewProxy.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015C96 RID: 89238 RVA: 0x0057F41F File Offset: 0x0057D61F
	public void Start()
	{
	}

	// Token: 0x06015C97 RID: 89239 RVA: 0x0057F424 File Offset: 0x0057D624
	public void BeforeShow()
	{
		this.OpenParam.SelectGridId = null;
		this.OpenParam.SelectGridIndex = null;
	}

	// Token: 0x06015C98 RID: 89240 RVA: 0x0057F45C File Offset: 0x0057D65C
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

	// Token: 0x06015C99 RID: 89241 RVA: 0x0057F4F0 File Offset: 0x0057D6F0
	public RouletteComponentAssembly GetRouletteComponent()
	{
		RouletteComponentAssembly result;
		if (this.RouletteComponentMap.TryGetValue(this.CurrentRouletteType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06015C9A RID: 89242 RVA: 0x0057F515 File Offset: 0x0057D715
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

	// Token: 0x06015C9B RID: 89243 RVA: 0x0057F524 File Offset: 0x0057D724
	public int GetRouletteGridId(int index, ERouletteGridType gridType)
	{
		return this.CurrentRouletteDataList.GetRouletteGridId(index, gridType, false).GetValueOrDefault();
	}

	// Token: 0x06015C9C RID: 89244 RVA: 0x0057F548 File Offset: 0x0057D748
	public void Destroy()
	{
		foreach (RouletteComponentAssembly rouletteComponentAssembly in this.RouletteComponentMap.Values)
		{
			rouletteComponentAssembly.Destroy(null);
		}
		this.RouletteComponentMap.Clear();
	}

	// Token: 0x06015C9D RID: 89245 RVA: 0x0057F5AC File Offset: 0x0057D7AC
	public bool CanOpenView()
	{
		return this.GetTabTypeList().Count > 0;
	}

	// Token: 0x06015C9E RID: 89246 RVA: 0x0057F5BC File Offset: 0x0057D7BC
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

	// Token: 0x0400A240 RID: 41536
	private readonly Dictionary<ERouletteType, RouletteComponentAssembly> RouletteComponentMap = new Dictionary<ERouletteType, RouletteComponentAssembly>();

	// Token: 0x0400A241 RID: 41537
	protected RouletteAssemblyView View;

	// Token: 0x0400A242 RID: 41538
	public IRouletteAssemblyOpenParam OpenParam;

	// Token: 0x0400A243 RID: 41539
	public List<ERouletteType> TypeList = new List<ERouletteType>();

	// Token: 0x0400A244 RID: 41540
	public Dictionary<ERouletteType, RouletteListDataBase> RouletteListDataMap = new Dictionary<ERouletteType, RouletteListDataBase>();

	// Token: 0x0400A245 RID: 41541
	public ERouletteType CurrentRouletteType;

	// Token: 0x0400A246 RID: 41542
	public Dictionary<ERouletteGridType, List<AssemblyGridData>> AssemblyGridDataMap = new Dictionary<ERouletteGridType, List<AssemblyGridData>>();

	// Token: 0x0400A247 RID: 41543
	public IRouletteListSaveData CurrentRouletteListSaveData;
}
