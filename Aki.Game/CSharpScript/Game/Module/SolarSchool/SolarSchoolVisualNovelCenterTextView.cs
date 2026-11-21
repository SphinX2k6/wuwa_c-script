using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A69 RID: 23145
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelCenterTextView : UiViewBase
	{
		// Token: 0x17006CB7 RID: 27831
		// (get) Token: 0x06039032 RID: 233522 RVA: 0x00FF8326 File Offset: 0x00FF6526
		public bool IsTyping
		{
			get
			{
				VisualNovelTextPlayer textPlayer = this.TextPlayer;
				return textPlayer != null && textPlayer.IsTyping;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06039033 RID: 233523 RVA: 0x00FF833C File Offset: 0x00FF653C
		// (remove) Token: 0x06039034 RID: 233524 RVA: 0x00FF8374 File Offset: 0x00FF6574
		public event Action ContinueRequested;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06039035 RID: 233525 RVA: 0x00FF83AC File Offset: 0x00FF65AC
		// (remove) Token: 0x06039036 RID: 233526 RVA: 0x00FF83E4 File Offset: 0x00FF65E4
		public event Action UltraFastForwardRequested;

		// Token: 0x06039037 RID: 233527 RVA: 0x00FF8419 File Offset: 0x00FF6619
		[NullableContext(1)]
		public SolarSchoolVisualNovelCenterTextView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039038 RID: 233528 RVA: 0x00FF8424 File Offset: 0x00FF6624
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnContinueButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnSkipButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039039 RID: 233529 RVA: 0x00FF8574 File Offset: 0x00FF6774
		protected override void OnStart()
		{
			UUIText text = base.GetText(0);
			this.TextPlayer = new VisualNovelTextPlayer(text, null);
			base.GetItem(5).SetUIActive(false);
			base.GetTexture(2).SetUIActive(false);
			base.GetButton(3).GetRootComponent().SetUIActive(true);
			this.SetUltraFastForwardButtonVisible(false);
			object openParam = this.OpenParam;
			this.SetInputLocked(openParam is bool && (bool)openParam);
		}

		// Token: 0x0603903A RID: 233530 RVA: 0x00FF85E7 File Offset: 0x00FF67E7
		protected override void OnBeforeDestroy()
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer != null)
			{
				textPlayer.Destroy();
			}
			this.TextPlayer = null;
			this.ContinueRequested = null;
			this.UltraFastForwardRequested = null;
		}

		// Token: 0x0603903B RID: 233531 RVA: 0x00FF8610 File Offset: 0x00FF6810
		[NullableContext(1)]
		public UniTask ShowTextAsync(string content, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelCenterTextView.<ShowTextAsync>d__15 <ShowTextAsync>d__;
			<ShowTextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowTextAsync>d__.<>4__this = this;
			<ShowTextAsync>d__.content = content;
			<ShowTextAsync>d__.playbackMode = playbackMode;
			<ShowTextAsync>d__.<>1__state = -1;
			<ShowTextAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelCenterTextView.<ShowTextAsync>d__15>(ref <ShowTextAsync>d__);
			return <ShowTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603903C RID: 233532 RVA: 0x00FF8663 File Offset: 0x00FF6863
		public void CompleteTyping()
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.CompleteTyping();
		}

		// Token: 0x0603903D RID: 233533 RVA: 0x00FF8675 File Offset: 0x00FF6875
		public void SetPlaybackRate(float playbackRate)
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.SetPlaybackRate(playbackRate);
		}

		// Token: 0x0603903E RID: 233534 RVA: 0x00FF8688 File Offset: 0x00FF6888
		public void SetPaused(bool paused)
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.SetPaused(paused);
		}

		// Token: 0x0603903F RID: 233535 RVA: 0x00FF869B File Offset: 0x00FF689B
		public void SetUltraFastForwardButtonVisible(bool visible)
		{
			base.SetButtonUiActive(6, visible);
		}

		// Token: 0x06039040 RID: 233536 RVA: 0x00FF86A5 File Offset: 0x00FF68A5
		public void SetInputLocked(bool locked)
		{
			this.IsInputLocked = locked;
			if (base.IsDestroyOrDestroying)
			{
				return;
			}
			base.GetButton(3).SetSelfInteractive(!locked);
			base.GetButton(6).SetSelfInteractive(!locked);
		}

		// Token: 0x06039041 RID: 233537 RVA: 0x00FF86D7 File Offset: 0x00FF68D7
		private void OnContinueButtonClicked()
		{
			if (!this.IsInputLocked)
			{
				Action continueRequested = this.ContinueRequested;
				if (continueRequested == null)
				{
					return;
				}
				continueRequested();
			}
		}

		// Token: 0x06039042 RID: 233538 RVA: 0x00FF86F1 File Offset: 0x00FF68F1
		private void OnSkipButtonClicked()
		{
			if (!this.IsInputLocked)
			{
				Action ultraFastForwardRequested = this.UltraFastForwardRequested;
				if (ultraFastForwardRequested == null)
				{
					return;
				}
				ultraFastForwardRequested();
			}
		}

		// Token: 0x0401E013 RID: 122899
		private VisualNovelTextPlayer TextPlayer;

		// Token: 0x0401E014 RID: 122900
		private bool IsInputLocked;

		// Token: 0x0200B659 RID: 46681
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403868E RID: 231054
			public const int Text = 0;

			// Token: 0x0403868F RID: 231055
			public const int BackgroundTexture = 1;

			// Token: 0x04038690 RID: 231056
			public const int ContentTexture = 2;

			// Token: 0x04038691 RID: 231057
			public const int ContinueButton = 3;

			// Token: 0x04038692 RID: 231058
			public const int StateItem = 5;

			// Token: 0x04038693 RID: 231059
			public const int SkipButton = 6;
		}
	}
}
