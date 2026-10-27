using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070CB RID: 28875
	[NullableContext(1)]
	[Nullable(0)]
	public class MeshDitherDetectConfig
	{
		// Token: 0x06046757 RID: 288599 RVA: 0x011B06BC File Offset: 0x011AE8BC
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

		// Token: 0x04024EBE RID: 151230
		public int Id;

		// Token: 0x04024EBF RID: 151231
		public bool MarkDelete;

		// Token: 0x04024EC0 RID: 151232
		public int Priority;

		// Token: 0x04024EC1 RID: 151233
		public FName BaseBoneName = CharacterNameDefines.Instance.BIP_001_SPINE;

		// Token: 0x04024EC2 RID: 151234
		public FName TargetBoneName = CharacterNameDefines.Instance.BIP_001_NECK;

		// Token: 0x04024EC3 RID: 151235
		public FName BasisBoneName = CharacterNameDefines.Instance.BIP_001_SPINE;

		// Token: 0x04024EC4 RID: 151236
		public float CapsuleAdditionRadius;

		// Token: 0x04024EC5 RID: 151237
		public float CapsuleAdditionHeight;

		// Token: 0x04024EC6 RID: 151238
		public Vector CapsuleAdditionOffset = Vector.Create();

		// Token: 0x04024EC7 RID: 151239
		public Rotator CapsuleAdditionRotator = Rotator.Create();

		// Token: 0x04024EC8 RID: 151240
		public bool EnableDebug;

		// Token: 0x04024EC9 RID: 151241
		public bool OverrideDitherConfig;

		// Token: 0x04024ECA RID: 151242
		public float StartHideDistance;

		// Token: 0x04024ECB RID: 151243
		public float CompleteHideDistance;

		// Token: 0x04024ECC RID: 151244
		public float StartDitherValue;
	}
}
