using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A74 RID: 23156
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelNarrationDialogueItem : UiPanelBase
	{
		// Token: 0x17006CBE RID: 27838
		// (get) Token: 0x060390D9 RID: 233689 RVA: 0x00FFA8B8 File Offset: 0x00FF8AB8
		public bool IsTyping
		{
			get
			{
				VisualNovelTextPlayer textPlayer = this.TextPlayer;
				return textPlayer != null && textPlayer.IsTyping;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060390DA RID: 233690 RVA: 0x00FFA8CC File Offset: 0x00FF8ACC
		// (remove) Token: 0x060390DB RID: 233691 RVA: 0x00FFA904 File Offset: 0x00FF8B04
		public event Action ContinueRequested;

		// Token: 0x060390DC RID: 233692 RVA: 0x00FFA93C File Offset: 0x00FF8B3C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060390DD RID: 233693 RVA: 0x00FFA9C8 File Offset: 0x00FF8BC8
		protected override void OnStart()
		{
			UUIText text = base.GetText(1);
			this.TextScroll.Init(new PlotTextScrollComponentContext
			{
				TextComponent = text,
				TextScrollView = base.GetScrollView(0)
			});
			this.TextScroll.EnableManualScroll(new Action(this.OnTextClicked));
			this.TextPlayer = new VisualNovelTextPlayer(text, this.TextScroll);
			this.HideDialogue();
		}

		// Token: 0x060390DE RID: 233694 RVA: 0x00FFAA30 File Offset: 0x00FF8C30
		protected override void OnBeforeDestroy()
		{
			this.ContinueRequested = null;
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer != null)
			{
				textPlayer.Destroy();
			}
			this.TextPlayer = null;
			this.TextScroll.Clear();
		}

		// Token: 0x060390DF RID: 233695 RVA: 0x00FFAA5C File Offset: 0x00FF8C5C
		[NullableContext(1)]
		public UniTask ShowDialogueAsync(string content, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelNarrationDialogueItem.<ShowDialogueAsync>d__11 <ShowDialogueAsync>d__;
			<ShowDialogueAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowDialogueAsync>d__.<>4__this = this;
			<ShowDialogueAsync>d__.content = content;
			<ShowDialogueAsync>d__.playbackMode = playbackMode;
			<ShowDialogueAsync>d__.<>1__state = -1;
			<ShowDialogueAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelNarrationDialogueItem.<ShowDialogueAsync>d__11>(ref <ShowDialogueAsync>d__);
			return <ShowDialogueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390E0 RID: 233696 RVA: 0x00FFAAAF File Offset: 0x00FF8CAF
		public void CompleteTyping()
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.CompleteTyping();
		}

		// Token: 0x060390E1 RID: 233697 RVA: 0x00FFAAC1 File Offset: 0x00FF8CC1
		public void SetPlaybackRate(float playbackRate)
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.SetPlaybackRate(playbackRate);
		}

		// Token: 0x060390E2 RID: 233698 RVA: 0x00FFAAD4 File Offset: 0x00FF8CD4
		public void SetPaused(bool paused)
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.SetPaused(paused);
		}

		// Token: 0x060390E3 RID: 233699 RVA: 0x00FFAAE7 File Offset: 0x00FF8CE7
		public void HideDialogue()
		{
			base.SetUiActive(false);
		}

		// Token: 0x060390E4 RID: 233700 RVA: 0x00FFAAF0 File Offset: 0x00FF8CF0
		private void OnTextClicked()
		{
			Action continueRequested = this.ContinueRequested;
			if (continueRequested == null)
			{
				return;
			}
			continueRequested();
		}

		// Token: 0x0401E052 RID: 122962
		[Nullable(1)]
		private readonly PlotTextScrollComponent TextScroll = new PlotTextScrollComponent();

		// Token: 0x0401E053 RID: 122963
		private VisualNovelTextPlayer TextPlayer;

		// Token: 0x0200B674 RID: 46708
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04038726 RID: 231206
			public const int DialogueScrollView = 0;

			// Token: 0x04038727 RID: 231207
			public const int DialogueText = 1;

			// Token: 0x04038728 RID: 231208
			public const int NextSprite = 2;
		}
	}
}
