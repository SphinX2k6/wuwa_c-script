using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A71 RID: 23153
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelDialogueView : UiViewBase, IVisualNovelView
	{
		// Token: 0x17006CBA RID: 27834
		// (get) Token: 0x0603908F RID: 233615 RVA: 0x00FF9BD3 File Offset: 0x00FF7DD3
		public bool IsTyping
		{
			get
			{
				SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
				return dialogueItem != null && dialogueItem.IsTyping;
			}
		}

		// Token: 0x17006CBB RID: 27835
		// (get) Token: 0x06039090 RID: 233616 RVA: 0x00FF9BE6 File Offset: 0x00FF7DE6
		public VisualNovelTransform CgTransform
		{
			get
			{
				return new VisualNovelTransform(0f, 0f, 1f);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06039091 RID: 233617 RVA: 0x00FF9BFC File Offset: 0x00FF7DFC
		// (remove) Token: 0x06039092 RID: 233618 RVA: 0x00FF9C34 File Offset: 0x00FF7E34
		public event Action ContinueRequested;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06039093 RID: 233619 RVA: 0x00FF9C6C File Offset: 0x00FF7E6C
		// (remove) Token: 0x06039094 RID: 233620 RVA: 0x00FF9CA4 File Offset: 0x00FF7EA4
		public event Action<int> ChoiceSelected;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06039095 RID: 233621 RVA: 0x00FF9CDC File Offset: 0x00FF7EDC
		// (remove) Token: 0x06039096 RID: 233622 RVA: 0x00FF9D14 File Offset: 0x00FF7F14
		public event Action AutoPlayRequested;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06039097 RID: 233623 RVA: 0x00FF9D4C File Offset: 0x00FF7F4C
		// (remove) Token: 0x06039098 RID: 233624 RVA: 0x00FF9D84 File Offset: 0x00FF7F84
		public event Action FastForwardStarted;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06039099 RID: 233625 RVA: 0x00FF9DBC File Offset: 0x00FF7FBC
		// (remove) Token: 0x0603909A RID: 233626 RVA: 0x00FF9DF4 File Offset: 0x00FF7FF4
		public event Action FastForwardEnded;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0603909B RID: 233627 RVA: 0x00FF9E2C File Offset: 0x00FF802C
		// (remove) Token: 0x0603909C RID: 233628 RVA: 0x00FF9E64 File Offset: 0x00FF8064
		public event Action UltraFastForwardRequested;

		// Token: 0x0603909D RID: 233629 RVA: 0x00FF9E99 File Offset: 0x00FF8099
		[NullableContext(1)]
		public SolarSchoolVisualNovelDialogueView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603909E RID: 233630 RVA: 0x00FF9EA4 File Offset: 0x00FF80A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603909F RID: 233631 RVA: 0x00FF9EEC File Offset: 0x00FF80EC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolVisualNovelDialogueView.<OnBeforeStartAsync>d__30 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelDialogueView.<OnBeforeStartAsync>d__30>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390A0 RID: 233632 RVA: 0x00FF9F30 File Offset: 0x00FF8130
		protected override void OnStart()
		{
			this.Context = (this.OpenParam as VisualNovelContext);
			if (this.Context == null)
			{
				global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "轻量视觉小说对话界面缺少播放上下文", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Scene = new VisualNovelScene();
			this.Context.SetSceneAndView(this.Scene, this);
			this.DialogueItem.SetAssetCache(this.Context.Assets);
			this.SetDialogueVisible(this.Context.DialogueVisible);
			this.SetPlaybackRate(this.Context.PlaybackRate);
			this.SetPaused(this.Context.IsPaused);
			this.SetInputLocked(this.Context.IsInputLocked);
		}

		// Token: 0x060390A1 RID: 233633 RVA: 0x00FF9FF0 File Offset: 0x00FF81F0
		protected override void OnBeforeDestroy()
		{
			this.SetInputLocked(false);
			VisualNovelContext context = this.Context;
			if (context != null)
			{
				context.Player.Stop();
			}
			if (this.DialogueItem != null)
			{
				this.DialogueItem.ContinueRequested -= this.OnContinueRequested;
			}
			this.DialogueItem = null;
			this.ContinueRequested = null;
			this.ChoiceSelected = null;
			this.AutoPlayRequested = null;
			this.FastForwardStarted = null;
			this.FastForwardEnded = null;
			this.UltraFastForwardRequested = null;
			this.IsInputLocked = false;
		}

		// Token: 0x060390A2 RID: 233634 RVA: 0x00FFA074 File Offset: 0x00FF8274
		protected override UniTask OnDestroyAsyncImplementImplement()
		{
			SolarSchoolVisualNovelDialogueView.<OnDestroyAsyncImplementImplement>d__33 <OnDestroyAsyncImplementImplement>d__;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplementImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplementImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplementImplement>d__.<>t__builder.Start<SolarSchoolVisualNovelDialogueView.<OnDestroyAsyncImplementImplement>d__33>(ref <OnDestroyAsyncImplementImplement>d__);
			return <OnDestroyAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060390A3 RID: 233635 RVA: 0x00FFA0B7 File Offset: 0x00FF82B7
		[NullableContext(1)]
		public void SetAvatarConfig(int speakerId, IVisualNovelRoleConfig roleConfig)
		{
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetAvatarConfig(speakerId, roleConfig);
		}

		// Token: 0x060390A4 RID: 233636 RVA: 0x00FFA0CB File Offset: 0x00FF82CB
		[NullableContext(1)]
		public UniTask PrepareAsync(VisualNovelItem item)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060390A5 RID: 233637 RVA: 0x00FFA0D4 File Offset: 0x00FF82D4
		[NullableContext(1)]
		public UniTask ShowTextAsync(VisualNovelItem item, EVisualNovelPlaybackMode playbackMode)
		{
			SolarSchoolVisualNovelDialogueView.<ShowTextAsync>d__36 <ShowTextAsync>d__;
			<ShowTextAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowTextAsync>d__.<>4__this = this;
			<ShowTextAsync>d__.item = item;
			<ShowTextAsync>d__.playbackMode = playbackMode;
			<ShowTextAsync>d__.<>1__state = -1;
			<ShowTextAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelDialogueView.<ShowTextAsync>d__36>(ref <ShowTextAsync>d__);
			return <ShowTextAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060390A6 RID: 233638 RVA: 0x00FFA127 File Offset: 0x00FF8327
		[NullableContext(1)]
		public UniTask ApplyCgAsync(IVisualNovelCgBase cgConfig)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060390A7 RID: 233639 RVA: 0x00FFA12E File Offset: 0x00FF832E
		public UniTask PlayCgMoveAsync(VisualNovelCgMoveParameters parameters)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060390A8 RID: 233640 RVA: 0x00FFA135 File Offset: 0x00FF8335
		public void SetCgTransform(VisualNovelTransform transform)
		{
		}

		// Token: 0x060390A9 RID: 233641 RVA: 0x00FFA137 File Offset: 0x00FF8337
		[NullableContext(1)]
		public UniTask PlayScreenEffectAsync(string path, bool persistent)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060390AA RID: 233642 RVA: 0x00FFA13E File Offset: 0x00FF833E
		[NullableContext(1)]
		public UniTask StopScreenEffectAsync(string path)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060390AB RID: 233643 RVA: 0x00FFA145 File Offset: 0x00FF8345
		[NullableContext(1)]
		public void CompleteScreenEffect(string path)
		{
		}

		// Token: 0x060390AC RID: 233644 RVA: 0x00FFA147 File Offset: 0x00FF8347
		public UniTask PlayCustomScreenEffectAsync(EVisualNovelScreenEffectCustomType effectType)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x060390AD RID: 233645 RVA: 0x00FFA14E File Offset: 0x00FF834E
		public void CompleteCustomScreenEffect(EVisualNovelScreenEffectCustomType effectType)
		{
		}

		// Token: 0x060390AE RID: 233646 RVA: 0x00FFA150 File Offset: 0x00FF8350
		public void ClearScreenEffects()
		{
		}

		// Token: 0x060390AF RID: 233647 RVA: 0x00FFA154 File Offset: 0x00FF8354
		[NullableContext(1)]
		public UniTask ShowChoicesAsync(VisualNovelChoiceData choiceData)
		{
			global::Log.Instance.Error(ELogModule.VisualNovel, ELogAuthor.LZK, "轻量视觉小说对话界面不支持选项", default(ReadOnlySpan<ValueTuple<string, object>>));
			Action<int> choiceSelected = this.ChoiceSelected;
			if (choiceSelected != null)
			{
				choiceSelected(-1);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x060390B0 RID: 233648 RVA: 0x00FFA197 File Offset: 0x00FF8397
		public bool ShowCharacterIntroduction(int characterId)
		{
			return false;
		}

		// Token: 0x060390B1 RID: 233649 RVA: 0x00FFA19A File Offset: 0x00FF839A
		public void HideCharacterIntroduction()
		{
		}

		// Token: 0x060390B2 RID: 233650 RVA: 0x00FFA19C File Offset: 0x00FF839C
		public void CompleteTyping()
		{
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.CompleteTyping();
		}

		// Token: 0x060390B3 RID: 233651 RVA: 0x00FFA1AE File Offset: 0x00FF83AE
		public void SetPlaybackRate(float playbackRate)
		{
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetPlaybackRate(playbackRate);
		}

		// Token: 0x060390B4 RID: 233652 RVA: 0x00FFA1C1 File Offset: 0x00FF83C1
		public void SetPaused(bool paused)
		{
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetPaused(paused);
		}

		// Token: 0x060390B5 RID: 233653 RVA: 0x00FFA1D4 File Offset: 0x00FF83D4
		public void HideChoices()
		{
		}

		// Token: 0x060390B6 RID: 233654 RVA: 0x00FFA1D6 File Offset: 0x00FF83D6
		public void SetDialogueVisible(bool visible)
		{
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetUiActive(visible);
		}

		// Token: 0x060390B7 RID: 233655 RVA: 0x00FFA1E9 File Offset: 0x00FF83E9
		public void SetAutoButtonVisible(bool visible)
		{
		}

		// Token: 0x060390B8 RID: 233656 RVA: 0x00FFA1EB File Offset: 0x00FF83EB
		public void SetReviewButtonVisible(bool visible)
		{
		}

		// Token: 0x060390B9 RID: 233657 RVA: 0x00FFA1ED File Offset: 0x00FF83ED
		public void SetMenuButtonVisible(bool visible)
		{
		}

		// Token: 0x060390BA RID: 233658 RVA: 0x00FFA1EF File Offset: 0x00FF83EF
		public void SetAccelerateButtonVisible(bool visible)
		{
		}

		// Token: 0x060390BB RID: 233659 RVA: 0x00FFA1F1 File Offset: 0x00FF83F1
		public void SetHideUiButtonVisible(bool visible)
		{
		}

		// Token: 0x060390BC RID: 233660 RVA: 0x00FFA1F3 File Offset: 0x00FF83F3
		public void SetUltraFastForwardButtonVisible(bool visible)
		{
		}

		// Token: 0x060390BD RID: 233661 RVA: 0x00FFA1F5 File Offset: 0x00FF83F5
		public void SetPlaybackMode(EVisualNovelPlaybackMode playbackMode)
		{
		}

		// Token: 0x060390BE RID: 233662 RVA: 0x00FFA1F7 File Offset: 0x00FF83F7
		public void SetInputLocked(bool locked)
		{
			this.IsInputLocked = locked;
			UiLayer.Instance.SetShowMaskLayer("VisualNovelUltraFastForward", locked);
			SolarSchoolVisualNovelDialogueItem dialogueItem = this.DialogueItem;
			if (dialogueItem == null)
			{
				return;
			}
			dialogueItem.SetInputLocked(locked);
		}

		// Token: 0x060390BF RID: 233663 RVA: 0x00FFA221 File Offset: 0x00FF8421
		private void OnContinueRequested()
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

		// Token: 0x060390C0 RID: 233664 RVA: 0x00FFA23C File Offset: 0x00FF843C
		[NullableContext(1)]
		private static string GetTalkText(VisualNovelItem item)
		{
			if (!string.IsNullOrEmpty(item.TextKey))
			{
				return PublicUtil.Instance.GetFlowConfigLocalText(item.TextKey) ?? item.TextKey;
			}
			if (item.TextId == null)
			{
				return string.Empty;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
			defaultInterpolatedStringHandler.AppendLiteral("[TextId: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item.TextId.Value);
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060390C1 RID: 233665 RVA: 0x00FFA2C8 File Offset: 0x00FF84C8
		[NullableContext(1)]
		private static string GetSpeakerName(int speakerId)
		{
			Speaker? config = ConfigSpeakerById.GetConfig(speakerId, true);
			if (config == null)
			{
				return string.Empty;
			}
			return PublicUtil.Instance.GetConfigTextByTable(ETableText.SpeakerName, new int?(config.Value.Id)) ?? string.Empty;
		}

		// Token: 0x0401E040 RID: 122944
		[Nullable(1)]
		private const string INPUT_MASK_TAG = "VisualNovelUltraFastForward";

		// Token: 0x0401E041 RID: 122945
		private SolarSchoolVisualNovelDialogueItem DialogueItem;

		// Token: 0x0401E042 RID: 122946
		private VisualNovelContext Context;

		// Token: 0x0401E043 RID: 122947
		private VisualNovelScene Scene;

		// Token: 0x0401E044 RID: 122948
		private bool IsInputLocked;

		// Token: 0x0200B668 RID: 46696
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040386F0 RID: 231152
			public const int DialogueItem = 0;
		}
	}
}
