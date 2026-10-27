using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level
{
	// Token: 0x02006E5A RID: 28250
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritGuideLine
	{
		// Token: 0x06044D9C RID: 282012 RVA: 0x010FE220 File Offset: 0x010FC420
		public void Init(Transform transform)
		{
			AActor splineActor = this.SplineActor;
			if (splineActor != null && splineActor.IsValid())
			{
				AActor splineActor2 = this.SplineActor;
				FTransformDouble ftransformDouble = transform.ToUeTransform();
				splineActor2.D_K2_SetActorTransform(ftransformDouble, false, null, true);
				return;
			}
			AActor aactor = ActorSystem.Instance.Get(BP_BasePathLine_C.StaticClass(), transform.ToUeTransform(), null, true);
			this.SplineActor = aactor;
			USplineComponent usplineComponent = aactor.GetComponentByClass(USplineComponent.StaticClass()) as USplineComponent;
			usplineComponent.ClearSplinePoints(true);
			this.SplineComp = usplineComponent;
			this.SplinePoints = new TArray<FVectorDouble>();
		}

		// Token: 0x06044D9D RID: 282013 RVA: 0x010FE2A8 File Offset: 0x010FC4A8
		public void Clear()
		{
			this.SplineComp = null;
			this.SplinePoints = null;
			TimerHandle stopEffectTimer = this.StopEffectTimer;
			if (stopEffectTimer != null)
			{
				stopEffectTimer.Remove();
			}
			this.StopEffectTimer = null;
			int effectHandle = this.EffectHandle;
			if (!EffectSystem.Instance.IsValid(effectHandle))
			{
				this.<Clear>g__clearSplineActor|7_0(0);
				return;
			}
			EffectSystem.Instance.AddFinishCallback(effectHandle, new Action<int>(this.<Clear>g__clearSplineActor|7_0));
			EffectSystem.Instance.StopEffectById(effectHandle, "[FindSunSpiritGuideLine.Clear]", false, null);
		}

		// Token: 0x06044D9E RID: 282014 RVA: 0x010FE32C File Offset: 0x010FC52C
		public void SpawnGuideLine(string effectPath, Vector[] path, int duration)
		{
			AActor splineActor = this.SplineActor;
			if (splineActor == null || !splineActor.IsValid())
			{
				return;
			}
			if (EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				if (effectPath == this.EffectPath)
				{
					this.UpdateSplinePoint(path);
					TimerHandle stopEffectTimer = this.StopEffectTimer;
					if (stopEffectTimer != null)
					{
						stopEffectTimer.Remove();
					}
					this.StopEffectTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.StopEffect), (float)duration, null, null, true, 1f);
					return;
				}
				EffectSystem.Instance.StopEffectById(this.EffectHandle, "[FindSunSpiritGuideLine.Clear]", false, null);
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
			int num = instance.SpawnEffect(world, ftransformDouble, effectPath, "[FindSunSpiritGuideLine.SpawnGuideLine]", new EffectContext(null, this.SplineActor, false), EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(num))
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.LYY, "虚影找日灵SpawnGuideLine失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.EffectHandle = num;
			this.EffectPath = effectPath;
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
			AActor splineActor2 = this.SplineActor;
			FName? fname = null;
			effectActor.K2_AttachToActor(splineActor2, fname, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false);
			this.UpdateSplinePoint(path);
			this.StopEffectTimer = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.StopEffect), (float)duration, null, null, true, 1f);
		}

		// Token: 0x06044D9F RID: 282015 RVA: 0x010FE4A0 File Offset: 0x010FC6A0
		private void UpdateSplinePoint(Vector[] path)
		{
			this.SplinePoints.Empty(true);
			foreach (Vector vector in path)
			{
				this.SplinePoints.Add(vector.ToUeVector(false));
			}
			this.SplineComp.D_SetSplinePoints(this.SplinePoints, ESplineCoordinateSpace.World, true);
		}

		// Token: 0x06044DA0 RID: 282016 RVA: 0x010FE4F4 File Offset: 0x010FC6F4
		private void StopEffect(float _)
		{
			this.StopEffectTimer = null;
			if (EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle, "[FindSunSpiritGuideLine.Clear]", false, null);
			}
		}

		// Token: 0x06044DA2 RID: 282018 RVA: 0x010FE54D File Offset: 0x010FC74D
		[CompilerGenerated]
		private void <Clear>g__clearSplineActor|7_0(int _)
		{
			AActor splineActor = this.SplineActor;
			if (splineActor != null && splineActor.IsValid())
			{
				ActorSystem.Instance.Put("FindSunSpiritGuideLine.Clear", this.SplineActor, null);
				this.SplineActor = null;
			}
		}

		// Token: 0x04023D2F RID: 146735
		[Nullable(2)]
		private AActor SplineActor;

		// Token: 0x04023D30 RID: 146736
		[Nullable(2)]
		private USplineComponent SplineComp;

		// Token: 0x04023D31 RID: 146737
		[Nullable(2)]
		private TArray<FVectorDouble> SplinePoints;

		// Token: 0x04023D32 RID: 146738
		private string EffectPath = "";

		// Token: 0x04023D33 RID: 146739
		private int EffectHandle;

		// Token: 0x04023D34 RID: 146740
		[Nullable(2)]
		private TimerHandle StopEffectTimer;
	}
}
