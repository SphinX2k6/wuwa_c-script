using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.Level
{
	// Token: 0x02005FDB RID: 24539
	[NullableContext(1)]
	[Nullable(0)]
	public class FindSunSpiritGuideLine
	{
		// Token: 0x0603AF29 RID: 241449 RVA: 0x010A8780 File Offset: 0x010A6980
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

		// Token: 0x0603AF2A RID: 241450 RVA: 0x010A8808 File Offset: 0x010A6A08
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

		// Token: 0x0603AF2B RID: 241451 RVA: 0x010A888C File Offset: 0x010A6A8C
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

		// Token: 0x0603AF2C RID: 241452 RVA: 0x010A8A00 File Offset: 0x010A6C00
		private void UpdateSplinePoint(Vector[] path)
		{
			this.SplinePoints.Empty(true);
			foreach (Vector vector in path)
			{
				this.SplinePoints.Add(vector.ToUeVector(false));
			}
			this.SplineComp.D_SetSplinePoints(this.SplinePoints, ESplineCoordinateSpace.World, true);
		}

		// Token: 0x0603AF2D RID: 241453 RVA: 0x010A8A54 File Offset: 0x010A6C54
		private void StopEffect(float _)
		{
			this.StopEffectTimer = null;
			if (EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle, "[FindSunSpiritGuideLine.Clear]", false, null);
			}
		}

		// Token: 0x0603AF2F RID: 241455 RVA: 0x010A8AAD File Offset: 0x010A6CAD
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

		// Token: 0x0401EFE4 RID: 126948
		[Nullable(2)]
		private AActor SplineActor;

		// Token: 0x0401EFE5 RID: 126949
		[Nullable(2)]
		private USplineComponent SplineComp;

		// Token: 0x0401EFE6 RID: 126950
		[Nullable(2)]
		private TArray<FVectorDouble> SplinePoints;

		// Token: 0x0401EFE7 RID: 126951
		private string EffectPath = "";

		// Token: 0x0401EFE8 RID: 126952
		private int EffectHandle;

		// Token: 0x0401EFE9 RID: 126953
		[Nullable(2)]
		private TimerHandle StopEffectTimer;
	}
}
