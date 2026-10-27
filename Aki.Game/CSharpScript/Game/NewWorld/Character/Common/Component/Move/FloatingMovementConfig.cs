using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070DD RID: 28893
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingMovementConfig
	{
		// Token: 0x0604682D RID: 288813 RVA: 0x011B8788 File Offset: 0x011B6988
		public void Init(BP_FloatingMovementConfig_C asset)
		{
			this.MoveSpeed = (float)asset.MoveSpeed;
			this.SprintSpeed = (float)asset.SprintSpeed;
			this.TurnSpeedDeg = (float)asset.TurnSpeedDeg;
			this.EnergyRecoverSpeed = (float)asset.EnergyRecoverSpeed;
			this.EnergyRecoverCoolDownTime = (float)asset.EnergyRecoverCoolDownTime;
			this.AirCriticalHeight = (float)asset.AirCriticalHeight;
			this.CloseToGroundHeight = (float)asset.CloseToGroundHeight;
			this.AirEnergyConsumption = (float)asset.AirEnergyConsumption;
			this.DodgeEnergyConsumption = (float)asset.DodgeEnergyConsumption;
			this.DropEnergyConsumption = (float)asset.DropEnergyConsumption;
			this.FastMoveEnergyConsumption = (float)asset.FastMoveEnergyConsumption;
			this.MoveEnergyConsumption = (float)asset.MoveEnergyConsumption;
			this.RiseEnergyConsumption = (float)asset.RiseEnergyConsumption;
			this.SprintEnergyConsumption = (float)asset.SprintEnergyConsumption;
			this.RiseSpeed = (float)asset.RiseSpeed;
			this.DropSpeed = (float)asset.DropSpeed;
			this.AnimLerpAlpha = asset.AnimLerpAlpha;
			this.SpeedAcceleration = asset.SpeedAcceleration;
			this.DirectionLerpAlpha = asset.DirectionLerpAlpha;
			for (int i = 0; i < asset.ForbidRotationTagList.GameplayTags.Num(); i++)
			{
				this.ForbidRotationTagList.Add(asset.ForbidRotationTagList.GameplayTags.Get(i).TagId());
			}
			for (int j = 0; j < asset.ForbidCloseToGrounTagList.GameplayTags.Num(); j++)
			{
				this.ForbidCloseToGroundTagList.Add(asset.ForbidCloseToGrounTagList.GameplayTags.Get(j).TagId());
			}
			this.DefaultMoveModeConfig.SetConfig(asset.DefaultMode);
			this.FloatingMoveModeConfig.SetConfig(asset.FloatingMode);
			this.RiseMoveModeConfig.SetConfig(asset.RiseMode);
			this.DropMoveModeConfig.SetConfig(asset.DropMode);
			this.WalkMoveModeConfig.SetConfig(asset.WalkMode);
		}

		// Token: 0x04024FA5 RID: 151461
		public float MoveSpeed = 600f;

		// Token: 0x04024FA6 RID: 151462
		public float SprintSpeed = 1200f;

		// Token: 0x04024FA7 RID: 151463
		public float TurnSpeedDeg = 360f;

		// Token: 0x04024FA8 RID: 151464
		public float AnimLerpAlpha = 0.1f;

		// Token: 0x04024FA9 RID: 151465
		public float SpeedAcceleration = 0.5f;

		// Token: 0x04024FAA RID: 151466
		public float DirectionLerpAlpha = 0.1f;

		// Token: 0x04024FAB RID: 151467
		public float EnergyRecoverSpeed = 10f;

		// Token: 0x04024FAC RID: 151468
		public float EnergyRecoverCoolDownTime = 3f;

		// Token: 0x04024FAD RID: 151469
		public float AirCriticalHeight = 500f;

		// Token: 0x04024FAE RID: 151470
		public float CloseToGroundHeight = 550f;

		// Token: 0x04024FAF RID: 151471
		public float AirEnergyConsumption = 10f;

		// Token: 0x04024FB0 RID: 151472
		public float DodgeEnergyConsumption = 10f;

		// Token: 0x04024FB1 RID: 151473
		public float DropEnergyConsumption = 5f;

		// Token: 0x04024FB2 RID: 151474
		public float FastMoveEnergyConsumption = 15f;

		// Token: 0x04024FB3 RID: 151475
		public float MoveEnergyConsumption = 15f;

		// Token: 0x04024FB4 RID: 151476
		public float RiseEnergyConsumption = 20f;

		// Token: 0x04024FB5 RID: 151477
		public float SprintEnergyConsumption = 20f;

		// Token: 0x04024FB6 RID: 151478
		public float RiseSpeed = 300f;

		// Token: 0x04024FB7 RID: 151479
		public float DropSpeed = 200f;

		// Token: 0x04024FB8 RID: 151480
		public List<int> ForbidRotationTagList = new List<int>();

		// Token: 0x04024FB9 RID: 151481
		public List<int> ForbidCloseToGroundTagList = new List<int>();

		// Token: 0x04024FBA RID: 151482
		public MovementStateConfig DefaultMoveModeConfig = new MovementStateConfig();

		// Token: 0x04024FBB RID: 151483
		public MovementStateConfig FloatingMoveModeConfig = new MovementStateConfig();

		// Token: 0x04024FBC RID: 151484
		public MovementStateConfig RiseMoveModeConfig = new MovementStateConfig();

		// Token: 0x04024FBD RID: 151485
		public MovementStateConfig DropMoveModeConfig = new MovementStateConfig();

		// Token: 0x04024FBE RID: 151486
		public MovementStateConfig WalkMoveModeConfig = new MovementStateConfig();
	}
}
