using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.KuroProjectilePathTracer;
using UnrealEngine;

// Token: 0x020025EA RID: 9706
[NullableContext(2)]
[Nullable(0)]
public class CharacterThrowComponent : EntityComponent
{
	// Token: 0x170025F2 RID: 9714
	// (get) Token: 0x06018326 RID: 99110 RVA: 0x00747766 File Offset: 0x00745966
	public BP_KuroProjectilePathTracer_C ProjectilePathTracer
	{
		get
		{
			if (this.ProjectilePathTracerInternal == null)
			{
				this.ProjectilePathTracerInternal = (ActorSystem.Instance.Get(BP_KuroProjectilePathTracer_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_KuroProjectilePathTracer_C);
			}
			return this.ProjectilePathTracerInternal;
		}
	}

	// Token: 0x06018327 RID: 99111 RVA: 0x0074779C File Offset: 0x0074599C
	[NullableContext(1)]
	public void SetPredictProjectileInfo(bool returnValue, ref TArray<FVector> outPathPosition, FVector outLastTraceDestination, FHitResult outHit)
	{
		BP_KuroProjectilePathTracer_C projectilePathTracer = this.ProjectilePathTracer;
		if (projectilePathTracer == null)
		{
			return;
		}
		projectilePathTracer.SetPredictProjectileInfo(returnValue, ref outPathPosition, outLastTraceDestination, outHit);
	}

	// Token: 0x06018328 RID: 99112 RVA: 0x007477B3 File Offset: 0x007459B3
	public void SetVisible(bool isShow)
	{
		BP_KuroProjectilePathTracer_C projectilePathTracer = this.ProjectilePathTracer;
		if (projectilePathTracer == null)
		{
			return;
		}
		projectilePathTracer.SetVisible(isShow);
	}

	// Token: 0x06018329 RID: 99113 RVA: 0x007477C6 File Offset: 0x007459C6
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		if (((CharacterThrowComponent)componentTemplate).ProjectilePathTracerInternal == null)
		{
			this.ProjectilePathTracerInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ProjectilePathTracerInternal), "ProjectilePathTracerInternal"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x0400D05A RID: 53338
	private BP_KuroProjectilePathTracer_C ProjectilePathTracerInternal;
}
