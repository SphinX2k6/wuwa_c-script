using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Scene.KuroProjectilePathTracer;
using UnrealEngine;

// Token: 0x02003093 RID: 12435
[NullableContext(2)]
[Nullable(0)]
public class CharacterThrowComponent : EntityComponent
{
	// Token: 0x1700248E RID: 9358
	// (get) Token: 0x0601A936 RID: 108854 RVA: 0x007216D4 File Offset: 0x0071F8D4
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

	// Token: 0x0601A937 RID: 108855 RVA: 0x0072170A File Offset: 0x0071F90A
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

	// Token: 0x0601A938 RID: 108856 RVA: 0x00721721 File Offset: 0x0071F921
	public void SetVisible(bool isShow)
	{
		BP_KuroProjectilePathTracer_C projectilePathTracer = this.ProjectilePathTracer;
		if (projectilePathTracer == null)
		{
			return;
		}
		projectilePathTracer.SetVisible(isShow);
	}

	// Token: 0x0601A939 RID: 108857 RVA: 0x00721734 File Offset: 0x0071F934
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterThrowComponent characterThrowComponent = (CharacterThrowComponent)componentTemplate;
		if (base.CanResetComponentProperty("ProjectilePathTracerInternal"))
		{
			if (characterThrowComponent.ProjectilePathTracerInternal == null)
			{
				this.ProjectilePathTracerInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_KuroProjectilePathTracer_C>(this.ProjectilePathTracerInternal), "ProjectilePathTracerInternal"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400CC77 RID: 52343
	private BP_KuroProjectilePathTracer_C ProjectilePathTracerInternal;
}
