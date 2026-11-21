using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C28 RID: 23592
	[NullableContext(2)]
	[Nullable(0)]
	public class PianoSubtitleAnimPlayer
	{
		// Token: 0x06039F37 RID: 237367 RVA: 0x0104CD10 File Offset: 0x0104AF10
		public void Init(UUIText textComp, UUIItem fadeIn, UUIItem fadeOut, UUIItem rotateIn, UUIItem rotateOut)
		{
			this.Clear();
			this.TextComp = textComp;
			UUIText textComp2 = this.TextComp;
			if (textComp2 == null || !textComp2.IsValid())
			{
				return;
			}
			AActor owner = this.TextComp.GetOwner();
			this.TextAnimComp = (((owner != null) ? owner.GetComponentByClass(UUIEffectTextAnimation.StaticClass()) : null) as UUIEffectTextAnimation);
			this.InitSlot(PianoSubtitleAnimPlayer.ETweenSlot.FadeIn, fadeIn);
			this.InitSlot(PianoSubtitleAnimPlayer.ETweenSlot.FadeOut, fadeOut);
			this.InitSlot(PianoSubtitleAnimPlayer.ETweenSlot.RotateIn, rotateIn);
			this.InitSlot(PianoSubtitleAnimPlayer.ETweenSlot.RotateOut, rotateOut);
		}

		// Token: 0x06039F38 RID: 237368 RVA: 0x0104CD90 File Offset: 0x0104AF90
		private void InitSlot(PianoSubtitleAnimPlayer.ETweenSlot slot, UUIItem item)
		{
			ULGUIPlayTweenComponent ulguiplayTweenComponent;
			if (item == null || !item.IsValid())
			{
				ulguiplayTweenComponent = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				ulguiplayTweenComponent = (((owner != null) ? owner.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) : null) as ULGUIPlayTweenComponent);
			}
			ULGUIPlayTweenComponent ulguiplayTweenComponent2 = ulguiplayTweenComponent;
			if (((ulguiplayTweenComponent2 != null) ? ulguiplayTweenComponent2.GetPlayTween() : null) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.ZHZ;
				string message = "字幕动画节点或Tween缺失，该方向按无动画处理";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Slot", (int)slot);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			ulguiplayTweenComponent2.playOnStart = false;
			this.TweenPlayer.InitTweenAnim((int)slot, item, true);
			this.TweenPlayer.RegisterOnComplete((int)slot, delegate
			{
				this.OnTweenComplete(slot);
			});
			this.ValidSlots.Add(slot);
		}

		// Token: 0x06039F39 RID: 237369 RVA: 0x0104CE6C File Offset: 0x0104B06C
		public bool HasFadeIn(int effect)
		{
			return this.FindSlot(effect, true) != null;
		}

		// Token: 0x06039F3A RID: 237370 RVA: 0x0104CE8C File Offset: 0x0104B08C
		public void PlayIn(int effect, Action onComplete = null)
		{
			PianoSubtitleAnimPlayer.ETweenSlot? slot = this.FindSlot(effect, true);
			if (slot != null)
			{
				UUIEffectTextAnimation textAnimComp = this.TextAnimComp;
				if (textAnimComp != null && textAnimComp.IsValid())
				{
					this.TextAnimComp.SetSelectorOffset(1f);
				}
			}
			this.Play(slot, onComplete);
		}

		// Token: 0x06039F3B RID: 237371 RVA: 0x0104CED8 File Offset: 0x0104B0D8
		public void PlayOut(int effect, Action onComplete = null)
		{
			PianoSubtitleAnimPlayer.ETweenSlot? slot = this.FindSlot(effect, false);
			if (slot != null)
			{
				UUIEffectTextAnimation textAnimComp = this.TextAnimComp;
				if (textAnimComp != null && textAnimComp.IsValid())
				{
					this.TextAnimComp.SetSelectorOffset(0f);
				}
			}
			this.Play(slot, onComplete);
		}

		// Token: 0x06039F3C RID: 237372 RVA: 0x0104CF24 File Offset: 0x0104B124
		public void ShowImmediately()
		{
			this.Stop();
			UUIText textComp = this.TextComp;
			AActor aactor = (textComp != null) ? textComp.GetOwner() : null;
			if (aactor == null)
			{
				return;
			}
			TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(UUIEffectTextAnimation.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				UUIEffectTextAnimation uuieffectTextAnimation = tarray.Get(i) as UUIEffectTextAnimation;
				if (uuieffectTextAnimation != null && uuieffectTextAnimation.IsValid())
				{
					uuieffectTextAnimation.SetSelectorOffset(0f);
				}
			}
		}

		// Token: 0x06039F3D RID: 237373 RVA: 0x0104CF99 File Offset: 0x0104B199
		public void Stop()
		{
			this.CompleteCallback = null;
			if (this.PlayingSlot != null)
			{
				this.TweenPlayer.StopTweenAnim((int)this.PlayingSlot.Value);
				this.PlayingSlot = null;
			}
		}

		// Token: 0x06039F3E RID: 237374 RVA: 0x0104CFD1 File Offset: 0x0104B1D1
		public void Clear()
		{
			this.Stop();
			this.TweenPlayer.Clear(true);
			this.ValidSlots.Clear();
			this.TextComp = null;
			this.TextAnimComp = null;
		}

		// Token: 0x06039F3F RID: 237375 RVA: 0x0104D000 File Offset: 0x0104B200
		private void Play(PianoSubtitleAnimPlayer.ETweenSlot? slot, Action onComplete = null)
		{
			this.Stop();
			if (slot == null)
			{
				if (onComplete != null)
				{
					onComplete();
				}
				return;
			}
			this.PlayingSlot = slot;
			this.CompleteCallback = onComplete;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PianoGameplay;
			ELogAuthor author = ELogAuthor.ZHZ;
			PianoSubtitleAnimPlayer.ETweenSlot? etweenSlot = slot;
			PianoSubtitleAnimPlayer.ETweenSlot etweenSlot2 = PianoSubtitleAnimPlayer.ETweenSlot.FadeIn;
			string message = ((etweenSlot.GetValueOrDefault() == etweenSlot2 & etweenSlot != null) || slot.GetValueOrDefault() == PianoSubtitleAnimPlayer.ETweenSlot.RotateIn) ? "字幕入场动画开始" : "字幕退场动画开始";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Slot", (int)slot.Value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.TweenPlayer.PlayTweenAnim((int)slot.Value);
		}

		// Token: 0x06039F40 RID: 237376 RVA: 0x0104D0A4 File Offset: 0x0104B2A4
		private PianoSubtitleAnimPlayer.ETweenSlot? FindSlot(int effect, bool isIn)
		{
			PianoSubtitleAnimPlayer.ETweenSlot etweenSlot;
			switch (effect)
			{
			case 0:
				return null;
			case 1:
				etweenSlot = (isIn ? PianoSubtitleAnimPlayer.ETweenSlot.FadeIn : PianoSubtitleAnimPlayer.ETweenSlot.FadeOut);
				break;
			case 2:
				etweenSlot = (isIn ? PianoSubtitleAnimPlayer.ETweenSlot.RotateIn : PianoSubtitleAnimPlayer.ETweenSlot.RotateOut);
				break;
			default:
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PianoGameplay;
				ELogAuthor author = ELogAuthor.ZHZ;
				string message = "字幕入退场效果配置无效，按无动画处理";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Effect", effect);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			}
			if (!this.ValidSlots.Contains(etweenSlot))
			{
				return null;
			}
			return new PianoSubtitleAnimPlayer.ETweenSlot?(etweenSlot);
		}

		// Token: 0x06039F41 RID: 237377 RVA: 0x0104D138 File Offset: 0x0104B338
		private void OnTweenComplete(PianoSubtitleAnimPlayer.ETweenSlot slot)
		{
			PianoSubtitleAnimPlayer.ETweenSlot? playingSlot = this.PlayingSlot;
			if (!(slot == playingSlot.GetValueOrDefault() & playingSlot != null))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PianoGameplay;
			ELogAuthor author = ELogAuthor.ZHZ;
			string message = (slot == PianoSubtitleAnimPlayer.ETweenSlot.FadeIn || slot == PianoSubtitleAnimPlayer.ETweenSlot.RotateIn) ? "字幕入场动画结束" : "字幕退场动画结束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Slot", (int)slot);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			Action completeCallback = this.CompleteCallback;
			this.CompleteCallback = null;
			this.PlayingSlot = null;
			if (completeCallback == null)
			{
				return;
			}
			completeCallback();
		}

		// Token: 0x0401EA4D RID: 125517
		[Nullable(1)]
		private readonly BattleUiTweenAnimPlayer TweenPlayer = new BattleUiTweenAnimPlayer();

		// Token: 0x0401EA4E RID: 125518
		[Nullable(1)]
		private readonly HashSet<PianoSubtitleAnimPlayer.ETweenSlot> ValidSlots = new HashSet<PianoSubtitleAnimPlayer.ETweenSlot>();

		// Token: 0x0401EA4F RID: 125519
		private UUIText TextComp;

		// Token: 0x0401EA50 RID: 125520
		private UUIEffectTextAnimation TextAnimComp;

		// Token: 0x0401EA51 RID: 125521
		private PianoSubtitleAnimPlayer.ETweenSlot? PlayingSlot;

		// Token: 0x0401EA52 RID: 125522
		private Action CompleteCallback;

		// Token: 0x0200B794 RID: 46996
		[NullableContext(0)]
		private enum EFadeEffect
		{
			// Token: 0x04038B95 RID: 232341
			None,
			// Token: 0x04038B96 RID: 232342
			Static,
			// Token: 0x04038B97 RID: 232343
			Rotate
		}

		// Token: 0x0200B795 RID: 46997
		[NullableContext(0)]
		private enum ETweenSlot
		{
			// Token: 0x04038B99 RID: 232345
			FadeIn,
			// Token: 0x04038B9A RID: 232346
			FadeOut,
			// Token: 0x04038B9B RID: 232347
			RotateIn,
			// Token: 0x04038B9C RID: 232348
			RotateOut
		}
	}
}
