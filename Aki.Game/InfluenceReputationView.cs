using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001446 RID: 5190
[NullableContext(1)]
[Nullable(0)]
public class InfluenceReputationView : UiViewBase
{
	// Token: 0x0600CE67 RID: 52839 RVA: 0x003D5BBB File Offset: 0x003D3DBB
	public InfluenceReputationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CE68 RID: 52840 RVA: 0x003D5BDC File Offset: 0x003D3DDC
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

	// Token: 0x0600CE69 RID: 52841 RVA: 0x003D5E80 File Offset: 0x003D4080
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CE6A RID: 52842 RVA: 0x003D5E89 File Offset: 0x003D4089
	private void SearchClick()
	{
		UiManager.Instance.OpenView(EUiViewName.InfluenceSearchView, this.CurrentCountryId, null);
	}

	// Token: 0x0600CE6B RID: 52843 RVA: 0x003D5EA6 File Offset: 0x003D40A6
	private void SwitchClick()
	{
		UiManager.Instance.OpenView(EUiViewName.InfluenceAreaSelectView, this.CurrentCountryId, null);
	}

	// Token: 0x0600CE6C RID: 52844 RVA: 0x003D5EC4 File Offset: 0x003D40C4
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

	// Token: 0x0600CE6D RID: 52845 RVA: 0x003D5F68 File Offset: 0x003D4168
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

	// Token: 0x0600CE6E RID: 52846 RVA: 0x003D6008 File Offset: 0x003D4208
	private void DisActiveClick()
	{
		this.ShowHideContentDisActiveButton(false);
		if (this.SelectedIndex != null)
		{
			this.ScrollView.GetScrollItemByKey(this.SelectedIndex.Value).SetDisActiveToggleState();
			this.SelectedIndex = null;
		}
	}

	// Token: 0x0600CE6F RID: 52847 RVA: 0x003D6055 File Offset: 0x003D4255
	protected override void OnBeforeCreate()
	{
		this.CurrentCountryId = (int)this.OpenParam;
	}

	// Token: 0x0600CE70 RID: 52848 RVA: 0x003D6068 File Offset: 0x003D4268
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

	// Token: 0x0600CE71 RID: 52849 RVA: 0x003D6140 File Offset: 0x003D4340
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

	// Token: 0x0600CE72 RID: 52850 RVA: 0x003D6198 File Offset: 0x003D4398
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

	// Token: 0x0600CE73 RID: 52851 RVA: 0x003D6230 File Offset: 0x003D4430
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

	// Token: 0x0600CE74 RID: 52852 RVA: 0x003D6278 File Offset: 0x003D4478
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<int>(EEventName.RefreshInfluencePanel, new Action<int>(this.RefreshPanel));
		EventSystem.Instance.Add<int, int>(EEventName.SearchInfluence, new Action<int, int>(this.SearchInfluence));
	}

	// Token: 0x0600CE75 RID: 52853 RVA: 0x003D62B2 File Offset: 0x003D44B2
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.RefreshInfluencePanel, new Action<int>(this.RefreshPanel));
		EventSystem.Instance.Remove(EEventName.SearchInfluence, new Action<int, int>(this.SearchInfluence));
	}

	// Token: 0x0600CE76 RID: 52854 RVA: 0x003D62EC File Offset: 0x003D44EC
	private void RefreshPanel(int countryId)
	{
		this.CurrentCountryId = countryId;
		this.RefreshView();
	}

	// Token: 0x0600CE77 RID: 52855 RVA: 0x003D62FB File Offset: 0x003D44FB
	private void SearchInfluence(int influenceId, int countryId)
	{
		this.CurrentCountryId = countryId;
		this.RefreshView();
		this.SelectInfluence(influenceId);
	}

	// Token: 0x0600CE78 RID: 52856 RVA: 0x003D6311 File Offset: 0x003D4511
	protected override void OnAfterShow()
	{
		this.RefreshView();
	}

	// Token: 0x0600CE79 RID: 52857 RVA: 0x003D6319 File Offset: 0x003D4519
	protected override void OnBeforeDestroy()
	{
		this.ScrollView.ClearChildren();
		this.ScrollView = null;
		this.RightArrow = null;
		this.LeftArrow = null;
	}

	// Token: 0x0600CE7A RID: 52858 RVA: 0x003D633C File Offset: 0x003D453C
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

	// Token: 0x0600CE7B RID: 52859 RVA: 0x003D63D0 File Offset: 0x003D45D0
	private void SelectInfluence(int influenceId)
	{
		int num = Array.IndexOf<int>(this.InfluenceList, influenceId);
		this.ScrollView.GetScrollItemByKey(num).SetToggleState(EToggleState.ETT_Checked, true);
	}

	// Token: 0x0600CE7C RID: 52860 RVA: 0x003D6404 File Offset: 0x003D4604
	private void RefreshScrollView()
	{
		this.SelectedIndex = null;
		this.ScrollView.RefreshByData<int>(this.InfluenceList, null);
		this.RefreshArrowDirty = true;
	}

	// Token: 0x0600CE7D RID: 52861 RVA: 0x003D643E File Offset: 0x003D463E
	private void RefreshCountryName(string title)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), title, Array.Empty<object>());
	}

	// Token: 0x0600CE7E RID: 52862 RVA: 0x003D6458 File Offset: 0x003D4658
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

	// Token: 0x0600CE7F RID: 52863 RVA: 0x003D64EC File Offset: 0x003D46EC
	private void RefreshSwitchRedDot()
	{
		bool uiactive = InfluenceReputationModel.Instance.HasRedDotExcludeCurrentCountry(this.CurrentCountryId);
		base.GetItem(11).SetUIActive(uiactive);
	}

	// Token: 0x0600CE80 RID: 52864 RVA: 0x003D6518 File Offset: 0x003D4718
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

	// Token: 0x0600CE81 RID: 52865 RVA: 0x003D65C8 File Offset: 0x003D47C8
	private void ShowHideContentDisActiveButton(bool bShow)
	{
		base.GetButton(10).RootUIComp.Get().SetUIActive(bShow);
	}

	// Token: 0x0600CE82 RID: 52866 RVA: 0x003D65F0 File Offset: 0x003D47F0
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

	// Token: 0x0600CE83 RID: 52867 RVA: 0x003D6664 File Offset: 0x003D4864
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

	// Token: 0x04007579 RID: 30073
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<InfluenceDisplayItem> ScrollView;

	// Token: 0x0400757A RID: 30074
	private int CurrentCountryId;

	// Token: 0x0400757B RID: 30075
	private int? SelectedIndex = new int?(0);

	// Token: 0x0400757C RID: 30076
	private float ScrollValueX;

	// Token: 0x0400757D RID: 30077
	private bool IsExpand;

	// Token: 0x0400757E RID: 30078
	private bool LeftArrowActive;

	// Token: 0x0400757F RID: 30079
	private bool RightArrowActive;

	// Token: 0x04007580 RID: 30080
	[Nullable(2)]
	private UUIItem LeftArrow;

	// Token: 0x04007581 RID: 30081
	[Nullable(2)]
	private UUIItem RightArrow;

	// Token: 0x04007582 RID: 30082
	private int[] InfluenceList = new int[0];

	// Token: 0x04007583 RID: 30083
	private bool ScrollToDirty;

	// Token: 0x04007584 RID: 30084
	private bool RefreshArrowDirty;

	// Token: 0x020076F4 RID: 30452
	[NullableContext(0)]
	private enum EInfluenceReputationView
	{
		// Token: 0x04026A3E RID: 158270
		CloseButton,
		// Token: 0x04026A3F RID: 158271
		InfluenceScrollView,
		// Token: 0x04026A40 RID: 158272
		LeftArrow,
		// Token: 0x04026A41 RID: 158273
		RightArrow,
		// Token: 0x04026A42 RID: 158274
		InfluenceSwitch,
		// Token: 0x04026A43 RID: 158275
		InfluenceSearch,
		// Token: 0x04026A44 RID: 158276
		CharacterTexture,
		// Token: 0x04026A45 RID: 158277
		CountryName,
		// Token: 0x04026A46 RID: 158278
		InfluenceUnLockText,
		// Token: 0x04026A47 RID: 158279
		InfluenceAllText,
		// Token: 0x04026A48 RID: 158280
		ContentDisActiveButton,
		// Token: 0x04026A49 RID: 158281
		SwitchRedDot
	}
}
