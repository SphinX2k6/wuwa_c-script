using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200638D RID: 25485
	[NullableContext(1)]
	[Nullable(0)]
	public class FloatingMovementConfig
	{
		// Token: 0x0603DC1A RID: 252954 RVA: 0x011E7E5C File Offset: 0x011E605C
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

		// Token: 0x04020C3A RID: 134202
		public float MoveSpeed = 600f;

		// Token: 0x04020C3B RID: 134203
		public float SprintSpeed = 1200f;

		// Token: 0x04020C3C RID: 134204
		public float TurnSpeedDeg = 360f;

		// Token: 0x04020C3D RID: 134205
		public float AnimLerpAlpha = 0.1f;

		// Token: 0x04020C3E RID: 134206
		public float SpeedAcceleration = 0.5f;

		// Token: 0x04020C3F RID: 134207
		public float DirectionLerpAlpha = 0.1f;

		// Token: 0x04020C40 RID: 134208
		public float EnergyRecoverSpeed = 10f;

		// Token: 0x04020C41 RID: 134209
		public float EnergyRecoverCoolDownTime = 3f;

		// Token: 0x04020C42 RID: 134210
		public float AirCriticalHeight = 500f;

		// Token: 0x04020C43 RID: 134211
		public float CloseToGroundHeight = 550f;

		// Token: 0x04020C44 RID: 134212
		public float AirEnergyConsumption = 10f;

		// Token: 0x04020C45 RID: 134213
		public float DodgeEnergyConsumption = 10f;

		// Token: 0x04020C46 RID: 134214
		public float DropEnergyConsumption = 5f;

		// Token: 0x04020C47 RID: 134215
		public float FastMoveEnergyConsumption = 15f;

		// Token: 0x04020C48 RID: 134216
		public float MoveEnergyConsumption = 15f;

		// Token: 0x04020C49 RID: 134217
		public float RiseEnergyConsumption = 20f;

		// Token: 0x04020C4A RID: 134218
		public float SprintEnergyConsumption = 20f;

		// Token: 0x04020C4B RID: 134219
		public float RiseSpeed = 300f;

		// Token: 0x04020C4C RID: 134220
		public float DropSpeed = 200f;

		// Token: 0x04020C4D RID: 134221
		public List<int> ForbidRotationTagList = new List<int>();

		// Token: 0x04020C4E RID: 134222
		public List<int> ForbidCloseToGroundTagList = new List<int>();

		// Token: 0x04020C4F RID: 134223
		public MovementStateConfig DefaultMoveModeConfig = new MovementStateConfig();

		// Token: 0x04020C50 RID: 134224
		public MovementStateConfig FloatingMoveModeConfig = new MovementStateConfig();

		// Token: 0x04020C51 RID: 134225
		public MovementStateConfig RiseMoveModeConfig = new MovementStateConfig();

		// Token: 0x04020C52 RID: 134226
		public MovementStateConfig DropMoveModeConfig = new MovementStateConfig();

		// Token: 0x04020C53 RID: 134227
		public MovementStateConfig WalkMoveModeConfig = new MovementStateConfig();
	}
}
