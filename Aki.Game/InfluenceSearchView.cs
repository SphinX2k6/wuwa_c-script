using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200144B RID: 5195
[NullableContext(1)]
[Nullable(0)]
public class InfluenceSearchView : UiViewBase
{
	// Token: 0x0600CEA8 RID: 52904 RVA: 0x003D6FF2 File Offset: 0x003D51F2
	public InfluenceSearchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CEA9 RID: 52905 RVA: 0x003D7008 File Offset: 0x003D5208
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITextInputComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.RefreshClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.CloseClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CEAA RID: 52906 RVA: 0x003D7134 File Offset: 0x003D5334
	private void RefreshClick()
	{
		base.GetInputText(0).SetText("", true);
	}

	// Token: 0x0600CEAB RID: 52907 RVA: 0x003D7148 File Offset: 0x003D5348
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CEAC RID: 52908 RVA: 0x003D7151 File Offset: 0x003D5351
	protected override void OnBeforeCreate()
	{
		this.CurrentCountryId = (int)this.OpenParam;
	}

	// Token: 0x0600CEAD RID: 52909 RVA: 0x003D7164 File Offset: 0x003D5364
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<InfluenceSearchGrid>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceSearchGrid>(this.InitItem), null);
		base.GetInputText(0).OnTextChange.Bind(new Action<string>(this.InputTextChange));
	}

	// Token: 0x0600CEAE RID: 52910 RVA: 0x003D71A2 File Offset: 0x003D53A2
	protected override void OnAfterShow()
	{
		this.RefreshSearchResult();
	}

	// Token: 0x0600CEAF RID: 52911 RVA: 0x003D71AC File Offset: 0x003D53AC
	protected void RefreshSearchResult()
	{
		int[] array;
		if (string.IsNullOrEmpty(this.InputText))
		{
			array = new int[]
			{
				this.CurrentCountryId
			};
		}
		else
		{
			array = InfluenceReputationModel.Instance.GetUnLockCountry();
			Array.Sort<int>(array, delegate(int aCountryId, int bCountryId)
			{
				if (aCountryId == this.CurrentCountryId)
				{
					return -1;
				}
				if (bCountryId == this.CurrentCountryId)
				{
					return 1;
				}
				return aCountryId - bCountryId;
			});
		}
		InfluenceSearchData influenceSearchData = InfluenceReputationModel.Instance.FilterUnLockInfluenceList(array, this.InputText);
		bool hasResult = influenceSearchData.HasResult;
		base.GetItem(3).SetUIActive(!hasResult);
		this.ScrollView.SetActive(hasResult);
		if (hasResult)
		{
			this.ScrollView.RefreshByData<ValueTuple<int, List<int>>>(influenceSearchData.InfluenceList, null);
		}
	}

	// Token: 0x0600CEB0 RID: 52912 RVA: 0x003D7248 File Offset: 0x003D5448
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private ILayoutItem<InfluenceSearchGrid> InitItem(object tempData, UUIItem uiItem, int index)
	{
		ValueTuple<int, int[]> valueTuple = (ValueTuple<int, int[]>)tempData;
		if (this.CurrentCountryId == valueTuple.Item1)
		{
			InfluenceSearchGrid influenceSearchGrid = new InfluenceSearchGrid(uiItem);
			influenceSearchGrid.UpdateGrid(valueTuple.Item1, valueTuple.Item2);
			return new LayoutItem<InfluenceSearchGrid>
			{
				Key = index,
				Value = influenceSearchGrid
			};
		}
		if (valueTuple.Item2.Length == 0)
		{
			uiItem.SetUIActive(false);
			return null;
		}
		InfluenceSearchGrid influenceSearchGrid2 = new InfluenceSearchGrid(uiItem);
		influenceSearchGrid2.UpdateGrid(valueTuple.Item1, valueTuple.Item2);
		return new LayoutItem<InfluenceSearchGrid>
		{
			Key = index,
			Value = influenceSearchGrid2
		};
	}

	// Token: 0x0600CEB1 RID: 52913 RVA: 0x003D72E2 File Offset: 0x003D54E2
	private void InputTextChange(string inString)
	{
		this.InputText = inString;
		this.RefreshSearchResult();
	}

	// Token: 0x0600CEB2 RID: 52914 RVA: 0x003D72F1 File Offset: 0x003D54F1
	protected override void OnBeforeDestroy()
	{
		this.ScrollView.ClearChildren();
		this.ScrollView = null;
	}

	// Token: 0x0400758E RID: 30094
	protected int CurrentCountryId;

	// Token: 0x0400758F RID: 30095
	private string InputText = "";

	// Token: 0x04007590 RID: 30096
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<InfluenceSearchGrid> ScrollView;

	// Token: 0x020076F8 RID: 30456
	[NullableContext(0)]
	private enum EInfluenceSearchView
	{
		// Token: 0x04026A5F RID: 158303
		InputText,
		// Token: 0x04026A60 RID: 158304
		RefreshButton,
		// Token: 0x04026A61 RID: 158305
		ScrollView,
		// Token: 0x04026A62 RID: 158306
		NoSearchText,
		// Token: 0x04026A63 RID: 158307
		MaskButton
	}
}
