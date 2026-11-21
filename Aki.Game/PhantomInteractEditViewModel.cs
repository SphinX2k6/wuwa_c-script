using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

// Token: 0x0200194C RID: 6476
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractEditViewModel
{
	// Token: 0x170018A9 RID: 6313
	// (get) Token: 0x0600FFEC RID: 65516 RVA: 0x004AAF3A File Offset: 0x004A913A
	// (set) Token: 0x0600FFED RID: 65517 RVA: 0x004AAF42 File Offset: 0x004A9142
	public int SelectedItemIndex { get; set; }

	// Token: 0x170018AA RID: 6314
	// (get) Token: 0x0600FFEE RID: 65518 RVA: 0x004AAF4B File Offset: 0x004A914B
	// (set) Token: 0x0600FFEF RID: 65519 RVA: 0x004AAF53 File Offset: 0x004A9153
	public EPhantomInteractEditBtnState BtnState { get; set; } = EPhantomInteractEditBtnState.Equip;

	// Token: 0x170018AB RID: 6315
	// (get) Token: 0x0600FFF0 RID: 65520 RVA: 0x004AAF5C File Offset: 0x004A915C
	// (set) Token: 0x0600FFF1 RID: 65521 RVA: 0x004AAF64 File Offset: 0x004A9164
	public bool BtnAvailable { get; set; } = true;

	// Token: 0x170018AC RID: 6316
	// (get) Token: 0x0600FFF2 RID: 65522 RVA: 0x004AAF6D File Offset: 0x004A916D
	// (set) Token: 0x0600FFF3 RID: 65523 RVA: 0x004AAF75 File Offset: 0x004A9175
	[Nullable(2)]
	public IPhantomInteractItemData SelectedItemData { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018AD RID: 6317
	// (get) Token: 0x0600FFF4 RID: 65524 RVA: 0x004AAF7E File Offset: 0x004A917E
	// (set) Token: 0x0600FFF5 RID: 65525 RVA: 0x004AAF86 File Offset: 0x004A9186
	public PhantomInteractDetailViewModel DetailViewModel { get; set; } = new PhantomInteractDetailViewModel();

	// Token: 0x170018AE RID: 6318
	// (get) Token: 0x0600FFF6 RID: 65526 RVA: 0x004AAF8F File Offset: 0x004A918F
	// (set) Token: 0x0600FFF7 RID: 65527 RVA: 0x004AAF97 File Offset: 0x004A9197
	public bool ShowDetail { get; set; }

	// Token: 0x170018AF RID: 6319
	// (get) Token: 0x0600FFF8 RID: 65528 RVA: 0x004AAFA0 File Offset: 0x004A91A0
	// (set) Token: 0x0600FFF9 RID: 65529 RVA: 0x004AAFA8 File Offset: 0x004A91A8
	public List<IPhantomGridListData> GridsDataList { get; set; } = new List<IPhantomGridListData>();

	// Token: 0x170018B0 RID: 6320
	// (get) Token: 0x0600FFFA RID: 65530 RVA: 0x004AAFB1 File Offset: 0x004A91B1
	// (set) Token: 0x0600FFFB RID: 65531 RVA: 0x004AAFB9 File Offset: 0x004A91B9
	[Nullable(0)]
	public ValueTuple<int, int> SelectedGridItemIndex { [NullableContext(0)] get; [NullableContext(0)] set; } = new ValueTuple<int, int>(-1, -1);

	// Token: 0x170018B1 RID: 6321
	// (get) Token: 0x0600FFFC RID: 65532 RVA: 0x004AAFC2 File Offset: 0x004A91C2
	// (set) Token: 0x0600FFFD RID: 65533 RVA: 0x004AAFCA File Offset: 0x004A91CA
	public Dictionary<int, PhantomInteractEditGridViewModel> GridViewModelMap { get; set; } = new Dictionary<int, PhantomInteractEditGridViewModel>();

	// Token: 0x170018B2 RID: 6322
	// (get) Token: 0x0600FFFE RID: 65534 RVA: 0x004AAFD3 File Offset: 0x004A91D3
	// (set) Token: 0x0600FFFF RID: 65535 RVA: 0x004AAFDB File Offset: 0x004A91DB
	private List<int> SortGridViewModelIds { get; set; } = new List<int>();

	// Token: 0x170018B3 RID: 6323
	// (get) Token: 0x06010000 RID: 65536 RVA: 0x004AAFE4 File Offset: 0x004A91E4
	// (set) Token: 0x06010001 RID: 65537 RVA: 0x004AAFEC File Offset: 0x004A91EC
	[Nullable(2)]
	private PhantomInteractEditGridViewModel SelectedGridDataInternal { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018B4 RID: 6324
	// (get) Token: 0x06010002 RID: 65538 RVA: 0x004AAFF5 File Offset: 0x004A91F5
	// (set) Token: 0x06010003 RID: 65539 RVA: 0x004AAFFD File Offset: 0x004A91FD
	private PhantomInteractInfoData InfoData { get; set; } = new PhantomInteractInfoData();

	// Token: 0x170018B5 RID: 6325
	// (get) Token: 0x06010004 RID: 65540 RVA: 0x004AB006 File Offset: 0x004A9206
	// (set) Token: 0x06010005 RID: 65541 RVA: 0x004AB00E File Offset: 0x004A920E
	private int? FilterCost { get; set; }

	// Token: 0x170018B6 RID: 6326
	// (get) Token: 0x06010006 RID: 65542 RVA: 0x004AB017 File Offset: 0x004A9217
	// (set) Token: 0x06010007 RID: 65543 RVA: 0x004AB01F File Offset: 0x004A921F
	private bool? FilterIsSpecial { get; set; }

	// Token: 0x170018B7 RID: 6327
	// (get) Token: 0x06010008 RID: 65544 RVA: 0x004AB028 File Offset: 0x004A9228
	// (set) Token: 0x06010009 RID: 65545 RVA: 0x004AB030 File Offset: 0x004A9230
	private List<int> RecommendedMonsterIds { get; set; } = new List<int>();

	// Token: 0x0601000A RID: 65546 RVA: 0x004AB039 File Offset: 0x004A9239
	private void LocalLog(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0601000B RID: 65547 RVA: 0x004AB03B File Offset: 0x004A923B
	public void ConfirmEquipHandler()
	{
		if (this.ConfirmEquipHandlerInternal == null)
		{
			return;
		}
		this.ConfirmEquipHandlerInternal(this);
	}

	// Token: 0x0601000C RID: 65548 RVA: 0x004AB052 File Offset: 0x004A9252
	public void SetConfirmEquipHandler([Nullable(new byte[]
	{
		2,
		1
	})] Action<PhantomInteractEditViewModel> handler)
	{
		this.ConfirmEquipHandlerInternal = handler;
	}

	// Token: 0x0601000D RID: 65549 RVA: 0x004AB05B File Offset: 0x004A925B
	public void EquipRecommendHandler()
	{
		if (this.EquipRecommendHandlerInternal == null)
		{
			return;
		}
		this.EquipRecommendHandlerInternal(this);
	}

	// Token: 0x0601000E RID: 65550 RVA: 0x004AB072 File Offset: 0x004A9272
	public void SetEquipRecommendHandler([Nullable(new byte[]
	{
		2,
		1
	})] Action<PhantomInteractEditViewModel> handler)
	{
		this.EquipRecommendHandlerInternal = handler;
	}

	// Token: 0x0601000F RID: 65551 RVA: 0x004AB07B File Offset: 0x004A927B
	public void EquipRecommendCallback()
	{
		if (this.EquipRecommendCallbackInternal != null)
		{
			this.EquipRecommendCallbackInternal();
			this.EquipRecommendCallbackInternal = null;
		}
	}

	// Token: 0x06010010 RID: 65552 RVA: 0x004AB097 File Offset: 0x004A9297
	[NullableContext(2)]
	public void SetEquipRecommendCallback(Action callback)
	{
		this.EquipRecommendCallbackInternal = callback;
	}

	// Token: 0x06010011 RID: 65553 RVA: 0x004AB0A0 File Offset: 0x004A92A0
	public void MoveNextSkinHandler()
	{
		if (this.MoveNextSkinHandlerInternal == null)
		{
			return;
		}
		this.MoveNextSkinHandlerInternal(this);
		this.RefreshDetail();
	}

	// Token: 0x06010012 RID: 65554 RVA: 0x004AB0BD File Offset: 0x004A92BD
	public void SetMoveNextSkinHandler([Nullable(new byte[]
	{
		2,
		1
	})] Action<PhantomInteractEditViewModel> handler)
	{
		this.MoveNextSkinHandlerInternal = handler;
	}

	// Token: 0x170018B8 RID: 6328
	// (get) Token: 0x06010013 RID: 65555 RVA: 0x004AB0C6 File Offset: 0x004A92C6
	[Nullable(2)]
	public PhantomInteractEditGridViewModel SelectedGridData
	{
		[NullableContext(2)]
		get
		{
			return this.SelectedGridDataInternal;
		}
	}

	// Token: 0x06010014 RID: 65556 RVA: 0x004AB0CE File Offset: 0x004A92CE
	public List<int> GetFilteredRecommendedIdList()
	{
		return this.FilteredRecommendedMonsterIds;
	}

	// Token: 0x06010015 RID: 65557 RVA: 0x004AB0D8 File Offset: 0x004A92D8
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

	// Token: 0x06010016 RID: 65558 RVA: 0x004AB184 File Offset: 0x004A9384
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

	// Token: 0x06010017 RID: 65559 RVA: 0x004AB1DC File Offset: 0x004A93DC
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

	// Token: 0x06010018 RID: 65560 RVA: 0x004AB22C File Offset: 0x004A942C
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

	// Token: 0x06010019 RID: 65561 RVA: 0x004AB2BC File Offset: 0x004A94BC
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

	// Token: 0x0601001A RID: 65562 RVA: 0x004AB380 File Offset: 0x004A9580
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
		List<PhantomInteractEditGridViewModel> source = NoLinq.SortToList<PhantomInteractEditGridViewModel>(this.GridViewModelMap.Values, (PhantomInteractEditGridViewModel left, PhantomInteractEditGridViewModel right) => left.SortId.CompareTo(right.SortId));
		this.SortGridViewModelIds = NoLinq.SelectToList<PhantomInteractEditGridViewModel, int>(source, (PhantomInteractEditGridViewModel model) => model.MonsterId);
	}

	// Token: 0x0601001B RID: 65563 RVA: 0x004AB4DC File Offset: 0x004A96DC
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

	// Token: 0x0601001C RID: 65564 RVA: 0x004AB5B0 File Offset: 0x004A97B0
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

	// Token: 0x0601001D RID: 65565 RVA: 0x004AB63C File Offset: 0x004A983C
	public void SetFilterCost(int cost)
	{
		this.FilterCost = ((cost > 0) ? new int?(cost) : null);
	}

	// Token: 0x0601001E RID: 65566 RVA: 0x004AB664 File Offset: 0x004A9864
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

	// Token: 0x0601001F RID: 65567 RVA: 0x004AB69C File Offset: 0x004A989C
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

	// Token: 0x06010020 RID: 65568 RVA: 0x004AB864 File Offset: 0x004A9A64
	private bool FilterOnItem(IPhantomInteractGridData data)
	{
		return (this.FilterCost == null || data.Cost == this.FilterCost.Value) && (this.FilterIsSpecial == null || data.IsSpecial == this.FilterIsSpecial.Value);
	}

	// Token: 0x06010021 RID: 65569 RVA: 0x004AB8C4 File Offset: 0x004A9AC4
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

	// Token: 0x06010022 RID: 65570 RVA: 0x004AB9E0 File Offset: 0x004A9BE0
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

	// Token: 0x06010023 RID: 65571 RVA: 0x004ABA18 File Offset: 0x004A9C18
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

	// Token: 0x04008E2D RID: 36397
	private readonly List<int> FilteredGridMonsterIds = new List<int>();

	// Token: 0x04008E2F RID: 36399
	private readonly List<int> FilteredRecommendedMonsterIds = new List<int>();

	// Token: 0x04008E30 RID: 36400
	private readonly List<int> FilteredElseMonsterIds = new List<int>();

	// Token: 0x04008E31 RID: 36401
	private readonly HashSet<int> AreaSet = new HashSet<int>();

	// Token: 0x04008E32 RID: 36402
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomInteractEditViewModel> ConfirmEquipHandlerInternal;

	// Token: 0x04008E33 RID: 36403
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomInteractEditViewModel> EquipRecommendHandlerInternal;

	// Token: 0x04008E34 RID: 36404
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PhantomInteractEditViewModel> MoveNextSkinHandlerInternal;

	// Token: 0x04008E35 RID: 36405
	[Nullable(2)]
	private Action EquipRecommendCallbackInternal;
}
