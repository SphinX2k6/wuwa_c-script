using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FEB RID: 24555
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreFollowAbilityBase : LevelEntityAbilityBase
	{
		// Token: 0x0603AFAA RID: 241578 RVA: 0x010AB4B6 File Offset: 0x010A96B6
		public PlayerElementalCoreFollowAbilityBase(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603AFAB RID: 241579 RVA: 0x010AB4E4 File Offset: 0x010A96E4
		public override bool OnAddAbility(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>() != null;
		}

		// Token: 0x0603AFAC RID: 241580 RVA: 0x010AB4EF File Offset: 0x010A96EF
		public override void OnActivated(Entity entity)
		{
		}

		// Token: 0x0603AFAD RID: 241581 RVA: 0x010AB4F1 File Offset: 0x010A96F1
		public override void OnDeactivated(Entity entity)
		{
		}

		// Token: 0x0603AFAE RID: 241582 RVA: 0x010AB4F4 File Offset: 0x010A96F4
		protected bool GetTargetLocationAndRotation(ElementalCoreConfig config, Vector outLocation, Rotator outRotation)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return false;
			}
			outRotation.DeepCopy(config.Rotation);
			Vector locationOffset = config.LocationOffset;
			USkeletalMeshComponent mesh = baseCharacter.Mesh;
			FVectorDouble fvectorDouble;
			if (mesh != null)
			{
				fvectorDouble = mesh.D_GetSocketLocation(PlayerElementalCoreFollowAbilityBase.RootSocketName);
				outLocation.FromUeVector(fvectorDouble);
			}
			else
			{
				fvectorDouble = baseCharacter.D_K2_GetActorLocation();
				outLocation.FromUeVector(fvectorDouble);
			}
			Vector tempTargetForward = this.TempTargetForward;
			FVector actorForwardVector = Global.CharacterCameraManager.GetActorForwardVector();
			tempTargetForward.FromUeVector(actorForwardVector);
			Vector roleUpVector = this.RoleUpVector;
			fvectorDouble = baseCharacter.D_GetActorUpVector();
			roleUpVector.FromUeVector(fvectorDouble);
			Vector.VectorPlaneProject(this.TempTargetForward, this.RoleUpVector, this.TempVector);
			this.TempTargetForward.DeepCopy(this.TempVector);
			this.TempTargetForward.Normalize(9.99999993922529E-09);
			this.TempTargetForward.Multiply(locationOffset.X, this.TempVector);
			outLocation.AdditionEqual(this.TempVector);
			this.TempTargetForward.RotateAngleAxis(90.0, this.RoleUpVector, this.TempTargetForward);
			this.TempTargetForward.Multiply(locationOffset.Y, this.TempVector);
			outLocation.AdditionEqual(this.TempVector);
			this.RoleUpVector.Multiply(locationOffset.Z, this.TempVector);
			outLocation.AdditionEqual(this.TempVector);
			return true;
		}

		// Token: 0x0401F071 RID: 127089
		private static readonly FName RootSocketName = new FName("Root");

		// Token: 0x0401F072 RID: 127090
		private readonly Vector RoleUpVector = Vector.Create();

		// Token: 0x0401F073 RID: 127091
		private readonly Vector TempTargetForward = Vector.Create();

		// Token: 0x0401F074 RID: 127092
		private readonly Vector TempVector = Vector.Create();
	}
}
