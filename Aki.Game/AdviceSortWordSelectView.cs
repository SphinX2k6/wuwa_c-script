using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Advice;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016DC RID: 5852
[NullableContext(1)]
[Nullable(0)]
public class AdviceSortWordSelectView : UiViewBase
{
	// Token: 0x0600A79E RID: 42910 RVA: 0x00259E58 File Offset: 0x00258058
	public AdviceSortWordSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A79F RID: 42911 RVA: 0x00259E64 File Offset: 0x00258064
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x0600A7A0 RID: 42912 RVA: 0x00259F68 File Offset: 0x00258168
	protected override void OnStart()
	{
		this.AdviceWordTypeScroller = new GenericScrollView<AdviceWordTypeItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceWordTypeItem>(this.CreateSortItem), null);
		this.AdviceWordScroller = new GenericScrollView<AdviceWordItem>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceWordItem>(this.CreateWordItem), null);
		UUIItem tempOriginalItem = this.AdviceWordScroller.TempOriginalItem;
		if (tempOriginalItem != null)
		{
			AActor owner = tempOriginalItem.GetOwner();
			if (owner != null)
			{
				UUIButtonComponent uuibuttonComponent = owner.GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent;
				if (uuibuttonComponent != null)
				{
					owner.K2_DestroyComponent(uuibuttonComponent);
				}
			}
		}
		AdviceModel.Instance.PreSelectSortTypeId = AdviceModel.Instance.CurrentSelectSortTypeId;
		AdviceModel.Instance.PreSelectSortWordId = AdviceModel.Instance.CurrentSelectSortWordId;
		this.RefreshAdviceSort();
		this.RefreshTitle();
	}

	// Token: 0x0600A7A1 RID: 42913 RVA: 0x0025A020 File Offset: 0x00258220
	private ILayoutItem<AdviceWordTypeItem> CreateSortItem(object data, UUIItem uiItem, int index)
	{
		AdviceWordTypeItem adviceWordTypeItem = new AdviceWordTypeItem(uiItem);
		adviceWordTypeItem.UpdateItem((int)data);
		return new LayoutItem<AdviceWordTypeItem>
		{
			Key = index,
			Value = adviceWordTypeItem
		};
	}

	// Token: 0x0600A7A2 RID: 42914 RVA: 0x0025A058 File Offset: 0x00258258
	private ILayoutItem<AdviceWordItem> CreateWordItem(object data, UUIItem uiItem, int index)
	{
		AdviceWordItem adviceWordItem = new AdviceWordItem(uiItem);
		adviceWordItem.UpdateItem((int)data);
		return new LayoutItem<AdviceWordItem>
		{
			Key = index,
			Value = adviceWordItem
		};
	}

	// Token: 0x0600A7A3 RID: 42915 RVA: 0x0025A090 File Offset: 0x00258290
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSortWord));
	}

	// Token: 0x0600A7A4 RID: 42916 RVA: 0x0025A0AE File Offset: 0x002582AE
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSortWord));
	}

	// Token: 0x0600A7A5 RID: 42917 RVA: 0x0025A0CC File Offset: 0x002582CC
	private void OnClickConfirmBtn()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentWordMap[instance.CurrentSelectWordIndex] = instance.PreSelectSortWordId;
		base.CloseMe(null);
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceWord);
	}

	// Token: 0x0600A7A6 RID: 42918 RVA: 0x0025A10D File Offset: 0x0025830D
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A7A7 RID: 42919 RVA: 0x0025A116 File Offset: 0x00258316
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(7), "AdviceSelectWord", Array.Empty<object>());
	}

	// Token: 0x0600A7A8 RID: 42920 RVA: 0x0025A134 File Offset: 0x00258334
	private void RefreshAdviceSort()
	{
		IReadOnlyList<AdviceWordType> adviceWordTypeConfigs = AdviceConfig.Instance.GetAdviceWordTypeConfigs();
		List<int> list = new List<int>();
		if (adviceWordTypeConfigs != null)
		{
			foreach (AdviceWordType adviceWordType in adviceWordTypeConfigs)
			{
				list.Add(adviceWordType.Id);
			}
		}
		this.AdviceWordTypeScroller.RefreshByData<int>(list, null);
		this.RefreshAdviceSortWord();
		this.AdviceWordTypeFlag = 0;
		this.AdviceWordTypeScroller.UnBindLateUpdate();
		this.AdviceWordTypeScrollerScrollToDirty = true;
		this.AdviceWordTypeScroller.BindLateUpdate(new Action<float>(this.AdviceWordTypeScrollerLateUpdate));
	}

	// Token: 0x0600A7A9 RID: 42921 RVA: 0x0025A1E4 File Offset: 0x002583E4
	private void AdviceWordTypeScrollerLateUpdate(float deltaTime)
	{
		if (this.AdviceWordTypeScrollerScrollToDirty && this.AdviceWordTypeFlag >= 1)
		{
			this.AdviceWordTypeScrollerScrollToDirty = false;
			float wordTypeProgress = this.GetWordTypeProgress();
			base.GetScrollViewWithScrollbar(0).SetScrollProgress(wordTypeProgress);
			this.AdviceWordTypeScroller.UnBindLateUpdate();
		}
		this.AdviceWordTypeFlag++;
	}

	// Token: 0x0600A7AA RID: 42922 RVA: 0x0025A238 File Offset: 0x00258438
	private float GetWordTypeProgress()
	{
		IReadOnlyList<AdviceWordType> adviceWordTypeConfigs = AdviceConfig.Instance.GetAdviceWordTypeConfigs();
		int num = 0;
		if (adviceWordTypeConfigs == null)
		{
			return 0f;
		}
		for (int i = 0; i < adviceWordTypeConfigs.Count; i++)
		{
			if (adviceWordTypeConfigs[i].Id == AdviceModel.Instance.PreSelectSortTypeId)
			{
				num = i;
				break;
			}
		}
		if (adviceWordTypeConfigs.Count > 1)
		{
			return (float)num / (float)(adviceWordTypeConfigs.Count - 1);
		}
		return 0f;
	}

	// Token: 0x0600A7AB RID: 42923 RVA: 0x0025A2A8 File Offset: 0x002584A8
	private void RefreshAdviceSortWord()
	{
		int preSelectSortTypeId = AdviceModel.Instance.PreSelectSortTypeId;
		IReadOnlyList<AdviceWord> adviceWordConfigsByType = AdviceConfig.Instance.GetAdviceWordConfigsByType(preSelectSortTypeId);
		List<int> list = new List<int>();
		if (adviceWordConfigsByType != null)
		{
			foreach (AdviceWord adviceWord in adviceWordConfigsByType)
			{
				list.Add(adviceWord.Id);
			}
		}
		this.AdviceWordScroller.RefreshByData<int>(list, null);
		this.AdviceWordFlag = 0;
		this.AdviceWordScroller.UnBindLateUpdate();
		this.AdviceWordScrollerScrollToDirty = true;
		this.AdviceWordScroller.BindLateUpdate(new Action<float>(this.AdviceWordScrollerLateUpdate));
	}

	// Token: 0x0600A7AC RID: 42924 RVA: 0x0025A360 File Offset: 0x00258560
	private void AdviceWordScrollerLateUpdate(float deltaTime)
	{
		if (this.AdviceWordScrollerScrollToDirty && this.AdviceWordFlag >= 1)
		{
			this.AdviceWordScrollerScrollToDirty = false;
			float wordProgress = this.GetWordProgress();
			base.GetScrollViewWithScrollbar(2).SetScrollProgress(wordProgress);
		}
		if (this.AdviceWordFlag >= 2)
		{
			float wordProgress2 = this.GetWordProgress();
			UUIScrollbarComponent scrollScrollbar = base.GetScrollScrollbar(6);
			if (scrollScrollbar != null)
			{
				scrollScrollbar.SetValue(wordProgress2, true);
			}
			this.AdviceWordScroller.UnBindLateUpdate();
		}
		this.AdviceWordFlag++;
	}

	// Token: 0x0600A7AD RID: 42925 RVA: 0x0025A3D8 File Offset: 0x002585D8
	private float GetWordProgress()
	{
		int preSelectSortTypeId = AdviceModel.Instance.PreSelectSortTypeId;
		IReadOnlyList<AdviceWord> adviceWordConfigsByType = AdviceConfig.Instance.GetAdviceWordConfigsByType(preSelectSortTypeId);
		int num = 0;
		if (adviceWordConfigsByType == null)
		{
			return 0f;
		}
		for (int i = 0; i < adviceWordConfigsByType.Count; i++)
		{
			if (adviceWordConfigsByType[i].Id == AdviceModel.Instance.PreSelectSortWordId)
			{
				num = i;
				break;
			}
		}
		if (adviceWordConfigsByType.Count > 1)
		{
			return (float)num / (float)(adviceWordConfigsByType.Count - 1);
		}
		return 0f;
	}

	// Token: 0x0600A7AE RID: 42926 RVA: 0x0025A453 File Offset: 0x00258653
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceWordTypeItem> adviceWordTypeScroller = this.AdviceWordTypeScroller;
		if (adviceWordTypeScroller != null)
		{
			adviceWordTypeScroller.ClearChildren();
		}
		this.AdviceWordTypeScroller = null;
		GenericScrollView<AdviceWordItem> adviceWordScroller = this.AdviceWordScroller;
		if (adviceWordScroller != null)
		{
			adviceWordScroller.ClearChildren();
		}
		this.AdviceWordScroller = null;
	}

	// Token: 0x04004B91 RID: 19345
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004B92 RID: 19346
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceWordTypeItem> AdviceWordTypeScroller;

	// Token: 0x04004B93 RID: 19347
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceWordItem> AdviceWordScroller;

	// Token: 0x04004B94 RID: 19348
	private bool AdviceWordScrollerScrollToDirty;

	// Token: 0x04004B95 RID: 19349
	private int AdviceWordFlag;

	// Token: 0x04004B96 RID: 19350
	private bool AdviceWordTypeScrollerScrollToDirty;

	// Token: 0x04004B97 RID: 19351
	private int AdviceWordTypeFlag;

	// Token: 0x02007CB0 RID: 31920
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E63 RID: 167523
		public const int SortScroller = 0;

		// Token: 0x04028E64 RID: 167524
		public const int SortItem = 1;

		// Token: 0x04028E65 RID: 167525
		public const int WordScroller = 2;

		// Token: 0x04028E66 RID: 167526
		public const int WordItem = 3;

		// Token: 0x04028E67 RID: 167527
		public const int CancelBtn = 4;

		// Token: 0x04028E68 RID: 167528
		public const int ConfirmBtn = 5;

		// Token: 0x04028E69 RID: 167529
		public const int ScrollerBar = 6;

		// Token: 0x04028E6A RID: 167530
		public const int TitleText = 7;
	}
}
