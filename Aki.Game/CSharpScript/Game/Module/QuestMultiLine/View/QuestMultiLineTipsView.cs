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
	// Token: 0x02004FAE RID: 20398
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineTipsView : UiTickViewBase
	{
		// Token: 0x06034372 RID: 213874 RVA: 0x00C41A85 File Offset: 0x00C3FC85
		public QuestMultiLineTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034373 RID: 213875 RVA: 0x00C41A90 File Offset: 0x00C3FC90
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

		// Token: 0x06034374 RID: 213876 RVA: 0x00C41B9C File Offset: 0x00C3FD9C
		protected override UniTask OnBeforeStartAsync()
		{
			QuestMultiLineTipsView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<QuestMultiLineTipsView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034375 RID: 213877 RVA: 0x00C41BE0 File Offset: 0x00C3FDE0
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

		// Token: 0x06034376 RID: 213878 RVA: 0x00C41C94 File Offset: 0x00C3FE94
		protected override void OnAfterShow()
		{
			this.UiViewSequence.PlaySequence("StartTips", false, null);
		}

		// Token: 0x06034377 RID: 213879 RVA: 0x00C41CBC File Offset: 0x00C3FEBC
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

		// Token: 0x06034378 RID: 213880 RVA: 0x00C41D48 File Offset: 0x00C3FF48
		private void OnClick()
		{
			QuestMultiLineController.Instance.OpenQuestMultiLineView(this.TimePointId, this.EnableAnimation, false);
			this.UiViewSequence.PlaySequence("CloseTips", true, null);
		}

		// Token: 0x06034379 RID: 213881 RVA: 0x00C41D88 File Offset: 0x00C3FF88
		private void OnStartSeqFinish(string _)
		{
			this.UiViewSequence.PlaySequence("StartAtOnce", false, null);
			this.StartTick = true;
		}

		// Token: 0x0603437A RID: 213882 RVA: 0x00C41DB6 File Offset: 0x00C3FFB6
		private void OnCloseSeqFinish(string _)
		{
			this.StartTick = false;
			base.CloseMe(null);
		}

		// Token: 0x0401BC2F RID: 113711
		private int TimePointId;

		// Token: 0x0401BC30 RID: 113712
		private bool EnableAnimation;

		// Token: 0x0401BC31 RID: 113713
		private float CountDownTime;

		// Token: 0x0401BC32 RID: 113714
		private bool StartTick;

		// Token: 0x0200B0BB RID: 45243
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035A71 RID: 219761
			public const int TextName = 0;

			// Token: 0x04035A72 RID: 219762
			public const int SpriteIcon = 1;

			// Token: 0x04035A73 RID: 219763
			public const int ButtonTips = 2;

			// Token: 0x04035A74 RID: 219764
			public const int SpriteTimeBar = 3;

			// Token: 0x04035A75 RID: 219765
			public const int TextTitle = 4;
		}
	}
}
