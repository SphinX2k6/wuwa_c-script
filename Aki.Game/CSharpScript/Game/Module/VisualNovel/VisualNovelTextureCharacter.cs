using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037C3 RID: 14275
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class VisualNovelTextureCharacter : VisualNovelCharacter
	{
		// Token: 0x17004C8E RID: 19598
		// (get) Token: 0x060252BF RID: 152255 RVA: 0x00A7C86F File Offset: 0x00A7AA6F
		// (set) Token: 0x060252C0 RID: 152256 RVA: 0x00A7C877 File Offset: 0x00A7AA77
		public override int? CharacterId { get; protected set; }

		// Token: 0x060252C1 RID: 152257 RVA: 0x00A7C880 File Offset: 0x00A7AA80
		public VisualNovelTextureCharacter(UUIItem rootItem, UUITexture texture, Func<VisualNovelAssetCache> getAssetCache)
		{
			this.RootItem = rootItem;
			this.Texture = texture;
			this.GetAssetCache = getAssetCache;
			this.TextureOriginX = texture.GetAnchorOffsetX();
			this.TextureOriginY = texture.GetAnchorOffsetY();
			this.Reset();
		}

		// Token: 0x060252C2 RID: 152258 RVA: 0x00A7C950 File Offset: 0x00A7AB50
		public override bool Load(int characterId)
		{
			this.Reset();
			VisualNovelAssetCache visualNovelAssetCache = this.GetAssetCache();
			UTexture characterTexture = visualNovelAssetCache.GetCharacterTexture(characterId);
			if (characterTexture == null)
			{
				return false;
			}
			this.CharacterId = new int?(characterId);
			this.Texture.SetTexture(characterTexture);
			this.Texture.SetSizeFromTexture();
			this.Texture.SetUIActive(true);
			VisualNovelCharacterResource? visualNovelCharacterResource;
			VisualNovelTransform? visualNovelTransform = (visualNovelAssetCache.ConfigCenter.GetCharacterResource(characterId) != null) ? visualNovelCharacterResource.GetValueOrDefault().PortraitTransform : null;
			this.Texture.SetAnchorOffsetX(this.TextureOriginX + ((visualNovelTransform != null) ? visualNovelTransform.GetValueOrDefault().X : 0f));
			this.Texture.SetAnchorOffsetY(this.TextureOriginY + ((visualNovelTransform != null) ? visualNovelTransform.GetValueOrDefault().Y : 0f));
			this.TempPortraitScale.X = (this.TempPortraitScale.Y = ((visualNovelTransform != null) ? visualNovelTransform.GetValueOrDefault().Scale : 1f));
			this.Texture.SetUIItemScale(this.TempPortraitScale);
			this.State = new VisualNovelCharacterState(characterId, visualNovelAssetCache.ConfigCenter.GetAvgTalkerId(characterId))
			{
				Transform = this.GetTransform()
			};
			this.ApplyBrightness(this.State);
			return true;
		}

		// Token: 0x060252C3 RID: 152259 RVA: 0x00A7CAC0 File Offset: 0x00A7ACC0
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
			this.IsPortraitHidden = this.State.IsPortraitHidden;
			this.ApplyTransform(this.State.Transform);
			this.ApplyBrightness(this.State);
			this.RefreshVisible();
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Transform), null);
		}

		// Token: 0x060252C4 RID: 152260 RVA: 0x00A7CB4D File Offset: 0x00A7AD4D
		public override VisualNovelTransform GetTransform()
		{
			return this.CurrentTransform;
		}

		// Token: 0x060252C5 RID: 152261 RVA: 0x00A7CB58 File Offset: 0x00A7AD58
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
				this.ApplyTransform(this.State.Transform);
			}
			if (visualEffect != null)
			{
				this.ApplyBrightness(this.State);
			}
			if (hidePortrait != null)
			{
				this.IsPortraitHidden = this.State.IsPortraitHidden;
				this.RefreshVisible();
			}
			if (flag)
			{
				base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Transform), null);
			}
		}

		// Token: 0x060252C6 RID: 152262 RVA: 0x00A7CC0C File Offset: 0x00A7AE0C
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
			this.ApplyBrightness(this.State);
		}

		// Token: 0x060252C7 RID: 152263 RVA: 0x00A7CC6C File Offset: 0x00A7AE6C
		public override UniTask ShowAsync(float duration)
		{
			VisualNovelTextureCharacter.<ShowAsync>d__30 <ShowAsync>d__;
			<ShowAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowAsync>d__.<>4__this = this;
			<ShowAsync>d__.duration = duration;
			<ShowAsync>d__.<>1__state = -1;
			<ShowAsync>d__.<>t__builder.Start<VisualNovelTextureCharacter.<ShowAsync>d__30>(ref <ShowAsync>d__);
			return <ShowAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252C8 RID: 152264 RVA: 0x00A7CCB8 File Offset: 0x00A7AEB8
		public override UniTask HideAsync(float duration)
		{
			VisualNovelTextureCharacter.<HideAsync>d__31 <HideAsync>d__;
			<HideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideAsync>d__.<>4__this = this;
			<HideAsync>d__.duration = duration;
			<HideAsync>d__.<>1__state = -1;
			<HideAsync>d__.<>t__builder.Start<VisualNovelTextureCharacter.<HideAsync>d__31>(ref <HideAsync>d__);
			return <HideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252C9 RID: 152265 RVA: 0x00A7CD04 File Offset: 0x00A7AF04
		public override UniTask MoveAsync(VisualNovelCharacterMoveParameters parameters)
		{
			VisualNovelTextureCharacter.<MoveAsync>d__32 <MoveAsync>d__;
			<MoveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveAsync>d__.<>4__this = this;
			<MoveAsync>d__.parameters = parameters;
			<MoveAsync>d__.<>1__state = -1;
			<MoveAsync>d__.<>t__builder.Start<VisualNovelTextureCharacter.<MoveAsync>d__32>(ref <MoveAsync>d__);
			return <MoveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252CA RID: 152266 RVA: 0x00A7CD50 File Offset: 0x00A7AF50
		public override UniTask PlayEffectAsync(EVisualNovelPortraitEffectType effect, float distance)
		{
			VisualNovelTextureCharacter.<PlayEffectAsync>d__33 <PlayEffectAsync>d__;
			<PlayEffectAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayEffectAsync>d__.<>4__this = this;
			<PlayEffectAsync>d__.effect = effect;
			<PlayEffectAsync>d__.distance = distance;
			<PlayEffectAsync>d__.<>1__state = -1;
			<PlayEffectAsync>d__.<>t__builder.Start<VisualNovelTextureCharacter.<PlayEffectAsync>d__33>(ref <PlayEffectAsync>d__);
			return <PlayEffectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252CB RID: 152267 RVA: 0x00A7CDA4 File Offset: 0x00A7AFA4
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
			this.RefreshVisible();
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Visibility), null);
		}

		// Token: 0x060252CC RID: 152268 RVA: 0x00A7CDF0 File Offset: 0x00A7AFF0
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
			this.RefreshVisible();
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Visibility), null);
		}

		// Token: 0x060252CD RID: 152269 RVA: 0x00A7CE3C File Offset: 0x00A7B03C
		public override void FinishMove(int version)
		{
			if (version != base.TransformVersion)
			{
				return;
			}
			int transformVersion = base.TransformVersion;
			base.TransformVersion = transformVersion + 1;
			this.ApplyTransform(this.MoveTargetTransform);
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Transform), null);
		}

		// Token: 0x060252CE RID: 152270 RVA: 0x00A7CE7C File Offset: 0x00A7B07C
		public override void FinishEffect(int version)
		{
			if (version != base.EffectVersion)
			{
				return;
			}
			int effectVersion = base.EffectVersion;
			base.EffectVersion = effectVersion + 1;
			this.SetEffectOffset(0f, 0f);
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Effect), null);
		}

		// Token: 0x060252CF RID: 152271 RVA: 0x00A7CEC0 File Offset: 0x00A7B0C0
		public override void SetTemporarilyHidden(bool hidden)
		{
			this.IsTemporarilyHidden = hidden;
			this.RefreshVisible();
		}

		// Token: 0x060252D0 RID: 152272 RVA: 0x00A7CED0 File Offset: 0x00A7B0D0
		public override void Reset()
		{
			this.InvalidateOperations();
			this.State = null;
			this.CharacterId = null;
			this.IsShown = false;
			this.IsPortraitHidden = false;
			this.IsTemporarilyHidden = false;
			this.Brightness = (this.TargetBrightness = 1f);
			this.FadeAlpha = 1f;
			this.EffectOffsetX = (this.EffectOffsetY = 0f);
			this.Texture.SetTexture(null);
			this.ApplyTransform(new VisualNovelTransform(0f, 0f, 1f));
			this.RefreshColor();
			this.RefreshVisible();
			base.StopTweens(null, null);
		}

		// Token: 0x060252D1 RID: 152273 RVA: 0x00A7CF83 File Offset: 0x00A7B183
		public override void Destroy()
		{
			this.Reset();
		}

		// Token: 0x060252D2 RID: 152274 RVA: 0x00A7CF8C File Offset: 0x00A7B18C
		private void InvalidateOperations()
		{
			int num = base.VisibilityVersion;
			base.VisibilityVersion = num + 1;
			num = base.TransformVersion;
			base.TransformVersion = num + 1;
			this.ColorVersion++;
			num = base.EffectVersion;
			base.EffectVersion = num + 1;
		}

		// Token: 0x060252D3 RID: 152275 RVA: 0x00A7CFD8 File Offset: 0x00A7B1D8
		private void ApplyTransform(VisualNovelTransform transform)
		{
			this.CurrentTransform = transform;
			if (this.State != null)
			{
				this.State.Transform = transform;
			}
			this.RefreshPosition();
			this.TempScale.X = (this.TempScale.Y = transform.Scale);
			this.RootItem.SetUIItemScale(this.TempScale);
		}

		// Token: 0x060252D4 RID: 152276 RVA: 0x00A7D037 File Offset: 0x00A7B237
		private void SetEffectOffset(float x, float y)
		{
			this.EffectOffsetX = x;
			this.EffectOffsetY = y;
			this.RefreshPosition();
		}

		// Token: 0x060252D5 RID: 152277 RVA: 0x00A7D04D File Offset: 0x00A7B24D
		private void RefreshPosition()
		{
			this.RootItem.SetAnchorOffsetX(this.CurrentTransform.X + this.EffectOffsetX);
			this.RootItem.SetAnchorOffsetY(this.CurrentTransform.Y + this.EffectOffsetY);
		}

		// Token: 0x060252D6 RID: 152278 RVA: 0x00A7D08C File Offset: 0x00A7B28C
		private void ApplyBrightness(VisualNovelCharacterState state)
		{
			float num = (state.VisualEffect == EAvgVisualEffect.Darken || (state.VisualEffect == EAvgVisualEffect.Default && !state.IsSpeaking)) ? 0.5019608f : 1f;
			if (this.TargetBrightness == num)
			{
				return;
			}
			this.TargetBrightness = num;
			int num2 = this.ColorVersion + 1;
			this.ColorVersion = num2;
			int num3 = num2;
			if (!this.IsShown || !this.RootItem.IsUIActiveSelf())
			{
				this.Brightness = num;
				this.RefreshColor();
				base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Color), null);
				return;
			}
			base.StopTweens(new VisualNovelCharacter.TweenDomain?(VisualNovelCharacter.TweenDomain.Color), null);
			if (num3 != this.ColorVersion)
			{
				return;
			}
			this.PlayBrightnessAsync(num, num3).Forget();
		}

		// Token: 0x060252D7 RID: 152279 RVA: 0x00A7D140 File Offset: 0x00A7B340
		private UniTask PlayBrightnessAsync(float target, int version)
		{
			VisualNovelTextureCharacter.<PlayBrightnessAsync>d__46 <PlayBrightnessAsync>d__;
			<PlayBrightnessAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBrightnessAsync>d__.<>4__this = this;
			<PlayBrightnessAsync>d__.target = target;
			<PlayBrightnessAsync>d__.version = version;
			<PlayBrightnessAsync>d__.<>1__state = -1;
			<PlayBrightnessAsync>d__.<>t__builder.Start<VisualNovelTextureCharacter.<PlayBrightnessAsync>d__46>(ref <PlayBrightnessAsync>d__);
			return <PlayBrightnessAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060252D8 RID: 152280 RVA: 0x00A7D193 File Offset: 0x00A7B393
		private void SetFadeAlpha(float alpha)
		{
			this.FadeAlpha = alpha;
			this.RefreshColor();
		}

		// Token: 0x060252D9 RID: 152281 RVA: 0x00A7D1A4 File Offset: 0x00A7B3A4
		private void RefreshColor()
		{
			byte b = (byte)(255f * this.Brightness * this.FadeAlpha);
			byte a = (byte)(255f * this.FadeAlpha);
			this.Texture.SetColor(new FColor(b, b, b, a));
		}

		// Token: 0x060252DA RID: 152282 RVA: 0x00A7D1E8 File Offset: 0x00A7B3E8
		private void RefreshVisible()
		{
			bool flag = this.IsShown && !this.IsPortraitHidden && !this.IsTemporarilyHidden;
			this.RootItem.SetAlpha(flag ? 1f : 0f);
			this.RootItem.SetUIActive(flag);
		}

		// Token: 0x040148F7 RID: 84215
		private const float COLOR_TRANSITION_DURATION = 0.2f;

		// Token: 0x040148F8 RID: 84216
		private const float EFFECT_SEGMENT_DURATION = 0.08f;

		// Token: 0x040148F9 RID: 84217
		private readonly UUIItem RootItem;

		// Token: 0x040148FA RID: 84218
		private readonly UUITexture Texture;

		// Token: 0x040148FB RID: 84219
		private readonly Func<VisualNovelAssetCache> GetAssetCache;

		// Token: 0x040148FC RID: 84220
		private readonly float TextureOriginX;

		// Token: 0x040148FD RID: 84221
		private readonly float TextureOriginY;

		// Token: 0x040148FE RID: 84222
		private FVector TempScale = new FVector(1f, 1f, 1f);

		// Token: 0x040148FF RID: 84223
		private FVector TempPortraitScale = new FVector(1f, 1f, 1f);

		// Token: 0x04014900 RID: 84224
		private VisualNovelTransform CurrentTransform = new VisualNovelTransform(0f, 0f, 1f);

		// Token: 0x04014901 RID: 84225
		private VisualNovelTransform MoveTargetTransform = new VisualNovelTransform(0f, 0f, 1f);

		// Token: 0x04014902 RID: 84226
		private float EffectOffsetX;

		// Token: 0x04014903 RID: 84227
		private float EffectOffsetY;

		// Token: 0x04014904 RID: 84228
		private float Brightness = 1f;

		// Token: 0x04014905 RID: 84229
		private float TargetBrightness = 1f;

		// Token: 0x04014906 RID: 84230
		private float FadeAlpha = 1f;

		// Token: 0x04014907 RID: 84231
		private int ColorVersion;

		// Token: 0x04014908 RID: 84232
		private bool IsShown;

		// Token: 0x04014909 RID: 84233
		private bool IsPortraitHidden;

		// Token: 0x0401490A RID: 84234
		private bool IsTemporarilyHidden;
	}
}
