using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037C0 RID: 14272
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class VisualNovelSpineCharacter : VisualNovelCharacter
	{
		// Token: 0x17004C89 RID: 19593
		// (get) Token: 0x0602526E RID: 152174 RVA: 0x00A7ADB7 File Offset: 0x00A78FB7
		// (set) Token: 0x0602526F RID: 152175 RVA: 0x00A7ADBF File Offset: 0x00A78FBF
		public override int? CharacterId { get; protected set; }

		// Token: 0x06025270 RID: 152176 RVA: 0x00A7ADC8 File Offset: 0x00A78FC8
		[NullableContext(1)]
		public VisualNovelSpineCharacter(UUIItem characterRootItem, UUIItem spineParentItem, USpineSkeletonAnimationComponent characterSpine, LevelSequencePlayer sequencePlayer, [Nullable(new byte[]
		{
			1,
			2
		})] Func<VisualNovelAssetCache> getAssetCache, bool shouldApplyPortraitTransform, bool shouldPinRootToOrigin = false)
		{
			this.CharacterRootItem = characterRootItem;
			this.SpineParentItem = spineParentItem;
			this.CharacterSpine = characterSpine;
			this.SequencePlayer = sequencePlayer;
			this.GetAssetCache = getAssetCache;
			this.ShouldApplyPortraitTransform = shouldApplyPortraitTransform;
			this.ShouldPinRootToOrigin = shouldPinRootToOrigin;
			this.SpineParentOriginX = spineParentItem.GetAnchorOffsetX();
			this.SpineParentOriginY = spineParentItem.GetAnchorOffsetY();
			this.SpineParentOriginScale = spineParentItem.RelativeScale3D;
			this.CurrentTransform = new VisualNovelTransform(characterRootItem.GetAnchorOffsetX(), characterRootItem.GetAnchorOffsetY(), 1f);
			this.RootOriginTransform = this.CurrentTransform;
			this.MoveTargetTransform = this.CurrentTransform;
			this.CharacterRenderable = (characterSpine.GetOwner().GetComponentByClass(UUISpineRenderable.StaticClass()) as UUISpineRenderable);
			this.Reset();
		}

		// Token: 0x06025271 RID: 152177 RVA: 0x00A7AF00 File Offset: 0x00A79100
		public override bool Load(int characterId)
		{
			this.PrepareLoad(characterId);
			VisualNovelAssetCache visualNovelAssetCache = this.GetAssetCache();
			VisualNovelSpineCharacterAssets visualNovelSpineCharacterAssets = (visualNovelAssetCache != null) ? visualNovelAssetCache.GetSpineAssets(characterId) : null;
			if (visualNovelSpineCharacterAssets == null || !this.CharacterSpine.IsValid())
			{
				this.Reset();
				return false;
			}
			this.CharacterSpine.Atlas = visualNovelSpineCharacterAssets.Atlas;
			this.CharacterSpine.SkeletonData = visualNovelSpineCharacterAssets.SkeletonData;
			if (this.ShouldPinRootToOrigin)
			{
				this.SetTransform(new VisualNovelTransform(0f, 0f, 1f));
			}
			if (this.ShouldApplyPortraitTransform)
			{
				this.ApplyPortraitTransform(visualNovelSpineCharacterAssets.PortraitTransform);
			}
			this.CharacterSpine.ClearTracks();
			this.CharacterSpine.SetToSetupPose();
			this.CurrentBodyAnimation = null;
			this.CurrentMouthAnimation = null;
			this.ClosedMouthAnimation = null;
			this.SmallMouthAnimation = null;
			this.LargeMouthAnimation = null;
			this.CurrentEyeAnimation = null;
			this.CurrentBlinkAnimation = null;
			VisualNovelAssetCache visualNovelAssetCache2 = this.GetAssetCache();
			this.State = new VisualNovelCharacterState(characterId, (visualNovelAssetCache2 != null) ? visualNovelAssetCache2.ConfigCenter.GetAvgTalkerId(characterId) : 0)
			{
				Transform = this.GetTransform(),
				VisualEffect = EAvgVisualEffect.Highlight
			};
			this.ApplyAnimation(this.State.AnimationId, this.State.AvgTalkerId);
			this.ApplyColor(VisualNovelSpineCharacter.ResolveColor(this.State), true);
			return true;
		}

		// Token: 0x06025272 RID: 152178 RVA: 0x00A7B04F File Offset: 0x00A7924F
		public void SetBlinkEnabled(bool enabled)
		{
			if (this.BlinkEnabled == enabled)
			{
				return;
			}
			this.BlinkEnabled = enabled;
			if (enabled)
			{
				this.ScheduleBlink();
				return;
			}
			this.StopBlinking();
		}

		// Token: 0x06025273 RID: 152179 RVA: 0x00A7B074 File Offset: 0x00A79274
		[NullableContext(1)]
		public override void SetVoice(VisualNovelAudioEvent voice)
		{
			if (this.CharacterId == null || this.Voice == voice)
			{
				return;
			}
			this.StopTalking();
			if (voice.IsCompleted)
			{
				return;
			}
			this.Voice = voice;
			this.FollowVoiceAsync(voice, this.VoiceVersion).Forget();
		}

		// Token: 0x06025274 RID: 152180 RVA: 0x00A7B0C4 File Offset: 0x00A792C4
		[NullableContext(1)]
		private UniTask FollowVoiceAsync(VisualNovelAudioEvent voice, int version)
		{
			VisualNovelSpineCharacter.<FollowVoiceAsync>d__61 <FollowVoiceAsync>d__;
			<FollowVoiceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FollowVoiceAsync>d__.<>4__this = this;
			<FollowVoiceAsync>d__.voice = voice;
			<FollowVoiceAsync>d__.version = version;
			<FollowVoiceAsync>d__.<>1__state = -1;
			<FollowVoiceAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<FollowVoiceAsync>d__61>(ref <FollowVoiceAsync>d__);
			return <FollowVoiceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06025275 RID: 152181 RVA: 0x00A7B118 File Offset: 0x00A79318
		[NullableContext(1)]
		public override void ApplyState(VisualNovelCharacterState state)
		{
			int? characterId = this.CharacterId;
			int num = state.CharacterId;
			if (!(characterId.GetValueOrDefault() == num & characterId != null))
			{
				return;
			}
			num = base.TransformVersion;
			base.TransformVersion = num + 1;
			this.State = state.Clone();
			this.ShouldShowPortrait = !this.State.IsPortraitHidden;
			this.SetTransform(this.State.Transform);
			this.ApplyColor(VisualNovelSpineCharacter.ResolveColor(this.State), false);
			this.ApplyAnimation(this.State.AnimationId, this.State.AvgTalkerId);
			if (this.IsShown)
			{
				this.SetVisible(this.ShouldShowPortrait);
			}
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Transform), null);
		}

		// Token: 0x06025276 RID: 152182 RVA: 0x00A7B1D8 File Offset: 0x00A793D8
		public override VisualNovelTransform GetTransform()
		{
			return this.CurrentTransform;
		}

		// Token: 0x06025277 RID: 152183 RVA: 0x00A7B1E0 File Offset: 0x00A793E0
		public override void Modify(float? x, float? y, float? scale, int? animationId, EAvgVisualEffect? visualEffect, bool? hidePortrait)
		{
			if (this.State == null)
			{
				return;
			}
			bool flag = x != null || y != null || scale != null;
			if (flag)
			{
				int transformVersion = base.TransformVersion;
				base.TransformVersion = transformVersion + 1;
			}
			this.State.Apply(x, y, scale, animationId, visualEffect, hidePortrait);
			if (flag)
			{
				this.SetTransform(this.State.Transform);
			}
			if (animationId != null)
			{
				this.ApplyAnimation(this.State.AnimationId, this.State.AvgTalkerId);
			}
			if (visualEffect != null)
			{
				this.ApplyColor(VisualNovelSpineCharacter.ResolveColor(this.State), false);
			}
			if (hidePortrait != null)
			{
				this.ShouldShowPortrait = !this.State.IsPortraitHidden;
				this.SetVisible(this.IsShown && this.ShouldShowPortrait);
			}
			if (flag)
			{
				base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Transform), null);
			}
		}

		// Token: 0x06025278 RID: 152184 RVA: 0x00A7B2D0 File Offset: 0x00A794D0
		public override void SetSpeaking(bool speaking)
		{
			if (this.State == null)
			{
				return;
			}
			EAvgVisualEffect eavgVisualEffect = speaking ? EAvgVisualEffect.Highlight : EAvgVisualEffect.Darken;
			if (this.State.IsSpeaking == speaking && this.State.VisualEffect == eavgVisualEffect)
			{
				return;
			}
			this.State.IsSpeaking = speaking;
			this.State.VisualEffect = eavgVisualEffect;
			this.ApplyColor(VisualNovelSpineCharacter.ResolveColor(this.State), false);
		}

		// Token: 0x06025279 RID: 152185 RVA: 0x00A7B338 File Offset: 0x00A79538
		public override UniTask ShowAsync(float fadeDuration)
		{
			VisualNovelSpineCharacter.<ShowAsync>d__66 <ShowAsync>d__;
			<ShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAsync>d__.<>4__this = this;
			<ShowAsync>d__.fadeDuration = fadeDuration;
			<ShowAsync>d__.<>1__state = -1;
			<ShowAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<ShowAsync>d__66>(ref <ShowAsync>d__);
			return <ShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602527A RID: 152186 RVA: 0x00A7B384 File Offset: 0x00A79584
		public override UniTask HideAsync(float fadeDuration)
		{
			VisualNovelSpineCharacter.<HideAsync>d__67 <HideAsync>d__;
			<HideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideAsync>d__.<>4__this = this;
			<HideAsync>d__.fadeDuration = fadeDuration;
			<HideAsync>d__.<>1__state = -1;
			<HideAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<HideAsync>d__67>(ref <HideAsync>d__);
			return <HideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602527B RID: 152187 RVA: 0x00A7B3D0 File Offset: 0x00A795D0
		public override UniTask MoveAsync(VisualNovelCharacterMoveParameters parameters)
		{
			VisualNovelSpineCharacter.<MoveAsync>d__68 <MoveAsync>d__;
			<MoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveAsync>d__.<>4__this = this;
			<MoveAsync>d__.parameters = parameters;
			<MoveAsync>d__.<>1__state = -1;
			<MoveAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<MoveAsync>d__68>(ref <MoveAsync>d__);
			return <MoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602527C RID: 152188 RVA: 0x00A7B41C File Offset: 0x00A7961C
		public override UniTask PlayEffectAsync(EVisualNovelPortraitEffectType effect, float distance)
		{
			VisualNovelSpineCharacter.<PlayEffectAsync>d__69 <PlayEffectAsync>d__;
			<PlayEffectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEffectAsync>d__.<>4__this = this;
			<PlayEffectAsync>d__.effect = effect;
			<PlayEffectAsync>d__.distance = distance;
			<PlayEffectAsync>d__.<>1__state = -1;
			<PlayEffectAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<PlayEffectAsync>d__69>(ref <PlayEffectAsync>d__);
			return <PlayEffectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602527D RID: 152189 RVA: 0x00A7B470 File Offset: 0x00A79670
		public override void FinishShow(int version)
		{
			if (version != base.VisibilityVersion)
			{
				return;
			}
			int visibilityVersion = base.VisibilityVersion;
			base.VisibilityVersion = visibilityVersion + 1;
			this.IsShown = true;
			this.SetFadeAlpha(1f);
			this.SetVisible(this.ShouldShowPortrait);
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Visibility), null);
		}

		// Token: 0x0602527E RID: 152190 RVA: 0x00A7B4C4 File Offset: 0x00A796C4
		public override void FinishHide(int version)
		{
			if (version != base.VisibilityVersion)
			{
				return;
			}
			int visibilityVersion = base.VisibilityVersion;
			base.VisibilityVersion = visibilityVersion + 1;
			this.IsShown = false;
			this.SetFadeAlpha(0f);
			this.SetVisible(false);
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Visibility), null);
		}

		// Token: 0x0602527F RID: 152191 RVA: 0x00A7B514 File Offset: 0x00A79714
		public override void FinishMove(int version)
		{
			if (version != base.TransformVersion)
			{
				return;
			}
			int transformVersion = base.TransformVersion;
			base.TransformVersion = transformVersion + 1;
			this.SetTransform(this.MoveTargetTransform);
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Transform), null);
		}

		// Token: 0x06025280 RID: 152192 RVA: 0x00A7B554 File Offset: 0x00A79754
		public override void FinishEffect(int version)
		{
			if (version != base.EffectVersion)
			{
				return;
			}
			int effectVersion = base.EffectVersion;
			base.EffectVersion = effectVersion + 1;
			this.SetEffectOffset(0f, 0f);
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Effect), new Action(this.FinishShake));
		}

		// Token: 0x06025281 RID: 152193 RVA: 0x00A7B5A3 File Offset: 0x00A797A3
		public override void SetTemporarilyHidden(bool hidden)
		{
			if (this.IsTemporarilyHidden == hidden)
			{
				return;
			}
			this.IsTemporarilyHidden = hidden;
			this.SetVisible(this.IsShown && this.ShouldShowPortrait);
		}

		// Token: 0x06025282 RID: 152194 RVA: 0x00A7B5D0 File Offset: 0x00A797D0
		public override void Reset()
		{
			this.InvalidateOperations();
			this.State = null;
			this.SetEffectOffset(0f, 0f);
			this.SetTransform(this.RootOriginTransform);
			this.ResetRuntimeState();
			this.ResetAppearance();
			this.SetVisible(false);
			this.StopTalking();
			this.StopBlinking();
			this.CharacterSpine.Atlas = null;
			this.CharacterSpine.SkeletonData = null;
			this.CharacterSpine.ClearTracks();
			Action beforeComplete = new Action(this.FinishShake);
			base.StopTweens(null, beforeComplete);
		}

		// Token: 0x06025283 RID: 152195 RVA: 0x00A7B668 File Offset: 0x00A79868
		public void ApplyInitialVisibility(bool visible)
		{
			bool visible2 = visible && this.CharacterId != null && this.ShouldShowPortrait;
			this.SetFadeAlpha(1f);
			this.SetVisible(visible2);
		}

		// Token: 0x06025284 RID: 152196 RVA: 0x00A7B6A4 File Offset: 0x00A798A4
		public override void Destroy()
		{
			this.Reset();
		}

		// Token: 0x06025285 RID: 152197 RVA: 0x00A7B6AC File Offset: 0x00A798AC
		public override void SetPaused(bool paused)
		{
			base.SetPaused(paused);
			this.IsPaused = paused;
			this.CharacterSpine.SetTimeScale(paused ? 0f : this.SpinePlaybackRate);
			VisualNovelSpineCharacter.SetTimerPaused(this.BlinkIntervalTimer, paused);
			VisualNovelSpineCharacter.SetTimerPaused(this.MouthRefreshTimer, paused);
			if (!paused)
			{
				this.StartMouthAnimation();
			}
			this.RefreshShakePlayback();
		}

		// Token: 0x06025286 RID: 152198 RVA: 0x00A7B709 File Offset: 0x00A79909
		public override void SetPlaybackRate(float playbackRate)
		{
			base.SetPlaybackRate(playbackRate);
			this.SpinePlaybackRate = playbackRate;
			if (!this.IsPaused)
			{
				this.CharacterSpine.SetTimeScale(this.SpinePlaybackRate);
			}
			this.RefreshShakePlayback();
		}

		// Token: 0x06025287 RID: 152199 RVA: 0x00A7B738 File Offset: 0x00A79938
		private void InvalidateOperations()
		{
			int num = base.VisibilityVersion;
			base.VisibilityVersion = num + 1;
			num = base.TransformVersion;
			base.TransformVersion = num + 1;
			num = base.EffectVersion;
			base.EffectVersion = num + 1;
			this.ColorVersion++;
		}

		// Token: 0x06025288 RID: 152200 RVA: 0x00A7B784 File Offset: 0x00A79984
		private void ResetRuntimeState()
		{
			this.CharacterId = null;
			this.IsShown = false;
			this.IsTemporarilyHidden = false;
			this.ShouldShowPortrait = true;
			this.CurrentScale = 1f;
			this.CurrentBodyAnimation = null;
			this.CurrentMouthAnimation = null;
			this.ClosedMouthAnimation = null;
			this.SmallMouthAnimation = null;
			this.LargeMouthAnimation = null;
			this.CurrentEyeAnimation = null;
			this.CurrentBlinkAnimation = null;
			this.IsEyeTrackBlinking = false;
			this.CurrentMouthShape = EVisualNovelMouthShape.Closed;
		}

		// Token: 0x06025289 RID: 152201 RVA: 0x00A7B7FF File Offset: 0x00A799FF
		private void ResetAppearance()
		{
			this.SetFadeAlpha(1f);
			this.ApplyColor(VisualNovelSpineCharacter.HighlightColor, true);
		}

		// Token: 0x0602528A RID: 152202 RVA: 0x00A7B818 File Offset: 0x00A79A18
		private void ApplyColor(FColor color, bool immediately = false)
		{
			if (!immediately && this.TargetColor == color)
			{
				return;
			}
			this.TargetColor = color;
			int num = this.ColorVersion + 1;
			this.ColorVersion = num;
			int num2 = num;
			if (immediately || !this.IsShown || !this.CharacterRootItem.IsUIActiveSelf())
			{
				this.CurrentColor = color;
				this.RefreshColor();
				base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Color), null);
				return;
			}
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Color), null);
			if (this.ColorVersion != num2)
			{
				return;
			}
			this.PlayColorTransitionAsync(this.CurrentColor, color, num2).Forget();
		}

		// Token: 0x0602528B RID: 152203 RVA: 0x00A7B8B0 File Offset: 0x00A79AB0
		private UniTask PlayColorTransitionAsync(FColor start, FColor target, int colorVersion)
		{
			VisualNovelSpineCharacter.<PlayColorTransitionAsync>d__84 <PlayColorTransitionAsync>d__;
			<PlayColorTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayColorTransitionAsync>d__.<>4__this = this;
			<PlayColorTransitionAsync>d__.start = start;
			<PlayColorTransitionAsync>d__.target = target;
			<PlayColorTransitionAsync>d__.colorVersion = colorVersion;
			<PlayColorTransitionAsync>d__.<>1__state = -1;
			<PlayColorTransitionAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<PlayColorTransitionAsync>d__84>(ref <PlayColorTransitionAsync>d__);
			return <PlayColorTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602528C RID: 152204 RVA: 0x00A7B90B File Offset: 0x00A79B0B
		private void SetFadeAlpha(float alpha)
		{
			this.FadeAlpha = alpha;
			this.RefreshColor();
		}

		// Token: 0x0602528D RID: 152205 RVA: 0x00A7B91C File Offset: 0x00A79B1C
		private void RefreshColor()
		{
			byte r = (byte)((float)this.CurrentColor.R * this.FadeAlpha);
			byte g = (byte)((float)this.CurrentColor.G * this.FadeAlpha);
			byte b = (byte)((float)this.CurrentColor.B * this.FadeAlpha);
			byte a = (byte)((float)this.CurrentColor.A * this.FadeAlpha);
			this.CharacterRenderable.SetColor(new FColor(r, g, b, a));
		}

		// Token: 0x0602528E RID: 152206 RVA: 0x00A7B994 File Offset: 0x00A79B94
		private UniTask PlayEffectYAsync(float origin, float target, float end, int effectVersion)
		{
			VisualNovelSpineCharacter.<PlayEffectYAsync>d__87 <PlayEffectYAsync>d__;
			<PlayEffectYAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEffectYAsync>d__.<>4__this = this;
			<PlayEffectYAsync>d__.origin = origin;
			<PlayEffectYAsync>d__.target = target;
			<PlayEffectYAsync>d__.end = end;
			<PlayEffectYAsync>d__.effectVersion = effectVersion;
			<PlayEffectYAsync>d__.<>1__state = -1;
			<PlayEffectYAsync>d__.<>t__builder.Start<VisualNovelSpineCharacter.<PlayEffectYAsync>d__87>(ref <PlayEffectYAsync>d__);
			return <PlayEffectYAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602528F RID: 152207 RVA: 0x00A7B9F8 File Offset: 0x00A79BF8
		private UniTask PlayShakeAsync()
		{
			CustomPromise<bool> stopPromise = new CustomPromise<bool>();
			UniTask result = this.SequencePlayer.PlaySequenceAsync("shake", stopPromise, false, false, new float?(this.SpinePlaybackRate), false);
			this.RefreshShakePlayback();
			return result;
		}

		// Token: 0x06025290 RID: 152208 RVA: 0x00A7BA30 File Offset: 0x00A79C30
		private void FinishShake()
		{
			if (!this.SequencePlayer.IsPlayingSequence("shake"))
			{
				return;
			}
			this.SequencePlayer.StopSequenceByKey("shake", false, true);
		}

		// Token: 0x06025291 RID: 152209 RVA: 0x00A7BA58 File Offset: 0x00A79C58
		private void RefreshShakePlayback()
		{
			if (!this.SequencePlayer.IsPlayingSequence("shake"))
			{
				return;
			}
			ALevelSequenceActor sequencePlayerByKey = (this.CharacterRootItem.GetOwner() as AUIBaseActor).GetSequencePlayerByKey("shake");
			ULevelSequencePlayer ulevelSequencePlayer = (sequencePlayerByKey != null) ? sequencePlayerByKey.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				return;
			}
			ulevelSequencePlayer.SetPlayRate(this.SpinePlaybackRate);
			if (this.IsPaused)
			{
				ulevelSequencePlayer.Pause();
				return;
			}
			if (ulevelSequencePlayer.IsPaused())
			{
				ulevelSequencePlayer.Play();
			}
		}

		// Token: 0x06025292 RID: 152210 RVA: 0x00A7BACC File Offset: 0x00A79CCC
		private void SetTransform(VisualNovelTransform transform)
		{
			this.CurrentTransform = transform;
			if (this.State != null)
			{
				this.State.Transform = transform;
			}
			this.RefreshPosition();
			this.SetScale(transform.Scale);
		}

		// Token: 0x06025293 RID: 152211 RVA: 0x00A7BAFC File Offset: 0x00A79CFC
		private void SetEffectOffset(float x, float y)
		{
			this.EffectOffsetX = x;
			this.EffectOffsetY = y;
			this.RefreshPosition();
		}

		// Token: 0x06025294 RID: 152212 RVA: 0x00A7BB12 File Offset: 0x00A79D12
		private void RefreshPosition()
		{
			this.CharacterRootItem.SetAnchorOffsetX(this.CurrentTransform.X + this.EffectOffsetX);
			this.CharacterRootItem.SetAnchorOffsetY(this.CurrentTransform.Y + this.EffectOffsetY);
		}

		// Token: 0x06025295 RID: 152213 RVA: 0x00A7BB50 File Offset: 0x00A79D50
		private void ApplyLerp(VisualNovelTransform start, VisualNovelTransform target, float progress)
		{
			float x = MathUtils.Instance.Lerp(start.X, target.X, progress);
			float y = MathUtils.Instance.Lerp(start.Y, target.Y, progress);
			float scale = MathUtils.Instance.Lerp(start.Scale, target.Scale, progress);
			this.SetTransform(new VisualNovelTransform(x, y, scale));
		}

		// Token: 0x06025296 RID: 152214 RVA: 0x00A7BBBC File Offset: 0x00A79DBC
		public void ApplyAnimation(int animationId)
		{
			if (this.State != null)
			{
				this.State.AnimationId = animationId;
			}
			int num;
			if (this.CharacterId == null)
			{
				num = 0;
			}
			else
			{
				VisualNovelAssetCache visualNovelAssetCache = this.GetAssetCache();
				num = ((visualNovelAssetCache != null) ? visualNovelAssetCache.ConfigCenter.GetAvgTalkerId(this.CharacterId.Value) : 0);
			}
			int avgTalkerId = num;
			this.ApplyAnimation(animationId, avgTalkerId);
		}

		// Token: 0x06025297 RID: 152215 RVA: 0x00A7BC24 File Offset: 0x00A79E24
		private unsafe void ApplyAnimation(int animationId, int avgTalkerId)
		{
			VisualNovelAssetCache visualNovelAssetCache = this.GetAssetCache();
			VisualNovelConfigCenter visualNovelConfigCenter = (visualNovelAssetCache != null) ? visualNovelAssetCache.ConfigCenter : null;
			if (animationId == 0 && this.CharacterId != null)
			{
				animationId = ((visualNovelConfigCenter != null) ? visualNovelConfigCenter.GetDefaultCharacterAnimationId(this.CharacterId.Value) : 0);
			}
			if (animationId == 0)
			{
				this.ApplyDefaultAnimation();
				return;
			}
			VisualNovelCharacterAnimation? visualNovelCharacterAnimation = (visualNovelConfigCenter != null) ? visualNovelConfigCenter.GetCharacterAnimation(animationId) : null;
			if (visualNovelCharacterAnimation == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.VisualNovel;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "视觉小说角色组合动画配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("animationId", animationId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ApplyDefaultAnimation();
				return;
			}
			if (avgTalkerId != 0 && visualNovelCharacterAnimation.Value.AvgTalkerId != avgTalkerId)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.VisualNovel;
				ELogAuthor author2 = ELogAuthor.LZK;
				string message2 = "视觉小说角色组合动画与 AVG 对话人不匹配";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("animationId", animationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("expectedAvgTalkerId", avgTalkerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("configuredAvgTalkerId", visualNovelCharacterAnimation.Value.AvgTalkerId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.ApplyDefaultAnimation();
				return;
			}
			this.PlayTrackAnimation(0, string.IsNullOrEmpty(visualNovelCharacterAnimation.Value.Body) ? "1_1" : visualNovelCharacterAnimation.Value.Body, ref this.CurrentBodyAnimation);
			this.SetMouthAnimations(visualNovelCharacterAnimation.Value.Mouth, visualNovelCharacterAnimation.Value.MouthOpenSmall, visualNovelCharacterAnimation.Value.MouthOpenLarge);
			this.ApplyOptionalTrack(2, visualNovelCharacterAnimation.Value.Eye, ref this.CurrentEyeAnimation);
			this.SetBlinkAnimation(visualNovelCharacterAnimation.Value.Blink);
		}

		// Token: 0x06025298 RID: 152216 RVA: 0x00A7BE2D File Offset: 0x00A7A02D
		private void SetScale(float scale)
		{
			this.CurrentScale = scale;
			this.TempScale.X = scale;
			this.TempScale.Y = scale;
			this.CharacterRootItem.SetUIItemScale(this.TempScale);
		}

		// Token: 0x06025299 RID: 152217 RVA: 0x00A7BE60 File Offset: 0x00A7A060
		private void ApplyPortraitTransform(VisualNovelTransform? transform)
		{
			this.SpineParentItem.SetAnchorOffsetX(this.SpineParentOriginX + ((transform != null) ? transform.GetValueOrDefault().X : 0f));
			this.SpineParentItem.SetAnchorOffsetY(this.SpineParentOriginY + ((transform != null) ? transform.GetValueOrDefault().Y : 0f));
			float num = (transform != null) ? transform.GetValueOrDefault().Scale : 1f;
			this.TempPortraitScale.X = num;
			this.TempPortraitScale.Y = num;
			this.SpineParentItem.SetUIItemScale(this.TempPortraitScale);
		}

		// Token: 0x0602529A RID: 152218 RVA: 0x00A7BF18 File Offset: 0x00A7A118
		public void ApplyHeadIconTransform(VisualNovelTransform transform)
		{
			this.SpineParentItem.SetAnchorOffsetX(this.SpineParentOriginX + transform.X);
			this.SpineParentItem.SetAnchorOffsetY(this.SpineParentOriginY + transform.Y);
			this.TempPortraitScale.X = this.SpineParentOriginScale.X * transform.Scale;
			this.TempPortraitScale.Y = this.SpineParentOriginScale.Y * transform.Scale;
			this.TempPortraitScale.Z = this.SpineParentOriginScale.Z;
			this.SpineParentItem.SetUIItemScale(this.TempPortraitScale);
		}

		// Token: 0x0602529B RID: 152219 RVA: 0x00A7BFBA File Offset: 0x00A7A1BA
		[NullableContext(1)]
		private void PlayTrackAnimation(int track, string animation, [Nullable(2)] ref string currentAnimation)
		{
			if (currentAnimation == animation)
			{
				return;
			}
			this.CharacterSpine.SetAnimation(track, animation, true);
			currentAnimation = animation;
		}

		// Token: 0x0602529C RID: 152220 RVA: 0x00A7BFDC File Offset: 0x00A7A1DC
		private void ApplyDefaultAnimation()
		{
			this.PlayTrackAnimation(0, "1_1", ref this.CurrentBodyAnimation);
			this.ClearTrack(1, ref this.CurrentMouthAnimation);
			this.ClosedMouthAnimation = null;
			this.SmallMouthAnimation = null;
			this.LargeMouthAnimation = null;
			VisualNovelSpineCharacter.RemoveTimer(ref this.MouthRefreshTimer);
			this.CurrentMouthShape = EVisualNovelMouthShape.Closed;
			this.ClearTrack(2, ref this.CurrentEyeAnimation);
			this.StopBlinking();
			this.CurrentBlinkAnimation = null;
		}

		// Token: 0x0602529D RID: 152221 RVA: 0x00A7C049 File Offset: 0x00A7A249
		private void ApplyOptionalTrack(int track, string animation, ref string currentAnimation)
		{
			if (string.IsNullOrEmpty(animation))
			{
				this.ClearTrack(track, ref currentAnimation);
				return;
			}
			this.PlayTrackAnimation(track, animation, ref currentAnimation);
		}

		// Token: 0x0602529E RID: 152222 RVA: 0x00A7C065 File Offset: 0x00A7A265
		private void ClearTrack(int track, ref string currentAnimation)
		{
			if (currentAnimation == null)
			{
				return;
			}
			this.CharacterSpine.SetEmptyAnimation(track, 0f);
			currentAnimation = null;
		}

		// Token: 0x0602529F RID: 152223 RVA: 0x00A7C081 File Offset: 0x00A7A281
		private void SetBlinkAnimation(string animation)
		{
			if (this.CurrentBlinkAnimation == animation)
			{
				return;
			}
			this.StopBlinking();
			this.CurrentBlinkAnimation = (string.IsNullOrEmpty(animation) ? null : animation);
			this.ScheduleBlink();
		}

		// Token: 0x060252A0 RID: 152224 RVA: 0x00A7C0B0 File Offset: 0x00A7A2B0
		private void ScheduleBlink()
		{
			if (!this.BlinkEnabled || this.CurrentBlinkAnimation == null || this.CurrentEyeAnimation == null || this.CharacterId == null)
			{
				return;
			}
			if (!this.CharacterRootItem.IsUIActiveSelf() || this.IsTemporarilyHidden)
			{
				return;
			}
			if (this.BlinkIntervalTimer != null)
			{
				return;
			}
			float num = 3f + Random.Shared.NextSingle() * 3f;
			this.BlinkIntervalTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.PlayBlink();
			}, num * 1000f, null, "VisualNovelCharacterBlinkDelay", true, 1f);
			VisualNovelSpineCharacter.SetTimerPaused(this.BlinkIntervalTimer, this.IsPaused);
		}

		// Token: 0x060252A1 RID: 152225 RVA: 0x00A7C15C File Offset: 0x00A7A35C
		private void PlayBlink()
		{
			this.BlinkIntervalTimer = null;
			if (!this.BlinkEnabled || this.CurrentBlinkAnimation == null || this.CurrentEyeAnimation == null || this.CharacterId == null)
			{
				return;
			}
			if (!this.CharacterRootItem.IsUIActiveSelf() || this.IsTemporarilyHidden)
			{
				return;
			}
			this.CharacterSpine.SetAnimation(2, this.CurrentBlinkAnimation, false);
			this.CharacterSpine.AddAnimation(2, this.CurrentEyeAnimation, true, 0f);
			this.IsEyeTrackBlinking = true;
			this.ScheduleBlink();
		}

		// Token: 0x060252A2 RID: 152226 RVA: 0x00A7C1E9 File Offset: 0x00A7A3E9
		private void StopBlinking()
		{
			VisualNovelSpineCharacter.RemoveTimer(ref this.BlinkIntervalTimer);
			if (!this.IsEyeTrackBlinking)
			{
				return;
			}
			this.IsEyeTrackBlinking = false;
			if (this.CurrentEyeAnimation != null)
			{
				this.CharacterSpine.SetAnimation(2, this.CurrentEyeAnimation, true);
			}
		}

		// Token: 0x060252A3 RID: 152227 RVA: 0x00A7C224 File Offset: 0x00A7A424
		private void SetMouthAnimations(string closed, string small, string large)
		{
			if (this.ClosedMouthAnimation == closed && this.SmallMouthAnimation == small && this.LargeMouthAnimation == large)
			{
				return;
			}
			this.ClosedMouthAnimation = closed;
			this.SmallMouthAnimation = small;
			this.LargeMouthAnimation = large;
			this.ApplyMouthShape(this.CurrentMouthShape);
			this.StartMouthAnimation();
		}

		// Token: 0x060252A4 RID: 152228 RVA: 0x00A7C284 File Offset: 0x00A7A484
		private void StartMouthAnimation()
		{
			if (this.IsTalking)
			{
				VisualNovelAudioEvent voice = this.Voice;
				if (voice != null && !voice.IsCompleted && this.Voice.HasMouthAnimation())
				{
					if (!this.CharacterRootItem.IsUIActiveSelf() || this.IsTemporarilyHidden)
					{
						return;
					}
					if (string.IsNullOrEmpty(this.SmallMouthAnimation) && string.IsNullOrEmpty(this.LargeMouthAnimation))
					{
						VisualNovelSpineCharacter.RemoveTimer(ref this.MouthRefreshTimer);
						this.ApplyMouthShape(EVisualNovelMouthShape.Closed);
						return;
					}
					this.RefreshMouthShape();
					if (this.MouthRefreshTimer != null)
					{
						return;
					}
					this.MouthRefreshTimer = TimerSystem.Instance.Forever(delegate(float _)
					{
						this.RefreshMouthShape();
					}, 33.333332f, 1f, null, "VisualNovelCharacterMouth", true);
					VisualNovelSpineCharacter.SetTimerPaused(this.MouthRefreshTimer, this.IsPaused);
					return;
				}
			}
		}

		// Token: 0x060252A5 RID: 152229 RVA: 0x00A7C34B File Offset: 0x00A7A54B
		private void RefreshMouthShape()
		{
			if (this.IsTalking)
			{
				VisualNovelAudioEvent voice = this.Voice;
				if (voice != null && !voice.IsCompleted)
				{
					this.ApplyMouthShape(this.Voice.GetMouthShape());
					return;
				}
			}
		}

		// Token: 0x060252A6 RID: 152230 RVA: 0x00A7C37B File Offset: 0x00A7A57B
		private void StopTalking()
		{
			this.VoiceVersion++;
			this.Voice = null;
			this.IsTalking = false;
			VisualNovelSpineCharacter.RemoveTimer(ref this.MouthRefreshTimer);
			this.ApplyMouthShape(EVisualNovelMouthShape.Closed);
		}

		// Token: 0x060252A7 RID: 152231 RVA: 0x00A7C3AC File Offset: 0x00A7A5AC
		private void ApplyMouthShape(EVisualNovelMouthShape shape)
		{
			this.CurrentMouthShape = shape;
			string text;
			if (shape != EVisualNovelMouthShape.Small)
			{
				if (shape != EVisualNovelMouthShape.Large)
				{
					text = this.ClosedMouthAnimation;
				}
				else
				{
					text = this.LargeMouthAnimation;
				}
			}
			else
			{
				text = this.SmallMouthAnimation;
			}
			string text2 = text;
			if (shape != EVisualNovelMouthShape.Closed && string.IsNullOrEmpty(text2))
			{
				text2 = ((shape == EVisualNovelMouthShape.Small) ? this.LargeMouthAnimation : this.SmallMouthAnimation);
			}
			if (string.IsNullOrEmpty(text2))
			{
				text2 = this.ClosedMouthAnimation;
			}
			this.ApplyOptionalTrack(1, text2, ref this.CurrentMouthAnimation);
		}

		// Token: 0x060252A8 RID: 152232 RVA: 0x00A7C420 File Offset: 0x00A7A620
		private static void SetTimerPaused(TimerHandle timer, bool paused)
		{
			if (timer == null || timer.IsPause() == paused)
			{
				return;
			}
			if (paused)
			{
				timer.Pause();
				return;
			}
			timer.Resume();
		}

		// Token: 0x060252A9 RID: 152233 RVA: 0x00A7C441 File Offset: 0x00A7A641
		private static void RemoveTimer(ref TimerHandle timer)
		{
			TimerHandle timerHandle = timer;
			if (timerHandle != null && timerHandle.Valid())
			{
				timer.Remove();
			}
			timer = null;
		}

		// Token: 0x060252AA RID: 152234 RVA: 0x00A7C45E File Offset: 0x00A7A65E
		private void PrepareLoad(int characterId)
		{
			this.Reset();
			this.CharacterId = new int?(characterId);
			this.IsShown = false;
			this.SetFadeAlpha(1f);
			this.ApplyColor(VisualNovelSpineCharacter.HighlightColor, true);
			this.SetVisible(false);
		}

		// Token: 0x060252AB RID: 152235 RVA: 0x00A7C498 File Offset: 0x00A7A698
		private void SetVisible(bool visible)
		{
			bool flag = visible && !this.IsTemporarilyHidden;
			this.CharacterRootItem.SetAlpha(flag ? 1f : 0f);
			this.CharacterRootItem.SetUIActive(flag);
			if (flag)
			{
				this.ScheduleBlink();
				this.StartMouthAnimation();
				return;
			}
			this.StopBlinking();
			VisualNovelSpineCharacter.RemoveTimer(ref this.MouthRefreshTimer);
			this.ApplyMouthShape(EVisualNovelMouthShape.Closed);
		}

		// Token: 0x060252AC RID: 152236 RVA: 0x00A7C504 File Offset: 0x00A7A704
		[NullableContext(1)]
		private static FColor ResolveColor(VisualNovelCharacterState state)
		{
			EAvgVisualEffect visualEffect = state.VisualEffect;
			if (visualEffect != EAvgVisualEffect.Darken && (visualEffect != EAvgVisualEffect.Default || state.IsSpeaking))
			{
				return VisualNovelSpineCharacter.HighlightColor;
			}
			return VisualNovelSpineCharacter.DarkenColor;
		}

		// Token: 0x040148B8 RID: 84152
		private const float EFFECT_SEGMENT_DURATION = 0.08f;

		// Token: 0x040148B9 RID: 84153
		private const float BLINK_INTERVAL_MIN = 3f;

		// Token: 0x040148BA RID: 84154
		private const float BLINK_INTERVAL_MAX = 6f;

		// Token: 0x040148BB RID: 84155
		private const float MOUTH_REFRESH_INTERVAL = 33.333332f;

		// Token: 0x040148BC RID: 84156
		private const float COLOR_TRANSITION_DURATION = 0.2f;

		// Token: 0x040148BD RID: 84157
		[Nullable(1)]
		private const string DEFAULT_BODY_ANIMATION = "1_1";

		// Token: 0x040148BE RID: 84158
		[Nullable(1)]
		private const string SHAKE_SEQUENCE = "shake";

		// Token: 0x040148BF RID: 84159
		private static readonly FColor HighlightColor = FColor.White;

		// Token: 0x040148C0 RID: 84160
		private static readonly FColor DarkenColor = new FColor(128, 128, 128, byte.MaxValue);

		// Token: 0x040148C1 RID: 84161
		[Nullable(1)]
		private readonly USpineSkeletonAnimationComponent CharacterSpine;

		// Token: 0x040148C2 RID: 84162
		[Nullable(1)]
		private readonly UUIItem CharacterRootItem;

		// Token: 0x040148C3 RID: 84163
		[Nullable(1)]
		private readonly UUIItem SpineParentItem;

		// Token: 0x040148C4 RID: 84164
		[Nullable(1)]
		private readonly LevelSequencePlayer SequencePlayer;

		// Token: 0x040148C5 RID: 84165
		private readonly bool ShouldApplyPortraitTransform;

		// Token: 0x040148C6 RID: 84166
		private readonly bool ShouldPinRootToOrigin;

		// Token: 0x040148C7 RID: 84167
		[Nullable(1)]
		private readonly UUISpineRenderable CharacterRenderable;

		// Token: 0x040148C8 RID: 84168
		private FVector TempScale = new FVector(1f, 1f, 1f);

		// Token: 0x040148C9 RID: 84169
		private FVector TempPortraitScale = new FVector(1f, 1f, 1f);

		// Token: 0x040148CA RID: 84170
		private bool IsTemporarilyHidden;

		// Token: 0x040148CB RID: 84171
		private int ColorVersion;

		// Token: 0x040148CC RID: 84172
		private VisualNovelTransform CurrentTransform;

		// Token: 0x040148CD RID: 84173
		private readonly VisualNovelTransform RootOriginTransform;

		// Token: 0x040148CE RID: 84174
		private VisualNovelTransform MoveTargetTransform;

		// Token: 0x040148CF RID: 84175
		private float EffectOffsetX;

		// Token: 0x040148D0 RID: 84176
		private float EffectOffsetY;

		// Token: 0x040148D1 RID: 84177
		private FColor CurrentColor = VisualNovelSpineCharacter.HighlightColor;

		// Token: 0x040148D2 RID: 84178
		private FColor TargetColor = VisualNovelSpineCharacter.HighlightColor;

		// Token: 0x040148D3 RID: 84179
		private float FadeAlpha = 1f;

		// Token: 0x040148D4 RID: 84180
		private bool IsShown;

		// Token: 0x040148D5 RID: 84181
		private bool ShouldShowPortrait = true;

		// Token: 0x040148D6 RID: 84182
		private float CurrentScale = 1f;

		// Token: 0x040148D7 RID: 84183
		private float SpinePlaybackRate = 1f;

		// Token: 0x040148D8 RID: 84184
		private bool IsPaused;

		// Token: 0x040148D9 RID: 84185
		private string CurrentBodyAnimation;

		// Token: 0x040148DA RID: 84186
		private string CurrentMouthAnimation;

		// Token: 0x040148DB RID: 84187
		private string ClosedMouthAnimation;

		// Token: 0x040148DC RID: 84188
		private string SmallMouthAnimation;

		// Token: 0x040148DD RID: 84189
		private string LargeMouthAnimation;

		// Token: 0x040148DE RID: 84190
		private string CurrentEyeAnimation;

		// Token: 0x040148DF RID: 84191
		private string CurrentBlinkAnimation;

		// Token: 0x040148E0 RID: 84192
		private bool IsEyeTrackBlinking;

		// Token: 0x040148E1 RID: 84193
		private bool BlinkEnabled;

		// Token: 0x040148E2 RID: 84194
		private TimerHandle BlinkIntervalTimer;

		// Token: 0x040148E3 RID: 84195
		private TimerHandle MouthRefreshTimer;

		// Token: 0x040148E4 RID: 84196
		private VisualNovelAudioEvent Voice;

		// Token: 0x040148E5 RID: 84197
		private bool IsTalking;

		// Token: 0x040148E6 RID: 84198
		private int VoiceVersion;

		// Token: 0x040148E7 RID: 84199
		private EVisualNovelMouthShape CurrentMouthShape;

		// Token: 0x040148E8 RID: 84200
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Func<VisualNovelAssetCache> GetAssetCache;

		// Token: 0x040148E9 RID: 84201
		private readonly float SpineParentOriginX;

		// Token: 0x040148EA RID: 84202
		private readonly float SpineParentOriginY;

		// Token: 0x040148EB RID: 84203
		private readonly FVector SpineParentOriginScale;

		// Token: 0x02009526 RID: 38182
		[NullableContext(0)]
		private static class ESpineTrack
		{
			// Token: 0x0402E94B RID: 190795
			public const int Body = 0;

			// Token: 0x0402E94C RID: 190796
			public const int Mouth = 1;

			// Token: 0x0402E94D RID: 190797
			public const int Eye = 2;
		}
	}
}
