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

// Token: 0x02000B8F RID: 2959
[NullableContext(1)]
[Nullable(0)]
public class AdviceMutiSentenceSelectView : UiViewBase
{
	// Token: 0x06007B47 RID: 31559 RVA: 0x00263168 File Offset: 0x00261368
	public AdviceMutiSentenceSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007B48 RID: 31560 RVA: 0x00263174 File Offset: 0x00261374
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIScrollbarComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x06007B49 RID: 31561 RVA: 0x00263278 File Offset: 0x00261478
	protected override void OnStart()
	{
		this.AdviceSentenceSelectScroller = new GenericScrollView<AdviceSentenceSelectItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceSentenceSelectItem>(this.CreateSortItem), null);
		this.AdviceWordScroller = new GenericScrollView<AdviceSentenceSelectItemContent>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceSentenceSelectItemContent>(this.CreateWordItem), null);
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
		AdviceModel.Instance.CurrentSentenceSelectIndex = 0;
		AdviceModel.Instance.CurrentPreSentenceWordMap.Clear();
		foreach (KeyValuePair<int, int> keyValuePair in AdviceModel.Instance.CurrentSentenceWordMap)
		{
			AdviceModel.Instance.CurrentPreSentenceWordMap[keyValuePair.Key] = keyValuePair.Value;
		}
		this.RefreshAdviceSort();
		this.RefreshTitle();
	}

	// Token: 0x06007B4A RID: 31562 RVA: 0x00263384 File Offset: 0x00261584
	private ILayoutItem<AdviceSentenceSelectItem> CreateSortItem(object data, UUIItem uiItem, int index)
	{
		AdviceSentenceSelectItem adviceSentenceSelectItem = new AdviceSentenceSelectItem(uiItem);
		adviceSentenceSelectItem.UpdateItem((int)data);
		return new LayoutItem<AdviceSentenceSelectItem>
		{
			Key = index,
			Value = adviceSentenceSelectItem
		};
	}

	// Token: 0x06007B4B RID: 31563 RVA: 0x002633BC File Offset: 0x002615BC
	private ILayoutItem<AdviceSentenceSelectItemContent> CreateWordItem(object data, UUIItem uiItem, int index)
	{
		AdviceSentenceSelectItemContent adviceSentenceSelectItemContent = new AdviceSentenceSelectItemContent(uiItem);
		adviceSentenceSelectItemContent.UpdateItem((int)data);
		return new LayoutItem<AdviceSentenceSelectItemContent>
		{
			Key = index,
			Value = adviceSentenceSelectItemContent
		};
	}

	// Token: 0x06007B4C RID: 31564 RVA: 0x002633F4 File Offset: 0x002615F4
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
	}

	// Token: 0x06007B4D RID: 31565 RVA: 0x00263412 File Offset: 0x00261612
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
	}

	// Token: 0x06007B4E RID: 31566 RVA: 0x00263430 File Offset: 0x00261630
	private void OnClickConfirmBtn()
	{
		foreach (KeyValuePair<int, int> keyValuePair in AdviceModel.Instance.CurrentPreSentenceWordMap)
		{
			int num;
			AdviceModel.Instance.CurrentSentenceWordMap.TryGetValue(keyValuePair.Key, out num);
			if (num != keyValuePair.Value)
			{
				AdviceModel.Instance.OnChangeSentence(keyValuePair.Key);
			}
		}
		foreach (KeyValuePair<int, int> keyValuePair2 in AdviceModel.Instance.CurrentPreSentenceWordMap)
		{
			AdviceModel.Instance.CurrentSentenceWordMap[keyValuePair2.Key] = keyValuePair2.Value;
		}
		base.CloseMe(null);
		EventSystem.Instance.Emit(EEventName.OnChangeAdviceWord);
	}

	// Token: 0x06007B4F RID: 31567 RVA: 0x00263528 File Offset: 0x00261728
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007B50 RID: 31568 RVA: 0x00263531 File Offset: 0x00261731
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(7), "AdvicePutSentence", Array.Empty<object>());
	}

	// Token: 0x06007B51 RID: 31569 RVA: 0x00263550 File Offset: 0x00261750
	private void RefreshAdviceSort()
	{
		List<int> data = new List<int>
		{
			0,
			1
		};
		this.AdviceSentenceSelectScroller.RefreshByData<int>(data, null);
		this.RefreshAdviceSortWord();
		this.AdviceWordTypeFlag = 0;
		this.AdviceSentenceSelectScroller.UnBindLateUpdate();
		this.AdviceSentenceSelectScrollerScrollToDirty = true;
		this.AdviceSentenceSelectScroller.BindLateUpdate(new Action<float>(this.AdviceSentenceSelectScrollerLateUpdate));
	}

	// Token: 0x06007B52 RID: 31570 RVA: 0x002635BC File Offset: 0x002617BC
	private void AdviceSentenceSelectScrollerLateUpdate(float deltaTime)
	{
		if (this.AdviceSentenceSelectScrollerScrollToDirty && this.AdviceWordTypeFlag >= 1)
		{
			this.AdviceSentenceSelectScrollerScrollToDirty = false;
			float wordTypeProgress = this.GetWordTypeProgress();
			base.GetScrollViewWithScrollbar(0).SetScrollProgress(wordTypeProgress);
			this.AdviceSentenceSelectScroller.UnBindLateUpdate();
		}
		this.AdviceWordTypeFlag++;
	}

	// Token: 0x06007B53 RID: 31571 RVA: 0x0026360E File Offset: 0x0026180E
	private float GetWordTypeProgress()
	{
		return (float)AdviceModel.Instance.CurrentSentenceSelectIndex;
	}

	// Token: 0x06007B54 RID: 31572 RVA: 0x0026361C File Offset: 0x0026181C
	private void RefreshAdviceSortWord()
	{
		List<int> list = new List<int>();
		IReadOnlyList<AdviceSentence> adviceSentenceConfigs = AdviceConfig.Instance.GetAdviceSentenceConfigs();
		if (adviceSentenceConfigs != null)
		{
			foreach (AdviceSentence adviceSentence in adviceSentenceConfigs)
			{
				list.Add(adviceSentence.Id);
			}
		}
		this.AdviceWordScroller.RefreshByData<int>(list, null);
		this.AdviceWordFlag = 0;
		this.AdviceWordScroller.UnBindLateUpdate();
		this.AdviceWordScrollerScrollToDirty = true;
		this.AdviceWordScroller.BindLateUpdate(new Action<float>(this.AdviceWordScrollerLateUpdate));
	}

	// Token: 0x06007B55 RID: 31573 RVA: 0x002636C4 File Offset: 0x002618C4
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

	// Token: 0x06007B56 RID: 31574 RVA: 0x0026373C File Offset: 0x0026193C
	private float GetWordProgress()
	{
		int num;
		AdviceModel.Instance.CurrentPreSentenceWordMap.TryGetValue(AdviceModel.Instance.CurrentSentenceSelectIndex, out num);
		IReadOnlyList<AdviceSentence> adviceSentenceConfigs = AdviceConfig.Instance.GetAdviceSentenceConfigs();
		int num2 = 0;
		if (adviceSentenceConfigs == null)
		{
			return 0f;
		}
		for (int i = 0; i < adviceSentenceConfigs.Count; i++)
		{
			if (adviceSentenceConfigs[i].Id == num)
			{
				num2 = i;
				break;
			}
		}
		if (adviceSentenceConfigs.Count > 1)
		{
			return (float)num2 / (float)(adviceSentenceConfigs.Count - 1);
		}
		return 0f;
	}

	// Token: 0x06007B57 RID: 31575 RVA: 0x002637BE File Offset: 0x002619BE
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceSentenceSelectItem> adviceSentenceSelectScroller = this.AdviceSentenceSelectScroller;
		if (adviceSentenceSelectScroller != null)
		{
			adviceSentenceSelectScroller.ClearChildren();
		}
		this.AdviceSentenceSelectScroller = null;
		GenericScrollView<AdviceSentenceSelectItemContent> adviceWordScroller = this.AdviceWordScroller;
		if (adviceWordScroller != null)
		{
			adviceWordScroller.ClearChildren();
		}
		this.AdviceWordScroller = null;
	}

	// Token: 0x04004C2C RID: 19500
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004C2D RID: 19501
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceSentenceSelectItem> AdviceSentenceSelectScroller;

	// Token: 0x04004C2E RID: 19502
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceSentenceSelectItemContent> AdviceWordScroller;

	// Token: 0x04004C2F RID: 19503
	private bool AdviceWordScrollerScrollToDirty;

	// Token: 0x04004C30 RID: 19504
	private int AdviceWordFlag;

	// Token: 0x04004C31 RID: 19505
	private bool AdviceSentenceSelectScrollerScrollToDirty;

	// Token: 0x04004C32 RID: 19506
	private int AdviceWordTypeFlag;

	// Token: 0x02006E30 RID: 28208
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04024175 RID: 147829
		public const int SortScroller = 0;

		// Token: 0x04024176 RID: 147830
		public const int SortItem = 1;

		// Token: 0x04024177 RID: 147831
		public const int WordScroller = 2;

		// Token: 0x04024178 RID: 147832
		public const int WordItem = 3;

		// Token: 0x04024179 RID: 147833
		public const int ConfirmBtn = 4;

		// Token: 0x0402417A RID: 147834
		public const int CancelBtn = 5;

		// Token: 0x0402417B RID: 147835
		public const int ScrollerBar = 6;

		// Token: 0x0402417C RID: 147836
		public const int TitleText = 7;
	}
}
