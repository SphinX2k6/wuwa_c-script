using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061A2 RID: 24994
	public class MotorcycleAnimationComponent : VehicleAnimationComponent
	{
		// Token: 0x0603BF87 RID: 245639 RVA: 0x01109500 File Offset: 0x01107700
		protected override bool OnStart()
		{
			base.OnStart();
			if (this.Mesh.DoesSocketExist(VehicleAnimationComponent.CameraPosition))
			{
				Vector cameraPositionOffset = this.CameraPositionOffset;
				FVectorDouble refBoneComponentPosition = this.Mesh.GetRefBoneComponentPosition(this.Mesh.GetSocketBoneName(VehicleAnimationComponent.CameraPosition));
				cameraPositionOffset.FromUeVector(refBoneComponentPosition);
			}
			else if (this.Mesh.DoesSocketExist(VehicleAnimationComponent.SeatProp01))
			{
				Vector cameraPositionOffset2 = this.CameraPositionOffset;
				FVectorDouble refBoneComponentPosition = this.Mesh.GetRefBoneComponentPosition(this.Mesh.GetSocketBoneName(VehicleAnimationComponent.SeatProp01));
				cameraPositionOffset2.FromUeVector(refBoneComponentPosition);
			}
			this.Mesh.bUpdateChildTransInDelayComplete = true;
			UeSkeletalTickManageComponent component = base.Entity.GetComponent<UeSkeletalTickManageComponent>();
			if (component != null)
			{
				component.StartForceDisableAnimDelay(EForceDisableAnimDelayReason.Motorcycle);
			}
			return true;
		}

		// Token: 0x0603BF88 RID: 245640 RVA: 0x011095B4 File Offset: 0x011077B4
		[NullableContext(1)]
		public override void GetCameraPosition(Vector @out, FName? socketName = null)
		{
			if (!FNameUtil.IsEmpty(socketName))
			{
				FVectorDouble fvectorDouble = this.Mesh.D_GetSocketLocation(socketName.Value);
				@out.DeepCopy(fvectorDouble);
				return;
			}
			VehicleAnimationComponent.ECameraPositionType cameraPositionType = this.CameraPositionType;
			if (cameraPositionType != VehicleAnimationComponent.ECameraPositionType.CameraPosition)
			{
				if (cameraPositionType != VehicleAnimationComponent.ECameraPositionType.SeatProp01)
				{
					this.ActorComp.ActorUpProxy.Multiply((double)(0.5f * this.ActorComp.Actor.VehicleMovementComponent.VehicleShapeBounds.BoxExtent.Z), this.TmpDirect);
					this.ActorComp.ActorLocationProxy.Addition(this.TmpDirect, @out);
					return;
				}
				FVectorDouble fvectorDouble = this.Mesh.D_GetSocketLocation(VehicleAnimationComponent.SeatProp01);
				@out.FromUeVector(fvectorDouble);
				return;
			}
			else
			{
				if (base.HasModelBuffer())
				{
					this.TmpQuat.DeepCopy(this.Mesh.D_K2_GetComponentToWorld().GetRotation());
					this.BufferShowTransform.GetRotation().Inverse(this.TmpQuat2);
					this.TmpQuat2.Multiply(this.TmpQuat, this.TmpQuat);
					this.TmpQuat.RotateVector(this.CameraPositionOffset, this.TmpDirect);
					this.ActorComp.ActorLocationProxy.Addition(this.TmpDirect, @out);
					return;
				}
				this.ActorComp.ActorQuatProxy.RotateVector(this.CameraPositionOffset, this.TmpDirect);
				this.ActorComp.ActorLocationProxy.Addition(this.TmpDirect, @out);
				return;
			}
		}

		// Token: 0x17007100 RID: 28928
		// (get) Token: 0x0603BF89 RID: 245641 RVA: 0x01109722 File Offset: 0x01107922
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007101 RID: 28929
		// (get) Token: 0x0603BF8A RID: 245642 RVA: 0x01109725 File Offset: 0x01107925
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007102 RID: 28930
		// (get) Token: 0x0603BF8B RID: 245643 RVA: 0x01109728 File Offset: 0x01107928
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007103 RID: 28931
		// (get) Token: 0x0603BF8C RID: 245644 RVA: 0x0110972B File Offset: 0x0110792B
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007104 RID: 28932
		// (get) Token: 0x0603BF8D RID: 245645 RVA: 0x0110972E File Offset: 0x0110792E
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007105 RID: 28933
		// (get) Token: 0x0603BF8E RID: 245646 RVA: 0x01109731 File Offset: 0x01107931
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007106 RID: 28934
		// (get) Token: 0x0603BF8F RID: 245647 RVA: 0x01109734 File Offset: 0x01107934
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007107 RID: 28935
		// (get) Token: 0x0603BF90 RID: 245648 RVA: 0x01109737 File Offset: 0x01107937
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007108 RID: 28936
		// (get) Token: 0x0603BF91 RID: 245649 RVA: 0x0110973A File Offset: 0x0110793A
		public override bool NeedForceAfterTickInternal
		{
			get
			{
				return true;
			}
		}
	}
}
