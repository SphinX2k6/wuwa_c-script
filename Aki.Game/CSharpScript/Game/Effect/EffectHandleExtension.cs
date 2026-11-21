using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063E8 RID: 25576
	[NullableContext(1)]
	[Nullable(0)]
	public static class EffectHandleExtension
	{
		// Token: 0x0603DFB7 RID: 253879 RVA: 0x011FCCF6 File Offset: 0x011FAEF6
		public static bool IsValid([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.IsValid();
			}
			return self.IsT2 && self.AsT2.IsValid();
		}

		// Token: 0x0603DFB8 RID: 253880 RVA: 0x011FCD25 File Offset: 0x011FAF25
		public static void SetActorHiddenInGame([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, bool hiddenInGame)
		{
			if (self.IsT1)
			{
				self.AsT1.SetActorHiddenInGame(hiddenInGame);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.SetActorHiddenInGame(hiddenInGame);
			}
		}

		// Token: 0x0603DFB9 RID: 253881 RVA: 0x011FCD54 File Offset: 0x011FAF54
		[NullableContext(2)]
		public static void K2_AttachToActor([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, AActor parent, in FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_AttachToActor(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_AttachToActor(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
			}
		}

		// Token: 0x0603DFBA RID: 253882 RVA: 0x011FCDDC File Offset: 0x011FAFDC
		[NullableContext(2)]
		public static void K2_AttachToComponent([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, USceneComponent parent, FName? socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_AttachToComponent(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_AttachToComponent(parent, socketName ?? FName.NAME_None, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
			}
		}

		// Token: 0x0603DFBB RID: 253883 RVA: 0x011FCE58 File Offset: 0x011FB058
		public static FVectorDouble GetActorLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.GetActorLocation();
			}
			if (self.IsT2)
			{
				return self.AsT2.D_K2_GetActorLocation();
			}
			return default(FVectorDouble);
		}

		// Token: 0x0603DFBC RID: 253884 RVA: 0x011FCE9C File Offset: 0x011FB09C
		public static FVectorDouble D_K2_GetActorLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_GetActorLocation();
			}
			if (self.IsT2)
			{
				return self.AsT2.D_K2_GetActorLocation();
			}
			return default(FVectorDouble);
		}

		// Token: 0x0603DFBD RID: 253885 RVA: 0x011FCEE0 File Offset: 0x011FB0E0
		public static FRotator K2_GetActorRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.K2_GetActorRotation();
			}
			if (self.IsT2)
			{
				return self.AsT2.K2_GetActorRotation();
			}
			return default(FRotator);
		}

		// Token: 0x0603DFBE RID: 253886 RVA: 0x011FCF24 File Offset: 0x011FB124
		public static FVectorDouble D_GetActorScale3D([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_GetActorScale3D();
			}
			if (self.IsT2)
			{
				return self.AsT2.D_GetActorScale3D();
			}
			return default(FVectorDouble);
		}

		// Token: 0x0603DFBF RID: 253887 RVA: 0x011FCF66 File Offset: 0x011FB166
		public static bool D_K2_SetActorLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble location, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_SetActorLocation(location, bSweep, ref sweepHitResult, bTeleport);
			}
			return self.IsT2 && self.AsT2.D_K2_SetActorLocation(location, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603DFC0 RID: 253888 RVA: 0x011FCFA4 File Offset: 0x011FB1A4
		public static bool K2_SetActorRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FRotator rotation, bool bTeleportPhysics)
		{
			if (self.IsT1)
			{
				return self.AsT1.K2_SetActorRotation(rotation, bTeleportPhysics);
			}
			return self.IsT2 && self.AsT2.K2_SetActorRotation(rotation, bTeleportPhysics);
		}

		// Token: 0x0603DFC1 RID: 253889 RVA: 0x011FCFDC File Offset: 0x011FB1DC
		public static void D_SetActorScale3D([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble scale)
		{
			if (self.IsT1)
			{
				self.AsT1.D_SetActorScale3D(scale);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_SetActorScale3D(scale);
			}
		}

		// Token: 0x0603DFC2 RID: 253890 RVA: 0x011FD010 File Offset: 0x011FB210
		public static bool D_K2_SetActorLocationAndRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble location, in FRotator rotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_SetActorLocationAndRotation(location, rotation, false, ref sweepHitResult, true);
			}
			return self.IsT2 && self.AsT2.D_K2_SetActorLocationAndRotation(location, rotation, false, ref sweepHitResult, true);
		}

		// Token: 0x0603DFC3 RID: 253891 RVA: 0x011FD060 File Offset: 0x011FB260
		public static void D_K2_AddActorWorldOffset([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble deltaLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.D_K2_AddActorWorldOffset(deltaLocation, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_K2_AddActorWorldOffset(deltaLocation, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x0603DFC4 RID: 253892 RVA: 0x011FD09C File Offset: 0x011FB29C
		public static bool D_K2_SetActorTransform([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FTransformDouble transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				return self.AsT1.D_K2_SetActorTransform(transform, bSweep, ref sweepHitResult, bTeleport);
			}
			return self.IsT2 && self.AsT2.D_K2_SetActorTransform(transform, bSweep, ref sweepHitResult, bTeleport);
		}

		// Token: 0x0603DFC5 RID: 253893 RVA: 0x011FD0D5 File Offset: 0x011FB2D5
		public static void D_K2_SetActorRelativeLocation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FVectorDouble relativeLocation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.D_K2_SetActorRelativeLocation(relativeLocation, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_K2_SetActorRelativeLocation(relativeLocation, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x0603DFC6 RID: 253894 RVA: 0x011FD111 File Offset: 0x011FB311
		public static void K2_SetActorRelativeRotation([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FRotator relativeRotation, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_SetActorRelativeRotation(relativeRotation, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_SetActorRelativeRotation(relativeRotation, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x0603DFC7 RID: 253895 RVA: 0x011FD14D File Offset: 0x011FB34D
		public static void D_K2_SetActorRelativeTransform([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FTransformDouble relativeTransform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.D_K2_SetActorRelativeTransform(relativeTransform, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.D_K2_SetActorRelativeTransform(relativeTransform, bSweep, ref sweepHitResult, bTeleport);
			}
		}

		// Token: 0x0603DFC8 RID: 253896 RVA: 0x011FD184 File Offset: 0x011FB384
		public static void K2_AddActorLocalTransform([Nullable(new byte[]
		{
			0,
			1,
			1
		})] this OneOf<KuroEffectActorHandle, AActor> self, in FTransform transform, bool bSweep, ref FHitResult sweepHitResult, bool bTeleport)
		{
			if (self.IsT1)
			{
				self.AsT1.K2_AddActorLocalTransform(transform, bSweep, ref sweepHitResult, bTeleport);
				return;
			}
			if (self.IsT2)
			{
				self.AsT2.K2_AddActorLocalTransform(transform, bSweep, ref sweepHitResult, bTeleport);
			}
		}
	}
}
