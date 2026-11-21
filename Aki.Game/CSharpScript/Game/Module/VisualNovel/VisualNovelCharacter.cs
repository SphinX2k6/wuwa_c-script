using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A2 RID: 14242
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class VisualNovelCharacter
	{
		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x060250B4 RID: 151732
		// (set) Token: 0x060250B5 RID: 151733
		public abstract int? CharacterId { get; protected set; }

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x060250B6 RID: 151734 RVA: 0x00A76153 File Offset: 0x00A74353
		// (set) Token: 0x060250B7 RID: 151735 RVA: 0x00A7615B File Offset: 0x00A7435B
		public int VisibilityVersion { get; protected set; }

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x060250B8 RID: 151736 RVA: 0x00A76164 File Offset: 0x00A74364
		// (set) Token: 0x060250B9 RID: 151737 RVA: 0x00A7616C File Offset: 0x00A7436C
		public int TransformVersion { get; protected set; }

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x060250BA RID: 151738 RVA: 0x00A76175 File Offset: 0x00A74375
		// (set) Token: 0x060250BB RID: 151739 RVA: 0x00A7617D File Offset: 0x00A7437D
		public int EffectVersion { get; protected set; }

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x060250BC RID: 151740 RVA: 0x00A76186 File Offset: 0x00A74386
		// (set) Token: 0x060250BD RID: 151741 RVA: 0x00A7618E File Offset: 0x00A7438E
		public bool IsExiting { get; private set; }

		// Token: 0x060250BE RID: 151742 RVA: 0x00A76197 File Offset: 0x00A74397
		public VisualNovelCharacterState GetState()
		{
			VisualNovelCharacterState state = this.State;
			if (state == null)
			{
				return null;
			}
			return state.Clone();
		}

		// Token: 0x060250BF RID: 151743 RVA: 0x00A761AA File Offset: 0x00A743AA
		public int GetAvgTalkerId()
		{
			VisualNovelCharacterState state = this.State;
			if (state == null)
			{
				return 0;
			}
			return state.AvgTalkerId;
		}

		// Token: 0x060250C0 RID: 151744 RVA: 0x00A761BD File Offset: 0x00A743BD
		public bool BeginExit()
		{
			if (this.IsExiting)
			{
				return false;
			}
			this.IsExiting = true;
			this.ExitCompletion = new UniTaskCompletionSource();
			return true;
		}

		// Token: 0x060250C1 RID: 151745 RVA: 0x00A761DC File Offset: 0x00A743DC
		public UniTask WaitForExitAsync()
		{
			UniTaskCompletionSource exitCompletion = this.ExitCompletion;
			if (exitCompletion == null)
			{
				return UniTask.CompletedTask;
			}
			return exitCompletion.Task;
		}

		// Token: 0x060250C2 RID: 151746 RVA: 0x00A761F3 File Offset: 0x00A743F3
		public void EndExit()
		{
			UniTaskCompletionSource exitCompletion = this.ExitCompletion;
			this.ExitCompletion = null;
			this.IsExiting = false;
			if (exitCompletion == null)
			{
				return;
			}
			exitCompletion.TrySetResult();
		}

		// Token: 0x060250C3 RID: 151747
		public abstract bool Load(int characterId);

		// Token: 0x060250C4 RID: 151748
		[NullableContext(1)]
		public abstract void ApplyState(VisualNovelCharacterState state);

		// Token: 0x060250C5 RID: 151749
		public abstract VisualNovelTransform GetTransform();

		// Token: 0x060250C6 RID: 151750
		public abstract void Modify(float? x, float? y, float? scale, int? animationId, EAvgVisualEffect? visualEffect, bool? hidePortrait);

		// Token: 0x060250C7 RID: 151751
		public abstract void SetSpeaking(bool speaking);

		// Token: 0x060250C8 RID: 151752
		public abstract UniTask ShowAsync(float duration);

		// Token: 0x060250C9 RID: 151753
		public abstract UniTask HideAsync(float duration);

		// Token: 0x060250CA RID: 151754
		public abstract UniTask MoveAsync(VisualNovelCharacterMoveParameters parameters);

		// Token: 0x060250CB RID: 151755
		public abstract UniTask PlayEffectAsync(EVisualNovelPortraitEffectType effect, float distance);

		// Token: 0x060250CC RID: 151756
		public abstract void FinishShow(int version);

		// Token: 0x060250CD RID: 151757
		public abstract void FinishHide(int version);

		// Token: 0x060250CE RID: 151758
		public abstract void FinishMove(int version);

		// Token: 0x060250CF RID: 151759
		public abstract void FinishEffect(int version);

		// Token: 0x060250D0 RID: 151760
		public abstract void SetTemporarilyHidden(bool hidden);

		// Token: 0x060250D1 RID: 151761
		public abstract void Reset();

		// Token: 0x060250D2 RID: 151762
		public abstract void Destroy();

		// Token: 0x060250D3 RID: 151763 RVA: 0x00A76214 File Offset: 0x00A74414
		[NullableContext(1)]
		public virtual void SetVoice(VisualNovelAudioEvent voice)
		{
		}

		// Token: 0x060250D4 RID: 151764 RVA: 0x00A76218 File Offset: 0x00A74418
		public virtual void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = playbackRate;
			foreach (LguiFloatTween lguiFloatTween in this.ActiveTweens.Keys)
			{
				ULTweener tweener = lguiFloatTween.GetTweener();
				if (tweener != null)
				{
					tweener.SetSpeed(this.PlaybackRate);
				}
			}
		}

		// Token: 0x060250D5 RID: 151765 RVA: 0x00A76288 File Offset: 0x00A74488
		public virtual void SetPaused(bool paused)
		{
			if (this.IsPaused == paused)
			{
				return;
			}
			this.IsPaused = paused;
			foreach (LguiFloatTween lguiFloatTween in this.ActiveTweens.Keys)
			{
				ULTweener tweener = lguiFloatTween.GetTweener();
				if (paused)
				{
					if (tweener != null)
					{
						tweener.Pause();
					}
				}
				else if (tweener != null)
				{
					tweener.Resume();
				}
			}
		}

		// Token: 0x060250D6 RID: 151766 RVA: 0x00A76308 File Offset: 0x00A74508
		[NullableContext(1)]
		protected UniTask PlayTweenAsync(VisualNovelCharacter.TweenDomain domain, float start, float end, float duration, Action<float> update, LTweenEase ease = LTweenEase.Linear, [Nullable(2)] UCurveFloat curve = null)
		{
			VisualNovelCharacter.<PlayTweenAsync>d__49 <PlayTweenAsync>d__;
			<PlayTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTweenAsync>d__.<>4__this = this;
			<PlayTweenAsync>d__.domain = domain;
			<PlayTweenAsync>d__.start = start;
			<PlayTweenAsync>d__.end = end;
			<PlayTweenAsync>d__.duration = duration;
			<PlayTweenAsync>d__.update = update;
			<PlayTweenAsync>d__.ease = ease;
			<PlayTweenAsync>d__.curve = curve;
			<PlayTweenAsync>d__.<>1__state = -1;
			<PlayTweenAsync>d__.<>t__builder.Start<VisualNovelCharacter.<PlayTweenAsync>d__49>(ref <PlayTweenAsync>d__);
			return <PlayTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060250D7 RID: 151767 RVA: 0x00A76388 File Offset: 0x00A74588
		protected void StopTweens(VisualNovelCharacter.TweenDomain? domain = null, Action beforeComplete = null)
		{
			List<ValueTuple<LguiFloatTween, UniTaskCompletionSource>> list = new List<ValueTuple<LguiFloatTween, UniTaskCompletionSource>>();
			foreach (KeyValuePair<LguiFloatTween, ValueTuple<VisualNovelCharacter.TweenDomain, UniTaskCompletionSource>> keyValuePair in this.ActiveTweens)
			{
				LguiFloatTween lguiFloatTween;
				ValueTuple<VisualNovelCharacter.TweenDomain, UniTaskCompletionSource> valueTuple;
				keyValuePair.Deconstruct(out lguiFloatTween, out valueTuple);
				LguiFloatTween item = lguiFloatTween;
				ValueTuple<VisualNovelCharacter.TweenDomain, UniTaskCompletionSource> valueTuple2 = valueTuple;
				if (domain == null || valueTuple2.Item1 == domain.Value)
				{
					list.Add(new ValueTuple<LguiFloatTween, UniTaskCompletionSource>(item, valueTuple2.Item2));
				}
			}
			foreach (ValueTuple<LguiFloatTween, UniTaskCompletionSource> valueTuple3 in list)
			{
				LguiFloatTween item2 = valueTuple3.Item1;
				this.ActiveTweens.Remove(item2);
			}
			foreach (ValueTuple<LguiFloatTween, UniTaskCompletionSource> valueTuple4 in list)
			{
				valueTuple4.Item1.KillTween();
			}
			if (beforeComplete != null)
			{
				beforeComplete();
			}
			foreach (ValueTuple<LguiFloatTween, UniTaskCompletionSource> valueTuple5 in list)
			{
				valueTuple5.Item2.TrySetResult();
			}
		}

		// Token: 0x040147DB RID: 83931
		[TupleElementNames(new string[]
		{
			"Domain",
			"Promise"
		})]
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1
		})]
		private readonly Dictionary<LguiFloatTween, ValueTuple<VisualNovelCharacter.TweenDomain, UniTaskCompletionSource>> ActiveTweens = new Dictionary<LguiFloatTween, ValueTuple<VisualNovelCharacter.TweenDomain, UniTaskCompletionSource>>();

		// Token: 0x040147DC RID: 83932
		private float PlaybackRate = 1f;

		// Token: 0x040147DD RID: 83933
		private bool IsPaused;

		// Token: 0x040147DE RID: 83934
		private UniTaskCompletionSource ExitCompletion;

		// Token: 0x040147DF RID: 83935
		protected VisualNovelCharacterState State;

		// Token: 0x0200950B RID: 38155
		[NullableContext(0)]
		protected enum TweenDomain
		{
			// Token: 0x0402E8C0 RID: 190656
			Visibility,
			// Token: 0x0402E8C1 RID: 190657
			Transform,
			// Token: 0x0402E8C2 RID: 190658
			Color,
			// Token: 0x0402E8C3 RID: 190659
			Effect
		}
	}
}
