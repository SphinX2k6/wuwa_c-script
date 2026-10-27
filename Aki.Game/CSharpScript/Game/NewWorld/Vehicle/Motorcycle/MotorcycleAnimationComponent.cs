using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x02007021 RID: 28705
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleAnimationComponent : VehicleAnimationComponent
	{
		// Token: 0x06045DCF RID: 286159 RVA: 0x0115F158 File Offset: 0x0115D358
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

		// Token: 0x06045DD0 RID: 286160 RVA: 0x0115F20C File Offset: 0x0115D40C
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

		// Token: 0x06045DD1 RID: 286161 RVA: 0x0115F37A File Offset: 0x0115D57A
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleAnimationComponent motorcycleAnimationComponent = (MotorcycleAnimationComponent)componentTemplate;
			return true;
		}
	}
}
