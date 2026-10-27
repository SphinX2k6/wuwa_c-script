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

// Token: 0x020016D7 RID: 5847
[NullableContext(1)]
[Nullable(0)]
public class AdviceMutiSentenceSelectView : UiViewBase
{
	// Token: 0x0600A767 RID: 42855 RVA: 0x00258D5C File Offset: 0x00256F5C
	public AdviceMutiSentenceSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A768 RID: 42856 RVA: 0x00258D68 File Offset: 0x00256F68
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

	// Token: 0x0600A769 RID: 42857 RVA: 0x00258E6C File Offset: 0x0025706C
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

	// Token: 0x0600A76A RID: 42858 RVA: 0x00258F78 File Offset: 0x00257178
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

	// Token: 0x0600A76B RID: 42859 RVA: 0x00258FB0 File Offset: 0x002571B0
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

	// Token: 0x0600A76C RID: 42860 RVA: 0x00258FE8 File Offset: 0x002571E8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
	}

	// Token: 0x0600A76D RID: 42861 RVA: 0x00259006 File Offset: 0x00257206
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnClickAdviceSort, new Action(this.RefreshAdviceSort));
	}

	// Token: 0x0600A76E RID: 42862 RVA: 0x00259024 File Offset: 0x00257224
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

	// Token: 0x0600A76F RID: 42863 RVA: 0x0025911C File Offset: 0x0025731C
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A770 RID: 42864 RVA: 0x00259125 File Offset: 0x00257325
	private void RefreshTitle()
	{
		LguiUtil.Instance.SetLocalText(base.GetText(7), "AdvicePutSentence", Array.Empty<object>());
	}

	// Token: 0x0600A771 RID: 42865 RVA: 0x00259144 File Offset: 0x00257344
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

	// Token: 0x0600A772 RID: 42866 RVA: 0x002591B0 File Offset: 0x002573B0
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

	// Token: 0x0600A773 RID: 42867 RVA: 0x00259202 File Offset: 0x00257402
	private float GetWordTypeProgress()
	{
		return (float)AdviceModel.Instance.CurrentSentenceSelectIndex;
	}

	// Token: 0x0600A774 RID: 42868 RVA: 0x00259210 File Offset: 0x00257410
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

	// Token: 0x0600A775 RID: 42869 RVA: 0x002592B8 File Offset: 0x002574B8
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

	// Token: 0x0600A776 RID: 42870 RVA: 0x00259330 File Offset: 0x00257530
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

	// Token: 0x0600A777 RID: 42871 RVA: 0x002593B2 File Offset: 0x002575B2
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

	// Token: 0x04004B85 RID: 19333
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004B86 RID: 19334
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceSentenceSelectItem> AdviceSentenceSelectScroller;

	// Token: 0x04004B87 RID: 19335
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceSentenceSelectItemContent> AdviceWordScroller;

	// Token: 0x04004B88 RID: 19336
	private bool AdviceWordScrollerScrollToDirty;

	// Token: 0x04004B89 RID: 19337
	private int AdviceWordFlag;

	// Token: 0x04004B8A RID: 19338
	private bool AdviceSentenceSelectScrollerScrollToDirty;

	// Token: 0x04004B8B RID: 19339
	private int AdviceWordTypeFlag;

	// Token: 0x02007CAB RID: 31915
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E4C RID: 167500
		public const int SortScroller = 0;

		// Token: 0x04028E4D RID: 167501
		public const int SortItem = 1;

		// Token: 0x04028E4E RID: 167502
		public const int WordScroller = 2;

		// Token: 0x04028E4F RID: 167503
		public const int WordItem = 3;

		// Token: 0x04028E50 RID: 167504
		public const int ConfirmBtn = 4;

		// Token: 0x04028E51 RID: 167505
		public const int CancelBtn = 5;

		// Token: 0x04028E52 RID: 167506
		public const int ScrollerBar = 6;

		// Token: 0x04028E53 RID: 167507
		public const int TitleText = 7;
	}
}
