using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000FDC RID: 4060
[NullableContext(1)]
[Nullable(0)]
public class FurnitureHandBookView : UiViewBase
{
	// Token: 0x06006841 RID: 26689 RVA: 0x0014B289 File Offset: 0x00149489
	public FurnitureHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006842 RID: 26690 RVA: 0x0014B2B4 File Offset: 0x001494B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
	}

	// Token: 0x06006843 RID: 26691 RVA: 0x0014B368 File Offset: 0x00149568
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureHandBookView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureHandBookView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006844 RID: 26692 RVA: 0x0014B3AC File Offset: 0x001495AC
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		FurnitureHandBookView.<OnBeforeShowAsyncImplementImplement>d__12 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<FurnitureHandBookView.<OnBeforeShowAsyncImplementImplement>d__12>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06006845 RID: 26693 RVA: 0x0014B3EF File Offset: 0x001495EF
	protected override void OnBeforeHide()
	{
		FurnitureController.Instance.SetAllFurnitureHandBookItemRedDotAsRead();
	}

	// Token: 0x06006846 RID: 26694 RVA: 0x0014B3FC File Offset: 0x001495FC
	protected virtual void UpdateAllDataList()
	{
		int handleId = FurnitureModel.Instance.HandleId;
		IEnumerable<Furniture> furnitureConfigListByHandleId = FurnitureConfig.Instance.GetFurnitureConfigListByHandleId(handleId);
		this.AllDataList.Clear();
		foreach (Furniture furnitureConfig in furnitureConfigListByHandleId)
		{
			bool isLock = !FurnitureModel.Instance.GetIsFurnitureUnlockById(furnitureConfig.Id);
			FurnitureHandBookItemData item = new FurnitureHandBookItemData
			{
				FurnitureConfig = furnitureConfig,
				IsLock = isLock,
				RedDotVisible = FurnitureModel.Instance.CheckFurnitureHandBookItemRedDot(furnitureConfig.Id)
			};
			this.AllDataList.Add(item);
		}
	}

	// Token: 0x06006847 RID: 26695 RVA: 0x0014B4AC File Offset: 0x001496AC
	private void UpdateCurShowDataList()
	{
		int[] tagList = (this.CurrentFilterConfig != null) ? this.CurrentFilterConfig.GetValueOrDefault().TagList() : null;
		if (tagList == null)
		{
			this.CurShowDataList = this.AllDataList;
		}
		else
		{
			this.CurShowDataList = this.AllDataList.FindAll((IFurnitureHandBookItemData data) => tagList.Contains(data.FurnitureConfig.TagId));
		}
		this.SortCurShowDataList();
	}

	// Token: 0x06006848 RID: 26696 RVA: 0x0014B51D File Offset: 0x0014971D
	private void SortCurShowDataList()
	{
		this.CurShowDataList.Sort(delegate(IFurnitureHandBookItemData a, IFurnitureHandBookItemData b)
		{
			if (a.IsLock != b.IsLock)
			{
				if (!a.IsLock)
				{
					return -1;
				}
				return 1;
			}
			else
			{
				if (a.FurnitureConfig.QualityId != b.FurnitureConfig.QualityId)
				{
					return b.FurnitureConfig.QualityId - a.FurnitureConfig.QualityId;
				}
				if (a.FurnitureConfig.Id != b.FurnitureConfig.Id)
				{
					return a.FurnitureConfig.Id - b.FurnitureConfig.Id;
				}
				return 0;
			}
		});
	}

	// Token: 0x06006849 RID: 26697 RVA: 0x0014B549 File Offset: 0x00149749
	public void RefreshGrid()
	{
		this.ItemLoopScrollView.RefreshByData(this.CurShowDataList, false, null, false);
	}

	// Token: 0x0600684A RID: 26698 RVA: 0x0014B560 File Offset: 0x00149760
	public void RefreshDetail()
	{
		if (this.CurSelectedFurnitureData == null)
		{
			return;
		}
		this.DetailItem.RefreshByFurnitureId(this.CurSelectedFurnitureData.FurnitureConfig.Id, true);
	}

	// Token: 0x0600684B RID: 26699 RVA: 0x0014B598 File Offset: 0x00149798
	public void RefreshNumText()
	{
		int num = 0;
		int count = this.AllDataList.Count;
		using (List<IFurnitureHandBookItemData>.Enumerator enumerator = this.AllDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (!enumerator.Current.IsLock)
				{
					num++;
				}
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "DIY_FurnitureDic_Process", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			count
		}));
	}

	// Token: 0x0600684C RID: 26700 RVA: 0x0014B630 File Offset: 0x00149830
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600684D RID: 26701 RVA: 0x0014B639 File Offset: 0x00149839
	private void OnDropDownSelect(int index, FurnitureFilterConfig data)
	{
		this.CurrentFilterConfig = new FurnitureFilterConfig?(this.FilterConfigList[index]);
		this.UpdateCurShowDataList();
		this.RefreshGrid();
		this.SelectProxy();
	}

	// Token: 0x0600684E RID: 26702 RVA: 0x0014B664 File Offset: 0x00149864
	private FurnitureHandBookItem CreateItemProxy()
	{
		FurnitureHandBookItem furnitureHandBookItem = new FurnitureHandBookItem();
		furnitureHandBookItem.BindOnExtendToggleStateChanged(delegate(MediumItemGridExtendCallback callbackParameter)
		{
			EToggleState state = callbackParameter.State;
			IFurnitureHandBookItemData data = callbackParameter.Data as IFurnitureHandBookItemData;
			this.OnFurnitureItemToggleChanged(state, data);
		});
		furnitureHandBookItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChangeFunctionForFurniture));
		return furnitureHandBookItem;
	}

	// Token: 0x0600684F RID: 26703 RVA: 0x0014B68F File Offset: 0x0014988F
	private void OnFurnitureItemToggleChanged(EToggleState state, IFurnitureHandBookItemData data)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectFurniture(data);
		}
	}

	// Token: 0x06006850 RID: 26704 RVA: 0x0014B69C File Offset: 0x0014989C
	private bool CanExecuteChangeFunctionForFurniture(object data, bool isForceSelected, EToggleState state)
	{
		int id = (data as IFurnitureHandBookItemData).FurnitureConfig.Id;
		if (state == EToggleState.ETT_Checked)
		{
			IFurnitureHandBookItemData curSelectedFurnitureData = this.CurSelectedFurnitureData;
			return curSelectedFurnitureData == null || curSelectedFurnitureData.FurnitureConfig.Id != id;
		}
		return true;
	}

	// Token: 0x06006851 RID: 26705 RVA: 0x0014B6E3 File Offset: 0x001498E3
	public void SelectFurniture(IFurnitureHandBookItemData data)
	{
		this.CurSelectedFurnitureData = data;
		this.SelectProxy();
		this.RefreshDetail();
	}

	// Token: 0x06006852 RID: 26706 RVA: 0x0014B6F8 File Offset: 0x001498F8
	public void SelectProxy()
	{
		FurnitureHandBookView.<>c__DisplayClass26_0 CS$<>8__locals1 = new FurnitureHandBookView.<>c__DisplayClass26_0();
		FurnitureHandBookView.<>c__DisplayClass26_0 CS$<>8__locals2 = CS$<>8__locals1;
		IFurnitureHandBookItemData curSelectedFurnitureData = this.CurSelectedFurnitureData;
		CS$<>8__locals2.furnitureId = ((curSelectedFurnitureData != null) ? new int?(curSelectedFurnitureData.FurnitureConfig.Id) : null);
		if (CS$<>8__locals1.furnitureId == null)
		{
			return;
		}
		int num = this.CurShowDataList.FindIndex(delegate(IFurnitureHandBookItemData item)
		{
			int id = item.FurnitureConfig.Id;
			int? furnitureId = CS$<>8__locals1.furnitureId;
			return id == furnitureId.GetValueOrDefault() & furnitureId != null;
		});
		if (num == -1)
		{
			return;
		}
		LoopScrollView<FurnitureHandBookItem, IFurnitureHandBookItemData> itemLoopScrollView = this.ItemLoopScrollView;
		if (itemLoopScrollView == null)
		{
			return;
		}
		itemLoopScrollView.SelectGridProxy(num, false);
	}

	// Token: 0x04002F94 RID: 12180
	[Nullable(2)]
	protected IFurnitureHandBookItemData CurSelectedFurnitureData;

	// Token: 0x04002F95 RID: 12181
	private readonly List<IFurnitureHandBookItemData> AllDataList = new List<IFurnitureHandBookItemData>();

	// Token: 0x04002F96 RID: 12182
	protected List<IFurnitureHandBookItemData> CurShowDataList = new List<IFurnitureHandBookItemData>();

	// Token: 0x04002F97 RID: 12183
	private FurnitureFilterConfig? CurrentFilterConfig;

	// Token: 0x04002F98 RID: 12184
	private IReadOnlyList<FurnitureFilterConfig> FilterConfigList = new List<FurnitureFilterConfig>();

	// Token: 0x04002F99 RID: 12185
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x04002F9A RID: 12186
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, FurnitureFilterConfig> FilterDropDownList;

	// Token: 0x04002F9B RID: 12187
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FurnitureHandBookItem, IFurnitureHandBookItemData> ItemLoopScrollView;

	// Token: 0x04002F9C RID: 12188
	[Nullable(2)]
	private FurnitureDetailTipItem DetailItem;
}
