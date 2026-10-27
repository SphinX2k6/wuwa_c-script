using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E6A RID: 28266
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalCoreFollowAbilityBase : LevelEntityAbilityBase
	{
		// Token: 0x06044E1B RID: 282139 RVA: 0x01100F4F File Offset: 0x010FF14F
		public PlayerElementalCoreFollowAbilityBase(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E1C RID: 282140 RVA: 0x01100F7D File Offset: 0x010FF17D
		public override bool OnAddAbility(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>() != null;
		}

		// Token: 0x06044E1D RID: 282141 RVA: 0x01100F88 File Offset: 0x010FF188
		public override void OnActivated(Entity entity)
		{
		}

		// Token: 0x06044E1E RID: 282142 RVA: 0x01100F8A File Offset: 0x010FF18A
		public override void OnDeactivated(Entity entity)
		{
		}

		// Token: 0x06044E1F RID: 282143 RVA: 0x01100F8C File Offset: 0x010FF18C
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

		// Token: 0x04023DBC RID: 146876
		private static readonly FName RootSocketName = new FName("Root");

		// Token: 0x04023DBD RID: 146877
		private readonly Vector RoleUpVector = Vector.Create();

		// Token: 0x04023DBE RID: 146878
		private readonly Vector TempTargetForward = Vector.Create();

		// Token: 0x04023DBF RID: 146879
		private readonly Vector TempVector = Vector.Create();
	}
}
