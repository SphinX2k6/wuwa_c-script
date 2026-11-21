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

// Token: 0x02000B99 RID: 2969
[NullableContext(1)]
[Nullable(0)]
public class AdviceWordSelectView : UiViewBase
{
	// Token: 0x06007BB2 RID: 31666 RVA: 0x002650AB File Offset: 0x002632AB
	public AdviceWordSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06007BB3 RID: 31667 RVA: 0x002650C0 File Offset: 0x002632C0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x06007BB4 RID: 31668 RVA: 0x00265181 File Offset: 0x00263381
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<AdviceWordSelectItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceWordSelectItem>(this.InitItem), null);
	}

	// Token: 0x06007BB5 RID: 31669 RVA: 0x002651A4 File Offset: 0x002633A4
	private ILayoutItem<AdviceWordSelectItem> InitItem(object wordIndex, UUIItem uiItem, int index)
	{
		AdviceWordSelectItem adviceWordSelectItem = new AdviceWordSelectItem(uiItem);
		adviceWordSelectItem.Update((int)wordIndex, AdviceModel.Instance.CurrentChangeWordType);
		return new LayoutItem<AdviceWordSelectItem>
		{
			Key = index,
			Value = adviceWordSelectItem
		};
	}

	// Token: 0x06007BB6 RID: 31670 RVA: 0x002651E8 File Offset: 0x002633E8
	private void OnClickConfirmBtn()
	{
		if (AdviceModel.Instance.CurrentChangeWordType == EChangeWordType.Sentence)
		{
			int currentPreSelectWordId = AdviceModel.Instance.CurrentPreSelectWordId;
			int currentPreSelectSentenceIndex = AdviceModel.Instance.CurrentPreSelectSentenceIndex;
			AdviceModel.Instance.CurrentSentenceWordMap[currentPreSelectSentenceIndex] = currentPreSelectWordId;
			AdviceModel.Instance.OnChangeSentence(currentPreSelectSentenceIndex);
		}
		else
		{
			AdviceModel.Instance.CurrentConjunctionId = AdviceModel.Instance.CurrentPreSelectWordId;
		}
		EventSystem.Instance.Emit(EEventName.OnChangeAdviceWord);
		base.CloseMe(null);
	}

	// Token: 0x06007BB7 RID: 31671 RVA: 0x00265260 File Offset: 0x00263460
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06007BB8 RID: 31672 RVA: 0x00265269 File Offset: 0x00263469
	protected override void OnAfterShow()
	{
		AdviceModel.Instance.CurrentPreSelectWordId = AdviceModel.Instance.CurrentSelectWordId;
		this.RefreshScroller();
		this.RefreshTitle();
	}

	// Token: 0x06007BB9 RID: 31673 RVA: 0x0026528C File Offset: 0x0026348C
	private void RefreshTitle()
	{
		if (AdviceModel.Instance.CurrentChangeWordType == EChangeWordType.Sentence)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(4), "AdvicePutSentence", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(4), "AdvicePutWord", Array.Empty<object>());
	}

	// Token: 0x06007BBA RID: 31674 RVA: 0x002652DC File Offset: 0x002634DC
	private void RefreshScroller()
	{
		bool currentChangeWordType = AdviceModel.Instance.CurrentChangeWordType != EChangeWordType.Sentence;
		List<int> list = new List<int>();
		if (!currentChangeWordType)
		{
			IReadOnlyList<AdviceSentence> adviceSentenceConfigs = AdviceConfig.Instance.GetAdviceSentenceConfigs();
			if (adviceSentenceConfigs == null)
			{
				goto IL_99;
			}
			using (IEnumerator<AdviceSentence> enumerator = adviceSentenceConfigs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					AdviceSentence adviceSentence = enumerator.Current;
					list.Add(adviceSentence.Id);
				}
				goto IL_99;
			}
		}
		IReadOnlyList<AdviceConjunction> adviceConjunctionConfigs = AdviceConfig.Instance.GetAdviceConjunctionConfigs();
		if (adviceConjunctionConfigs != null)
		{
			foreach (AdviceConjunction adviceConjunction in adviceConjunctionConfigs)
			{
				list.Add(adviceConjunction.Id);
			}
		}
		IL_99:
		this.CurrentIds = list;
		this.ScrollView.RefreshByData<int>(this.CurrentIds, null);
		this.ScrollView.UnBindLateUpdate();
		this.ScrollToDirty = true;
		this.WaitingLateUpdateFlag = 0;
		this.ScrollView.BindLateUpdate(new Action<float>(this.LateUpdate));
	}

	// Token: 0x06007BBB RID: 31675 RVA: 0x002653F0 File Offset: 0x002635F0
	private void LateUpdate(float deltaTime)
	{
		if (this.ScrollToDirty && this.WaitingLateUpdateFlag >= 1)
		{
			this.ScrollToDirty = false;
			float progress = this.GetProgress(this.CurrentIds.ToArray());
			base.GetScrollViewWithScrollbar(0).SetScrollProgress(progress);
			this.ScrollView.UnBindLateUpdate();
		}
		this.WaitingLateUpdateFlag++;
	}

	// Token: 0x06007BBC RID: 31676 RVA: 0x00265450 File Offset: 0x00263650
	private float GetProgress(int[] numbers)
	{
		int num = 0;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (AdviceModel.Instance.CurrentSelectWordId == numbers[i])
			{
				num = i;
				break;
			}
		}
		if (numbers.Length > 1)
		{
			return (float)num / (float)(numbers.Length - 1);
		}
		return 0f;
	}

	// Token: 0x06007BBD RID: 31677 RVA: 0x00265495 File Offset: 0x00263695
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceWordSelectItem> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.ClearChildren();
	}

	// Token: 0x04004C4A RID: 19530
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004C4B RID: 19531
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceWordSelectItem> ScrollView;

	// Token: 0x04004C4C RID: 19532
	private bool ScrollToDirty;

	// Token: 0x04004C4D RID: 19533
	private int WaitingLateUpdateFlag;

	// Token: 0x04004C4E RID: 19534
	private List<int> CurrentIds = new List<int>();

	// Token: 0x02006E39 RID: 28217
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402419E RID: 147870
		public const int WordScroller = 0;

		// Token: 0x0402419F RID: 147871
		public const int WordItem = 1;

		// Token: 0x040241A0 RID: 147872
		public const int ConfirmBtn = 2;

		// Token: 0x040241A1 RID: 147873
		public const int CancelBtn = 3;

		// Token: 0x040241A2 RID: 147874
		public const int TitleText = 4;
	}
}
