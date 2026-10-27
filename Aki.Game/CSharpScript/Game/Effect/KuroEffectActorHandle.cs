using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007270 RID: 29296
	[NullableContext(1)]
	[Nullable(0)]
	public class KuroEffectActorHandle
	{
		// Token: 0x06047C8A RID: 294026 RVA: 0x0125D4CB File Offset: 0x0125B6CB
		public KuroEffectActorHandle(int id)
		{
		}

		// Token: 0x06047C8B RID: 294027 RVA: 0x0125D4DA File Offset: 0x0125B6DA
		public bool IsValid()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_IsValid(this.<id>P);
		}

		// Token: 0x06047C8C RID: 294028 RVA: 0x0125D4E7 File Offset: 0x0125B6E7
		public void SetActorHiddenInGame(bool hiddenInGame)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_SetActorHiddenInGame(this.<id>P, hiddenInGame);
		}

		// Token: 0x06047C8D RID: 294029 RVA: 0x0125D4F5 File Offset: 0x0125B6F5
		[NullableContext(2)]
		public void K2_AttachToActor(AActor parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_AttachToActor(this.<id>P, parent, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
		}

		// Token: 0x06047C8E RID: 294030 RVA: 0x0125D50C File Offset: 0x0125B70C
		[NullableContext(2)]
		public void K2_AttachToComponent(USceneComponent parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_AttachToComponent(this.<id>P, parent, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
		}

		// Token: 0x06047C8F RID: 294031 RVA: 0x0125D523 File Offset: 0x0125B723
		public FVectorDouble GetActorLocation()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_GetActorLocation(this.<id>P);
		}

		// Token: 0x06047C90 RID: 294032 RVA: 0x0125D530 File Offset: 0x0125B730
		public FVectorDouble D_K2_GetActorLocation()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_GetActorLocation(this.<id>P);
		}

		// Token: 0x06047C91 RID: 294033 RVA: 0x0125D53D File Offset: 0x0125B73D
		public FRotator K2_GetActorRotation()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_GetActorRotation(this.<id>P);
		}

		// Token: 0x06047C92 RID: 294034 RVA: 0x0125D54A File Offset: 0x0125B74A
		public FVectorDouble D_GetActorScale3D()
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_GetActorScale3D(this.<id>P);
		}

		// Token: 0x06047C93 RID: 294035 RVA: 0x0125D557 File Offset: 0x0125B757
		public bool D_K2_SetActorLocation(in FVectorDouble location, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			sweepHitResult = new FHitResult();
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorLocation(this.<id>P, location, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C94 RID: 294036 RVA: 0x0125D570 File Offset: 0x0125B770
		public bool K2_SetActorRotation(in FRotator rotation, bool bTeleportPhysics)
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_SetActorRotation(this.<id>P, rotation, bTeleportPhysics);
		}

		// Token: 0x06047C95 RID: 294037 RVA: 0x0125D57F File Offset: 0x0125B77F
		public void D_SetActorScale3D(in FVectorDouble scale)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_SetActorScale3D(this.<id>P, scale);
		}

		// Token: 0x06047C96 RID: 294038 RVA: 0x0125D58D File Offset: 0x0125B78D
		public bool D_K2_SetActorLocationAndRotation(in FVectorDouble location, in FRotator rotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorLocationAndRotation(this.<id>P, location, rotation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C97 RID: 294039 RVA: 0x0125D5A1 File Offset: 0x0125B7A1
		public void D_K2_AddActorWorldOffset(in FVectorDouble deltaLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_AddActorWorldOffset(this.<id>P, deltaLocation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C98 RID: 294040 RVA: 0x0125D5B3 File Offset: 0x0125B7B3
		public bool D_K2_SetActorTransform(in FTransformDouble transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorTransform(this.<id>P, transform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C99 RID: 294041 RVA: 0x0125D5C5 File Offset: 0x0125B7C5
		public void D_K2_SetActorRelativeLocation(in FVectorDouble relativeLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorRelativeLocation(this.<id>P, relativeLocation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C9A RID: 294042 RVA: 0x0125D5D7 File Offset: 0x0125B7D7
		public void K2_SetActorRelativeRotation(in FRotator relativeRotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_SetActorRelativeRotation(this.<id>P, relativeRotation, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C9B RID: 294043 RVA: 0x0125D5E9 File Offset: 0x0125B7E9
		public void D_K2_SetActorRelativeTransform(in FTransformDouble relativeTransform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_D_K2_SetActorRelativeTransform(this.<id>P, relativeTransform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x06047C9C RID: 294044 RVA: 0x0125D5FB File Offset: 0x0125B7FB
		public void K2_AddActorLocalTransform(in FTransform transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.ActorHandle_K2_AddActorLocalTransform(this.<id>P, transform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x04025BD1 RID: 154577
		[CompilerGenerated]
		private int <id>P = id;
	}
}
