using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.WuwaGo.Controller.Role;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.GameplayEntity;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.GameMode
{
	// Token: 0x0200477B RID: 18299
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoNormalGameMode : WuWaGoGameModeBase
	{
		// Token: 0x0602FDAE RID: 196014 RVA: 0x00B1706B File Offset: 0x00B1526B
		protected override bool OnStart()
		{
			this.PrimeFollowCameraToMainControl();
			return true;
		}

		// Token: 0x0602FDAF RID: 196015 RVA: 0x00B17074 File Offset: 0x00B15274
		protected override bool OnEnd()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					logicComponent.RestoreCameraFromAdjust(new float?((float)1), null, true);
				}
			}
			return true;
		}

		// Token: 0x0602FDB0 RID: 196016 RVA: 0x00B170A5 File Offset: 0x00B152A5
		protected override void OnTick(float delta)
		{
			if (WuWaGoModel.Instance.EnableDebug)
			{
				this.DrawDebug(this.GameData);
			}
			this.UpdateFollowCameraToMainControl();
			if (base.IsDeathSequenceActive || base.IsCinematicPlaying)
			{
				return;
			}
			this.RoundManager.Tick(delta);
		}

		// Token: 0x0602FDB1 RID: 196017 RVA: 0x00B170E3 File Offset: 0x00B152E3
		private void PrimeFollowCameraToMainControl()
		{
			if (!this.UpdateFollowCameraToMainControl())
			{
				return;
			}
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera == null)
			{
				return;
			}
			FightCameraLogicComponent component = fightCamera.GetComponent<FightCameraLogicComponent>();
			if (component == null)
			{
				return;
			}
			component.SnapZoneFollowToCurrentTarget();
		}

		// Token: 0x0602FDB2 RID: 196018 RVA: 0x00B17114 File Offset: 0x00B15314
		private bool UpdateFollowCameraToMainControl()
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.GetComponent<FightCameraLogicComponent>() : null;
			WuWaGoMainControlRole mainControlRole = this.GameData.MainControlRole;
			FVectorDouble? fvectorDouble = (mainControlRole != null) ? mainControlRole.GetWorldLocation() : null;
			if (fightCameraLogicComponent == null || fvectorDouble == null)
			{
				return false;
			}
			Vector followCameraTargetScratch = this.FollowCameraTargetScratch;
			FVectorDouble value = fvectorDouble.Value;
			followCameraTargetScratch.FromUeVector(value);
			fightCameraLogicComponent.UpdateZoneFollowTargetPosition(this.FollowCameraTargetScratch);
			return true;
		}

		// Token: 0x0602FDB3 RID: 196019 RVA: 0x00B1718D File Offset: 0x00B1538D
		private void DrawDebug(WuWaGoGameData gameData)
		{
			this.DrawMainControlCoordinateText(gameData);
			this.DrawCurProcessUnitArrow(gameData);
			this.DrawAllGridLinks(gameData);
		}

		// Token: 0x0602FDB4 RID: 196020 RVA: 0x00B171A4 File Offset: 0x00B153A4
		private void DrawMainControlCoordinateText(WuWaGoGameData gameData)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Vector vector;
			if (baseCharacter == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
			}
			Vector vector2 = vector;
			if (vector2 == null)
			{
				return;
			}
			WuWaGoMainControlRole mainControlRole = gameData.MainControlRole;
			Vector vector3 = (mainControlRole != null) ? mainControlRole.Coordinate : null;
			UObject world = GlobalData.World;
			FVectorDouble textLocation = vector2.ToUeVector(false);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 3);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<double>((vector3 != null) ? vector3.X : 0.0);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>((vector3 != null) ? vector3.Y : 0.0);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>((vector3 != null) ? vector3.Z : 0.0);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			UKismetSystemLibrary.D_DrawDebugString(world, textLocation, defaultInterpolatedStringHandler.ToStringAndClear(), null, new FLinearColor?(WuWaGoNormalGameMode.DebugColorGreen), 0f);
		}

		// Token: 0x0602FDB5 RID: 196021 RVA: 0x00B17298 File Offset: 0x00B15498
		private void DrawCurProcessUnitArrow(WuWaGoGameData gameData)
		{
			WuWaGoRoleController curProcessUnit = this.RoundManager.CurProcessUnit;
			if (curProcessUnit == null)
			{
				return;
			}
			Vector worldPositionByCoordinate = WuWaGoUtil.GetWorldPositionByCoordinate(gameData.OriginTransform, curProcessUnit.BaseRole.Coordinate, null);
			worldPositionByCoordinate.Z += 300.0;
			Vector vector = Vector.Create();
			vector.DeepCopy(worldPositionByCoordinate);
			vector.Z -= 50.0;
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, worldPositionByCoordinate.ToUeVector(false), vector.ToUeVector(false), 100f, WuWaGoNormalGameMode.DebugColorGreen, 1f, 25f);
		}

		// Token: 0x0602FDB6 RID: 196022 RVA: 0x00B17334 File Offset: 0x00B15534
		private void DrawAllGridLinks(WuWaGoGameData gameData)
		{
			foreach (KeyValuePair<string, WuWaGoGrid> keyValuePair in gameData.Girds)
			{
				string text;
				WuWaGoGrid wuWaGoGrid;
				keyValuePair.Deconstruct(out text, out wuWaGoGrid);
				WuWaGoGrid wuWaGoGrid2 = wuWaGoGrid;
				this.DrawGridLinkDebug(gameData, wuWaGoGrid2, wuWaGoGrid2.LinkedDirections, WuWaGoNormalGameMode.DebugColorGreen);
			}
		}

		// Token: 0x0602FDB7 RID: 196023 RVA: 0x00B173A4 File Offset: 0x00B155A4
		private void DrawGearTrackLinks(WuWaGoGameData gameData)
		{
			foreach (WuWaGoGrid wuWaGoGrid in this.CollectGearTrackGrids(gameData))
			{
				this.DrawGridLinkDebug(gameData, wuWaGoGrid, wuWaGoGrid.GearLinkDirections, WuWaGoNormalGameMode.DebugColorGear);
			}
		}

		// Token: 0x0602FDB8 RID: 196024 RVA: 0x00B17400 File Offset: 0x00B15600
		private IReadOnlyList<WuWaGoGrid> CollectGearTrackGrids(WuWaGoGameData gameData)
		{
			this.DebugGearGridKeys.Clear();
			List<WuWaGoGrid> list = new List<WuWaGoGrid>();
			foreach (WuWaGoGameplayEntityBase wuWaGoGameplayEntityBase in gameData.GetGameplayEntitiesByType(EWuWaGoEntityType.Gear))
			{
				foreach (int pbDataId in (wuWaGoGameplayEntityBase as WuWaGoGearTrapEntity).TrackEntityIds)
				{
					WuWaGoGrid gameplayGridByPbDataId = gameData.GetGameplayGridByPbDataId(pbDataId);
					if (gameplayGridByPbDataId != null && gameplayGridByPbDataId.HasGearPath)
					{
						string coordinateKeyByVector = WuWaGoUtil.GetCoordinateKeyByVector(gameplayGridByPbDataId.Coordinate);
						if (this.DebugGearGridKeys.Add(coordinateKeyByVector))
						{
							list.Add(gameplayGridByPbDataId);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0602FDB9 RID: 196025 RVA: 0x00B174D4 File Offset: 0x00B156D4
		private void DrawGridLinkDebug(WuWaGoGameData gameData, WuWaGoGrid grid, IReadOnlyList<Vector> directions, FLinearColor color)
		{
			IWallFrame wallFrame = (grid.GridShape == EGridShape.Vertical) ? grid.WallFrame : null;
			if (grid.GridShape == EGridShape.Vertical && wallFrame == null)
			{
				return;
			}
			Vector worldPositionByCoordinate = WuWaGoUtil.GetWorldPositionByCoordinate(gameData.OriginTransform, grid.Coordinate, null);
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, worldPositionByCoordinate.ToUeVector(false), 15f, 12, new FLinearColor?(color), 1f, 0f);
			UObject world = GlobalData.World;
			FVectorDouble textLocation = worldPositionByCoordinate.ToUeVector(false);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted<double>(grid.Coordinate.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(grid.Coordinate.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(grid.Coordinate.Z);
			UKismetSystemLibrary.D_DrawDebugString(world, textLocation, defaultInterpolatedStringHandler.ToStringAndClear(), null, new FLinearColor?(color), 0f);
			Quat rotation = gameData.OriginTransform.GetRotation();
			rotation.Multiply(grid.Rotator.Quaternion(null), this.DebugScratchQuat);
			this.DebugScratchQuat.RotateVector(WuWaGoNormalGameMode.DebugLocalUpStep, this.DebugScratchLocalUp);
			worldPositionByCoordinate.Addition(this.DebugScratchLocalUp, this.DebugScratchArrowOrigin);
			int singleGridSize = WuWaGoGlobal.Setting.SingleGridSize;
			int num = (wallFrame != null) ? wallFrame.WallNormalX : 0;
			int num2 = (wallFrame != null) ? wallFrame.WallNormalY : 0;
			foreach (Vector vector in directions)
			{
				double num3 = (wallFrame != null) ? (vector.X * (double)num + vector.Y * (double)num2) : 0.0;
				double num4 = vector.X - num3 * (double)num;
				double num5 = vector.Y - num3 * (double)num2;
				double num6 = (grid.GridShape == EGridShape.Horizontal) ? 0.0 : vector.Z;
				double num7 = Math.Max(Math.Max(Math.Abs(num4), Math.Abs(num5)), Math.Abs(num6));
				if (num7 != 0.0)
				{
					double num8 = 0.5 / num7;
					this.DebugScratchLocalHalfDelta.Set(num4 * num8, num5 * num8, num6 * num8);
					this.DebugScratchLocalHalfDelta.MultiplyEqual((double)singleGridSize);
					rotation.RotateVector(this.DebugScratchLocalHalfDelta, this.DebugScratchHalfDeltaWorld);
					this.DebugScratchArrowOrigin.Addition(this.DebugScratchHalfDeltaWorld, this.DebugScratchArrowHalfEnd);
					UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, this.DebugScratchArrowOrigin.ToUeVector(false), this.DebugScratchArrowHalfEnd.ToUeVector(false), 100f, color, 1f, 5f);
				}
			}
		}

		// Token: 0x04019CEF RID: 105711
		private readonly Vector FollowCameraTargetScratch = Vector.Create();

		// Token: 0x04019CF0 RID: 105712
		private const bool ENABLE_GRID_LINK_DEBUG = true;

		// Token: 0x04019CF1 RID: 105713
		private const bool ENABLE_GEAR_TRACK_DEBUG = false;

		// Token: 0x04019CF2 RID: 105714
		[StaticVariableRuleIgnore]
		private static readonly Vector DebugLocalUpStep = Vector.Create(0.0, 0.0, 20.0);

		// Token: 0x04019CF3 RID: 105715
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor DebugColorGreen = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x04019CF4 RID: 105716
		[StaticVariableRuleIgnore]
		private static readonly FLinearColor DebugColorGear = new FLinearColor(1f, 0.4f, 0f, 1f);

		// Token: 0x04019CF5 RID: 105717
		private readonly HashSet<string> DebugGearGridKeys = new HashSet<string>();

		// Token: 0x04019CF6 RID: 105718
		private readonly Vector DebugScratchArrowOrigin = Vector.Create();

		// Token: 0x04019CF7 RID: 105719
		private readonly Vector DebugScratchLocalUp = Vector.Create();

		// Token: 0x04019CF8 RID: 105720
		private readonly Vector DebugScratchLocalHalfDelta = Vector.Create();

		// Token: 0x04019CF9 RID: 105721
		private readonly Vector DebugScratchHalfDeltaWorld = Vector.Create();

		// Token: 0x04019CFA RID: 105722
		private readonly Vector DebugScratchArrowHalfEnd = Vector.Create();

		// Token: 0x04019CFB RID: 105723
		private readonly Quat DebugScratchQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
