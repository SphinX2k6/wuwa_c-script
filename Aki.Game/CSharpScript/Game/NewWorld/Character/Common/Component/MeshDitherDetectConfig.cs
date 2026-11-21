using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200632F RID: 25391
	[NullableContext(1)]
	[Nullable(0)]
	public class MeshDitherDetectConfig
	{
		// Token: 0x0603D84B RID: 251979 RVA: 0x011CFA38 File Offset: 0x011CDC38
		public MeshDitherDetectConfig(SMeshDitherDetectConfig meshDitherDetectConfig, int id)
		{
			this.Id = id;
			this.Priority = meshDitherDetectConfig.Priority;
			this.BaseBoneName = meshDitherDetectConfig.TraceConfig.BaseBoneName;
			this.TargetBoneName = meshDitherDetectConfig.TraceConfig.TargetBoneName;
			this.BasisBoneName = meshDitherDetectConfig.TraceConfig.BasisBoneName;
			this.CapsuleAdditionRadius = meshDitherDetectConfig.TraceConfig.AdditionCapsuleSize.X;
			this.CapsuleAdditionHeight = meshDitherDetectConfig.TraceConfig.AdditionCapsuleSize.Y;
			Vector capsuleAdditionOffset = this.CapsuleAdditionOffset;
			FVector additionCapsuleOffset = meshDitherDetectConfig.TraceConfig.AdditionCapsuleOffset;
			FVectorDouble fvectorDouble = additionCapsuleOffset;
			capsuleAdditionOffset.DeepCopy(fvectorDouble);
			Rotator capsuleAdditionRotator = this.CapsuleAdditionRotator;
			FRotator additionCapsuleRotator = meshDitherDetectConfig.TraceConfig.AdditionCapsuleRotator;
			capsuleAdditionRotator.DeepCopy(additionCapsuleRotator);
			this.EnableDebug = meshDitherDetectConfig.TraceConfig.Debug;
			this.OverrideDitherConfig = meshDitherDetectConfig.DitherConfig.OverrideDefaultDitherConfig;
			this.StartHideDistance = meshDitherDetectConfig.DitherConfig.StartHideDistance;
			this.CompleteHideDistance = meshDitherDetectConfig.DitherConfig.CompleteHideDistance;
			this.StartDitherValue = meshDitherDetectConfig.DitherConfig.StartDitherValue;
		}

		// Token: 0x040209FD RID: 133629
		public int Id;

		// Token: 0x040209FE RID: 133630
		public bool MarkDelete;

		// Token: 0x040209FF RID: 133631
		public int Priority;

		// Token: 0x04020A00 RID: 133632
		public FName BaseBoneName = CharacterNameDefines.Instance.BIP_001_SPINE;

		// Token: 0x04020A01 RID: 133633
		public FName TargetBoneName = CharacterNameDefines.Instance.BIP_001_NECK;

		// Token: 0x04020A02 RID: 133634
		public FName BasisBoneName = CharacterNameDefines.Instance.BIP_001_SPINE;

		// Token: 0x04020A03 RID: 133635
		public float CapsuleAdditionRadius;

		// Token: 0x04020A04 RID: 133636
		public float CapsuleAdditionHeight;

		// Token: 0x04020A05 RID: 133637
		public Vector CapsuleAdditionOffset = Vector.Create();

		// Token: 0x04020A06 RID: 133638
		public Rotator CapsuleAdditionRotator = Rotator.Create();

		// Token: 0x04020A07 RID: 133639
		public bool EnableDebug;

		// Token: 0x04020A08 RID: 133640
		public bool OverrideDitherConfig;

		// Token: 0x04020A09 RID: 133641
		public float StartHideDistance;

		// Token: 0x04020A0A RID: 133642
		public float CompleteHideDistance;

		// Token: 0x04020A0B RID: 133643
		public float StartDitherValue;
	}
}
