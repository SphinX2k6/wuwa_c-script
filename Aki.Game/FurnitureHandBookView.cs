using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000491 RID: 1169
[NullableContext(1)]
[Nullable(0)]
public class FurnitureHandBookView : UiViewBase
{
	// Token: 0x06003BD9 RID: 15321 RVA: 0x00153B4D File Offset: 0x00151D4D
	public FurnitureHandBookView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003BDA RID: 15322 RVA: 0x00153B78 File Offset: 0x00151D78
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

	// Token: 0x06003BDB RID: 15323 RVA: 0x00153C2C File Offset: 0x00151E2C
	protected override UniTask OnBeforeStartAsync()
	{
		FurnitureHandBookView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FurnitureHandBookView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003BDC RID: 15324 RVA: 0x00153C70 File Offset: 0x00151E70
	protected override UniTask OnBeforeShowAsyncImplementImplement()
	{
		FurnitureHandBookView.<OnBeforeShowAsyncImplementImplement>d__12 <OnBeforeShowAsyncImplementImplement>d__;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<FurnitureHandBookView.<OnBeforeShowAsyncImplementImplement>d__12>(ref <OnBeforeShowAsyncImplementImplement>d__);
		return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06003BDD RID: 15325 RVA: 0x00153CB3 File Offset: 0x00151EB3
	protected override void OnBeforeHide()
	{
		FurnitureController.Instance.SetAllFurnitureHandBookItemRedDotAsRead();
	}

	// Token: 0x06003BDE RID: 15326 RVA: 0x00153CC0 File Offset: 0x00151EC0
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

	// Token: 0x06003BDF RID: 15327 RVA: 0x00153D70 File Offset: 0x00151F70
	private void UpdateCurShowDataList()
	{
		int[] tagList = (this.CurrentFilterConfig != null) ? this.CurrentFilterConfig.GetValueOrDefault().TagList() : null;
		if (tagList == null)
		{
			this.CurShowDataList = this.AllDataList;
		}
		else
		{
			this.CurShowDataList = this.AllDataList.FindAll((IFurnitureHandBookItemData data) => Array.IndexOf<int>(tagList, data.FurnitureConfig.TagId) >= 0);
		}
		this.SortCurShowDataList();
	}

	// Token: 0x06003BE0 RID: 15328 RVA: 0x00153DE1 File Offset: 0x00151FE1
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

	// Token: 0x06003BE1 RID: 15329 RVA: 0x00153E0D File Offset: 0x0015200D
	public void RefreshGrid()
	{
		this.ItemLoopScrollView.RefreshByData(this.CurShowDataList, false, null, false);
	}

	// Token: 0x06003BE2 RID: 15330 RVA: 0x00153E24 File Offset: 0x00152024
	public void RefreshDetail()
	{
		if (this.CurSelectedFurnitureData == null)
		{
			return;
		}
		this.DetailItem.RefreshByFurnitureId(this.CurSelectedFurnitureData.FurnitureConfig.Id, true);
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x00153E5C File Offset: 0x0015205C
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

	// Token: 0x06003BE4 RID: 15332 RVA: 0x00153EF4 File Offset: 0x001520F4
	private void OnClickBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x06003BE5 RID: 15333 RVA: 0x00153EFD File Offset: 0x001520FD
	private void OnDropDownSelect(int index, FurnitureFilterConfig data)
	{
		this.CurrentFilterConfig = new FurnitureFilterConfig?(this.FilterConfigList[index]);
		this.UpdateCurShowDataList();
		this.RefreshGrid();
		this.SelectProxy();
	}

	// Token: 0x06003BE6 RID: 15334 RVA: 0x00153F28 File Offset: 0x00152128
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

	// Token: 0x06003BE7 RID: 15335 RVA: 0x00153F53 File Offset: 0x00152153
	private void OnFurnitureItemToggleChanged(EToggleState state, IFurnitureHandBookItemData data)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.SelectFurniture(data);
		}
	}

	// Token: 0x06003BE8 RID: 15336 RVA: 0x00153F60 File Offset: 0x00152160
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

	// Token: 0x06003BE9 RID: 15337 RVA: 0x00153FA7 File Offset: 0x001521A7
	public void SelectFurniture(IFurnitureHandBookItemData data)
	{
		this.CurSelectedFurnitureData = data;
		this.SelectProxy();
		this.RefreshDetail();
	}

	// Token: 0x06003BEA RID: 15338 RVA: 0x00153FBC File Offset: 0x001521BC
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

	// Token: 0x0400302D RID: 12333
	[Nullable(2)]
	protected IFurnitureHandBookItemData CurSelectedFurnitureData;

	// Token: 0x0400302E RID: 12334
	private readonly List<IFurnitureHandBookItemData> AllDataList = new List<IFurnitureHandBookItemData>();

	// Token: 0x0400302F RID: 12335
	protected List<IFurnitureHandBookItemData> CurShowDataList = new List<IFurnitureHandBookItemData>();

	// Token: 0x04003030 RID: 12336
	private FurnitureFilterConfig? CurrentFilterConfig;

	// Token: 0x04003031 RID: 12337
	private IReadOnlyList<FurnitureFilterConfig> FilterConfigList = new List<FurnitureFilterConfig>();

	// Token: 0x04003032 RID: 12338
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x04003033 RID: 12339
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private CommonDropDown<TableTextArgNew, FurnitureFilterConfig> FilterDropDownList;

	// Token: 0x04003034 RID: 12340
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<FurnitureHandBookItem, IFurnitureHandBookItemData> ItemLoopScrollView;

	// Token: 0x04003035 RID: 12341
	[Nullable(2)]
	private FurnitureDetailTipItem DetailItem;
}
