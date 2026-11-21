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

// Token: 0x02000B94 RID: 2964
[NullableContext(1)]
[Nullable(0)]
public class AdviceSortWordSelectView : UiViewBase
{
	// Token: 0x06007B7E RID: 31614 RVA: 0x00264260 File Offset: 0x00262460
	public AdviceSortWordSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007B7F RID: 31615 RVA: 0x0026426C File Offset: 0x0026246C
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

	// Token: 0x06007B80 RID: 31616 RVA: 0x00264370 File Offset: 0x00262570
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

	// Token: 0x06007B81 RID: 31617 RVA: 0x00264428 File Offset: 0x00262628
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

	// Token: 0x06007B82 RID: 31618 RVA: 0x00264460 File Offset: 0x00262660
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

	// Token: 0x06007B83 RID: 31619 RVA: 0x00264498 File Offset: 0x00262698
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSortWord));
	}

	// Token: 0x06007B84 RID: 31620 RVA: 0x002644B6 File Offset: 0x002626B6
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSortWord));
	}

	// Token: 0x06007B85 RID: 31621 RVA: 0x002644D4 File Offset: 0x002626D4
	private void OnClickConfirmBtn()
	{
		AdviceModel instance = AdviceModel.Instance;
		instance.CurrentWordMap[instance.CurrentSelectWordIndex] = instance.PreSelectSortWordId;
		base.CloseMe(null);
		EventSystem.Instance.Emit(EEventName.OnSelectAdviceWord);
	}

	// Token: 0x06007B86 RID: 31622 RVA: 0x00264515 File Offset: 0x00262715
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007B87 RID: 31623 RVA: 0x0026451E File Offset: 0x0026271E
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(7), "AdviceSelectWord", Array.Empty<object>());
	}

	// Token: 0x06007B88 RID: 31624 RVA: 0x0026453C File Offset: 0x0026273C
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

	// Token: 0x06007B89 RID: 31625 RVA: 0x002645EC File Offset: 0x002627EC
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

	// Token: 0x06007B8A RID: 31626 RVA: 0x00264640 File Offset: 0x00262840
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

	// Token: 0x06007B8B RID: 31627 RVA: 0x002646B0 File Offset: 0x002628B0
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

	// Token: 0x06007B8C RID: 31628 RVA: 0x00264768 File Offset: 0x00262968
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

	// Token: 0x06007B8D RID: 31629 RVA: 0x002647E0 File Offset: 0x002629E0
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

	// Token: 0x06007B8E RID: 31630 RVA: 0x0026485B File Offset: 0x00262A5B
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

	// Token: 0x04004C38 RID: 19512
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004C39 RID: 19513
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceWordTypeItem> AdviceWordTypeScroller;

	// Token: 0x04004C3A RID: 19514
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceWordItem> AdviceWordScroller;

	// Token: 0x04004C3B RID: 19515
	private bool AdviceWordScrollerScrollToDirty;

	// Token: 0x04004C3C RID: 19516
	private int AdviceWordFlag;

	// Token: 0x04004C3D RID: 19517
	private bool AdviceWordTypeScrollerScrollToDirty;

	// Token: 0x04004C3E RID: 19518
	private int AdviceWordTypeFlag;

	// Token: 0x02006E35 RID: 28213
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402418C RID: 147852
		public const int SortScroller = 0;

		// Token: 0x0402418D RID: 147853
		public const int SortItem = 1;

		// Token: 0x0402418E RID: 147854
		public const int WordScroller = 2;

		// Token: 0x0402418F RID: 147855
		public const int WordItem = 3;

		// Token: 0x04024190 RID: 147856
		public const int CancelBtn = 4;

		// Token: 0x04024191 RID: 147857
		public const int ConfirmBtn = 5;

		// Token: 0x04024192 RID: 147858
		public const int ScrollerBar = 6;

		// Token: 0x04024193 RID: 147859
		public const int TitleText = 7;
	}
}
