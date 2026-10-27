using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F84 RID: 8068
[NullableContext(1)]
[Nullable(0)]
public class InfluenceReputationView : UiViewBase
{
	// Token: 0x0600FA48 RID: 64072 RVA: 0x003CA07F File Offset: 0x003C827F
	public InfluenceReputationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FA49 RID: 64073 RVA: 0x003CA0A0 File Offset: 0x003C82A0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 6;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.CloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.SearchClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.SwitchClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.LeftArrowClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.RightArrowClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.DisActiveClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FA4A RID: 64074 RVA: 0x003CA344 File Offset: 0x003C8544
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FA4B RID: 64075 RVA: 0x003CA34D File Offset: 0x003C854D
	private void SearchClick()
	{
		UiManager.Instance.OpenView(EUiViewName.InfluenceSearchView, this.CurrentCountryId, null);
	}

	// Token: 0x0600FA4C RID: 64076 RVA: 0x003CA36A File Offset: 0x003C856A
	private void SwitchClick()
	{
		UiManager.Instance.OpenView(EUiViewName.InfluenceAreaSelectView, this.CurrentCountryId, null);
	}

	// Token: 0x0600FA4D RID: 64077 RVA: 0x003CA388 File Offset: 0x003C8588
	private void LeftArrowClick()
	{
		UUIItem uuiitem = this.ScrollView.ContentItem.Get();
		float width = uuiitem.GetWidth();
		float num = Math.Abs(uuiitem.GetAnchorOffsetX()) + this.ScrollView.ScrollWidth;
		int num2 = this.InfluenceList.Length;
		if (num > width)
		{
			this.ScrollView.ScrollToRight(num2 - 2);
			return;
		}
		float num3 = width / (float)num2;
		int num4;
		if (num % num3 < 10f)
		{
			num4 = (int)Math.Floor((double)(num / num3)) - 1 - 1;
		}
		else
		{
			num4 = (int)Math.Floor((double)(num / num3)) - 1;
		}
		this.ScrollView.ScrollToRight(num4);
	}

	// Token: 0x0600FA4E RID: 64078 RVA: 0x003CA42C File Offset: 0x003C862C
	private void RightArrowClick()
	{
		UUIItem uuiitem = this.ScrollView.ContentItem.Get();
		float width = uuiitem.GetWidth();
		float num = Math.Abs(uuiitem.GetAnchorOffsetX());
		if (num < 0f)
		{
			this.ScrollView.ScrollToLeft(1);
		}
		int num2 = this.InfluenceList.Length;
		float num3 = width / (float)num2;
		float num4 = num % num3;
		int num5;
		if (num3 - num4 < 10f)
		{
			num5 = (int)Math.Floor((double)(num / num3)) + 1 + 1;
		}
		else
		{
			num5 = (int)Math.Floor((double)(num / num3)) + 1;
		}
		this.ScrollView.ScrollToLeft(num5);
	}

	// Token: 0x0600FA4F RID: 64079 RVA: 0x003CA4CC File Offset: 0x003C86CC
	private void DisActiveClick()
	{
		this.ShowHideContentDisActiveButton(false);
		if (this.SelectedIndex != null)
		{
			this.ScrollView.GetScrollItemByKey(this.SelectedIndex.Value).SetDisActiveToggleState();
			this.SelectedIndex = null;
		}
	}

	// Token: 0x0600FA50 RID: 64080 RVA: 0x003CA519 File Offset: 0x003C8719
	protected override void OnBeforeCreate()
	{
		this.CurrentCountryId = (int)this.OpenParam;
	}

	// Token: 0x0600FA51 RID: 64081 RVA: 0x003CA52C File Offset: 0x003C872C
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<InfluenceDisplayItem>(base.GetScrollViewWithScrollbar(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<InfluenceDisplayItem>(this.InitItem), null);
		this.ScrollView.BindScrollValueChange(new Action<FVector2D>(this.ScrollValueChange));
		this.ScrollView.BindLateUpdate(new Action<float>(this.LateUpdate));
		string playerStand = PlayerInfoModel.Instance.GetPlayerStand();
		base.SetTextureByPath(playerStand, base.GetTexture(6), null, null);
		this.LeftArrow = base.GetButton(2).RootUIComp.Get();
		this.RightArrow = base.GetButton(3).RootUIComp.Get();
		this.LeftArrow.SetUIActive(false);
		this.RightArrow.SetUIActive(false);
		this.LeftArrowActive = false;
		this.RightArrowActive = false;
	}

	// Token: 0x0600FA52 RID: 64082 RVA: 0x003CA604 File Offset: 0x003C8804
	private ILayoutItem<InfluenceDisplayItem> InitItem(object influenceId, UUIItem uiItem, int index)
	{
		InfluenceDisplayItem influenceDisplayItem = new InfluenceDisplayItem(uiItem);
		influenceDisplayItem.UpdateItem((int)influenceId, this.CurrentCountryId);
		influenceDisplayItem.SetToggleFunction(new TToggleFunction(this.ToggleCallBack));
		influenceDisplayItem.SetIndex(index);
		return new LayoutItem<InfluenceDisplayItem>
		{
			Key = index,
			Value = influenceDisplayItem
		};
	}

	// Token: 0x0600FA53 RID: 64083 RVA: 0x003CA65C File Offset: 0x003C885C
	private void ToggleCallBack(EToggleState state, int index)
	{
		if (state == EToggleState.ETT_UnChecked)
		{
			int? selectedIndex = this.SelectedIndex;
			if (selectedIndex.GetValueOrDefault() == index & selectedIndex != null)
			{
				this.SelectedIndex = null;
				this.RefreshArrow();
				this.ShowHideContentDisActiveButton(false);
			}
			return;
		}
		int? selectedIndex2 = this.SelectedIndex;
		this.SelectedIndex = new int?(index);
		if (selectedIndex2 != null)
		{
			this.ScrollView.GetScrollItemByKey(selectedIndex2.Value).SetDisActiveToggleState();
		}
		else
		{
			this.RefreshArrow();
		}
		this.ScrollToDirty = true;
		this.ShowHideContentDisActiveButton(true);
	}

	// Token: 0x0600FA54 RID: 64084 RVA: 0x003CA6F4 File Offset: 0x003C88F4
	private void ScrollValueChange(FVector2D progress)
	{
		if (!this.IsExpand)
		{
			return;
		}
		float num = MathUtils.Instance.Clamp(progress.X, 0f, 1f);
		if (this.ScrollValueX == num)
		{
			return;
		}
		this.ScrollValueX = num;
		this.RefreshArrow();
	}

	// Token: 0x0600FA55 RID: 64085 RVA: 0x003CA73C File Offset: 0x003C893C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshInfluencePanel, new Action<int>(this.RefreshPanel));
		EventSystem.Instance.Add<int, int>(EEventName.SearchInfluence, new Action<int, int>(this.SearchInfluence));
	}

	// Token: 0x0600FA56 RID: 64086 RVA: 0x003CA776 File Offset: 0x003C8976
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshInfluencePanel, new Action<int>(this.RefreshPanel));
		EventSystem.Instance.Remove(EEventName.SearchInfluence, new Action<int, int>(this.SearchInfluence));
	}

	// Token: 0x0600FA57 RID: 64087 RVA: 0x003CA7B0 File Offset: 0x003C89B0
	private void RefreshPanel(int countryId)
	{
		this.CurrentCountryId = countryId;
		this.RefreshView();
	}

	// Token: 0x0600FA58 RID: 64088 RVA: 0x003CA7BF File Offset: 0x003C89BF
	private void SearchInfluence(int influenceId, int countryId)
	{
		this.CurrentCountryId = countryId;
		this.RefreshView();
		this.SelectInfluence(influenceId);
	}

	// Token: 0x0600FA59 RID: 64089 RVA: 0x003CA7D5 File Offset: 0x003C89D5
	protected override void OnAfterShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600FA5A RID: 64090 RVA: 0x003CA7DD File Offset: 0x003C89DD
	protected override void OnBeforeDestroy()
	{
		this.ScrollView.ClearChildren();
		this.ScrollView = null;
		this.RightArrow = null;
		this.LeftArrow = null;
	}

	// Token: 0x0600FA5B RID: 64091 RVA: 0x003CA800 File Offset: 0x003C8A00
	private void RefreshView()
	{
		Country? countryConfig = InfluenceConfig.Instance.GetCountryConfig(this.CurrentCountryId);
		if (countryConfig == null)
		{
			return;
		}
		Country value = countryConfig.Value;
		List<int> list = new List<int>();
		foreach (int num in value.Influences())
		{
			if (num != 0)
			{
				list.Add(num);
			}
		}
		this.InfluenceList = list.ToArray();
		this.RefreshScrollView();
		this.RefreshCountryName(value.Title);
		this.RefreshUnLock();
		this.RefreshSwitchRedDot();
		this.ShowHideContentDisActiveButton(false);
	}

	// Token: 0x0600FA5C RID: 64092 RVA: 0x003CA894 File Offset: 0x003C8A94
	private void SelectInfluence(int influenceId)
	{
		int num = Array.IndexOf<int>(this.InfluenceList, influenceId);
		this.ScrollView.GetScrollItemByKey(num).SetToggleState(EToggleState.ETT_Checked, true);
	}

	// Token: 0x0600FA5D RID: 64093 RVA: 0x003CA8C8 File Offset: 0x003C8AC8
	private void RefreshScrollView()
	{
		this.SelectedIndex = null;
		this.ScrollView.RefreshByData<int>(this.InfluenceList.ToList<int>(), null);
		this.RefreshArrowDirty = true;
	}

	// Token: 0x0600FA5E RID: 64094 RVA: 0x003CA907 File Offset: 0x003C8B07
	private void RefreshCountryName(string title)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), title, Array.Empty<object>());
	}

	// Token: 0x0600FA5F RID: 64095 RVA: 0x003CA920 File Offset: 0x003C8B20
	private void RefreshUnLock()
	{
		int num = 0;
		using (Dictionary<object, InfluenceDisplayItem>.ValueCollection.Enumerator enumerator = this.ScrollView.GetScrollItemMap().Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.IsUnLock())
				{
					num++;
				}
			}
		}
		base.GetText(8).SetText(num.ToString(), true);
		base.GetText(9).SetText(this.InfluenceList.Length.ToString(), true);
	}

	// Token: 0x0600FA60 RID: 64096 RVA: 0x003CA9B4 File Offset: 0x003C8BB4
	private void RefreshSwitchRedDot()
	{
		bool uiactive = InfluenceReputationModel.Instance.HasRedDotExcludeCurrentCountry(this.CurrentCountryId);
		base.GetItem(11).SetUIActive(uiactive);
	}

	// Token: 0x0600FA61 RID: 64097 RVA: 0x003CA9E0 File Offset: 0x003C8BE0
	private void RefreshArrow()
	{
		if (!this.IsExpand || this.SelectedIndex != null)
		{
			if (this.LeftArrowActive)
			{
				this.LeftArrowActive = false;
				this.LeftArrow.SetUIActive(false);
			}
			if (this.RightArrowActive)
			{
				this.RightArrowActive = false;
				this.RightArrow.SetUIActive(false);
			}
			return;
		}
		bool flag = this.ScrollValueX < 0.95f;
		if (this.LeftArrowActive != flag)
		{
			this.LeftArrowActive = flag;
			this.LeftArrow.SetUIActive(flag);
		}
		bool flag2 = this.ScrollValueX > 0.05f;
		if (this.RightArrowActive != flag2)
		{
			this.RightArrowActive = flag2;
			this.RightArrow.SetUIActive(flag2);
		}
	}

	// Token: 0x0600FA62 RID: 64098 RVA: 0x003CAA90 File Offset: 0x003C8C90
	private void ShowHideContentDisActiveButton(bool bShow)
	{
		base.GetButton(10).RootUIComp.Get().SetUIActive(bShow);
	}

	// Token: 0x0600FA63 RID: 64099 RVA: 0x003CAAB8 File Offset: 0x003C8CB8
	private void ScrollTo()
	{
		int count = this.ScrollView.GetScrollItemMap().Count;
		int? selectedIndex = this.SelectedIndex;
		int num = count - 1;
		if (selectedIndex.GetValueOrDefault() == num & selectedIndex != null)
		{
			this.ScrollView.ScrollToLeft(this.SelectedIndex.Value - 1);
			return;
		}
		this.ScrollView.ScrollToLeft(this.SelectedIndex.Value);
	}

	// Token: 0x0600FA64 RID: 64100 RVA: 0x003CAB2C File Offset: 0x003C8D2C
	private void LateUpdate(float deltaTime)
	{
		if (this.ScrollToDirty)
		{
			this.ScrollToDirty = false;
			this.ScrollTo();
		}
		if (this.RefreshArrowDirty)
		{
			this.RefreshArrowDirty = false;
			this.IsExpand = this.ScrollView.IsExpand;
			this.RefreshArrow();
		}
	}

	// Token: 0x04007498 RID: 29848
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<InfluenceDisplayItem> ScrollView;

	// Token: 0x04007499 RID: 29849
	private int CurrentCountryId;

	// Token: 0x0400749A RID: 29850
	private int? SelectedIndex = new int?(0);

	// Token: 0x0400749B RID: 29851
	private float ScrollValueX;

	// Token: 0x0400749C RID: 29852
	private bool IsExpand;

	// Token: 0x0400749D RID: 29853
	private bool LeftArrowActive;

	// Token: 0x0400749E RID: 29854
	private bool RightArrowActive;

	// Token: 0x0400749F RID: 29855
	[Nullable(2)]
	private UUIItem LeftArrow;

	// Token: 0x040074A0 RID: 29856
	[Nullable(2)]
	private UUIItem RightArrow;

	// Token: 0x040074A1 RID: 29857
	private int[] InfluenceList = new int[0];

	// Token: 0x040074A2 RID: 29858
	private bool ScrollToDirty;

	// Token: 0x040074A3 RID: 29859
	private bool RefreshArrowDirty;

	// Token: 0x0200856F RID: 34159
	[NullableContext(0)]
	private enum EInfluenceReputationView
	{
		// Token: 0x0402B71B RID: 177947
		CloseButton,
		// Token: 0x0402B71C RID: 177948
		InfluenceScrollView,
		// Token: 0x0402B71D RID: 177949
		LeftArrow,
		// Token: 0x0402B71E RID: 177950
		RightArrow,
		// Token: 0x0402B71F RID: 177951
		InfluenceSwitch,
		// Token: 0x0402B720 RID: 177952
		InfluenceSearch,
		// Token: 0x0402B721 RID: 177953
		CharacterTexture,
		// Token: 0x0402B722 RID: 177954
		CountryName,
		// Token: 0x0402B723 RID: 177955
		InfluenceUnLockText,
		// Token: 0x0402B724 RID: 177956
		InfluenceAllText,
		// Token: 0x0402B725 RID: 177957
		ContentDisActiveButton,
		// Token: 0x0402B726 RID: 177958
		SwitchRedDot
	}
}
