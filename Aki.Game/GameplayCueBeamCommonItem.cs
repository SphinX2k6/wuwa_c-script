using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020024FD RID: 9469
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueBeamCommonItem
{
	// Token: 0x0601770D RID: 96013 RVA: 0x006E9FBD File Offset: 0x006E81BD
	private GameplayCueBeamCommonItem(ABaseCharacter owner, string path)
	{
		this.Owner = owner;
		this.Path = path;
	}

	// Token: 0x0601770E RID: 96014 RVA: 0x006E9FD3 File Offset: 0x006E81D3
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

	// Token: 0x0601770F RID: 96015 RVA: 0x006E9FF8 File Offset: 0x006E81F8
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

	// Token: 0x06017710 RID: 96016 RVA: 0x006EA064 File Offset: 0x006E8264
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

	// Token: 0x06017711 RID: 96017 RVA: 0x006EA0A0 File Offset: 0x006E82A0
	public AActor GetOwner()
	{
		return this.SplineInternal.GetOwner();
	}

	// Token: 0x06017712 RID: 96018 RVA: 0x006EA0B0 File Offset: 0x006E82B0
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

	// Token: 0x06017713 RID: 96019 RVA: 0x006EA158 File Offset: 0x006E8358
	private void RefreshSplinePoints(int newSplinePointCount)
	{
		if (newSplinePointCount > this.CurrentSplinePointCount)
		{
			for (int i = 0; i < newSplinePointCount - this.CurrentSplinePointCount; i++)
			{
				int num = this.CurrentSplinePointCount + i;
				FSplinePoint fsplinePoint = new FSplinePoint
				{
					InputKey = (float)num,
					Scale = Vector.OneVector,
					Type = ESplinePointType.Linear
				};
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

	// Token: 0x0400C746 RID: 51014
	[Nullable(2)]
	private USplineComponent SplineInternal;

	// Token: 0x0400C747 RID: 51015
	private int CurrentSplinePointCount;

	// Token: 0x0400C748 RID: 51016
	private bool IsActive;

	// Token: 0x0400C749 RID: 51017
	[Nullable(2)]
	public FVectorDouble[] CurrentPoints;

	// Token: 0x0400C74A RID: 51018
	private readonly ABaseCharacter Owner;

	// Token: 0x0400C74B RID: 51019
	public readonly string Path;

	// Token: 0x0400C74C RID: 51020
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<UNiagaraComponent> OnNiagaraReady;
}
