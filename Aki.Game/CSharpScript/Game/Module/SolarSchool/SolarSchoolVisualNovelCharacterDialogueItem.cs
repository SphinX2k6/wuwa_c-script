using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A6A RID: 23146
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelCharacterDialogueItem : UiPanelBase
	{
		// Token: 0x17006CB8 RID: 27832
		// (get) Token: 0x06039043 RID: 233539 RVA: 0x00FF870B File Offset: 0x00FF690B
		public bool IsTyping
		{
			get
			{
				VisualNovelTextPlayer textPlayer = this.TextPlayer;
				return textPlayer != null && textPlayer.IsTyping;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06039044 RID: 233540 RVA: 0x00FF8720 File Offset: 0x00FF6920
		// (remove) Token: 0x06039045 RID: 233541 RVA: 0x00FF8758 File Offset: 0x00FF6958
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action ContinueRequested;

		// Token: 0x06039046 RID: 233542 RVA: 0x00FF8790 File Offset: 0x00FF6990
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039047 RID: 233543 RVA: 0x00FF883C File Offset: 0x00FF6A3C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolVisualNovelCharacterDialogueItem.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelCharacterDialogueItem.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039048 RID: 233544 RVA: 0x00FF8880 File Offset: 0x00FF6A80
		protected override void OnStart()
		{
			UUIText text = base.GetText(3);
			this.TextScroll.Init(new PlotTextScrollComponentContext
			{
				TextComponent = text,
				TextScrollView = base.GetScrollView(2)
			});
			this.TextScroll.EnableManualScroll(new Action(this.OnTextClicked));
			this.TextPlayer = new VisualNovelTextPlayer(text, this.TextScroll);
			this.HideDialogue();
		}

		// Token: 0x06039049 RID: 233545 RVA: 0x00FF88E8 File Offset: 0x00FF6AE8
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
			SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
			if (characterSpineItem != null)
			{
				VisualNovelSpineCharacter character = characterSpineItem.Character;
				if (character != null)
				{
					character.Reset();
				}
			}
			this.CharacterSpineItem = null;
			this.AvatarStates.Clear();
			this.AssetCache = null;
		}

		// Token: 0x0603904A RID: 233546 RVA: 0x00FF8954 File Offset: 0x00FF6B54
		public UniTask RefreshAsync(int speakerId, string speakerName, [Nullable(2)] VisualNovelAudioEvent voice)
		{
			SolarSchoolVisualNovelCharacterDialogueItem.<RefreshAsync>d__16 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.speakerId = speakerId;
			<RefreshAsync>d__.speakerName = speakerName;
			<RefreshAsync>d__.voice = voice;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelCharacterDialogueItem.<RefreshAsync>d__16>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603904B RID: 233547 RVA: 0x00FF89AF File Offset: 0x00FF6BAF
		public UniTask ShowTextAsync(string content, EVisualNovelPlaybackMode playbackMode)
		{
			return this.TextPlayer.PlayAsync(content, playbackMode);
		}

		// Token: 0x0603904C RID: 233548 RVA: 0x00FF89BE File Offset: 0x00FF6BBE
		public void CompleteTyping()
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer == null)
			{
				return;
			}
			textPlayer.CompleteTyping();
		}

		// Token: 0x0603904D RID: 233549 RVA: 0x00FF89D0 File Offset: 0x00FF6BD0
		public void SetPlaybackRate(float playbackRate)
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer != null)
			{
				textPlayer.SetPlaybackRate(playbackRate);
			}
			SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
			if (characterSpineItem == null)
			{
				return;
			}
			VisualNovelSpineCharacter character = characterSpineItem.Character;
			if (character == null)
			{
				return;
			}
			character.SetPlaybackRate(playbackRate);
		}

		// Token: 0x0603904E RID: 233550 RVA: 0x00FF89FF File Offset: 0x00FF6BFF
		public void SetPaused(bool paused)
		{
			VisualNovelTextPlayer textPlayer = this.TextPlayer;
			if (textPlayer != null)
			{
				textPlayer.SetPaused(paused);
			}
			SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
			if (characterSpineItem == null)
			{
				return;
			}
			VisualNovelSpineCharacter character = characterSpineItem.Character;
			if (character == null)
			{
				return;
			}
			character.SetPaused(paused);
		}

		// Token: 0x0603904F RID: 233551 RVA: 0x00FF8A30 File Offset: 0x00FF6C30
		public void SetAssetCache(VisualNovelAssetCache assetCache)
		{
			if (this.AssetCache != assetCache)
			{
				this.AvatarStates.Clear();
				SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
				if (characterSpineItem != null)
				{
					VisualNovelSpineCharacter character = characterSpineItem.Character;
					if (character != null)
					{
						character.Reset();
					}
				}
				this.AssetCache = assetCache;
			}
			SolarSchoolCharacterSpineItem characterSpineItem2 = this.CharacterSpineItem;
			if (characterSpineItem2 == null)
			{
				return;
			}
			characterSpineItem2.SetAssetCache(assetCache);
		}

		// Token: 0x06039050 RID: 233552 RVA: 0x00FF8A88 File Offset: 0x00FF6C88
		public void SetAvatarConfig(int speakerId, IVisualNovelRoleConfig roleConfig)
		{
			if (roleConfig.Expression == null && roleConfig.HideAvatar == null)
			{
				return;
			}
			VisualNovelAssetCache assetCache = this.AssetCache;
			int num = (assetCache != null) ? assetCache.ConfigCenter.GetAvgTalkerId(speakerId) : 0;
			if (num == 0)
			{
				return;
			}
			SolarSchoolVisualNovelCharacterDialogueItem.AvatarState valueOrDefault = this.AvatarStates.GetValueOrDefault(num, default(SolarSchoolVisualNovelCharacterDialogueItem.AvatarState));
			if (roleConfig.Expression != null)
			{
				valueOrDefault.AnimationId = roleConfig.Expression.Value;
			}
			if (roleConfig.HideAvatar != null)
			{
				valueOrDefault.Hidden = roleConfig.HideAvatar.Value;
			}
			this.AvatarStates[num] = valueOrDefault;
		}

		// Token: 0x06039051 RID: 233553 RVA: 0x00FF8B41 File Offset: 0x00FF6D41
		public void HideDialogue()
		{
			SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
			if (characterSpineItem != null)
			{
				VisualNovelSpineCharacter character = characterSpineItem.Character;
				if (character != null)
				{
					character.SetTemporarilyHidden(true);
				}
			}
			base.SetUiActive(false);
		}

		// Token: 0x06039052 RID: 233554 RVA: 0x00FF8B68 File Offset: 0x00FF6D68
		private UniTask ShowCharacterSpineAsync(int speakerId, int animationId, bool hideAvatar)
		{
			SolarSchoolVisualNovelCharacterDialogueItem.<ShowCharacterSpineAsync>d__24 <ShowCharacterSpineAsync>d__;
			<ShowCharacterSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowCharacterSpineAsync>d__.<>4__this = this;
			<ShowCharacterSpineAsync>d__.speakerId = speakerId;
			<ShowCharacterSpineAsync>d__.animationId = animationId;
			<ShowCharacterSpineAsync>d__.hideAvatar = hideAvatar;
			<ShowCharacterSpineAsync>d__.<>1__state = -1;
			<ShowCharacterSpineAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelCharacterDialogueItem.<ShowCharacterSpineAsync>d__24>(ref <ShowCharacterSpineAsync>d__);
			return <ShowCharacterSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039053 RID: 233555 RVA: 0x00FF8BC3 File Offset: 0x00FF6DC3
		private void OnTextClicked()
		{
			Action continueRequested = this.ContinueRequested;
			if (continueRequested == null)
			{
				return;
			}
			continueRequested();
		}

		// Token: 0x0401E017 RID: 122903
		private readonly Dictionary<int, SolarSchoolVisualNovelCharacterDialogueItem.AvatarState> AvatarStates = new Dictionary<int, SolarSchoolVisualNovelCharacterDialogueItem.AvatarState>();

		// Token: 0x0401E018 RID: 122904
		private readonly PlotTextScrollComponent TextScroll = new PlotTextScrollComponent();

		// Token: 0x0401E019 RID: 122905
		[Nullable(2)]
		private SolarSchoolCharacterSpineItem CharacterSpineItem;

		// Token: 0x0401E01A RID: 122906
		[Nullable(2)]
		private VisualNovelAssetCache AssetCache;

		// Token: 0x0401E01B RID: 122907
		[Nullable(2)]
		private VisualNovelTextPlayer TextPlayer;

		// Token: 0x0200B65B RID: 46683
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403869A RID: 231066
			public const int CharacterSpineItem = 0;

			// Token: 0x0403869B RID: 231067
			public const int SpeakerNameText = 1;

			// Token: 0x0403869C RID: 231068
			public const int DialogueScrollView = 2;

			// Token: 0x0403869D RID: 231069
			public const int DialogueText = 3;
		}

		// Token: 0x0200B65C RID: 46684
		[NullableContext(0)]
		private struct AvatarState
		{
			// Token: 0x0403869E RID: 231070
			public int AnimationId;

			// Token: 0x0403869F RID: 231071
			public bool Hidden;
		}
	}
}
