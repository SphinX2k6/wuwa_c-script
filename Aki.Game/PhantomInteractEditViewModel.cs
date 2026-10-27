using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

// Token: 0x02002467 RID: 9319
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractEditViewModel
{
	// Token: 0x1700186F RID: 6255
	// (get) Token: 0x06012B34 RID: 76596 RVA: 0x0049D7CE File Offset: 0x0049B9CE
	// (set) Token: 0x06012B35 RID: 76597 RVA: 0x0049D7D6 File Offset: 0x0049B9D6
	public int SelectedItemIndex { get; set; }

	// Token: 0x17001870 RID: 6256
	// (get) Token: 0x06012B36 RID: 76598 RVA: 0x0049D7DF File Offset: 0x0049B9DF
	// (set) Token: 0x06012B37 RID: 76599 RVA: 0x0049D7E7 File Offset: 0x0049B9E7
	public EPhantomInteractEditBtnState BtnState { get; set; } = EPhantomInteractEditBtnState.Equip;

	// Token: 0x17001871 RID: 6257
	// (get) Token: 0x06012B38 RID: 76600 RVA: 0x0049D7F0 File Offset: 0x0049B9F0
	// (set) Token: 0x06012B39 RID: 76601 RVA: 0x0049D7F8 File Offset: 0x0049B9F8
	public bool BtnAvailable { get; set; } = true;

	// Token: 0x17001872 RID: 6258
	// (get) Token: 0x06012B3A RID: 76602 RVA: 0x0049D801 File Offset: 0x0049BA01
	// (set) Token: 0x06012B3B RID: 76603 RVA: 0x0049D809 File Offset: 0x0049BA09
	[Nullable(2)]
	public IPhantomInteractItemData SelectedItemData { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17001873 RID: 6259
	// (get) Token: 0x06012B3C RID: 76604 RVA: 0x0049D812 File Offset: 0x0049BA12
	// (set) Token: 0x06012B3D RID: 76605 RVA: 0x0049D81A File Offset: 0x0049BA1A
	public PhantomInteractDetailViewModel DetailViewModel { get; set; } = new PhantomInteractDetailViewModel();

	// Token: 0x17001874 RID: 6260
	// (get) Token: 0x06012B3E RID: 76606 RVA: 0x0049D823 File Offset: 0x0049BA23
	// (set) Token: 0x06012B3F RID: 76607 RVA: 0x0049D82B File Offset: 0x0049BA2B
	public bool ShowDetail { get; set; }

	// Token: 0x17001875 RID: 6261
	// (get) Token: 0x06012B40 RID: 76608 RVA: 0x0049D834 File Offset: 0x0049BA34
	// (set) Token: 0x06012B41 RID: 76609 RVA: 0x0049D83C File Offset: 0x0049BA3C
	public List<IPhantomGridListData> GridsDataList { get; set; } = new List<IPhantomGridListData>();

	// Token: 0x17001876 RID: 6262
	// (get) Token: 0x06012B42 RID: 76610 RVA: 0x0049D845 File Offset: 0x0049BA45
	// (set) Token: 0x06012B43 RID: 76611 RVA: 0x0049D84D File Offset: 0x0049BA4D
	[Nullable(0)]
	public ValueTuple<int, int> SelectedGridItemIndex { [NullableContext(0)] get; [NullableContext(0)] set; } = new ValueTuple<int, int>(-1, -1);

	// Token: 0x17001877 RID: 6263
	// (get) Token: 0x06012B44 RID: 76612 RVA: 0x0049D856 File Offset: 0x0049BA56
	// (set) Token: 0x06012B45 RID: 76613 RVA: 0x0049D85E File Offset: 0x0049BA5E
	public Dictionary<int, PhantomInteractEditGridViewModel> GridViewModelMap { get; set; } = new Dictionary<int, PhantomInteractEditGridViewModel>();

	// Token: 0x17001878 RID: 6264
	// (get) Token: 0x06012B46 RID: 76614 RVA: 0x0049D867 File Offset: 0x0049BA67
	// (set) Token: 0x06012B47 RID: 76615 RVA: 0x0049D86F File Offset: 0x0049BA6F
	private List<int> SortGridViewModelIds { get; set; } = new List<int>();

	// Token: 0x17001879 RID: 6265
	// (get) Token: 0x06012B48 RID: 76616 RVA: 0x0049D878 File Offset: 0x0049BA78
	// (set) Token: 0x06012B49 RID: 76617 RVA: 0x0049D880 File Offset: 0x0049BA80
	[Nullable(2)]
	private PhantomInteractEditGridViewModel SelectedGridDataInternal { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x1700187A RID: 6266
	// (get) Token: 0x06012B4A RID: 76618 RVA: 0x0049D889 File Offset: 0x0049BA89
	// (set) Token: 0x06012B4B RID: 76619 RVA: 0x0049D891 File Offset: 0x0049BA91
	private PhantomInteractInfoData InfoData { get; set; } = new PhantomInteractInfoData();

	// Token: 0x1700187B RID: 6267
	// (get) Token: 0x06012B4C RID: 76620 RVA: 0x0049D89A File Offset: 0x0049BA9A
	// (set) Token: 0x06012B4D RID: 76621 RVA: 0x0049D8A2 File Offset: 0x0049BAA2
	private int? FilterCost { get; set; }

	// Token: 0x1700187C RID: 6268
	// (get) Token: 0x06012B4E RID: 76622 RVA: 0x0049D8AB File Offset: 0x0049BAAB
	// (set) Token: 0x06012B4F RID: 76623 RVA: 0x0049D8B3 File Offset: 0x0049BAB3
	private bool? FilterIsSpecial { get; set; }

	// Token: 0x1700187D RID: 6269
	// (get) Token: 0x06012B50 RID: 76624 RVA: 0x0049D8BC File Offset: 0x0049BABC
	// (set) Token: 0x06012B51 RID: 76625 RVA: 0x0049D8C4 File Offset: 0x0049BAC4
	private List<int> RecommendedMonsterIds { get; set; } = new List<int>();

	// Token: 0x06012B52 RID: 76626 RVA: 0x0049D8CD File Offset: 0x0049BACD
	private void LocalLog(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x06012B53 RID: 76627 RVA: 0x0049D8CF File Offset: 0x0049BACF
	public void ConfirmEquipHandler()
	{
		if (this.ConfirmEquipHandlerInternal == null)
		{
			return;
		}
		this.ConfirmEquipHandlerInternal(this);
	}

	// Token: 0x06012B54 RID: 76628 RVA: 0x0049D8E6 File Offset: 0x0049BAE6
	public void SetConfirmEquipHandler([Nullable(new byte[]
	{
		2,
		1
	})] Action<PhantomInteractEditViewModel> handler)
	{
		this.ConfirmEquipHandlerInternal = handler;
	}

	// Token: 0x06012B55 RID: 76629 RVA: 0x0049D8EF File Offset: 0x0049BAEF
	public void EquipRecommendHandler()
	{
		if (this.EquipRecommendHandlerInternal == null)
		{
			return;
		}
		this.EquipRecommendHandlerInternal(this);
	}

	// Token: 0x06012B56 RID: 76630 RVA: 0x0049D906 File Offset: 0x0049BB06
	public void SetEquipRecommendHandler([Nullable(new byte[]
	{
		2,
		1
	})] Action<PhantomInteractEditViewModel> handler)
	{
		this.EquipRecommendHandlerInternal = handler;
	}

	// Token: 0x06012B57 RID: 76631 RVA: 0x0049D90F File Offset: 0x0049BB0F
	public void EquipRecommendCallback()
	{
		if (this.EquipRecommendCallbackInternal != null)
		{
			this.EquipRecommendCallbackInternal();
			this.EquipRecommendCallbackInternal = null;
		}
	}

	// Token: 0x06012B58 RID: 76632 RVA: 0x0049D92B File Offset: 0x0049BB2B
	[NullableContext(2)]
	public void SetEquipRecommendCallback(Action callback)
	{
		this.EquipRecommendCallbackInternal = callback;
	}

	// Token: 0x06012B59 RID: 76633 RVA: 0x0049D934 File Offset: 0x0049BB34
	public void MoveNextSkinHandler()
	{
		if (this.MoveNextSkinHandlerInternal == null)
		{
			return;
		}
		this.MoveNextSkinHandlerInternal(this);
		this.RefreshDetail();
	}

	// Token: 0x06012B5A RID: 76634 RVA: 0x0049D951 File Offset: 0x0049BB51
	public void SetMoveNextSkinHandler([Nullable(new byte[]
	{
		2,
		1
	})] Action<PhantomInteractEditViewModel> handler)
	{
		this.MoveNextSkinHandlerInternal = handler;
	}

	// Token: 0x1700187E RID: 6270
	// (get) Token: 0x06012B5B RID: 76635 RVA: 0x0049D95A File Offset: 0x0049BB5A
	[Nullable(2)]
	public PhantomInteractEditGridViewModel SelectedGridData
	{
		[NullableContext(2)]
		get
		{
			return this.SelectedGridDataInternal;
		}
	}

	// Token: 0x06012B5C RID: 76636 RVA: 0x0049D962 File Offset: 0x0049BB62
	public List<int> GetFilteredRecommendedIdList()
	{
		return this.FilteredRecommendedMonsterIds;
	}

	// Token: 0x06012B5D RID: 76637 RVA: 0x0049D96C File Offset: 0x0049BB6C
	public void InitData(PhantomInteractInfoData infoData, int selectedItemIndex)
	{
		this.InfoData = infoData;
		int currentAreaId = AreaModel.Instance.GetCurrentAreaId(null);
		this.RecommendedMonsterIds = this.LoadAreaRelativeData(currentAreaId);
		this.InitGridViewModels(infoData.GridItemDataList);
		this.RefreshFilterGridViewData();
		this.SelectItem(selectedItemIndex);
		IPhantomInteractItemData selectedItemData = this.SelectedItemData;
		if (selectedItemData != null && selectedItemData.MonsterId == 0)
		{
			int num = 0;
			if (this.GridsDataList.Count > 0)
			{
				IPhantomGridListData phantomGridListData = this.GridsDataList[0];
				if (phantomGridListData != null && phantomGridListData.MonsterIds.Count > 0)
				{
					num = phantomGridListData.MonsterIds[0];
				}
			}
			if (num > 0)
			{
				this.SelectGrid(num);
			}
		}
	}

	// Token: 0x06012B5E RID: 76638 RVA: 0x0049DA18 File Offset: 0x0049BC18
	public void SelectItem(int index)
	{
		this.SelectedItemIndex = index;
		this.SelectedItemData = this.InfoData.EquippedVisionData[index];
		if (this.SelectedItemData.MonsterId == 0)
		{
			this.RefreshDetail();
		}
		else
		{
			this.SelectGrid(this.SelectedItemData.MonsterId);
		}
		this.RefreshBtnState();
	}

	// Token: 0x06012B5F RID: 76639 RVA: 0x0049DA70 File Offset: 0x0049BC70
	public void SelectGrid(int monsterId)
	{
		this.SelectedGridItemIndex = this.SelectGridViewModel(monsterId);
		IPhantomInteractItemData selectedItemData = this.SelectedItemData;
		if (selectedItemData != null && selectedItemData.MonsterId == 0)
		{
			this.BtnState = EPhantomInteractEditBtnState.Equip;
		}
		else
		{
			this.BtnState = EPhantomInteractEditBtnState.Swap;
		}
		this.RefreshDetail();
		this.RefreshBtnState();
	}

	// Token: 0x06012B60 RID: 76640 RVA: 0x0049DAC0 File Offset: 0x0049BCC0
	public int FindGridIndexInMultiTemplate(int monsterId)
	{
		if (this.FilteredRecommendedMonsterIds.Count <= 0)
		{
			return this.FilteredElseMonsterIds.FindIndex((int id) => id == monsterId);
		}
		int num = this.FilteredRecommendedMonsterIds.FindIndex((int id) => id == monsterId);
		if (num >= 0)
		{
			return num + 1;
		}
		int num2 = this.FilteredElseMonsterIds.FindIndex((int id) => id == monsterId);
		if (num2 >= 0)
		{
			return num2 + this.FilteredRecommendedMonsterIds.Count + 2;
		}
		return -1;
	}

	// Token: 0x06012B61 RID: 76641 RVA: 0x0049DB50 File Offset: 0x0049BD50
	private void RefreshBtnState()
	{
		if (this.SelectedGridData == null)
		{
			this.BtnState = EPhantomInteractEditBtnState.Invisible;
			this.BtnAvailable = false;
			return;
		}
		this.BtnAvailable = this.SelectedGridData.IsUnlocked;
		IPhantomInteractItemData selectedItemData = this.SelectedItemData;
		if (selectedItemData != null && selectedItemData.MonsterId == 0)
		{
			this.BtnState = EPhantomInteractEditBtnState.Equip;
			return;
		}
		IPhantomInteractItemData selectedItemData2 = this.SelectedItemData;
		int? num = (selectedItemData2 != null) ? new int?(selectedItemData2.MonsterId) : null;
		PhantomInteractEditGridViewModel selectedGridData = this.SelectedGridData;
		int? num2 = (selectedGridData != null) ? new int?(selectedGridData.MonsterId) : null;
		this.BtnState = ((num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) ? EPhantomInteractEditBtnState.UnEquip : EPhantomInteractEditBtnState.Swap);
	}

	// Token: 0x06012B62 RID: 76642 RVA: 0x0049DC14 File Offset: 0x0049BE14
	private void InitGridViewModels(List<IPhantomInteractGridData> gridDataList)
	{
		this.GridViewModelMap.Clear();
		foreach (IPhantomInteractGridData phantomInteractGridData in gridDataList)
		{
			PhantomInteractEditGridViewModel phantomInteractEditGridViewModel = new PhantomInteractEditGridViewModel(phantomInteractGridData);
			phantomInteractEditGridViewModel.IsInArea = this.CheckInteractAreaListInRecommendArea(phantomInteractGridData.InteractAreaList);
			this.GridViewModelMap[phantomInteractGridData.MonsterId] = phantomInteractEditGridViewModel;
		}
		foreach (int num in this.RecommendedMonsterIds)
		{
			if (!this.GridViewModelMap.ContainsKey(num))
			{
				PhantomInteractGridData phantomInteractGridData2 = new PhantomInteractGridData();
				phantomInteractGridData2.LoadLockData(num);
				PhantomInteractEditGridViewModel phantomInteractEditGridViewModel2 = new PhantomInteractEditGridViewModel(phantomInteractGridData2);
				phantomInteractEditGridViewModel2.IsInArea = true;
				this.GridViewModelMap[phantomInteractGridData2.MonsterId] = phantomInteractEditGridViewModel2;
			}
		}
		this.SortGridViewModelIds = (from a in this.GridViewModelMap.Values
		orderby a.SortId
		select a into vm
		select vm.MonsterId).ToList<int>();
	}

	// Token: 0x06012B63 RID: 76643 RVA: 0x0049DD70 File Offset: 0x0049BF70
	[NullableContext(0)]
	private ValueTuple<int, int> SelectGridViewModel(int monsterId)
	{
		if (this.GridsDataList == null)
		{
			return new ValueTuple<int, int>(-1, -1);
		}
		ValueTuple<int, int>? valueTuple = null;
		for (int i = 0; i < this.GridsDataList.Count; i++)
		{
			IPhantomGridListData phantomGridListData = this.GridsDataList[i];
			for (int j = 0; j < phantomGridListData.MonsterIds.Count; j++)
			{
				int num = phantomGridListData.MonsterIds[j];
				PhantomInteractEditGridViewModel phantomInteractEditGridViewModel;
				if (this.GridViewModelMap.TryGetValue(num, out phantomInteractEditGridViewModel) && phantomInteractEditGridViewModel != null)
				{
					phantomInteractEditGridViewModel.IsSelected = (num == monsterId);
					if (valueTuple == null && phantomInteractEditGridViewModel.IsSelected)
					{
						valueTuple = new ValueTuple<int, int>?(new ValueTuple<int, int>(i, j));
						this.SelectedGridDataInternal = phantomInteractEditGridViewModel;
					}
				}
			}
		}
		ValueTuple<int, int>? valueTuple2 = valueTuple;
		if (valueTuple2 == null)
		{
			return new ValueTuple<int, int>(-1, -1);
		}
		return valueTuple2.GetValueOrDefault();
	}

	// Token: 0x06012B64 RID: 76644 RVA: 0x0049DE44 File Offset: 0x0049C044
	private void RefreshDetail()
	{
		int? num = null;
		if (this.SelectedGridData != null)
		{
			num = new int?(this.SelectedGridData.MonsterId);
		}
		else if (this.SelectedItemData != null)
		{
			num = new int?(this.SelectedItemData.MonsterId);
		}
		if (num != null)
		{
			int? num2 = num;
			int num3 = 0;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				this.ShowDetail = true;
				this.DetailViewModel.RefreshData(this.SelectedGridData);
				return;
			}
		}
		this.ShowDetail = false;
	}

	// Token: 0x06012B65 RID: 76645 RVA: 0x0049DED0 File Offset: 0x0049C0D0
	public void SetFilterCost(int cost)
	{
		this.FilterCost = ((cost > 0) ? new int?(cost) : null);
	}

	// Token: 0x06012B66 RID: 76646 RVA: 0x0049DEF8 File Offset: 0x0049C0F8
	public void SetFilterIsSpecial(EFilterIsSpecialOption option)
	{
		bool? filterIsSpecial = null;
		if (option == EFilterIsSpecialOption.Special)
		{
			filterIsSpecial = new bool?(true);
		}
		else if (option == EFilterIsSpecialOption.NonSpecial)
		{
			filterIsSpecial = new bool?(false);
		}
		this.FilterIsSpecial = filterIsSpecial;
	}

	// Token: 0x06012B67 RID: 76647 RVA: 0x0049DF30 File Offset: 0x0049C130
	public void RefreshFilterGridViewData()
	{
		this.FilteredGridMonsterIds.Clear();
		this.FilteredRecommendedMonsterIds.Clear();
		this.FilteredElseMonsterIds.Clear();
		int num = 0;
		foreach (int key in this.SortGridViewModelIds)
		{
			PhantomInteractEditGridViewModel phantomInteractEditGridViewModel;
			if (this.GridViewModelMap.TryGetValue(key, out phantomInteractEditGridViewModel) && phantomInteractEditGridViewModel != null && this.FilterOnItem(phantomInteractEditGridViewModel))
			{
				this.FilteredGridMonsterIds.Add(phantomInteractEditGridViewModel.MonsterId);
				if (this.CheckInteractAreaListInRecommendArea(phantomInteractEditGridViewModel.InteractAreaList))
				{
					this.FilteredRecommendedMonsterIds.Add(phantomInteractEditGridViewModel.MonsterId);
					if (phantomInteractEditGridViewModel.IsUnlocked)
					{
						num++;
					}
				}
				else
				{
					this.FilteredElseMonsterIds.Add(phantomInteractEditGridViewModel.MonsterId);
				}
			}
		}
		if (this.FilteredRecommendedMonsterIds.Count == 0)
		{
			this.GridsDataList = new List<IPhantomGridListData>
			{
				new PhantomGridListData
				{
					TitleType = EGridTitleType.Hide,
					MonsterIds = this.FilteredElseMonsterIds
				}
			};
		}
		else
		{
			this.GridsDataList = new List<IPhantomGridListData>
			{
				new PhantomGridListData
				{
					TitleType = ((num > 0) ? EGridTitleType.Recommend : EGridTitleType.RecommendEmpty),
					MonsterIds = this.FilteredRecommendedMonsterIds
				}
			};
			if (this.FilteredElseMonsterIds.Count > 0)
			{
				this.GridsDataList.Add(new PhantomGridListData
				{
					TitleType = EGridTitleType.Else,
					MonsterIds = this.FilteredElseMonsterIds
				});
			}
		}
		int num2 = 0;
		if (this.GridsDataList.Count > 0)
		{
			IPhantomGridListData phantomGridListData = this.GridsDataList[0];
			if (phantomGridListData != null && phantomGridListData.MonsterIds.Count > 0)
			{
				num2 = phantomGridListData.MonsterIds[0];
			}
		}
		if (num2 > 0)
		{
			this.SelectGrid(num2);
		}
	}

	// Token: 0x06012B68 RID: 76648 RVA: 0x0049E0F8 File Offset: 0x0049C2F8
	private bool FilterOnItem(IPhantomInteractGridData data)
	{
		return (this.FilterCost == null || data.Cost == this.FilterCost.Value) && (this.FilterIsSpecial == null || data.IsSpecial == this.FilterIsSpecial.Value);
	}

	// Token: 0x06012B69 RID: 76649 RVA: 0x0049E158 File Offset: 0x0049C358
	private unsafe List<int> LoadAreaRelativeData(int currentAreaId)
	{
		this.AreaSet.Clear();
		List<int> allAreaIdInheritableById = AreaModel.Instance.GetAllAreaIdInheritableById(currentAreaId);
		foreach (int item in allAreaIdInheritableById)
		{
			this.AreaSet.Add(item);
		}
		List<int> list = new List<int>();
		IReadOnlyList<CalabashDevelopReward> calabashDevelopList = CalabashConfig.Instance.GetCalabashDevelopList();
		if (calabashDevelopList != null)
		{
			foreach (CalabashDevelopReward config in calabashDevelopList)
			{
				if (this.CheckInteractAreaListInRecommendArea(config))
				{
					list.Add(config.MonsterId);
				}
			}
		}
		string message = "[声骸显像]加载当前地区推荐声骸";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("当前所属的所有区域", allAreaIdInheritableById);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("推荐声骸列表", list);
		this.LocalLog(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return list;
	}

	// Token: 0x06012B6A RID: 76650 RVA: 0x0049E274 File Offset: 0x0049C474
	private bool CheckInteractAreaListInRecommendArea(IReadOnlyList<int> interactAreaIds)
	{
		for (int i = 0; i < interactAreaIds.Count; i++)
		{
			if (this.AreaSet.Contains(interactAreaIds[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06012B6B RID: 76651 RVA: 0x0049E2AC File Offset: 0x0049C4AC
	private bool CheckInteractAreaListInRecommendArea(CalabashDevelopReward config)
	{
		int[] interactAreaListArray = config.GetInteractAreaListArray();
		if (interactAreaListArray == null)
		{
			return false;
		}
		foreach (int item in interactAreaListArray)
		{
			if (this.AreaSet.Contains(item))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x04008CE6 RID: 36070
	private readonly List<int> FilteredGridMonsterIds = new List<int>();

	// Token: 0x04008CE8 RID: 36072
	private readonly List<int> FilteredRecommendedMonsterIds = new List<int>();

	// Token: 0x04008CE9 RID: 36073
	private readonly List<int> FilteredElseMonsterIds = new List<int>();

	// Token: 0x04008CEA RID: 36074
	private readonly HashSet<int> AreaSet = new HashSet<int>();

	// Token: 0x04008CEB RID: 36075
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomInteractEditViewModel> ConfirmEquipHandlerInternal;

	// Token: 0x04008CEC RID: 36076
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomInteractEditViewModel> EquipRecommendHandlerInternal;

	// Token: 0x04008CED RID: 36077
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomInteractEditViewModel> MoveNextSkinHandlerInternal;

	// Token: 0x04008CEE RID: 36078
	[Nullable(2)]
	private Action EquipRecommendCallbackInternal;
}
