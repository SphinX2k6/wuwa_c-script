using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Entity.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Utils.LockingHandler;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x0200642A RID: 25642
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraCollision
	{
		// Token: 0x0603E3D1 RID: 254929 RVA: 0x0121415F File Offset: 0x0121235F
		public void Init(FightCameraLogicComponent camera)
		{
			this.Camera = camera;
		}

		// Token: 0x0603E3D2 RID: 254930 RVA: 0x01214168 File Offset: 0x01212368
		public void InitTraceElements()
		{
			this.CameraSphereTrace = new UTraceSphereElement();
			this.CameraSphereTrace.bIsSingle = false;
			this.CameraSphereTrace.bTraceComplex = false;
			this.CameraSphereTrace.bIgnoreSelf = true;
			this.CameraSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.CameraRightSphereTrace = new UTraceSphereElement();
			this.CameraRightSphereTrace.bIsSingle = true;
			this.CameraRightSphereTrace.bTraceComplex = false;
			this.CameraRightSphereTrace.bIgnoreSelf = true;
			this.CameraRightSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.CameraLeftSphereTrace = new UTraceSphereElement();
			this.CameraLeftSphereTrace.bIsSingle = true;
			this.CameraLeftSphereTrace.bTraceComplex = false;
			this.CameraLeftSphereTrace.bIgnoreSelf = true;
			this.CameraLeftSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.CameraNpcSphereTrace = new UTraceSphereElement();
			this.CameraNpcSphereTrace.bIsSingle = false;
			this.CameraNpcSphereTrace.bTraceComplex = false;
			this.CameraNpcSphereTrace.bIgnoreSelf = true;
			this.CameraNpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			this.CameraNpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			this.CameraNpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
			this.CameraPlayerSphereTrace = new UTraceSphereElement();
			this.CameraPlayerSphereTrace.bIsSingle = false;
			this.CameraPlayerSphereTrace.bTraceComplex = false;
			this.CameraPlayerSphereTrace.bIgnoreSelf = true;
			this.CameraPlayerSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			this.CameraPlayerSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			this.CameraPlayerSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
			this.CameraInPlaceSphereTrace = new UTraceSphereElement();
			this.CameraInPlaceSphereTrace.bIsSingle = true;
			this.CameraInPlaceSphereTrace.bTraceComplex = false;
			this.CameraInPlaceSphereTrace.bIgnoreSelf = true;
			this.CameraInPlaceSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
		}

		// Token: 0x0603E3D3 RID: 254931 RVA: 0x01214330 File Offset: 0x01212530
		public void SetDrawDebugEnable(bool isEnable)
		{
			if (isEnable)
			{
				this.CameraSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				this.CameraSphereTrace.DrawTime = 5f;
				this.CameraRightSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				this.CameraRightSphereTrace.DrawTime = 5f;
				this.CameraLeftSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				this.CameraLeftSphereTrace.DrawTime = 5f;
				this.CameraNpcSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				this.CameraNpcSphereTrace.DrawTime = 5f;
				this.CameraPlayerSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
				this.CameraPlayerSphereTrace.DrawTime = 5f;
				this.CameraInPlaceSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.ForOneFrame);
				this.CameraInPlaceSphereTrace.DrawTime = 5f;
				return;
			}
			this.CameraSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			this.CameraSphereTrace.DrawTime = 0f;
			this.CameraRightSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			this.CameraRightSphereTrace.DrawTime = 0f;
			this.CameraLeftSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			this.CameraLeftSphereTrace.DrawTime = 0f;
			this.CameraNpcSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			this.CameraNpcSphereTrace.DrawTime = 0f;
			this.CameraPlayerSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			this.CameraPlayerSphereTrace.DrawTime = 0f;
			this.CameraInPlaceSphereTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
			this.CameraInPlaceSphereTrace.DrawTime = 0f;
		}

		// Token: 0x0603E3D4 RID: 254932 RVA: 0x01214494 File Offset: 0x01212694
		public void SetCharacter(TsBaseCharacter character)
		{
			this.Character = character;
			this.CameraSphereTrace.ActorsToIgnore.Add(character);
			this.CameraRightSphereTrace.ActorsToIgnore.Add(character);
			this.CameraLeftSphereTrace.ActorsToIgnore.Add(character);
			this.CameraNpcSphereTrace.ActorsToIgnore.Add(character);
			this.CameraPlayerSphereTrace.ActorsToIgnore.Add(character);
			this.CameraInPlaceSphereTrace.ActorsToIgnore.Add(character);
			CharacterSwimComponent charSwimComp;
			if (character == null)
			{
				charSwimComp = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
				charSwimComp = ((characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterSwimComponent>() : null);
			}
			this.CharSwimComp = charSwimComp;
		}

		// Token: 0x0603E3D5 RID: 254933 RVA: 0x01214531 File Offset: 0x01212731
		public void SetCameraConfig(float collisionProbeSize, float minFloorZnOffset)
		{
			this.CameraCollisionProbeSizeSquared = collisionProbeSize * collisionProbeSize * 4f;
			this.CameraMinFloorZnOffset = minFloorZnOffset;
		}

		// Token: 0x0603E3D6 RID: 254934 RVA: 0x0121454C File Offset: 0x0121274C
		public void Clear()
		{
			if (this.CameraSphereTrace != null)
			{
				this.CameraSphereTrace.Dispose();
				this.CameraSphereTrace = null;
			}
			if (this.CameraLeftSphereTrace != null)
			{
				this.CameraLeftSphereTrace.Dispose();
				this.CameraLeftSphereTrace = null;
			}
			if (this.CameraRightSphereTrace != null)
			{
				this.CameraRightSphereTrace.Dispose();
				this.CameraRightSphereTrace = null;
			}
			if (this.CameraNpcSphereTrace != null)
			{
				this.CameraNpcSphereTrace.Dispose();
				this.CameraNpcSphereTrace = null;
			}
			if (this.CameraPlayerSphereTrace != null)
			{
				this.CameraPlayerSphereTrace.Dispose();
				this.CameraPlayerSphereTrace = null;
			}
			if (this.CameraInPlaceSphereTrace != null)
			{
				this.CameraInPlaceSphereTrace.Dispose();
				this.CameraInPlaceSphereTrace = null;
			}
			this.IsMiddleCollision = false;
			this.IsInPlaceCollision = false;
			this.IsCameraFloatOnWater = false;
			this.IsLeftCollision = false;
			this.IsRightCollision = false;
			this.DitheredNpcSet.Clear();
			this.OcclusionDitherDataMap.Clear();
			this.LastFrameActiveDitherActors.Clear();
			this.WaitRemoveActorList.Clear();
		}

		// Token: 0x0603E3D7 RID: 254935 RVA: 0x01214644 File Offset: 0x01212844
		public void ResetBlendData()
		{
			this.CurrentBlendState = ECollisionBlendState.None;
		}

		// Token: 0x0603E3D8 RID: 254936 RVA: 0x0121464D File Offset: 0x0121284D
		public Vector CheckCollision(Vector armLocation, Vector cameraLocation, float deltaTime)
		{
			this.CameraTargetLocation.DeepCopy(cameraLocation);
			if (this.CollisionMode == ECameraCollisionMode.Default)
			{
				this.DefaultCheckWorkFlow(armLocation, cameraLocation, deltaTime);
			}
			else if (this.CollisionMode == ECameraCollisionMode.InPlaceProbe)
			{
				this.InPlaceProbeCheckWorkFlow(armLocation, cameraLocation, deltaTime);
			}
			return this.CameraTargetLocation;
		}

		// Token: 0x0603E3D9 RID: 254937 RVA: 0x01214688 File Offset: 0x01212888
		private void DefaultCheckWorkFlow(Vector armLocation, Vector cameraLocation, float deltaTime)
		{
			if (this.IsCameraCollisionEnable() && this.GmCameraCollisionEnable)
			{
				this.SetCollisionSize();
				this.CheckMiddleCollision(armLocation, cameraLocation);
				this.CheckTwoSideCollision(armLocation, cameraLocation);
				this.CheckFloatOnWater();
				this.UpdateBlendState(armLocation, cameraLocation);
				this.UpdateBlendLocation(armLocation, cameraLocation, deltaTime);
			}
			this.ResetAllOcclusionDither();
			this.UpdateNpcDither();
			this.TraceElementBetweenCameraAndPlayer(armLocation);
			bool needXRay = this.IsHitSomethingBetweenCameraAndPlayer && this.IsPlayerBlueStateEnable(this.CameraPlayerSphereTrace.HitResult);
			this.UpdatePlayerXRayState(needXRay);
			this.UpdateOcclusionDither();
			this.CalculateAllOcclusionDitherValue(deltaTime);
			this.SetAllDitherValue();
		}

		// Token: 0x0603E3DA RID: 254938 RVA: 0x0121471C File Offset: 0x0121291C
		private void InPlaceProbeCheckWorkFlow(Vector armLocation, Vector cameraLocation, float deltaTime)
		{
			if (this.IsCameraCollisionEnable() && this.GmCameraCollisionEnable)
			{
				this.SetCollisionSize();
				this.CheckInPlaceCollision(cameraLocation);
				this.IsCameraFloatOnWater = false;
				if (this.IsInPlaceCollision)
				{
					this.CheckMiddleCollision(armLocation, cameraLocation);
				}
				this.UpdateInPlaceBlendState(armLocation, cameraLocation);
				this.UpdateBlendLocation(armLocation, cameraLocation, deltaTime);
			}
			this.ResetAllOcclusionDither();
			this.UpdateNpcDither();
			this.UpdatePlayerXRayState(true);
			this.CalculateAllOcclusionDitherValue(deltaTime);
			this.SetAllDitherValue();
		}

		// Token: 0x0603E3DB RID: 254939 RVA: 0x01214790 File Offset: 0x01212990
		private void CheckMiddleCollision(Vector armLocation, Vector cameraLocation)
		{
			this.GravityDirect.DeepCopy(this.Camera.GravityDirect);
			this.StartLocation.DeepCopy(armLocation);
			this.EndLocation.DeepCopy(cameraLocation);
			this.CameraSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraSphereTrace.Radius = this.Camera.CurrentCollisionSize;
			if (this.CharSwimComp != null)
			{
				double znInGravityForDirect = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, this.StartLocation);
				Vector tmpVector = this.TmpVector;
				Vector vector = tmpVector;
				FVectorDouble waterLocation = this.CharSwimComp.GetWaterLocation();
				vector.DeepCopy(waterLocation);
				GravityUtils.Instance.AddZnInGravityForDirect(this.GravityDirect, tmpVector, this.Camera.CollisionAdditionalHeightInWater);
				double znInGravityForDirect2 = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, tmpVector);
				this.StartLocation.Z = ((znInGravityForDirect > znInGravityForDirect2) ? this.StartLocation.Z : tmpVector.Z);
			}
			double znInGravityForDirect3 = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, this.StartLocation);
			Vector tmpVector2 = this.TmpVector;
			tmpVector2.DeepCopy(this.Camera.Character.CharacterActorComponent.FloorLocation);
			GravityUtils.Instance.AddZnInGravityForDirect(this.GravityDirect, tmpVector2, this.CameraMinFloorZnOffset);
			double znInGravityForDirect4 = GravityUtils.Instance.GetZnInGravityForDirect(this.GravityDirect, tmpVector2);
			this.StartLocation.Z = ((znInGravityForDirect3 > znInGravityForDirect4) ? this.StartLocation.Z : tmpVector2.Z);
			TraceElementCommon.Instance.SetStartLocation(this.CameraSphereTrace, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraSphereTrace, this.EndLocation);
			this.IsMiddleCollision = false;
			if (TraceElementCommon.Instance.SphereTrace(this.CameraSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera"))
			{
				this.MiddleCollisionHitIndex = this.GetValidHitIndex(this.StartLocation, this.EndLocation, this.CameraSphereTrace.HitResult);
				if (this.MiddleCollisionHitIndex >= 0)
				{
					TraceElementCommon.Instance.GetHitLocation(this.CameraSphereTrace.HitResult, this.MiddleCollisionHitIndex, this.CameraTargetLocation);
					this.IsMiddleCollision = true;
				}
			}
		}

		// Token: 0x0603E3DC RID: 254940 RVA: 0x012149A8 File Offset: 0x01212BA8
		private void CheckFloatOnWater()
		{
			this.IsCameraFloatOnWater = false;
			if (!this.IsMiddleCollision)
			{
				return;
			}
			UKuroHitResult hitResult = this.CameraSphereTrace.HitResult;
			TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr = (hitResult != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(hitResult.Components.Get(this.MiddleCollisionHitIndex)) : null;
			UKuroHitResult hitResult2 = this.CameraSphereTrace.HitResult;
			TArray<int> tarray = (hitResult2 != null) ? hitResult2.ItemArray : null;
			int instanceIndex = (tarray != null && this.MiddleCollisionHitIndex < tarray.Num()) ? tarray.Get(this.MiddleCollisionHitIndex) : 0;
			if (tweakObjectPtr != null && tweakObjectPtr.GetValueOrDefault().IsValid(false, false))
			{
				TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr2 = tweakObjectPtr;
				if (!(UKuroCollisionLibrary.GetCollisionResponseToChannel((tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null, KuroCollisionChannel.Water, instanceIndex) != ECollisionResponse.ECR_Block))
				{
					this.IsCameraFloatOnWater = true;
					return;
				}
			}
		}

		// Token: 0x0603E3DD RID: 254941 RVA: 0x01214A8C File Offset: 0x01212C8C
		private void CheckTwoSideCollision(Vector armLocation, Vector cameraLocation)
		{
			if (!this.IsMiddleCollision)
			{
				return;
			}
			armLocation.Subtraction(cameraLocation, this.ArmDirection);
			this.ArmDirection.Normalize(9.99999993922529E-09);
			double num = (double)(this.Camera.CheckWidth + this.CurrentCollisionDifferenceSize) / Vector.Dist(cameraLocation, this.CameraTargetLocation);
			double inB = Vector.Dist(cameraLocation, armLocation) * num;
			this.ArmDirection.CrossProduct(this.GravityDirect, this.OffsetVector);
			this.OffsetVector.MultiplyEqual(inB);
			armLocation.Addition(this.OffsetVector, this.StartLocation);
			UKuroHitResult hitResult = this.CameraRightSphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			this.CameraRightSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraRightSphereTrace.Radius = this.Camera.CheckCollisionProbeSize;
			this.StartLocation.DeepCopy(this.ModifyLocation(this.StartLocation, this.ArmDirection, -this.CameraRightSphereTrace.Radius));
			this.EndLocation.DeepCopy(cameraLocation);
			TraceElementCommon.Instance.SetStartLocation(this.CameraRightSphereTrace, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraRightSphereTrace, this.EndLocation);
			this.IsRightCollision = TraceElementCommon.Instance.SphereTrace(this.CameraRightSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera");
			if (!this.IsRightCollision)
			{
				TraceElementCommon.Instance.SetStartLocation(this.CameraRightSphereTrace, this.EndLocation);
				TraceElementCommon.Instance.SetEndLocation(this.CameraRightSphereTrace, this.StartLocation);
				this.IsRightCollision = TraceElementCommon.Instance.SphereTrace(this.CameraRightSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera");
			}
			this.OffsetVector.UnaryNegation(this.OffsetVector);
			armLocation.Addition(this.OffsetVector, this.StartLocation);
			UKuroHitResult hitResult2 = this.CameraLeftSphereTrace.HitResult;
			if (hitResult2 != null)
			{
				hitResult2.Clear();
			}
			this.CameraLeftSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraLeftSphereTrace.Radius = this.Camera.CheckCollisionProbeSize;
			this.StartLocation.DeepCopy(this.ModifyLocation(this.StartLocation, this.ArmDirection, -this.CameraLeftSphereTrace.Radius));
			TraceElementCommon.Instance.SetStartLocation(this.CameraLeftSphereTrace, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraLeftSphereTrace, this.EndLocation);
			this.IsLeftCollision = TraceElementCommon.Instance.SphereTrace(this.CameraLeftSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera");
			if (!this.IsLeftCollision)
			{
				TraceElementCommon.Instance.SetStartLocation(this.CameraLeftSphereTrace, this.EndLocation);
				TraceElementCommon.Instance.SetEndLocation(this.CameraLeftSphereTrace, this.StartLocation);
				this.IsLeftCollision = TraceElementCommon.Instance.SphereTrace(this.CameraLeftSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera");
			}
		}

		// Token: 0x0603E3DE RID: 254942 RVA: 0x01214D50 File Offset: 0x01212F50
		private void UpdateBlendState(Vector armLocation, Vector cameraLocation)
		{
			if (!this.IsOpenBlend)
			{
				this.CurrentBlendState = (this.IsMiddleCollision ? ECollisionBlendState.Loop : ECollisionBlendState.None);
				return;
			}
			if (this.SpecialUpdateBlend())
			{
				return;
			}
			switch (this.CurrentBlendState)
			{
			case ECollisionBlendState.None:
				if (this.IsMiddleCollision && (this.IsLeftCollision || this.IsRightCollision))
				{
					armLocation.Subtraction(this.Camera.CameraLocation, this.CurrentArmVector);
					armLocation.Subtraction(this.CameraTargetLocation, this.TargetArmVector);
					this.CurrentArmLength = (float)this.CurrentArmVector.Size();
					this.TargetArmLength = (float)this.TargetArmVector.Size();
					this.CurrentBlendState = ECollisionBlendState.BlendIn;
					return;
				}
				break;
			case ECollisionBlendState.BlendIn:
				if (this.IsMiddleCollision && this.IsLeftCollision && this.IsRightCollision)
				{
					this.CurrentBlendState = ECollisionBlendState.Loop;
					return;
				}
				if (this.IsMiddleCollision && (this.IsLeftCollision || this.IsRightCollision))
				{
					armLocation.Subtraction(this.Camera.CameraLocation, this.CurrentArmVector);
					armLocation.Subtraction(this.CameraTargetLocation, this.TargetArmVector);
					this.CurrentArmLength = (float)this.CurrentArmVector.Size();
					this.TargetArmLength = (float)this.TargetArmVector.Size();
					if (this.IsResetCamera(armLocation, cameraLocation, this.CurrentArmLength))
					{
						this.ResetBlendData();
						return;
					}
					if (this.CurrentArmLength <= this.TargetArmLength)
					{
						this.CurrentBlendState = ECollisionBlendState.Loop;
						return;
					}
				}
				else
				{
					if (this.IsMiddleCollision)
					{
						this.CurrentBlendState = ECollisionBlendState.BlendIn;
						return;
					}
					this.CurrentBlendState = ECollisionBlendState.BlendOut;
					return;
				}
				break;
			case ECollisionBlendState.Loop:
				if (!this.IsMiddleCollision && !this.IsLeftCollision && !this.IsRightCollision)
				{
					armLocation.Subtraction(this.Camera.CameraLocation, this.CurrentArmVector);
					armLocation.Subtraction(cameraLocation, this.TargetArmVector);
					this.CurrentArmLength = (float)this.CurrentArmVector.Size();
					this.TargetArmLength = (float)this.TargetArmVector.Size();
					this.CurrentBlendState = ECollisionBlendState.BlendOut;
				}
				break;
			case ECollisionBlendState.BlendOut:
				if (this.IsMiddleCollision && (this.IsLeftCollision || this.IsRightCollision))
				{
					this.CurrentBlendState = ECollisionBlendState.BlendIn;
					return;
				}
				armLocation.Subtraction(this.Camera.CameraLocation, this.CurrentArmVector);
				armLocation.Subtraction(cameraLocation, this.TargetArmVector);
				this.CurrentArmLength = (float)this.CurrentArmVector.Size();
				this.TargetArmLength = (float)this.TargetArmVector.Size();
				if (this.IsResetCamera(armLocation, cameraLocation, this.CurrentArmLength))
				{
					this.ResetBlendData();
					return;
				}
				if (this.CurrentArmLength >= this.TargetArmLength || this.CurrentArmLength >= this.Camera.MaxArmLength)
				{
					this.CurrentBlendState = ECollisionBlendState.None;
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0603E3DF RID: 254943 RVA: 0x01214FFC File Offset: 0x012131FC
		private void UpdateBlendLocation(Vector armLocation, Vector cameraLocation, float deltaTime)
		{
			if (this.IsCameraFloatOnWater)
			{
				return;
			}
			switch (this.CurrentBlendState)
			{
			case ECollisionBlendState.None:
				this.CameraTargetLocation.DeepCopy(cameraLocation);
				break;
			case ECollisionBlendState.BlendIn:
			{
				float num = this.CurrentArmLength - this.Camera.InSpeed * deltaTime;
				num = Math.Max(this.TargetArmLength, num);
				cameraLocation.Subtraction(armLocation, this.ArmDirection);
				this.ArmDirection.Normalize(9.99999993922529E-09);
				this.ArmDirection.Multiply((double)num, this.NewArmVector);
				armLocation.Addition(this.NewArmVector, this.CameraTargetLocation);
				return;
			}
			case ECollisionBlendState.Loop:
				break;
			case ECollisionBlendState.BlendOut:
			{
				float num2 = this.CurrentArmLength + this.Camera.OutSpeed * deltaTime;
				num2 = Math.Min(this.TargetArmLength, num2);
				num2 = Math.Min(this.Camera.MaxArmLength, num2);
				cameraLocation.Subtraction(armLocation, this.ArmDirection);
				this.ArmDirection.Normalize(9.99999993922529E-09);
				this.ArmDirection.Multiply((double)num2, this.NewArmVector);
				armLocation.Addition(this.NewArmVector, this.CameraTargetLocation);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0603E3E0 RID: 254944 RVA: 0x01215128 File Offset: 0x01213328
		private void CheckInPlaceCollision(Vector cameraLocation)
		{
			this.IsInPlaceCollision = false;
			UKuroHitResult hitResult = this.CameraInPlaceSphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			this.CameraInPlaceSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraInPlaceSphereTrace.Radius = this.Camera.CurrentCollisionSize;
			TraceElementCommon.Instance.SetStartLocation(this.CameraInPlaceSphereTrace, cameraLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraInPlaceSphereTrace, cameraLocation);
			this.IsInPlaceCollision = TraceElementCommon.Instance.SphereTrace(this.CameraInPlaceSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera_InPlace");
		}

		// Token: 0x0603E3E1 RID: 254945 RVA: 0x012151B8 File Offset: 0x012133B8
		private void UpdateInPlaceBlendState(Vector armLocation, Vector cameraLocation)
		{
			if (this.IsInPlaceCollision && this.IsMiddleCollision)
			{
				this.CurrentBlendState = ECollisionBlendState.Loop;
				return;
			}
			ECollisionBlendState currentBlendState = this.CurrentBlendState;
			if (currentBlendState != ECollisionBlendState.None && currentBlendState - ECollisionBlendState.BlendIn <= 2)
			{
				armLocation.Subtraction(this.Camera.CameraLocation, this.CurrentArmVector);
				armLocation.Subtraction(cameraLocation, this.TargetArmVector);
				this.CurrentArmLength = (float)this.CurrentArmVector.Size();
				this.TargetArmLength = (float)this.TargetArmVector.Size();
				if (this.CurrentBlendState == ECollisionBlendState.BlendOut && (this.CurrentArmLength >= this.TargetArmLength || this.CurrentArmLength >= this.Camera.MaxArmLength))
				{
					this.CurrentBlendState = ECollisionBlendState.None;
					return;
				}
				this.CurrentBlendState = ECollisionBlendState.BlendOut;
			}
		}

		// Token: 0x0603E3E2 RID: 254946 RVA: 0x01215278 File Offset: 0x01213478
		private void SetDitherGroupEffect(ABaseCharacter actor, float ditherValue)
		{
			Entity entityNoBlueprint = actor.GetEntityNoBlueprint();
			long? num;
			if (entityNoBlueprint == null)
			{
				num = null;
			}
			else
			{
				CreatureDataComponent creatureDataComponent = entityNoBlueprint.CheckGetComponent<CreatureDataComponent>();
				num = ((creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
			}
			long? num2 = num;
			if (num2 != null)
			{
				long valueOrDefault = num2.GetValueOrDefault();
				if (valueOrDefault != 0L)
				{
					IReadOnlyList<long> set = this.Camera.CameraModel.DitherEntityGroups.GetSet(valueOrDefault);
					if (set == null || set.Count == 0)
					{
						return;
					}
					foreach (long creatureDataId in set)
					{
						EntityHandle entity = CreatureModel.Instance.GetEntity(creatureDataId);
						if (entity != null && entity.Valid)
						{
							WorldEntity entity2 = entity.Entity;
							if (entity2 != null && entity2.Valid)
							{
								BaseActorComponent baseActorComponent = entity.Entity.CheckGetComponent<BaseActorComponent>();
								ABaseCharacter abaseCharacter = ((baseActorComponent != null) ? baseActorComponent.Owner : null) as ABaseCharacter;
								if (abaseCharacter != null && CameraCollision.IsCharacterRenderingType(abaseCharacter))
								{
									abaseCharacter.SetDitherEffect(ditherValue, ECharacterDitherType.Fight);
								}
							}
						}
					}
					return;
				}
			}
		}

		// Token: 0x0603E3E3 RID: 254947 RVA: 0x0121539C File Offset: 0x0121359C
		private void UpdateNpcDither()
		{
			if (!this.IsCameraNpcDitherEnable() || !this.GmNpcDitherEnable)
			{
				if (this.DitheredNpcSet.Count > 0)
				{
					foreach (ABaseCharacter abaseCharacter in this.DitheredNpcSet)
					{
						if (abaseCharacter.IsValid())
						{
							this.SetDitherEffect(abaseCharacter, 1f, ECameraDitherType.CameraDither);
						}
					}
					this.DitheredNpcSet.Clear();
				}
				return;
			}
			this.UpdateCameraCollisionRadius();
			this.UpdateCameraCollisionLocation();
			UKuroHitResult hitResult = this.CameraNpcSphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			this.CameraNpcSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraNpcSphereTrace.Radius = this.CameraCollisionRadius;
			TraceElementCommon.Instance.SetStartLocation(this.CameraNpcSphereTrace, this.CameraTargetLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraNpcSphereTrace, this.CameraCollisionLocation);
			bool flag = TraceElementCommon.Instance.SphereTrace(this.CameraNpcSphereTrace, "FightCameraLogicComponent_CheckCollision_Npc");
			int hitCount = this.CameraNpcSphereTrace.HitResult.GetHitCount();
			if (flag)
			{
				this.UpdateDitheredNpcDistance(this.CameraNpcSphereTrace.HitResult);
				foreach (KeyValuePair<ABaseCharacter, float> keyValuePair in this.DitheredNpcDistanceMap)
				{
					ABaseCharacter key = keyValuePair.Key;
					float value = keyValuePair.Value;
					if (this.IsCharacterIgnoreNpcDither(key))
					{
						this.SetDitherEffect(key, 1f, ECameraDitherType.CameraDither);
					}
					else
					{
						float npcDitherValue = this.GetNpcDitherValue(key, value);
						this.SetDitherEffect(key, npcDitherValue, ECameraDitherType.CameraDither);
						int num = this.DitheredNpcSet.IndexOf(key);
						if (num != -1)
						{
							this.DitheredNpcSet.RemoveAt(num);
						}
						this.DitheredNpcSet.Add(key);
					}
				}
			}
			for (int i = 0; i < this.DitheredNpcSet.Count - hitCount; i++)
			{
				ABaseCharacter actor = this.DitheredNpcSet[0];
				if (CameraCollision.IsCharacterRenderingType(actor))
				{
					this.SetDitherEffect(actor, 1f, ECameraDitherType.CameraDither);
				}
				this.DitheredNpcSet.RemoveAt(0);
			}
		}

		// Token: 0x0603E3E4 RID: 254948 RVA: 0x012155D4 File Offset: 0x012137D4
		private void UpdatePlayerXRayState(bool needXRay)
		{
			if (!this.IsPlayerXRayEnable)
			{
				TsBaseCharacter character = this.Character;
				if (character == null)
				{
					return;
				}
				CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					return;
				}
				characterActorComponent.SetActorXRayState(false);
				return;
			}
			else
			{
				TsBaseCharacter character2 = this.Character;
				if (character2 == null)
				{
					return;
				}
				CharacterActorComponent characterActorComponent2 = character2.CharacterActorComponent;
				if (characterActorComponent2 == null)
				{
					return;
				}
				characterActorComponent2.SetActorXRayState(needXRay);
				return;
			}
		}

		// Token: 0x0603E3E5 RID: 254949 RVA: 0x01215620 File Offset: 0x01213820
		public void ResetAllNpcDither()
		{
			foreach (ABaseCharacter abaseCharacter in this.DitheredNpcSet)
			{
				if (abaseCharacter.IsValid())
				{
					this.SetDitherEffect(abaseCharacter, 1f, ECameraDitherType.CameraDither);
				}
			}
			this.DitheredNpcSet.Clear();
		}

		// Token: 0x0603E3E6 RID: 254950 RVA: 0x0121568C File Offset: 0x0121388C
		private unsafe void SetCollisionSize()
		{
			if (this.Camera.NearCollisionProbeSize <= this.Camera.CollisionProbeSize)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Character;
				ELogAuthor author = ELogAuthor.LJM;
				string message = "CollisionSize数据错误:NearCollisionProbeSize <= this.CollisionProbeSize";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CollisionProbeSize", this.Camera.CollisionProbeSize);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NearCollisionProbeSize", this.Camera.NearCollisionProbeSize);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.CurrentCollisionDifferenceSize = this.Camera.NearCollisionProbeSize - this.Camera.CollisionProbeSize;
			float num = MathUtils.Instance.Clamp(this.Camera.CameraInputController.InputSpeedPercentage / this.Camera.CollisionSizePercentage, 0f, 1f);
			this.Camera.CurrentCollisionSize = this.CurrentCollisionDifferenceSize * num + this.Camera.CollisionProbeSize;
			this.Camera.CurrentCollisionSize = MathUtils.Instance.Clamp(this.Camera.CurrentCollisionSize, this.Camera.CurrentCollisionSize, this.Camera.NearCollisionProbeSize);
			if (this.CurrentBlendState != ECollisionBlendState.None)
			{
				this.Camera.CurrentCollisionSize = this.Camera.NearCollisionProbeSize;
			}
		}

		// Token: 0x0603E3E7 RID: 254951 RVA: 0x012157E4 File Offset: 0x012139E4
		private Vector ModifyLocation(Vector inLocation, Vector direction, float length)
		{
			direction.Multiply((double)length, this.TmpVector);
			inLocation.Addition(this.TmpVector, this.TmpVector);
			return this.TmpVector;
		}

		// Token: 0x0603E3E8 RID: 254952 RVA: 0x01215810 File Offset: 0x01213A10
		private bool SpecialUpdateBlend()
		{
			if (this.Camera.CameraDialogueController.State != EBlendState.None)
			{
				this.CurrentBlendState = (this.IsMiddleCollision ? ECollisionBlendState.Loop : ECollisionBlendState.None);
				return true;
			}
			if (GameModeModel.Instance.IsSilentLogin)
			{
				this.CurrentBlendState = ECollisionBlendState.None;
				return true;
			}
			if (this.BlendPauseType == ECameraBlendPauseType.Forever)
			{
				this.CurrentBlendState = (this.IsMiddleCollision ? ECollisionBlendState.Loop : ECollisionBlendState.None);
				return true;
			}
			if (this.BlendPauseType == ECameraBlendPauseType.ForOneFrame)
			{
				this.BlendPauseType = ECameraBlendPauseType.None;
				this.CurrentBlendState = (this.IsMiddleCollision ? ECollisionBlendState.Loop : ECollisionBlendState.None);
				return true;
			}
			return false;
		}

		// Token: 0x0603E3E9 RID: 254953 RVA: 0x0121589C File Offset: 0x01213A9C
		private bool IsResetCamera(Vector armLocation, Vector cameraLocation, float currentDistance)
		{
			double num = armLocation.Subtraction(cameraLocation, this.TmpVector).SizeSquared();
			return (double)(currentDistance * currentDistance) > num;
		}

		// Token: 0x0603E3EA RID: 254954 RVA: 0x012158C4 File Offset: 0x01213AC4
		private bool IsCharacterIgnoreNpcDither(ABaseCharacter character)
		{
			Entity entityNoBlueprint = character.GetEntityNoBlueprint();
			if (entityNoBlueprint == null || !entityNoBlueprint.Valid)
			{
				return false;
			}
			BaseTagComponent component = entityNoBlueprint.GetComponent<BaseTagComponent>();
			if (component != null && component.HasAnyTag(CameraCollision.IgnoreNpcDitherTagList))
			{
				return true;
			}
			NpcPerformComponent component2 = entityNoBlueprint.GetComponent<NpcPerformComponent>();
			return component2 != null && component2.IsNpcIgnoreCameraHide;
		}

		// Token: 0x0603E3EB RID: 254955 RVA: 0x01215918 File Offset: 0x01213B18
		private void UpdateCameraCollisionRadius()
		{
			if (MathUtils.Instance.IsNearlyZero((double)this.Camera.CameraModel.CameraDitherStartHideDistance, new double?(0.0001)))
			{
				return;
			}
			if (MathUtils.Instance.IsNearlyEqual((double)this.CurrentCameraDitherStartHideDistance, (double)this.Camera.CameraModel.CameraDitherStartHideDistance, null) && MathUtils.Instance.IsNearlyEqual((double)this.CurrentCameraDitherFov, (double)this.Camera.Fov, null))
			{
				return;
			}
			this.CurrentCameraDitherStartHideDistance = this.Camera.CameraModel.CameraDitherStartHideDistance;
			this.CurrentCameraDitherFov = this.Camera.Fov;
			float currentCameraDitherStartHideDistance = this.CurrentCameraDitherStartHideDistance;
			float aspectRatio = this.Camera.CameraActor.CameraComponent.AspectRatio;
			double c = Math.Sin(MathUtils.Instance.VerticalFovToHorizontally((double)this.Camera.Fov, (double)aspectRatio) / 2.0 * 0.01745329238474369) * (double)currentCameraDitherStartHideDistance * 2.0;
			this.CameraCollisionRadius = (float)MathUtils.Instance.GetTriangleCircumradius((double)currentCameraDitherStartHideDistance, (double)currentCameraDitherStartHideDistance, c);
		}

		// Token: 0x0603E3EC RID: 254956 RVA: 0x01215A40 File Offset: 0x01213C40
		private void UpdateCameraCollisionLocation()
		{
			this.Camera.CameraForward.Normalize(9.99999993922529E-09);
			this.Camera.CameraForward.Multiply((double)this.CameraCollisionRadius, this.TmpVector);
			this.CameraTargetLocation.Addition(this.TmpVector, this.CameraCollisionLocation);
		}

		// Token: 0x0603E3ED RID: 254957 RVA: 0x01215AA0 File Offset: 0x01213CA0
		private void UpdateDitheredNpcDistance(UKuroHitResult hitResult)
		{
			int hitCount = hitResult.GetHitCount();
			this.DitheredNpcDistanceMap.Clear();
			for (int i = 0; i < hitCount; i++)
			{
				ABaseCharacter abaseCharacter = hitResult.Actors.Get(i).Get() as ABaseCharacter;
				if (CameraCollision.IsCharacterRenderingType(abaseCharacter))
				{
					Entity entityNoBlueprint = abaseCharacter.GetEntityNoBlueprint();
					CreatureDataComponent creatureDataComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CreatureDataComponent>() : null;
					SModelConfig smodelConfig = (creatureDataComponent != null) ? creatureDataComponent.GetModelConfig() : null;
					if (smodelConfig == null || !smodelConfig.主角蓝透)
					{
						if (abaseCharacter.CapsuleComponent != null && abaseCharacter.CapsuleComponent.GetCollisionObjectType() == KuroCollisionChannel.Vehicle)
						{
							Entity entityNoBlueprint2 = abaseCharacter.GetEntityNoBlueprint();
							if (entityNoBlueprint2 == null || entityNoBlueprint2.GetComponent<MotorcycleActorComponent>() == null || VehicleModel.Instance.MaterialControllerHandles.Count > 0)
							{
								this.DitheredNpcSet.Remove(abaseCharacter);
								goto IL_114;
							}
						}
						TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TmpVector);
						float valueOrDefault = this.DitheredNpcDistanceMap.GetValueOrDefault(abaseCharacter, 9999999f);
						double num = Vector.Dist(this.TmpVector, this.CameraTargetLocation);
						if (num < (double)valueOrDefault)
						{
							this.DitheredNpcDistanceMap[abaseCharacter] = (float)num;
						}
					}
				}
				IL_114:;
			}
		}

		// Token: 0x0603E3EE RID: 254958 RVA: 0x01215BCC File Offset: 0x01213DCC
		private float GetNpcDitherValue(ABaseCharacter actor, float distance)
		{
			if (!actor.IsValid() || actor.CapsuleComponent == null)
			{
				return 1f;
			}
			float completeHideDistance = this.Camera.CompleteHideDistance;
			float startHideDistance = this.Camera.StartHideDistance;
			float startDitherValue = this.Camera.StartDitherValue;
			if ((ECollisionChannel)actor.CapsuleComponent.GetCollisionObjectType() == KuroCollisionChannel.PawnMonster)
			{
				Entity entityNoBlueprint = (actor as TsBaseCharacter).GetEntityNoBlueprint();
				CharacterActorComponent characterActorComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterActorComponent>() : null;
				if (characterActorComponent != null)
				{
					completeHideDistance = characterActorComponent.CompleteHideDistance;
					startHideDistance = characterActorComponent.StartHideDistance;
					startDitherValue = characterActorComponent.StartDitherValue;
				}
			}
			else if ((ECollisionChannel)actor.CapsuleComponent.GetCollisionObjectType() == KuroCollisionChannel.Vehicle)
			{
				Entity entityNoBlueprint2 = (actor as TsBaseVehicle).GetEntityNoBlueprint();
				VehicleActorComponent vehicleActorComponent = (entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<VehicleActorComponent>() : null;
				if (vehicleActorComponent != null && vehicleActorComponent.StartHideDistance > 0f)
				{
					completeHideDistance = vehicleActorComponent.CompleteHideDistance;
					startHideDistance = vehicleActorComponent.StartHideDistance;
					startDitherValue = vehicleActorComponent.StartDitherValue;
				}
			}
			return MathUtils.Instance.RangeClamp(distance, completeHideDistance, startHideDistance, 0.01f, startDitherValue);
		}

		// Token: 0x0603E3EF RID: 254959 RVA: 0x01215CCC File Offset: 0x01213ECC
		private int GetValidHitIndex(Vector startLocation, Vector endLocation, UKuroHitResult hitResult)
		{
			if (startLocation.Z > endLocation.Z)
			{
				return 0;
			}
			int result = -1;
			float num = 9999999f;
			int hitCount = hitResult.GetHitCount();
			for (int i = 0; i < hitCount; i++)
			{
				UKuroHitResult hitResult2 = this.CameraSphereTrace.HitResult;
				TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr;
				if (hitResult2 == null)
				{
					tweakObjectPtr = null;
				}
				else
				{
					TArray<TWeakObjectPtr<UPrimitiveComponent>> components = hitResult2.Components;
					tweakObjectPtr = ((components != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components.Get(i)) : null);
				}
				TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr2 = tweakObjectPtr;
				if (tweakObjectPtr2 == null || tweakObjectPtr2.Value.Get().IsValid())
				{
					UKuroHitResult hitResult3 = this.CameraSphereTrace.HitResult;
					TArray<int> tarray = (hitResult3 != null) ? hitResult3.ItemArray : null;
					int instanceIndex = (tarray != null && i < tarray.Num()) ? tarray.Get(i) : 0;
					TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TmpVector);
					float num2 = (float)Vector.DistSquared(this.TmpVector, startLocation);
					TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr3 = tweakObjectPtr2;
					if ((!(UKuroCollisionLibrary.GetCollisionResponseToChannel((tweakObjectPtr3 != null) ? tweakObjectPtr3.GetValueOrDefault() : null, KuroCollisionChannel.Water, instanceIndex) == ECollisionResponse.ECR_Block) || num2 > this.CameraCollisionProbeSizeSquared) && num2 < num)
					{
						num = num2;
						result = i;
					}
				}
			}
			return result;
		}

		// Token: 0x0603E3F0 RID: 254960 RVA: 0x01215E0C File Offset: 0x0121400C
		private bool IsPlayerBlueStateEnable(UKuroHitResult hitResult)
		{
			int hitCount = hitResult.GetHitCount();
			for (int i = 0; i < hitCount; i++)
			{
				ABaseCharacter abaseCharacter = hitResult.Actors.Get(i).Get() as ABaseCharacter;
				if (CameraCollision.IsCharacterRenderingType(abaseCharacter))
				{
					Entity entityNoBlueprint = abaseCharacter.GetEntityNoBlueprint();
					CreatureDataComponent creatureDataComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CreatureDataComponent>() : null;
					SModelConfig smodelConfig = (creatureDataComponent != null) ? creatureDataComponent.GetModelConfig() : null;
					if (smodelConfig != null && smodelConfig.主角蓝透)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603E3F1 RID: 254961 RVA: 0x01215E80 File Offset: 0x01214080
		public bool TraceCheckPlayerLocation(Vector beginLocation, Vector endLocation, Vector outLocation)
		{
			this.CameraSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraSphereTrace.Radius = this.Camera.CurrentCollisionSize;
			TraceElementCommon.Instance.SetStartLocation(this.CameraSphereTrace, beginLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraSphereTrace, endLocation);
			if (TraceElementCommon.Instance.SphereTrace(this.CameraSphereTrace, "FightCameraLogicComponent_CheckCollision_Camera_Caught_PlayerLocation"))
			{
				TraceElementCommon.Instance.GetHitLocation(this.CameraSphereTrace.HitResult, 0, outLocation);
				return true;
			}
			return false;
		}

		// Token: 0x0603E3F2 RID: 254962 RVA: 0x01215F06 File Offset: 0x01214106
		public void SetCameraBlendPauseType(ECameraBlendPauseType pauseType)
		{
			this.BlendPauseType = pauseType;
		}

		// Token: 0x0603E3F3 RID: 254963 RVA: 0x01215F10 File Offset: 0x01214110
		[NullableContext(2)]
		public static bool IsCharacterRenderingType(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return false;
			}
			TsBaseCharacter tsBaseCharacter = actor as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				EntityHandle handle = CharacterModel.Instance.GetHandle(tsBaseCharacter.GetEntityIdNoBlueprint());
				return handle != null && handle.Valid;
			}
			TsBaseVehicle tsBaseVehicle = actor as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				EntityHandle handle2 = CharacterModel.Instance.GetHandle(tsBaseVehicle.GetEntityIdNoBlueprint());
				return handle2 != null && handle2.Valid;
			}
			return false;
		}

		// Token: 0x0603E3F4 RID: 254964 RVA: 0x01215F7D File Offset: 0x0121417D
		public void LockCameraCollision(ECameraCollisionLockType lockType)
		{
			this.CameraCollisionLockingHandler.Lock(lockType);
		}

		// Token: 0x0603E3F5 RID: 254965 RVA: 0x01215F8B File Offset: 0x0121418B
		public void UnlockCameraCollision(ECameraCollisionLockType lockType)
		{
			this.CameraCollisionLockingHandler.Unlock(lockType);
		}

		// Token: 0x0603E3F6 RID: 254966 RVA: 0x01215F99 File Offset: 0x01214199
		public bool IsCameraCollisionEnable()
		{
			return this.CameraCollisionLockingHandler.IsUnlocked();
		}

		// Token: 0x0603E3F7 RID: 254967 RVA: 0x01215FA6 File Offset: 0x012141A6
		public void LockCameraNpcDither(ENpcDitherLockType lockType)
		{
			this.NpcDitherLockingHandler.Lock(lockType);
		}

		// Token: 0x0603E3F8 RID: 254968 RVA: 0x01215FB4 File Offset: 0x012141B4
		public void UnlockCameraNpcDither(ENpcDitherLockType lockType)
		{
			this.NpcDitherLockingHandler.Unlock(lockType);
		}

		// Token: 0x0603E3F9 RID: 254969 RVA: 0x01215FC2 File Offset: 0x012141C2
		public bool IsCameraNpcDitherEnable()
		{
			return this.NpcDitherLockingHandler.IsUnlocked();
		}

		// Token: 0x0603E3FA RID: 254970 RVA: 0x01215FCF File Offset: 0x012141CF
		public bool GetIsMiddleCollision()
		{
			return this.IsMiddleCollision;
		}

		// Token: 0x0603E3FB RID: 254971 RVA: 0x01215FD7 File Offset: 0x012141D7
		public bool CheckIsOcclusionDitherActiveActor(ABaseCharacter actor)
		{
			Entity entityNoBlueprint = actor.GetEntityNoBlueprint();
			object obj;
			if (entityNoBlueprint == null)
			{
				obj = null;
			}
			else
			{
				CharacterActorComponent component = entityNoBlueprint.GetComponent<CharacterActorComponent>();
				obj = ((component != null) ? component.OcclusionDitherConfig : null);
			}
			object obj2 = obj;
			return obj2 != null && obj2.IsEnableOcclusionDither;
		}

		// Token: 0x0603E3FC RID: 254972 RVA: 0x01216004 File Offset: 0x01214204
		public bool CheckOcclusionDitherActive(ABaseCharacter actor)
		{
			if (!this.IsActiveOcclusionDither)
			{
				return false;
			}
			Entity entityNoBlueprint = actor.GetEntityNoBlueprint();
			if (entityNoBlueprint == null || !entityNoBlueprint.Valid)
			{
				return false;
			}
			CharacterActorComponent component = entityNoBlueprint.GetComponent<CharacterActorComponent>();
			OcclusionDitherConfig occlusionDitherConfig = (component != null) ? component.OcclusionDitherConfig : null;
			FGameplayTag? fgameplayTag = (occlusionDitherConfig != null) ? occlusionDitherConfig.IgnoreOcclusionDitherTag : null;
			if (fgameplayTag != null)
			{
				FGameplayTag valueOrDefault = fgameplayTag.GetValueOrDefault();
				BaseTagComponent component2 = entityNoBlueprint.GetComponent<BaseTagComponent>();
				if (component2 != null && component2.HasTag(valueOrDefault.TagId()))
				{
					return false;
				}
			}
			return occlusionDitherConfig != null && occlusionDitherConfig.IsEnableOcclusionDither;
		}

		// Token: 0x0603E3FD RID: 254973 RVA: 0x01216090 File Offset: 0x01214290
		public void CalculateAllOcclusionDitherValue(float deltaTime)
		{
			foreach (KeyValuePair<ABaseCharacter, OcclusionDitherData> keyValuePair in this.OcclusionDitherDataMap)
			{
				OcclusionDitherData value = keyValuePair.Value;
				if (value != null)
				{
					float currentValue = value.CurrentValue;
					float targetOcclusionDitherValue = value.TargetOcclusionDitherValue;
					float targetCameraDitherValue = value.TargetCameraDitherValue;
					float interpSpeed = value.InterpSpeed;
					value.CurrentValue = MathUtils.Instance.Lerp(currentValue, Math.Min(targetOcclusionDitherValue, targetCameraDitherValue), interpSpeed * deltaTime);
				}
			}
		}

		// Token: 0x0603E3FE RID: 254974 RVA: 0x01216124 File Offset: 0x01214324
		public float GetActorInterpSpeed(ABaseCharacter actor)
		{
			Entity entityNoBlueprint = actor.GetEntityNoBlueprint();
			float? num;
			if (entityNoBlueprint == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent component = entityNoBlueprint.GetComponent<CharacterActorComponent>();
				if (component == null)
				{
					num = null;
				}
				else
				{
					OcclusionDitherConfig occlusionDitherConfig = component.OcclusionDitherConfig;
					num = ((occlusionDitherConfig != null) ? new float?(occlusionDitherConfig.OcclusionDitherInterpSpeed) : null);
				}
			}
			float? num2 = num;
			return num2.GetValueOrDefault(1f);
		}

		// Token: 0x0603E3FF RID: 254975 RVA: 0x01216188 File Offset: 0x01214388
		public void ResetAllOcclusionDither()
		{
			foreach (ABaseCharacter key in this.LastFrameActiveDitherActors)
			{
				OcclusionDitherData occlusionDitherData;
				if (this.OcclusionDitherDataMap.TryGetValue(key, out occlusionDitherData))
				{
					occlusionDitherData.TargetCameraDitherValue = 1f;
					occlusionDitherData.TargetOcclusionDitherValue = 1f;
				}
			}
			this.LastFrameActiveDitherActors.Clear();
			this.WaitRemoveActorList.Clear();
		}

		// Token: 0x0603E400 RID: 254976 RVA: 0x01216210 File Offset: 0x01214410
		public void SetOcclusionDitherTargetValue(ABaseCharacter actor, float targetOcclusionDitherValue)
		{
			OcclusionDitherData occlusionDitherData;
			if (!this.OcclusionDitherDataMap.TryGetValue(actor, out occlusionDitherData))
			{
				occlusionDitherData = new OcclusionDitherData
				{
					CurrentValue = 1f,
					TargetCameraDitherValue = 1f,
					TargetOcclusionDitherValue = 1f,
					InterpSpeed = this.GetActorInterpSpeed(actor)
				};
				this.OcclusionDitherDataMap[actor] = occlusionDitherData;
			}
			occlusionDitherData.TargetOcclusionDitherValue = targetOcclusionDitherValue;
			this.LastFrameActiveDitherActors.Add(actor);
		}

		// Token: 0x0603E401 RID: 254977 RVA: 0x01216284 File Offset: 0x01214484
		public void SetCameraDitherTargetValue(ABaseCharacter actor, float targetCameraDitherValue)
		{
			OcclusionDitherData occlusionDitherData;
			if (!this.OcclusionDitherDataMap.TryGetValue(actor, out occlusionDitherData))
			{
				occlusionDitherData = new OcclusionDitherData
				{
					CurrentValue = 1f,
					TargetCameraDitherValue = 1f,
					TargetOcclusionDitherValue = 1f,
					InterpSpeed = this.GetActorInterpSpeed(actor)
				};
				this.OcclusionDitherDataMap[actor] = occlusionDitherData;
			}
			occlusionDitherData.TargetCameraDitherValue = targetCameraDitherValue;
			this.LastFrameActiveDitherActors.Add(actor);
		}

		// Token: 0x0603E402 RID: 254978 RVA: 0x012162F8 File Offset: 0x012144F8
		private void UpdateOcclusionDither()
		{
			if (!this.IsActiveOcclusionDither)
			{
				return;
			}
			UKuroHitResult hitResult = this.CameraPlayerSphereTrace.HitResult;
			int hitCount = hitResult.GetHitCount();
			for (int i = 0; i < hitCount; i++)
			{
				TWeakObjectPtr<AActor> tweakObjectPtr = hitResult.Actors.Get(i);
				AActor aactor = tweakObjectPtr.Get();
				if (aactor != null && aactor.IsValid())
				{
					UPrimitiveComponent uprimitiveComponent = hitResult.Components.Get(i).Get();
					if ((uprimitiveComponent == null || !uprimitiveComponent.ComponentHasTag(CameraCollision.TagIgnoreOcclusionDither)) && CameraCollision.IsCharacterRenderingType(tweakObjectPtr.Get()))
					{
						ABaseCharacter abaseCharacter = tweakObjectPtr.Get() as ABaseCharacter;
						if (abaseCharacter != null && this.CheckOcclusionDitherActive(abaseCharacter))
						{
							Entity entityNoBlueprint = abaseCharacter.GetEntityNoBlueprint();
							OcclusionDitherConfig occlusionDitherConfig;
							if (entityNoBlueprint == null)
							{
								occlusionDitherConfig = null;
							}
							else
							{
								CharacterActorComponent component = entityNoBlueprint.GetComponent<CharacterActorComponent>();
								occlusionDitherConfig = ((component != null) ? component.OcclusionDitherConfig : null);
							}
							OcclusionDitherConfig occlusionDitherConfig2 = occlusionDitherConfig;
							this.SetOcclusionDitherTargetValue(abaseCharacter, (occlusionDitherConfig2 != null) ? occlusionDitherConfig2.OcclusionDitherValue : 1f);
						}
					}
				}
			}
		}

		// Token: 0x0603E403 RID: 254979 RVA: 0x012163E8 File Offset: 0x012145E8
		private void SetAllDitherValue()
		{
			foreach (KeyValuePair<ABaseCharacter, OcclusionDitherData> keyValuePair in this.OcclusionDitherDataMap)
			{
				ABaseCharacter key = keyValuePair.Key;
				OcclusionDitherData value = keyValuePair.Value;
				if (CameraCollision.IsCharacterRenderingType(key))
				{
					float currentValue = value.CurrentValue;
					if (value.TargetCameraDitherValue >= 1f && value.TargetOcclusionDitherValue >= 1f && MathUtils.Instance.IsNearlyEqual((double)currentValue, 1.0, new double?(0.0001)))
					{
						key.SetDitherEffect(1f, ECharacterDitherType.Fight);
						this.SetDitherGroupEffect(key, 1f);
						this.WaitRemoveActorList.Add(key);
					}
					else
					{
						key.SetDitherEffect(currentValue, ECharacterDitherType.Fight);
						this.SetDitherGroupEffect(key, currentValue);
					}
				}
				else
				{
					this.WaitRemoveActorList.Add(key);
				}
			}
			foreach (ABaseCharacter key2 in this.WaitRemoveActorList)
			{
				this.OcclusionDitherDataMap.Remove(key2);
			}
		}

		// Token: 0x0603E404 RID: 254980 RVA: 0x01216530 File Offset: 0x01214730
		private void SetDitherEffect(ABaseCharacter actor, float ditherValue, ECameraDitherType ditherType)
		{
			if (this.CheckIsOcclusionDitherActiveActor(actor))
			{
				if (ditherType == ECameraDitherType.OcclusionDither)
				{
					this.SetOcclusionDitherTargetValue(actor, ditherValue);
					return;
				}
				if (ditherType == ECameraDitherType.CameraDither)
				{
					this.SetCameraDitherTargetValue(actor, ditherValue);
					return;
				}
			}
			else
			{
				actor.SetDitherEffect(ditherValue, ECharacterDitherType.Fight);
				this.SetDitherGroupEffect(actor, ditherValue);
			}
		}

		// Token: 0x0603E405 RID: 254981 RVA: 0x01216564 File Offset: 0x01214764
		private void TraceElementBetweenCameraAndPlayer(Vector armLocation)
		{
			if (!this.IsPlayerXRayEnable && !this.IsActiveOcclusionDither)
			{
				return;
			}
			UKuroHitResult hitResult = this.CameraPlayerSphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			this.CameraPlayerSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraPlayerSphereTrace.Radius = 20f;
			TraceElementCommon.Instance.SetStartLocation(this.CameraPlayerSphereTrace, this.CameraTargetLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraPlayerSphereTrace, armLocation);
			this.IsHitSomethingBetweenCameraAndPlayer = TraceElementCommon.Instance.SphereTrace(this.CameraPlayerSphereTrace, "FightCameraLogicComponent_CheckCollision_Player");
		}

		// Token: 0x0603E406 RID: 254982 RVA: 0x012165FA File Offset: 0x012147FA
		public void SetCameraCollisionMode(ECameraCollisionMode mode)
		{
			if (this.CollisionMode == mode)
			{
				return;
			}
			this.CollisionMode = mode;
			this.ResetBlendData();
		}

		// Token: 0x04021231 RID: 135729
		public const float MinDither = 0.01f;

		// Token: 0x04021232 RID: 135730
		public const int MaxValue = 9999999;

		// Token: 0x04021233 RID: 135731
		public const int ProbeRatio = 4;

		// Token: 0x04021234 RID: 135732
		public const int PlayerCollisionRadius = 20;

		// Token: 0x04021235 RID: 135733
		public const string ProfileKey1 = "FightCameraLogicComponent_CheckCollision_Camera";

		// Token: 0x04021236 RID: 135734
		public const string ProfileKey2 = "FightCameraLogicComponent_CheckCollision_Npc";

		// Token: 0x04021237 RID: 135735
		public const string ProfileKey3 = "FightCameraLogicComponent_CheckCollision_Camera_Caught_PlayerLocation";

		// Token: 0x04021238 RID: 135736
		public const string ProfileKey4 = "FightCameraLogicComponent_CheckCollision_Player";

		// Token: 0x04021239 RID: 135737
		public const string ProfileKey5 = "FightCameraLogicComponent_CheckCollision_Camera_InPlace";

		// Token: 0x0402123A RID: 135738
		public static readonly FName TagIgnoreOcclusionDither = new FName("Ignore_Occlusion_Dither");

		// Token: 0x0402123B RID: 135739
		[StaticVariableRuleIgnore]
		private static readonly int[] IgnoreNpcDitherTagList = new int[]
		{
			GameplayTagDefine.EGameplayTagId["功能.通用镜头.忽略碰撞隐藏"],
			GameplayTagDefine.EGameplayTagId["载具.摩托.第一人称"]
		};

		// Token: 0x0402123C RID: 135740
		[Nullable(2)]
		private FightCameraLogicComponent Camera;

		// Token: 0x0402123D RID: 135741
		[Nullable(2)]
		private TsBaseCharacter Character;

		// Token: 0x0402123E RID: 135742
		[Nullable(2)]
		private CharacterSwimComponent CharSwimComp;

		// Token: 0x0402123F RID: 135743
		[Nullable(2)]
		private UTraceSphereElement CameraSphereTrace;

		// Token: 0x04021240 RID: 135744
		[Nullable(2)]
		private UTraceSphereElement CameraLeftSphereTrace;

		// Token: 0x04021241 RID: 135745
		[Nullable(2)]
		private UTraceSphereElement CameraRightSphereTrace;

		// Token: 0x04021242 RID: 135746
		[Nullable(2)]
		private UTraceSphereElement CameraNpcSphereTrace;

		// Token: 0x04021243 RID: 135747
		[Nullable(2)]
		private UTraceSphereElement CameraPlayerSphereTrace;

		// Token: 0x04021244 RID: 135748
		[Nullable(2)]
		private UTraceSphereElement CameraInPlaceSphereTrace;

		// Token: 0x04021245 RID: 135749
		private bool IsHitSomethingBetweenCameraAndPlayer;

		// Token: 0x04021246 RID: 135750
		private readonly Vector GravityDirect = Vector.Create();

		// Token: 0x04021247 RID: 135751
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04021248 RID: 135752
		private readonly Vector EndLocation = Vector.Create();

		// Token: 0x04021249 RID: 135753
		private readonly Vector ArmDirection = Vector.Create();

		// Token: 0x0402124A RID: 135754
		private readonly Vector OffsetVector = Vector.Create();

		// Token: 0x0402124B RID: 135755
		private readonly Vector CameraTargetLocation = Vector.Create();

		// Token: 0x0402124C RID: 135756
		private readonly Vector CameraCollisionLocation = Vector.Create();

		// Token: 0x0402124D RID: 135757
		private readonly Vector CurrentArmVector = Vector.Create();

		// Token: 0x0402124E RID: 135758
		private readonly Vector TargetArmVector = Vector.Create();

		// Token: 0x0402124F RID: 135759
		private readonly Vector NewArmVector = Vector.Create();

		// Token: 0x04021250 RID: 135760
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x04021251 RID: 135761
		private float CurrentArmLength;

		// Token: 0x04021252 RID: 135762
		private float TargetArmLength;

		// Token: 0x04021253 RID: 135763
		private int MiddleCollisionHitIndex;

		// Token: 0x04021254 RID: 135764
		private bool IsMiddleCollision;

		// Token: 0x04021255 RID: 135765
		private bool IsInPlaceCollision;

		// Token: 0x04021256 RID: 135766
		private bool IsCameraFloatOnWater;

		// Token: 0x04021257 RID: 135767
		public bool IsLeftCollision;

		// Token: 0x04021258 RID: 135768
		public bool IsRightCollision;

		// Token: 0x04021259 RID: 135769
		public bool IsOpenBlend = true;

		// Token: 0x0402125A RID: 135770
		public ECameraCollisionMode CollisionMode;

		// Token: 0x0402125B RID: 135771
		private ECameraBlendPauseType BlendPauseType;

		// Token: 0x0402125C RID: 135772
		public ECollisionBlendState CurrentBlendState;

		// Token: 0x0402125D RID: 135773
		private float CurrentCollisionDifferenceSize;

		// Token: 0x0402125E RID: 135774
		private float CameraCollisionRadius;

		// Token: 0x0402125F RID: 135775
		private float CurrentCameraDitherStartHideDistance;

		// Token: 0x04021260 RID: 135776
		private float CurrentCameraDitherFov;

		// Token: 0x04021261 RID: 135777
		private float CameraCollisionProbeSizeSquared;

		// Token: 0x04021262 RID: 135778
		private float CameraMinFloorZnOffset;

		// Token: 0x04021263 RID: 135779
		private readonly UniqueLockingHandler<ECameraCollisionLockType> CameraCollisionLockingHandler = new UniqueLockingHandler<ECameraCollisionLockType>();

		// Token: 0x04021264 RID: 135780
		private readonly UniqueLockingHandler<ENpcDitherLockType> NpcDitherLockingHandler = new UniqueLockingHandler<ENpcDitherLockType>();

		// Token: 0x04021265 RID: 135781
		public bool IsPlayerXRayEnable = true;

		// Token: 0x04021266 RID: 135782
		private readonly List<ABaseCharacter> DitheredNpcSet = new List<ABaseCharacter>();

		// Token: 0x04021267 RID: 135783
		private readonly Dictionary<ABaseCharacter, float> DitheredNpcDistanceMap = new Dictionary<ABaseCharacter, float>();

		// Token: 0x04021268 RID: 135784
		public bool GmCameraCollisionEnable = true;

		// Token: 0x04021269 RID: 135785
		public bool GmNpcDitherEnable = true;

		// Token: 0x0402126A RID: 135786
		public bool IsActiveOcclusionDither = true;

		// Token: 0x0402126B RID: 135787
		private readonly Dictionary<ABaseCharacter, OcclusionDitherData> OcclusionDitherDataMap = new Dictionary<ABaseCharacter, OcclusionDitherData>();

		// Token: 0x0402126C RID: 135788
		private readonly List<ABaseCharacter> WaitRemoveActorList = new List<ABaseCharacter>();

		// Token: 0x0402126D RID: 135789
		private readonly HashSet<ABaseCharacter> LastFrameActiveDitherActors = new HashSet<ABaseCharacter>();
	}
}
