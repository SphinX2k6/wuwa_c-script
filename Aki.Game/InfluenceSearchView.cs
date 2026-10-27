using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F89 RID: 8073
[NullableContext(1)]
[Nullable(0)]
public class InfluenceSearchView : UiViewBase
{
	// Token: 0x0600FA89 RID: 64137 RVA: 0x003CB4BA File Offset: 0x003C96BA
	public InfluenceSearchView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FA8A RID: 64138 RVA: 0x003CB4D0 File Offset: 0x003C96D0
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

	// Token: 0x0600FA8B RID: 64139 RVA: 0x003CB5FC File Offset: 0x003C97FC
	private void RefreshClick()
	{
		base.GetInputText(0).SetText("", true);
	}

	// Token: 0x0600FA8C RID: 64140 RVA: 0x003CB610 File Offset: 0x003C9810
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FA8D RID: 64141 RVA: 0x003CB619 File Offset: 0x003C9819
	protected override void OnBeforeCreate()
	{
		this.CurrentCountryId = (int)this.OpenParam;
	}

	// Token: 0x0600FA8E RID: 64142 RVA: 0x003CB62C File Offset: 0x003C982C
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<InfluenceSearchGrid>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceSearchGrid>(this.InitItem), null);
		base.GetInputText(0).OnTextChange.Bind(new Action<string>(this.InputTextChange));
	}

	// Token: 0x0600FA8F RID: 64143 RVA: 0x003CB66A File Offset: 0x003C986A
	protected override void OnAfterShow()
	{
		this.RefreshSearchResult();
	}

	// Token: 0x0600FA90 RID: 64144 RVA: 0x003CB674 File Offset: 0x003C9874
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

	// Token: 0x0600FA91 RID: 64145 RVA: 0x003CB710 File Offset: 0x003C9910
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

	// Token: 0x0600FA92 RID: 64146 RVA: 0x003CB7AA File Offset: 0x003C99AA
	private void InputTextChange(string inString)
	{
		this.InputText = inString;
		this.RefreshSearchResult();
	}

	// Token: 0x0600FA93 RID: 64147 RVA: 0x003CB7B9 File Offset: 0x003C99B9
	protected override void OnBeforeDestroy()
	{
		this.ScrollView.ClearChildren();
		this.ScrollView = null;
	}

	// Token: 0x040074AD RID: 29869
	protected int CurrentCountryId;

	// Token: 0x040074AE RID: 29870
	private string InputText = "";

	// Token: 0x040074AF RID: 29871
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<InfluenceSearchGrid> ScrollView;

	// Token: 0x02008573 RID: 34163
	[NullableContext(0)]
	private enum EInfluenceSearchView
	{
		// Token: 0x0402B73C RID: 177980
		InputText,
		// Token: 0x0402B73D RID: 177981
		RefreshButton,
		// Token: 0x0402B73E RID: 177982
		ScrollView,
		// Token: 0x0402B73F RID: 177983
		NoSearchText,
		// Token: 0x0402B740 RID: 177984
		MaskButton
	}
}
