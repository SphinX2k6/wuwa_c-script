using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuestMultiLine.View
{
	// Token: 0x02003F77 RID: 16247
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineTipsView : UiTickViewBase
	{
		// Token: 0x060291E0 RID: 168416 RVA: 0x00B8B231 File Offset: 0x00B89431
		public QuestMultiLineTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060291E1 RID: 168417 RVA: 0x00B8B23C File Offset: 0x00B8943C
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

		// Token: 0x060291E2 RID: 168418 RVA: 0x00B8B348 File Offset: 0x00B89548
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineTipsView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineTipsView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060291E3 RID: 168419 RVA: 0x00B8B38C File Offset: 0x00B8958C
		protected override void OnStart()
		{
			this.TimePointId = ((QuestMultiLineTipsParam)this.OpenParam).TimePointId;
			this.EnableAnimation = ((QuestMultiLineTipsParam)this.OpenParam).EnableAnimation;
			this.CountDownTime = 0f;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "QuestBranch_OpenTips_Content", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "QuestBranch_OpenTips_Title", Array.Empty<object>());
			this.UiViewSequence.AddSequenceFinishEvent("StartTips", new Action<string>(this.OnStartSeqFinish), false);
			this.UiViewSequence.AddSequenceFinishEvent("CloseTips", new Action<string>(this.OnCloseSeqFinish), false);
		}

		// Token: 0x060291E4 RID: 168420 RVA: 0x00B8B440 File Offset: 0x00B89640
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("StartTips", false, null);
		}

		// Token: 0x060291E5 RID: 168421 RVA: 0x00B8B468 File Offset: 0x00B89668
		protected override void OnTick(float delta)
		{
			if (this.TimePointId == 0 || !this.StartTick)
			{
				return;
			}
			if (this.CountDownTime >= 1000f)
			{
				this.UiViewSequence.PlaySequence("CloseTips", true, null);
				this.StartTick = false;
				return;
			}
			UUISprite sprite = base.GetSprite(3);
			this.CountDownTime += delta;
			float num = Math.Max(1000f - this.CountDownTime, 0f);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(num / 1000f);
		}

		// Token: 0x060291E6 RID: 168422 RVA: 0x00B8B4F4 File Offset: 0x00B896F4
		private void OnClick()
		{
			QuestMultiLineController.Instance.OpenQuestMultiLineView(this.TimePointId, this.EnableAnimation, false);
			this.UiViewSequence.PlaySequence("CloseTips", true, null);
		}

		// Token: 0x060291E7 RID: 168423 RVA: 0x00B8B534 File Offset: 0x00B89734
		private void OnStartSeqFinish(string _)
		{
			this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
			this.StartTick = true;
		}

		// Token: 0x060291E8 RID: 168424 RVA: 0x00B8B562 File Offset: 0x00B89762
		private void OnCloseSeqFinish(string _)
		{
			this.StartTick = false;
			base.CloseMe(null);
		}

		// Token: 0x04016604 RID: 91652
		private int TimePointId;

		// Token: 0x04016605 RID: 91653
		private bool EnableAnimation;

		// Token: 0x04016606 RID: 91654
		private float CountDownTime;

		// Token: 0x04016607 RID: 91655
		private bool StartTick;

		// Token: 0x02009AEB RID: 39659
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403049C RID: 197788
			public const int TextName = 0;

			// Token: 0x0403049D RID: 197789
			public const int SpriteIcon = 1;

			// Token: 0x0403049E RID: 197790
			public const int ButtonTips = 2;

			// Token: 0x0403049F RID: 197791
			public const int SpriteTimeBar = 3;

			// Token: 0x040304A0 RID: 197792
			public const int TextTitle = 4;
		}
	}
}
