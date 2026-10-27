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

// Token: 0x020016E1 RID: 5857
[NullableContext(1)]
[Nullable(0)]
public class AdviceWordSelectView : UiViewBase
{
	// Token: 0x0600A7D2 RID: 42962 RVA: 0x0025ACA3 File Offset: 0x00258EA3
	public AdviceWordSelectView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600A7D3 RID: 42963 RVA: 0x0025ACB8 File Offset: 0x00258EB8
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

	// Token: 0x0600A7D4 RID: 42964 RVA: 0x0025AD79 File Offset: 0x00258F79
	protected override void OnStart()
	{
		this.ScrollView = new GenericScrollView<AdviceWordSelectItem>(base.GetScrollViewWithScrollbar(0), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceWordSelectItem>(this.InitItem), null);
	}

	// Token: 0x0600A7D5 RID: 42965 RVA: 0x0025AD9C File Offset: 0x00258F9C
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

	// Token: 0x0600A7D6 RID: 42966 RVA: 0x0025ADE0 File Offset: 0x00258FE0
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

	// Token: 0x0600A7D7 RID: 42967 RVA: 0x0025AE58 File Offset: 0x00259058
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600A7D8 RID: 42968 RVA: 0x0025AE61 File Offset: 0x00259061
	protected override void OnAfterShow()
	{
		AdviceModel.Instance.CurrentPreSelectWordId = AdviceModel.Instance.CurrentSelectWordId;
		this.RefreshScroller();
		this.RefreshTitle();
	}

	// Token: 0x0600A7D9 RID: 42969 RVA: 0x0025AE84 File Offset: 0x00259084
	private void RefreshTitle()
	{
		if (AdviceModel.Instance.CurrentChangeWordType == EChangeWordType.Sentence)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(4), "AdvicePutSentence", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalText(base.GetText(4), "AdvicePutWord", Array.Empty<object>());
	}

	// Token: 0x0600A7DA RID: 42970 RVA: 0x0025AED4 File Offset: 0x002590D4
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

	// Token: 0x0600A7DB RID: 42971 RVA: 0x0025AFE8 File Offset: 0x002591E8
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

	// Token: 0x0600A7DC RID: 42972 RVA: 0x0025B048 File Offset: 0x00259248
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

	// Token: 0x0600A7DD RID: 42973 RVA: 0x0025B08D File Offset: 0x0025928D
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceWordSelectItem> scrollView = this.ScrollView;
		if (scrollView == null)
		{
			return;
		}
		scrollView.ClearChildren();
	}

	// Token: 0x04004BA3 RID: 19363
	private const int WAITUPDATECOUNT = 1;

	// Token: 0x04004BA4 RID: 19364
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceWordSelectItem> ScrollView;

	// Token: 0x04004BA5 RID: 19365
	private bool ScrollToDirty;

	// Token: 0x04004BA6 RID: 19366
	private int WaitingLateUpdateFlag;

	// Token: 0x04004BA7 RID: 19367
	private List<int> CurrentIds = new List<int>();

	// Token: 0x02007CB4 RID: 31924
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E75 RID: 167541
		public const int WordScroller = 0;

		// Token: 0x04028E76 RID: 167542
		public const int WordItem = 1;

		// Token: 0x04028E77 RID: 167543
		public const int ConfirmBtn = 2;

		// Token: 0x04028E78 RID: 167544
		public const int CancelBtn = 3;

		// Token: 0x04028E79 RID: 167545
		public const int TitleText = 4;
	}
}
