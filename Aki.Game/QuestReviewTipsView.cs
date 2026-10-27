using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002687 RID: 9863
[NullableContext(1)]
[Nullable(0)]
public class QuestReviewTipsView : UiTickViewBase
{
	// Token: 0x06014354 RID: 82772 RVA: 0x0051AD83 File Offset: 0x00518F83
	public QuestReviewTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06014355 RID: 82773 RVA: 0x0051AD8C File Offset: 0x00518F8C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014356 RID: 82774 RVA: 0x0051AE98 File Offset: 0x00519098
	protected override UniTask OnBeforeStartAsync()
	{
		QuestReviewTipsView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QuestReviewTipsView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014357 RID: 82775 RVA: 0x0051AEDC File Offset: 0x005190DC
	protected override void OnStart()
	{
		IQuestReviewTipsParam questReviewTipsParam = this.OpenParam as IQuestReviewTipsParam;
		this.EntryData = ((questReviewTipsParam == null) ? null : QuestReviewModel.Instance.GetQuestReviewEntryDataById(questReviewTipsParam.EntryId));
		this.CountDownTime = 0f;
		this.StartTick = false;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "StoryReview_Tips_Content", Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "StoryReview_Tips_Title", Array.Empty<object>());
		this.UiViewSequence.AddSequenceFinishEvent("StartTips", new Action<string>(this.OnStartSeqFinish), false);
		this.UiViewSequence.AddSequenceFinishEvent("CloseTips", new Action<string>(this.OnCloseSeqFinish), false);
	}

	// Token: 0x06014358 RID: 82776 RVA: 0x0051AF94 File Offset: 0x00519194
	protected override void OnAfterShow()
	{
		this.UiViewSequence.PlaySequence("StartTips", false, null);
	}

	// Token: 0x06014359 RID: 82777 RVA: 0x0051AFBC File Offset: 0x005191BC
	protected override void OnTick(float delta)
	{
		if (this.EntryData == null || !this.StartTick)
		{
			return;
		}
		if (this.CountDownTime >= this.EntryData.TimerDurationMs)
		{
			this.UiViewSequence.PlaySequence("CloseTips", true, null);
			this.StartTick = false;
			return;
		}
		UUISprite sprite = base.GetSprite(3);
		this.CountDownTime += delta;
		float num = Math.Max(this.EntryData.TimerDurationMs - this.CountDownTime, 0f);
		if (sprite == null)
		{
			return;
		}
		sprite.SetFillAmount(num / this.EntryData.TimerDurationMs);
	}

	// Token: 0x0601435A RID: 82778 RVA: 0x0051B058 File Offset: 0x00519258
	private void OnClick()
	{
		if (this.EntryData == null)
		{
			return;
		}
		QuestReviewController.Instance.OpenQuestReview(this.EntryData.Id, true);
		this.UiViewSequence.PlaySequence("CloseTips", true, null);
	}

	// Token: 0x0601435B RID: 82779 RVA: 0x0051B0A0 File Offset: 0x005192A0
	private void OnStartSeqFinish(string _)
	{
		this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
		this.StartTick = true;
	}

	// Token: 0x0601435C RID: 82780 RVA: 0x0051B0CE File Offset: 0x005192CE
	private void OnCloseSeqFinish(string _)
	{
		this.StartTick = false;
		base.CloseMe(null);
	}

	// Token: 0x04009817 RID: 38935
	[Nullable(2)]
	private QuestReviewEntryData EntryData;

	// Token: 0x04009818 RID: 38936
	private float CountDownTime;

	// Token: 0x04009819 RID: 38937
	private bool StartTick;

	// Token: 0x02008CD7 RID: 36055
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DB3D RID: 187197
		public const int TextName = 0;

		// Token: 0x0402DB3E RID: 187198
		public const int SpriteIcon = 1;

		// Token: 0x0402DB3F RID: 187199
		public const int ButtonTips = 2;

		// Token: 0x0402DB40 RID: 187200
		public const int SpriteTimeBar = 3;

		// Token: 0x0402DB41 RID: 187201
		public const int TextTitle = 4;
	}
}
