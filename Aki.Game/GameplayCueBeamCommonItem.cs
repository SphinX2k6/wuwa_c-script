using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FA9 RID: 12201
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueBeamCommonItem
{
	// Token: 0x06019DFB RID: 105979 RVA: 0x006C3721 File Offset: 0x006C1921
	private GameplayCueBeamCommonItem(ABaseCharacter owner, string path)
	{
		this.Owner = owner;
		this.Path = path;
	}

	// Token: 0x06019DFC RID: 105980 RVA: 0x006C3737 File Offset: 0x006C1937
	public static GameplayCueBeamCommonItem Spawn(ABaseCharacter owner, string path, [Nullable(new byte[]
	{
		2,
		1
	})] Action<UNiagaraComponent> onNiagaraReady = null)
	{
		GameplayCueBeamCommonItem gameplayCueBeamCommonItem = new GameplayCueBeamCommonItem(owner, path);
		gameplayCueBeamCommonItem.IsActive = true;
		gameplayCueBeamCommonItem.OnNiagaraReady = onNiagaraReady;
		gameplayCueBeamCommonItem.SplineInternal = gameplayCueBeamCommonItem.SpawnBeamActor();
		return gameplayCueBeamCommonItem;
	}

	// Token: 0x06019DFD RID: 105981 RVA: 0x006C375C File Offset: 0x006C195C
	public void Tick(FVectorDouble[] points, float delta)
	{
		this.CurrentPoints = points;
		this.SplineInternal.GetOwner().D_K2_SetActorLocation(this.Owner.D_K2_GetActorLocation(), false, ref WorldGlobal.SweepHitResult, true);
		int num = points.Length;
		if (num != this.CurrentSplinePointCount)
		{
			this.RefreshSplinePoints(num);
		}
		for (int i = 0; i < num; i++)
		{
			this.SplineInternal.D_SetLocationAtSplinePoint(i, points[i], ESplineCoordinateSpace.World, true);
		}
	}

	// Token: 0x06019DFE RID: 105982 RVA: 0x006C37C8 File Offset: 0x006C19C8
	public void Destroy()
	{
		this.IsActive = false;
		USplineComponent splineInternal = this.SplineInternal;
		AActor aactor = (splineInternal != null) ? splineInternal.GetOwner() : null;
		if (aactor != null)
		{
			ActorSystem.Instance.Put("GameplayCueBeamCommonItem.Destroy", aactor, null);
		}
	}

	// Token: 0x06019DFF RID: 105983 RVA: 0x006C3804 File Offset: 0x006C1A04
	public AActor GetOwner()
	{
		return this.SplineInternal.GetOwner();
	}

	// Token: 0x06019E00 RID: 105984 RVA: 0x006C3814 File Offset: 0x006C1A14
	private USplineComponent SpawnBeamActor()
	{
		AActor actor = ActorSystem.Instance.Get(AActor.StaticClass(), this.Owner.D_GetTransform(), null, true);
		USplineComponent splineComponent = actor.AddComponentByClass(USplineComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as USplineComponent;
		splineComponent.ClearSplinePoints(true);
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(this.Path, delegate([Nullable(2)] UNiagaraSystem effectObject, string _)
		{
			if (this.IsActive && effectObject != null && effectObject.IsValid())
			{
				AActor actor = actor;
				if (actor != null && actor.IsValid())
				{
					UNiagaraComponent uniagaraComponent = actor.AddComponentByClass(UNiagaraComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UNiagaraComponent;
					if (uniagaraComponent == null)
					{
						return;
					}
					uniagaraComponent.SetAsset(effectObject, true);
					Action<UNiagaraComponent> onNiagaraReady = this.OnNiagaraReady;
					if (onNiagaraReady != null)
					{
						onNiagaraReady(uniagaraComponent);
					}
					UKuroRenderingRuntimeBPPluginBPLibrary.SetNiagaraSplineComponent(uniagaraComponent, "NewSpline", splineComponent);
					return;
				}
			}
		}, 100, "js_undefined");
		return splineComponent;
	}

	// Token: 0x06019E01 RID: 105985 RVA: 0x006C38BC File Offset: 0x006C1ABC
	private void RefreshSplinePoints(int newSplinePointCount)
	{
		if (newSplinePointCount > this.CurrentSplinePointCount)
		{
			for (int i = 0; i < newSplinePointCount - this.CurrentSplinePointCount; i++)
			{
				FSplinePoint fsplinePoint = new FSplinePoint((float)(this.CurrentSplinePointCount + i), Vector.ZeroVector, Vector.ZeroVector, Vector.ZeroVector, Rotator.ZeroRotator, Vector.OneVector, ESplinePointType.Linear);
				this.SplineInternal.AddPoint(fsplinePoint, true);
			}
		}
		else
		{
			for (int j = this.CurrentSplinePointCount - 1; j >= newSplinePointCount; j--)
			{
				this.SplineInternal.RemoveSplinePoint(j, true);
			}
		}
		this.CurrentSplinePointCount = newSplinePointCount;
	}

	// Token: 0x0400C39D RID: 50077
	[Nullable(2)]
	private USplineComponent SplineInternal;

	// Token: 0x0400C39E RID: 50078
	private int CurrentSplinePointCount;

	// Token: 0x0400C39F RID: 50079
	private bool IsActive;

	// Token: 0x0400C3A0 RID: 50080
	[Nullable(2)]
	public FVectorDouble[] CurrentPoints;

	// Token: 0x0400C3A1 RID: 50081
	private readonly ABaseCharacter Owner;

	// Token: 0x0400C3A2 RID: 50082
	public readonly string Path;

	// Token: 0x0400C3A3 RID: 50083
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<UNiagaraComponent> OnNiagaraReady;
}
