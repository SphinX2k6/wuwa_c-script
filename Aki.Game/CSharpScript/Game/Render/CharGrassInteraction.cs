using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034CB RID: 13515
	[NullableContext(2)]
	[Nullable(0)]
	public class CharGrassInteraction : CharRenderBase
	{
		// Token: 0x06022656 RID: 140886 RVA: 0x009BEBB0 File Offset: 0x009BCDB0
		private double GetRefBoneHeight()
		{
			return this.OwnerSkeletal.D_GetSocketTransform(new FName("Bip001Head"), ERelativeTransformSpace.RTS_Component).GetLocation().Z;
		}

		// Token: 0x06022657 RID: 140887 RVA: 0x009BEBE0 File Offset: 0x009BCDE0
		public void SetEnabled(bool enabled)
		{
			this.Enabled = enabled;
			if (this.GrassInteractionComponent != null)
			{
				this.GrassInteractionComponent.bEnabled = enabled;
			}
		}

		// Token: 0x06022658 RID: 140888 RVA: 0x009BEC00 File Offset: 0x009BCE00
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

		// Token: 0x06022659 RID: 140889 RVA: 0x009BEC38 File Offset: 0x009BCE38
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

		// Token: 0x0602265A RID: 140890 RVA: 0x009BEDB8 File Offset: 0x009BCFB8
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

		// Token: 0x0602265B RID: 140891 RVA: 0x009BEE20 File Offset: 0x009BD020
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

		// Token: 0x0602265C RID: 140892 RVA: 0x009BEEDD File Offset: 0x009BD0DD
		public override void PostBodyInfoRuntimeInit(FName bodyName)
		{
			this.UpdateForAimisi();
		}

		// Token: 0x0602265D RID: 140893 RVA: 0x009BEEE8 File Offset: 0x009BD0E8
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

		// Token: 0x0602265E RID: 140894 RVA: 0x009BEFC3 File Offset: 0x009BD1C3
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

		// Token: 0x0602265F RID: 140895 RVA: 0x009BEFE8 File Offset: 0x009BD1E8
		[NullableContext(1)]
		public override string GetStatName()
		{
			return "CharGrassInteraction";
		}

		// Token: 0x06022660 RID: 140896 RVA: 0x009BEFEF File Offset: 0x009BD1EF
		public override int GetComponentId()
		{
			return 11;
		}

		// Token: 0x04012EDD RID: 77533
		public UKuroGrassInteractionSphereComponent GrassInteractionComponent;

		// Token: 0x04012EDE RID: 77534
		public bool Enabled = true;

		// Token: 0x04012EDF RID: 77535
		public bool IsOnMobile;

		// Token: 0x04012EE0 RID: 77536
		public UCapsuleComponent OwnerCapsule;

		// Token: 0x04012EE1 RID: 77537
		public USkeletalMeshComponent OwnerSkeletal;

		// Token: 0x04012EE2 RID: 77538
		public FVector? BaseBias;

		// Token: 0x04012EE3 RID: 77539
		private float AverageBoneHeight;

		// Token: 0x04012EE4 RID: 77540
		private bool NeedBoneMotion;

		// Token: 0x04012EE5 RID: 77541
		public readonly float InteractionDefaultRadius = 70f;

		// Token: 0x04012EE6 RID: 77542
		public readonly FVector InteractionDefaultBias = new FVector(0f, 0f, 70f);
	}
}
