using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A3 RID: 17827
	[NullableContext(2)]
	[Nullable(0)]
	public class CharGrassInteraction : CharRenderBase
	{
		// Token: 0x0602DF6C RID: 188268 RVA: 0x00A92990 File Offset: 0x00A90B90
		private double GetRefBoneHeight()
		{
			return this.OwnerSkeletal.D_GetSocketTransform(new FName("Bip001Head"), ERelativeTransformSpace.RTS_Component).GetLocation().Z;
		}

		// Token: 0x0602DF6D RID: 188269 RVA: 0x00A929C0 File Offset: 0x00A90BC0
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
			if (this.GrassInteractionComponent != null)
			{
				this.GrassInteractionComponent.bEnabled = enabled;
			}
		}

		// Token: 0x0602DF6E RID: 188270 RVA: 0x00A929E0 File Offset: 0x00A90BE0
		public void SetConfig(PDA_InteractionPlayerConfig_C config)
		{
			if (config == null)
			{
				return;
			}
			if (this.IsOnMobile)
			{
				return;
			}
			float 植被交互半径 = config.植被交互半径;
			FVector 植被交互相对位置 = config.植被交互相对位置;
			bool 启用植被交互 = config.启用植被交互;
			this.UpdateInteraction(植被交互半径, 植被交互相对位置, 启用植被交互);
		}

		// Token: 0x0602DF6F RID: 188271 RVA: 0x00A92A18 File Offset: 0x00A90C18
		private void UpdateInteraction(float radius, FVector bias, bool enabled)
		{
			if (this.IsOnMobile)
			{
				return;
			}
			AActor cachedOwner = this.RenderComponent.GetCachedOwner();
			if (cachedOwner != null)
			{
				TsBaseCharacter tsBaseCharacter = cachedOwner as TsBaseCharacter;
				if (tsBaseCharacter != null)
				{
					this.OwnerCapsule = tsBaseCharacter.CapsuleComponent;
					this.OwnerSkeletal = tsBaseCharacter.Mesh;
				}
				else
				{
					TsBaseVehicle tsBaseVehicle = cachedOwner as TsBaseVehicle;
					if (tsBaseVehicle != null)
					{
						this.OwnerCapsule = tsBaseVehicle.CapsuleComponent;
						this.OwnerSkeletal = tsBaseVehicle.Mesh;
					}
				}
			}
			if (this.OwnerCapsule == null || this.OwnerSkeletal == null)
			{
				return;
			}
			ECharacterRenderingType? renderType = base.GetRenderingComponent().GetRenderType();
			bool flag;
			if (renderType != null)
			{
				ECharacterRenderingType valueOrDefault = renderType.GetValueOrDefault();
				if (valueOrDefault <= ECharacterRenderingType.RemotePlayer)
				{
					flag = true;
					goto IL_9A;
				}
			}
			flag = false;
			IL_9A:
			if (flag && this.OwnerSkeletal.GetBoneIndex(new FName("Bip001Head")) != -1)
			{
				this.AverageBoneHeight = (float)this.GetRefBoneHeight();
				this.NeedBoneMotion = true;
			}
			this.BaseBias = new FVector?(new FVector(bias.X, bias.Y, bias.Z - this.OwnerCapsule.CapsuleHalfHeight));
			if (this.GrassInteractionComponent == null)
			{
				AActor owner = base.GetRenderingComponent().GetOwner();
				AActor aactor = owner;
				TSubclassOf<UActorComponent> @class = UKuroGrassInteractionSphereComponent.StaticClass();
				bool bManualAttachment = false;
				FVector value = this.BaseBias.Value;
				FTransform ftransform = new FTransform(ref value);
				this.GrassInteractionComponent = (aactor.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroGrassInteractionSphereComponent);
			}
			this.GrassInteractionComponent.Radius = radius;
			this.GrassInteractionComponent.bEnabled = enabled;
			this.Enabled = enabled;
			this.UpdateForAimisi();
		}

		// Token: 0x0602DF70 RID: 188272 RVA: 0x00A92B98 File Offset: 0x00A90D98
		public override void Start()
		{
			this.IsOnMobile = (UKuroRenderingRuntimeBPPluginBPLibrary.GetWorldFeatureLevel(GlobalData.World) == KuroFeatureLevel.ES3_1);
			if (this.IsOnMobile)
			{
				base.OnInitSuccess();
				return;
			}
			if (this.RenderComponent.InteractionConfig != null)
			{
				this.SetConfig(this.RenderComponent.InteractionConfig);
			}
			else
			{
				this.UpdateInteraction(this.InteractionDefaultRadius, this.InteractionDefaultBias, true);
			}
			base.OnInitSuccess();
		}

		// Token: 0x0602DF71 RID: 188273 RVA: 0x00A92C00 File Offset: 0x00A90E00
		public override void Update()
		{
			if (this.IsOnMobile || this.GrassInteractionComponent == null)
			{
				return;
			}
			if (!this.NeedBoneMotion)
			{
				return;
			}
			float num = (float)this.GetRefBoneHeight();
			this.AverageBoneHeight = this.AverageBoneHeight * 0.9f + num * 0.1f;
			float num2 = num - this.AverageBoneHeight;
			if (num2 < -10f)
			{
				num2 = -10f;
			}
			FVectorDouble newLocation = new FVectorDouble((double)this.BaseBias.Value.X, (double)this.BaseBias.Value.Y, (double)this.BaseBias.Value.Z + (double)num2 * 3.0);
			FHitResult fhitResult = new FHitResult();
			this.GrassInteractionComponent.D_K2_SetRelativeLocation(newLocation, false, ref fhitResult, false);
		}

		// Token: 0x0602DF72 RID: 188274 RVA: 0x00A92CBD File Offset: 0x00A90EBD
		public override void PostBodyInfoRuntimeInit(FName bodyName)
		{
			this.UpdateForAimisi();
		}

		// Token: 0x0602DF73 RID: 188275 RVA: 0x00A92CC8 File Offset: 0x00A90EC8
		public void UpdateForAimisi()
		{
			if (this.GrassInteractionComponent != null)
			{
				USkeletalMeshComponent ownerSkeletal = this.OwnerSkeletal;
				USkeletalMesh uskeletalMesh = (ownerSkeletal != null) ? ownerSkeletal.SkeletalMesh : null;
				if (uskeletalMesh != null)
				{
					string name = uskeletalMesh.GetName();
					if (name == "R2T1AimisiGDMd10011")
					{
						this.GrassInteractionComponent.Radius = 150f;
						this.AverageBoneHeight = (float)this.GetRefBoneHeight();
						this.BaseBias = new FVector?(new FVector(0f, 0f, -7f));
						return;
					}
					if (name == "R2T1AimisiMd10011")
					{
						this.GrassInteractionComponent.Radius = 70f;
						this.AverageBoneHeight = (float)this.GetRefBoneHeight();
						this.OwnerCapsule.CapsuleHalfHeight = 77f;
						this.BaseBias = new FVector?(new FVector(0f, 0f, -7f));
					}
				}
			}
		}

		// Token: 0x0602DF74 RID: 188276 RVA: 0x00A92DA3 File Offset: 0x00A90FA3
		public override void Destroy()
		{
			if (this.GrassInteractionComponent != null)
			{
				AActor owner = this.GrassInteractionComponent.GetOwner();
				if (owner == null)
				{
					return;
				}
				owner.K2_DestroyComponent(this.GrassInteractionComponent);
			}
		}

		// Token: 0x0602DF75 RID: 188277 RVA: 0x00A92DC8 File Offset: 0x00A90FC8
		[NullableContext(1)]
		public override string GetStatName()
		{
			return "CharGrassInteraction";
		}

		// Token: 0x0602DF76 RID: 188278 RVA: 0x00A92DCF File Offset: 0x00A90FCF
		public override int GetComponentId()
		{
			return 11;
		}

		// Token: 0x040188A2 RID: 100514
		public UKuroGrassInteractionSphereComponent GrassInteractionComponent;

		// Token: 0x040188A3 RID: 100515
		public bool Enabled = true;

		// Token: 0x040188A4 RID: 100516
		public bool IsOnMobile;

		// Token: 0x040188A5 RID: 100517
		public UCapsuleComponent OwnerCapsule;

		// Token: 0x040188A6 RID: 100518
		public USkeletalMeshComponent OwnerSkeletal;

		// Token: 0x040188A7 RID: 100519
		public FVector? BaseBias;

		// Token: 0x040188A8 RID: 100520
		private float AverageBoneHeight;

		// Token: 0x040188A9 RID: 100521
		private bool NeedBoneMotion;

		// Token: 0x040188AA RID: 100522
		public readonly float InteractionDefaultRadius = 70f;

		// Token: 0x040188AB RID: 100523
		public readonly FVector InteractionDefaultBias = new FVector(0f, 0f, 70f);
	}
}
