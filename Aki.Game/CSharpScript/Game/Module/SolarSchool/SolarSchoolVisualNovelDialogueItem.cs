using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A70 RID: 23152
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelDialogueItem : UiPanelBase
	{
		// Token: 0x17006CB9 RID: 27833
		// (get) Token: 0x06039075 RID: 233589 RVA: 0x00FF966F File Offset: 0x00FF786F
		public bool IsTyping
		{
			get
			{
				if (!this.IsShowingText)
				{
					SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
					if (characterDialogueItem == null || !characterDialogueItem.IsTyping)
					{
						SolarSchoolVisualNovelNarrationDialogueItem narrationDialogueItem = this.NarrationDialogueItem;
						return narrationDialogueItem != null && narrationDialogueItem.IsTyping;
					}
				}
				return true;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06039076 RID: 233590 RVA: 0x00FF96A0 File Offset: 0x00FF78A0
		// (remove) Token: 0x06039077 RID: 233591 RVA: 0x00FF96D8 File Offset: 0x00FF78D8
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action ContinueRequested;

		// Token: 0x06039078 RID: 233592 RVA: 0x00FF9710 File Offset: 0x00FF7910
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnNextButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039079 RID: 233593 RVA: 0x00FF97F8 File Offset: 0x00FF79F8
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolVisualNovelDialogueItem.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelDialogueItem.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603907A RID: 233594 RVA: 0x00FF983B File Offset: 0x00FF7A3B
		protected override void OnStart()
		{
			this.SetContentVisible(true);
			this.HideDialogue();
		}

		// Token: 0x0603907B RID: 233595 RVA: 0x00FF984A File Offset: 0x00FF7A4A
		protected override void OnBeforeDestroy()
		{
			this.DialogueVersion++;
			this.IsShowingText = false;
			this.SequencePlayer.Clear();
			this.ContinueRequested = null;
			this.CharacterDialogueItem = null;
			this.NarrationDialogueItem = null;
		}

		// Token: 0x0603907C RID: 233596 RVA: 0x00FF9881 File Offset: 0x00FF7A81
		public UniTask ShowCharacterDialogueAsync(int speakerId, string speakerName, string content, EVisualNovelPlaybackMode playbackMode, [Nullable(2)] VisualNovelAudioEvent voice)
		{
			return this.ShowDialogueAsync(speakerId, speakerName, content, playbackMode, voice);
		}

		// Token: 0x0603907D RID: 233597 RVA: 0x00FF9890 File Offset: 0x00FF7A90
		public UniTask ShowNarrationAsync(string content, EVisualNovelPlaybackMode playbackMode)
		{
			return this.ShowDialogueAsync(0, string.Empty, content, playbackMode, null);
		}

		// Token: 0x0603907E RID: 233598 RVA: 0x00FF98A1 File Offset: 0x00FF7AA1
		public void CompleteTyping()
		{
			this.CompleteTextImmediately = true;
			SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
			if (characterDialogueItem != null)
			{
				characterDialogueItem.CompleteTyping();
			}
			SolarSchoolVisualNovelNarrationDialogueItem narrationDialogueItem = this.NarrationDialogueItem;
			if (narrationDialogueItem != null)
			{
				narrationDialogueItem.CompleteTyping();
			}
			if (this.IsShowingText)
			{
				this.SequencePlayer.StopCurrentSequence(true, true);
			}
		}

		// Token: 0x0603907F RID: 233599 RVA: 0x00FF98E4 File Offset: 0x00FF7AE4
		public void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
			if (characterDialogueItem != null)
			{
				characterDialogueItem.SetPlaybackRate(playbackRate);
			}
			SolarSchoolVisualNovelNarrationDialogueItem narrationDialogueItem = this.NarrationDialogueItem;
			if (narrationDialogueItem != null)
			{
				narrationDialogueItem.SetPlaybackRate(playbackRate);
			}
			string currentSequence = this.SequencePlayer.GetCurrentSequence();
			if (currentSequence != null)
			{
				this.ApplySequencePlaybackRate(currentSequence);
			}
		}

		// Token: 0x06039080 RID: 233600 RVA: 0x00FF9932 File Offset: 0x00FF7B32
		public void PlayStartSequence()
		{
			this.SequencePlayer.StopCurrentSequence(false, false);
			this.SequencePlayer.PlayLevelSequenceByName("Talk_Start", false, new float?(this.PlaybackRate), false);
		}

		// Token: 0x06039081 RID: 233601 RVA: 0x00FF995E File Offset: 0x00FF7B5E
		public UniTask PlayStartSequenceAsync()
		{
			return this.PlaySequenceAsync("Talk_Start");
		}

		// Token: 0x06039082 RID: 233602 RVA: 0x00FF996B File Offset: 0x00FF7B6B
		public UniTask PlayCloseSequenceAsync()
		{
			this.DialogueVersion++;
			this.HasDialogue = false;
			this.IsShowingText = false;
			this.CompleteTyping();
			return this.PlaySequenceAsync("Talk_Close");
		}

		// Token: 0x06039083 RID: 233603 RVA: 0x00FF999C File Offset: 0x00FF7B9C
		public void SetPaused(bool paused)
		{
			if (this.IsPaused == paused)
			{
				return;
			}
			this.IsPaused = paused;
			SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
			if (characterDialogueItem != null)
			{
				characterDialogueItem.SetPaused(paused);
			}
			SolarSchoolVisualNovelNarrationDialogueItem narrationDialogueItem = this.NarrationDialogueItem;
			if (narrationDialogueItem != null)
			{
				narrationDialogueItem.SetPaused(paused);
			}
			if (paused)
			{
				this.SequencePlayer.PauseSequence();
				return;
			}
			this.SequencePlayer.ResumeSequence();
		}

		// Token: 0x06039084 RID: 233604 RVA: 0x00FF99F8 File Offset: 0x00FF7BF8
		public void SetInputLocked(bool locked)
		{
			UUIButtonComponent button = base.GetButton(2);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!locked);
		}

		// Token: 0x06039085 RID: 233605 RVA: 0x00FF9A0F File Offset: 0x00FF7C0F
		public void SetContentVisible(bool visible)
		{
			base.GetItem(3).SetUIActive(visible);
		}

		// Token: 0x06039086 RID: 233606 RVA: 0x00FF9A1E File Offset: 0x00FF7C1E
		public void SetAssetCache(VisualNovelAssetCache assetCache)
		{
			SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
			if (characterDialogueItem == null)
			{
				return;
			}
			characterDialogueItem.SetAssetCache(assetCache);
		}

		// Token: 0x06039087 RID: 233607 RVA: 0x00FF9A31 File Offset: 0x00FF7C31
		public void SetAvatarConfig(int speakerId, IVisualNovelRoleConfig roleConfig)
		{
			SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
			if (characterDialogueItem == null)
			{
				return;
			}
			characterDialogueItem.SetAvatarConfig(speakerId, roleConfig);
		}

		// Token: 0x06039088 RID: 233608 RVA: 0x00FF9A48 File Offset: 0x00FF7C48
		public void HideDialogue()
		{
			this.DialogueVersion++;
			this.HasDialogue = false;
			this.CompleteTyping();
			this.IsShowingText = false;
			SolarSchoolVisualNovelCharacterDialogueItem characterDialogueItem = this.CharacterDialogueItem;
			if (characterDialogueItem != null)
			{
				characterDialogueItem.HideDialogue();
			}
			SolarSchoolVisualNovelNarrationDialogueItem narrationDialogueItem = this.NarrationDialogueItem;
			if (narrationDialogueItem != null)
			{
				narrationDialogueItem.HideDialogue();
			}
			base.SetUiActive(false);
		}

		// Token: 0x06039089 RID: 233609 RVA: 0x00FF9AA0 File Offset: 0x00FF7CA0
		private UniTask ShowDialogueAsync(int speakerId, string speakerName, string content, EVisualNovelPlaybackMode playbackMode, [Nullable(2)] VisualNovelAudioEvent voice = null)
		{
			SolarSchoolVisualNovelDialogueItem.<ShowDialogueAsync>d__35 <ShowDialogueAsync>d__;
			<ShowDialogueAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowDialogueAsync>d__.<>4__this = this;
			<ShowDialogueAsync>d__.speakerId = speakerId;
			<ShowDialogueAsync>d__.speakerName = speakerName;
			<ShowDialogueAsync>d__.content = content;
			<ShowDialogueAsync>d__.playbackMode = playbackMode;
			<ShowDialogueAsync>d__.voice = voice;
			<ShowDialogueAsync>d__.<>1__state = -1;
			<ShowDialogueAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelDialogueItem.<ShowDialogueAsync>d__35>(ref <ShowDialogueAsync>d__);
			return <ShowDialogueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603908A RID: 233610 RVA: 0x00FF9B10 File Offset: 0x00FF7D10
		private UniTask PlaySequenceAsync(string sequenceName)
		{
			this.SequencePlayer.StopCurrentSequence(false, false);
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			return this.SequencePlayer.PlaySequenceAsync(sequenceName, stopPromise, false, false, new float?(this.PlaybackRate), false);
		}

		// Token: 0x0603908B RID: 233611 RVA: 0x00FF9B4B File Offset: 0x00FF7D4B
		private void OnSequenceStarted(string sequenceName)
		{
			this.ApplySequencePlaybackRate(sequenceName);
			if (this.IsShowingText && this.CompleteTextImmediately)
			{
				this.SequencePlayer.StopSequenceByKey(sequenceName, true, true);
				return;
			}
			if (this.IsPaused)
			{
				this.SequencePlayer.PauseSequence();
			}
		}

		// Token: 0x0603908C RID: 233612 RVA: 0x00FF9B86 File Offset: 0x00FF7D86
		private void ApplySequencePlaybackRate(string sequenceName)
		{
			ALevelSequenceActor sequencePlayerByKey = this.RootActor.GetSequencePlayerByKey(sequenceName);
			if (sequencePlayerByKey == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(this.PlaybackRate);
		}

		// Token: 0x0603908D RID: 233613 RVA: 0x00FF9BAE File Offset: 0x00FF7DAE
		private void OnNextButtonClicked()
		{
			Action continueRequested = this.ContinueRequested;
			if (continueRequested == null)
			{
				return;
			}
			continueRequested();
		}

		// Token: 0x0401E033 RID: 122931
		private const string START_SEQUENCE = "Talk_Start";

		// Token: 0x0401E034 RID: 122932
		private const string CLOSE_SEQUENCE = "Talk_Close";

		// Token: 0x0401E035 RID: 122933
		[Nullable(2)]
		private SolarSchoolVisualNovelCharacterDialogueItem CharacterDialogueItem;

		// Token: 0x0401E036 RID: 122934
		[Nullable(2)]
		private SolarSchoolVisualNovelNarrationDialogueItem NarrationDialogueItem;

		// Token: 0x0401E037 RID: 122935
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401E038 RID: 122936
		private float PlaybackRate = 1f;

		// Token: 0x0401E039 RID: 122937
		private int CurrentSpeakerId;

		// Token: 0x0401E03A RID: 122938
		private int DialogueVersion;

		// Token: 0x0401E03B RID: 122939
		private bool HasDialogue;

		// Token: 0x0401E03C RID: 122940
		private bool IsShowingText;

		// Token: 0x0401E03D RID: 122941
		private bool CompleteTextImmediately;

		// Token: 0x0401E03E RID: 122942
		private bool IsPaused;

		// Token: 0x0200B665 RID: 46693
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040386DB RID: 231131
			public const int CharacterDialogueItem = 0;

			// Token: 0x040386DC RID: 231132
			public const int NarrationDialogueItem = 1;

			// Token: 0x040386DD RID: 231133
			public const int NextButton = 2;

			// Token: 0x040386DE RID: 231134
			public const int ContentItem = 3;
		}
	}
}
