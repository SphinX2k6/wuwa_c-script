using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Portal;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02004553 RID: 17747
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalUtils : Singleton
	{
		// Token: 0x17007552 RID: 30034
		// (get) Token: 0x0602DD8E RID: 187790 RVA: 0x00A8A770 File Offset: 0x00A88970
		private PortalCapturePerformanceConfig DefaultCapturePerformanceConfig
		{
			get
			{
				PortalCapturePerformanceConfig result;
				if ((result = this.DefaultCapturePerformanceConfigInstance) == null)
				{
					result = (this.DefaultCapturePerformanceConfigInstance = new PortalCapturePerformanceConfig(new PortalPlatformCaptureConfig(new Dictionary<EPortalCaptureLevel, FSceneCaptureComponent2DParams>
					{
						{
							EPortalCaptureLevel.VeryLow,
							new FSceneCaptureComponent2DParams(1000000f, 64, 1, 1, 2000f, false, false, false, true)
						},
						{
							EPortalCaptureLevel.Low,
							new FSceneCaptureComponent2DParams(0.033333f, 256, 1, 1, 2000f, true, false, false, true)
						},
						{
							EPortalCaptureLevel.Mid,
							new FSceneCaptureComponent2DParams(0.033333f, 512, 1, 1, 2000f, true, false, false, true)
						},
						{
							EPortalCaptureLevel.High,
							new FSceneCaptureComponent2DParams(0.016667f, 1024, 1, 1, 2000f, true, false, false, true)
						}
					}, new Dictionary<EPortalCaptureLevel, double>
					{
						{
							EPortalCaptureLevel.VeryLow,
							3000.0
						},
						{
							EPortalCaptureLevel.Low,
							1500.0
						},
						{
							EPortalCaptureLevel.Mid,
							500.0
						}
					}), new PortalPlatformCaptureConfig(new Dictionary<EPortalCaptureLevel, FSceneCaptureComponent2DParams>
					{
						{
							EPortalCaptureLevel.VeryLow,
							new FSceneCaptureComponent2DParams(1000000f, 64, 1, 1, 2000f, false, false, false, false)
						},
						{
							EPortalCaptureLevel.Low,
							new FSceneCaptureComponent2DParams(0.066667f, 128, 1, 1, 2000f, true, false, false, false)
						},
						{
							EPortalCaptureLevel.Mid,
							new FSceneCaptureComponent2DParams(0.066667f, 256, 1, 1, 2000f, true, false, false, true)
						},
						{
							EPortalCaptureLevel.High,
							new FSceneCaptureComponent2DParams(0.066667f, 256, 1, 1, 2000f, true, false, false, true)
						}
					}, new Dictionary<EPortalCaptureLevel, double>
					{
						{
							EPortalCaptureLevel.VeryLow,
							3000.0
						},
						{
							EPortalCaptureLevel.Low,
							1500.0
						},
						{
							EPortalCaptureLevel.Mid,
							500.0
						}
					})));
				}
				return result;
			}
		}

		// Token: 0x0602DD8F RID: 187791 RVA: 0x00A8A918 File Offset: 0x00A88B18
		private void DrawCaptureDebug(Transform playerCameraTrans, FTransformDouble sourcePortalWorld, FTransformDouble targetPortalWorld, FTransformDouble captureTransform, double nearPlane, double nearCenterY, double nearCenterZ, double nearHalfWidth, double nearHalfHeight)
		{
			FVectorDouble fvectorDouble = new FVectorDouble(nearPlane, nearCenterY, nearCenterZ);
			FVectorDouble center = captureTransform.TransformPosition(fvectorDouble);
			fvectorDouble = new FVectorDouble(0.0, nearHalfWidth, 0.0);
			FVectorDouble right = captureTransform.TransformVector(fvectorDouble);
			fvectorDouble = new FVectorDouble(0.0, 0.0, nearHalfHeight);
			FVectorDouble up = captureTransform.TransformVector(fvectorDouble);
			FVectorDouble location = captureTransform.GetLocation();
			this.DrawDebugFrustumToPlane(location, center, right, up);
			this.DrawDebugLine(playerCameraTrans.GetLocation().ToUeVector(false), sourcePortalWorld.GetLocation(), this.DebugColorOrange, 0f);
			this.DrawDebugLine(location, targetPortalWorld.GetLocation(), this.DebugColorGreen, 0f);
			this.DrawDebugTransform(sourcePortalWorld, 80f, 0f);
			this.DrawDebugTransform(targetPortalWorld, 80f, 0f);
		}

		// Token: 0x0602DD90 RID: 187792 RVA: 0x00A8A9F8 File Offset: 0x00A88BF8
		private void DrawDebugFrustumToPlane(FVectorDouble origin, FVectorDouble center, FVectorDouble right, FVectorDouble up)
		{
			FVectorDouble fvectorDouble = new FVectorDouble(center.X - right.X - up.X, center.Y - right.Y - up.Y, center.Z - right.Z - up.Z);
			FVectorDouble fvectorDouble2 = new FVectorDouble(center.X + right.X - up.X, center.Y + right.Y - up.Y, center.Z + right.Z - up.Z);
			FVectorDouble fvectorDouble3 = new FVectorDouble(center.X + right.X + up.X, center.Y + right.Y + up.Y, center.Z + right.Z + up.Z);
			FVectorDouble fvectorDouble4 = new FVectorDouble(center.X - right.X + up.X, center.Y - right.Y + up.Y, center.Z - right.Z + up.Z);
			this.DrawDebugLine(origin, fvectorDouble, this.DebugColorCyan, 0f);
			this.DrawDebugLine(origin, fvectorDouble2, this.DebugColorCyan, 0f);
			this.DrawDebugLine(origin, fvectorDouble3, this.DebugColorCyan, 0f);
			this.DrawDebugLine(origin, fvectorDouble4, this.DebugColorCyan, 0f);
			this.DrawDebugLine(fvectorDouble, fvectorDouble2, this.DebugColorYellow, 0f);
			this.DrawDebugLine(fvectorDouble2, fvectorDouble3, this.DebugColorYellow, 0f);
			this.DrawDebugLine(fvectorDouble3, fvectorDouble4, this.DebugColorYellow, 0f);
			this.DrawDebugLine(fvectorDouble4, fvectorDouble, this.DebugColorYellow, 0f);
			this.DrawDebugSphere(origin, this.DebugColorCyan, 10f, 0f);
		}

		// Token: 0x0602DD91 RID: 187793 RVA: 0x00A8ABCC File Offset: 0x00A88DCC
		private void DrawDebugSphere(FVectorDouble position, FLinearColor color, float radius = 18f, float duration = 5f)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, position, radius, 12, new FLinearColor?(color), duration, 2f);
		}

		// Token: 0x0602DD92 RID: 187794 RVA: 0x00A8ABE9 File Offset: 0x00A88DE9
		private void DrawDebugArrow(FVectorDouble start, FVectorDouble end, FLinearColor color)
		{
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, start, end, 24f, color, 5f, 2f);
		}

		// Token: 0x0602DD93 RID: 187795 RVA: 0x00A8AC08 File Offset: 0x00A88E08
		private void DrawDebugDirection(FVectorDouble start, IVector direction, FLinearColor color, float scale = 120f)
		{
			FVectorDouble end = new FVectorDouble(start.X + direction.X * (double)scale, start.Y + direction.Y * (double)scale, start.Z + direction.Z * (double)scale);
			this.DrawDebugArrow(start, end, color);
		}

		// Token: 0x0602DD94 RID: 187796 RVA: 0x00A8AC58 File Offset: 0x00A88E58
		private void DrawDebugTransform(FTransformDouble transform, float scale = 80f, float duration = 5f)
		{
			UKismetSystemLibrary.D_DrawDebugCoordinateSystem(GlobalData.World, transform.GetLocation(), transform.Rotator(), scale, duration, 2f);
		}

		// Token: 0x0602DD95 RID: 187797 RVA: 0x00A8AC79 File Offset: 0x00A88E79
		private void DrawDebugLine(FVectorDouble start, FVectorDouble end, FLinearColor color, float duration = 5f)
		{
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, start, end, color, duration, 2f);
		}

		// Token: 0x0602DD96 RID: 187798 RVA: 0x00A8AC90 File Offset: 0x00A88E90
		[return: Nullable(2)]
		public Vector GetMappingPosToOtherPortal(Vector mapFromPos, long portalId, bool bA2B, Vector outPos, bool enableDebug = false)
		{
			if (portalId == 0L)
			{
				outPos.DeepCopy(mapFromPos);
				return outPos;
			}
			BP_Portal_C portal = PortalModel.Instance.GetPortal(portalId);
			if (portal == null || !portal.Portal1Enable || !portal.Portal2Enable)
			{
				return null;
			}
			FTransformDouble portalOutTf;
			FTransformDouble portalInTf;
			if (!bA2B)
			{
				FTransformDouble portalWorldTransform = portal.PortalWorldTransform2;
				FTransformDouble ftransformDouble = portal.PortalWorldTransform1;
				portalOutTf = ftransformDouble;
				portalInTf = portalWorldTransform;
			}
			else
			{
				FTransformDouble portalWorldTransform2 = portal.PortalWorldTransform1;
				FTransformDouble ftransformDouble = portal.PortalWorldTransform2;
				portalOutTf = ftransformDouble;
				portalInTf = portalWorldTransform2;
			}
			return this.GetMappingPosByPortalTransform(mapFromPos, portalInTf, portalOutTf, outPos, enableDebug);
		}

		// Token: 0x0602DD97 RID: 187799 RVA: 0x00A8AD04 File Offset: 0x00A88F04
		public Vector GetMappingPosByPortalTransform(Vector mapFromPos, FTransformDouble portalInTf, FTransformDouble portalOutTf, Vector outPos, bool enableDebug = false)
		{
			FVectorDouble fvectorDouble = mapFromPos.ToUeVector(false);
			FVectorDouble fvectorDouble2 = portalInTf.InverseTransformPosition(fvectorDouble);
			FVectorDouble fvectorDouble3 = this.PortalRotateTf.TransformPosition(fvectorDouble2);
			FVectorDouble end = portalOutTf.TransformPosition(fvectorDouble3);
			outPos.DeepCopy(end);
			if (enableDebug)
			{
				this.DrawDebugArrow(portalInTf.GetLocation(), mapFromPos.ToUeVector(false), this.DebugColorCyan);
				this.DrawDebugArrow(portalOutTf.GetLocation(), end, this.DebugColorGreen);
			}
			return outPos;
		}

		// Token: 0x0602DD98 RID: 187800 RVA: 0x00A8AD78 File Offset: 0x00A88F78
		public Vector GetMappingVecByPortalTransform(Vector mapFromVec, FTransformDouble portalInTf, FTransformDouble portalOutTf, Vector outVec, bool enableDebug = false)
		{
			FVectorDouble fvectorDouble = mapFromVec.ToUeVector(false);
			FVectorDouble fvectorDouble2 = portalInTf.InverseTransformVector(fvectorDouble);
			FVectorDouble fvectorDouble3 = this.PortalRotateTf.TransformVector(fvectorDouble2);
			FVectorDouble fvectorDouble4 = portalOutTf.TransformVector(fvectorDouble3);
			outVec.DeepCopy(fvectorDouble4);
			if (enableDebug)
			{
				FVectorDouble location = portalInTf.GetLocation();
				FVectorDouble location2 = portalOutTf.GetLocation();
				FVectorDouble fvectorDouble5 = portalInTf.TransformVector(fvectorDouble3);
				this.DrawDebugDirection(location, mapFromVec, this.DebugColorCyan, 120f);
				this.DrawDebugArrow(location, new FVectorDouble(location.X + fvectorDouble5.X, location.Y + fvectorDouble5.Y, location.Z + fvectorDouble5.Z), this.DebugColorYellow);
				this.DrawDebugArrow(location2, new FVectorDouble(location2.X + fvectorDouble4.X, location2.Y + fvectorDouble4.Y, location2.Z + fvectorDouble4.Z), this.DebugColorGreen);
			}
			return outVec;
		}

		// Token: 0x0602DD99 RID: 187801 RVA: 0x00A8AE70 File Offset: 0x00A89070
		public FTransformDouble? GetMappingTransformToOtherPortal(FTransformDouble mapFromTf, long portalId, bool bA2B)
		{
			if (portalId == 0L)
			{
				return new FTransformDouble?(mapFromTf);
			}
			BP_Portal_C portal = PortalModel.Instance.GetPortal(portalId);
			if (portal == null || !portal.Portal1Enable || !portal.Portal2Enable)
			{
				return null;
			}
			FTransformDouble portalOutTf;
			FTransformDouble portalInTf;
			if (!bA2B)
			{
				FTransformDouble portalWorldTransform = portal.PortalWorldTransform2;
				FTransformDouble ftransformDouble = portal.PortalWorldTransform1;
				portalOutTf = ftransformDouble;
				portalInTf = portalWorldTransform;
			}
			else
			{
				FTransformDouble portalWorldTransform2 = portal.PortalWorldTransform1;
				FTransformDouble ftransformDouble = portal.PortalWorldTransform2;
				portalOutTf = ftransformDouble;
				portalInTf = portalWorldTransform2;
			}
			return new FTransformDouble?(this.GetMappingTransformByPortalTransform(mapFromTf, portalInTf, portalOutTf, false));
		}

		// Token: 0x0602DD9A RID: 187802 RVA: 0x00A8AEEC File Offset: 0x00A890EC
		public FTransformDouble GetMappingTransformByPortalTransform(FTransformDouble mapFromTf, FTransformDouble portalInTf, FTransformDouble portalOutTf, bool enableDebug = false)
		{
			FTransformDouble relativeTransform = mapFromTf.GetRelativeTransform(portalInTf);
			FTransformDouble ftransformDouble = relativeTransform * portalOutTf;
			if (enableDebug)
			{
				this.DrawDebugTransform(portalInTf, 80f, 5f);
				this.DrawDebugTransform(portalOutTf, 80f, 5f);
				this.DrawDebugTransform(mapFromTf, 60f, 5f);
				this.DrawDebugTransform(ftransformDouble, 100f, 5f);
				this.DrawDebugArrow(mapFromTf.GetLocation(), ftransformDouble.GetLocation(), this.DebugColorGreen);
			}
			return ftransformDouble;
		}

		// Token: 0x0602DD9B RID: 187803 RVA: 0x00A8AF70 File Offset: 0x00A89170
		[NullableContext(2)]
		public FTransformDouble? GetMappingOffsetTransformToOtherPortal(FTransformDouble mapFromTf, long portalId, bool bA2B, IVector mapFromOffsetDir = null, float offset = 0f, bool enableGroundFix = false, bool enableDebug = false)
		{
			if (portalId == 0L)
			{
				return new FTransformDouble?(mapFromTf);
			}
			BP_Portal_C portal = PortalModel.Instance.GetPortal(portalId);
			if (portal == null || !portal.Portal1Enable || !portal.Portal2Enable)
			{
				return null;
			}
			FTransformDouble ftransformDouble2;
			FTransformDouble ftransformDouble3;
			if (!bA2B)
			{
				FTransformDouble portalWorldTransform = portal.PortalWorldTransform2;
				FTransformDouble ftransformDouble = portal.PortalWorldTransform1;
				ftransformDouble2 = ftransformDouble;
				ftransformDouble3 = portalWorldTransform;
			}
			else
			{
				FTransformDouble portalWorldTransform2 = portal.PortalWorldTransform1;
				FTransformDouble ftransformDouble = portal.PortalWorldTransform2;
				ftransformDouble2 = ftransformDouble;
				ftransformDouble3 = portalWorldTransform2;
			}
			return this.GetMappingOffsetTransformByPortalTransform(mapFromTf, ftransformDouble3, ftransformDouble2, null, mapFromOffsetDir, offset, enableGroundFix, enableDebug);
		}

		// Token: 0x0602DD9C RID: 187804 RVA: 0x00A8AFF4 File Offset: 0x00A891F4
		[NullableContext(2)]
		public FTransformDouble? GetMappingOffsetTransformByPortalTransform(in FTransformDouble mapFromTf, in FTransformDouble portalInTf, in FTransformDouble portalOutTf, IVector portalOutGravityDirect = null, IVector mapFromOffsetDir = null, float offset = 0f, bool enableGroundFix = false, bool enableDebug = false)
		{
			if (portalOutGravityDirect == null)
			{
				portalOutGravityDirect = Vector.DownVectorProxy;
			}
			FTransformDouble mappingTransformByPortalTransform = this.GetMappingTransformByPortalTransform(mapFromTf, portalInTf, portalOutTf, enableDebug);
			Vector tempTargetTfUpVec = this.TempTargetTfUpVec;
			tempTargetTfUpVec.FromConfigVector(portalOutGravityDirect);
			tempTargetTfUpVec.UnaryNegation(tempTargetTfUpVec);
			tempTargetTfUpVec.GetSafeNormal(tempTargetTfUpVec, 9.99999993922529E-09);
			Vector tempSourceForwardVec = this.TempSourceForwardVec;
			Quat.Create(mapFromTf.GetRotation()).GetForwardVector(tempSourceForwardVec);
			Vector tempSourceRightVec = this.TempSourceRightVec;
			Quat.Create(mapFromTf.GetRotation()).GetRightVector(tempSourceRightVec);
			Vector tempMappedForwardVec = this.TempMappedForwardVec;
			this.GetMappingVecByPortalTransform(tempSourceForwardVec, portalInTf, portalOutTf, tempMappedForwardVec, false);
			tempMappedForwardVec.GetSafeNormal(tempMappedForwardVec, 9.99999993922529E-09);
			Vector tempMappedRightVec = this.TempMappedRightVec;
			this.GetMappingVecByPortalTransform(tempSourceRightVec, portalInTf, portalOutTf, tempMappedRightVec, false);
			tempMappedRightVec.GetSafeNormal(tempMappedRightVec, 9.99999993922529E-09);
			Vector tempProjectedForwardVec = this.TempProjectedForwardVec;
			this.GravityPlaneProjection(tempMappedForwardVec, tempTargetTfUpVec, tempProjectedForwardVec);
			Vector tempProjectedRightVec = this.TempProjectedRightVec;
			this.GravityPlaneProjection(tempMappedRightVec, tempTargetTfUpVec, tempProjectedRightVec);
			Quat quat = Quat.Create(mappingTransformByPortalTransform.GetRotation());
			if (tempProjectedForwardVec.SizeSquared() > tempProjectedRightVec.SizeSquared())
			{
				MathUtils.Instance.LookRotationForwardFirst(tempProjectedForwardVec, tempTargetTfUpVec, quat);
			}
			else
			{
				Vector tempNewForwardVec = this.TempNewForwardVec;
				tempProjectedRightVec.CrossProduct(tempTargetTfUpVec, tempNewForwardVec);
				MathUtils.Instance.LookRotationForwardFirst(tempNewForwardVec, tempTargetTfUpVec, quat);
			}
			FQuat fquat = quat.ToUeQuat();
			mappingTransformByPortalTransform.SetRotation(fquat);
			if (mapFromOffsetDir != null && offset != 0f)
			{
				this.AddMappedOffset(ref mappingTransformByPortalTransform, portalInTf, portalOutTf, tempTargetTfUpVec, tempMappedForwardVec, mapFromOffsetDir, offset, enableDebug);
			}
			if (enableGroundFix)
			{
				this.TryFixUndergroundByProjectedGravityColumn(ref mappingTransformByPortalTransform, portalOutTf, portalOutGravityDirect, enableDebug);
			}
			return new FTransformDouble?(mappingTransformByPortalTransform);
		}

		// Token: 0x0602DD9D RID: 187805 RVA: 0x00A8B1A8 File Offset: 0x00A893A8
		private void AddMappedOffset(ref FTransformDouble mapToTf, in FTransformDouble portalInTf, in FTransformDouble portalOutTf, Vector upVec, Vector fallbackDir, IVector mapFromOffsetDir, float offset, bool enableDebug)
		{
			Vector tempMapFromOffsetDirVec = this.TempMapFromOffsetDirVec;
			tempMapFromOffsetDirVec.FromUeVector(mapFromOffsetDir);
			Vector tempMappedOffsetDirVec = this.TempMappedOffsetDirVec;
			this.GetMappingVecByPortalTransform(tempMapFromOffsetDirVec, portalInTf, portalOutTf, tempMappedOffsetDirVec, false);
			Vector tempOffsetDirOnUpPlaneVec = this.TempOffsetDirOnUpPlaneVec;
			this.GravityPlaneProjection(tempMappedOffsetDirVec, upVec, tempOffsetDirOnUpPlaneVec);
			tempOffsetDirOnUpPlaneVec.GetSafeNormal(tempOffsetDirOnUpPlaneVec, 9.99999993922529E-09);
			Vector vector = tempOffsetDirOnUpPlaneVec.IsNearlyZero(9.999999747378752E-05) ? fallbackDir : tempOffsetDirOnUpPlaneVec;
			Vector tempOffsetVec = this.TempOffsetVec;
			vector.Multiply((double)offset, tempOffsetVec);
			FVectorDouble location = mapToTf.GetLocation();
			FVectorDouble fvectorDouble = new FVectorDouble(tempOffsetVec.X, tempOffsetVec.Y, tempOffsetVec.Z);
			mapToTf.AddToTranslation(fvectorDouble);
			if (enableDebug)
			{
				this.DrawDebugDirection(location, vector, this.DebugColorOrange, 120f);
				this.DrawDebugSphere(mapToTf.GetLocation(), this.DebugColorOrange, 22f, 5f);
			}
		}

		// Token: 0x0602DD9E RID: 187806 RVA: 0x00A8B290 File Offset: 0x00A89490
		private void TryFixUndergroundByProjectedGravityColumn(ref FTransformDouble mapToTf, FTransformDouble portalOutTf, IVector portalOutGravityDirect, bool enableDebug)
		{
			Vector tempGroundFixGravityDir = this.TempGroundFixGravityDir;
			tempGroundFixGravityDir.FromConfigVector(portalOutGravityDirect);
			if (!tempGroundFixGravityDir.Normalize(9.99999993922529E-09))
			{
				return;
			}
			Vector tempGroundFixPortalOutLocation = this.TempGroundFixPortalOutLocation;
			Vector vector = tempGroundFixPortalOutLocation;
			FVectorDouble fvectorDouble = portalOutTf.GetLocation();
			vector.FromUeVector(fvectorDouble);
			Vector tempGroundFixMapToLocation = this.TempGroundFixMapToLocation;
			Vector vector2 = tempGroundFixMapToLocation;
			fvectorDouble = mapToTf.GetLocation();
			vector2.FromUeVector(fvectorDouble);
			Vector tempGroundFixOffsetVec = this.TempGroundFixOffsetVec;
			tempGroundFixMapToLocation.Subtraction(tempGroundFixPortalOutLocation, tempGroundFixOffsetVec);
			double num = tempGroundFixOffsetVec.DotProduct(tempGroundFixGravityDir);
			if (num <= 25.0)
			{
				return;
			}
			Vector tempGroundFixTraceStart = this.TempGroundFixTraceStart;
			this.GravityPlaneProjection(tempGroundFixOffsetVec, tempGroundFixGravityDir, tempGroundFixTraceStart);
			tempGroundFixTraceStart.AdditionEqual(tempGroundFixPortalOutLocation);
			Vector tempGroundFixTraceEnd = this.TempGroundFixTraceEnd;
			tempGroundFixGravityDir.Multiply(num, tempGroundFixTraceEnd);
			tempGroundFixTraceEnd.AdditionEqual(tempGroundFixTraceStart);
			UTraceLineElement lineTrace = TraceElementModel.Instance.GetLineTrace();
			lineTrace.WorldContextObject = GlobalData.World;
			lineTrace.ActorsToIgnore.Empty(true);
			TraceElementCommon.Instance.SetStartLocation(lineTrace, tempGroundFixTraceStart);
			TraceElementCommon.Instance.SetEndLocation(lineTrace, tempGroundFixTraceEnd);
			if (enableDebug)
			{
				lineTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
				this.DrawDebugSphere(tempGroundFixTraceStart.ToUeVector(false), this.DebugColorLightBlue, 14f, 5f);
				this.DrawDebugSphere(mapToTf.GetLocation(), this.DebugColorRed, 16f, 5f);
				this.DrawDebugLine(tempGroundFixTraceStart.ToUeVector(false), tempGroundFixTraceEnd.ToUeVector(false), this.DebugColorLightBlue, 5f);
			}
			bool flag = TraceElementCommon.Instance.LineTrace(lineTrace, "PortalUtils.TryFixUndergroundByProjectedGravityColumn");
			UKuroHitResult hitResult = lineTrace.HitResult;
			lineTrace.ClearCacheData(false);
			if (!flag || (hitResult == null || !hitResult.bBlockingHit))
			{
				return;
			}
			Vector tempGroundFixHitPoint = this.TempGroundFixHitPoint;
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, tempGroundFixHitPoint);
			tempGroundFixGravityDir.Multiply(25.0, this.TempGroundFixGravityProjection);
			tempGroundFixHitPoint.Subtraction(this.TempGroundFixGravityProjection, tempGroundFixMapToLocation);
			fvectorDouble = tempGroundFixMapToLocation.ToUeVector(false);
			mapToTf.SetLocation(fvectorDouble);
			if (enableDebug)
			{
				this.DrawDebugSphere(tempGroundFixHitPoint.ToUeVector(false), this.DebugColorYellow, 18f, 5f);
				this.DrawDebugSphere(mapToTf.GetLocation(), this.DebugColorMintGreen, 20f, 5f);
				this.DrawDebugLine(tempGroundFixHitPoint.ToUeVector(false), mapToTf.GetLocation(), this.DebugColorMintGreen, 5f);
			}
		}

		// Token: 0x0602DD9F RID: 187807 RVA: 0x00A8B4D8 File Offset: 0x00A896D8
		public bool UpdateCaptureCamera(Transform playerCameraTrans, FTransformDouble sourcePortalWorld, FTransformDouble targetPortalWorld, FVector sourcePortalBounds, USceneCaptureComponent2D capture, bool enableDebug = false)
		{
			capture.bUseCustomProjectionMatrix = false;
			Transform tmpCaptureT = this.TmpCaptureT1;
			this.GetMappingCameraTransformToOtherPortal(playerCameraTrans, sourcePortalWorld, targetPortalWorld, tmpCaptureT);
			tmpCaptureT.GetScale3D().Set(1.0, 1.0, 1.0);
			Transform tmpCaptureT2 = this.TmpCaptureT2;
			tmpCaptureT2.FromUeTransform(targetPortalWorld);
			Vector tmpCaptureV = this.TmpCaptureV1;
			tmpCaptureV.FromUeVector(sourcePortalBounds);
			tmpCaptureT2.GetScale3D().Multiply(tmpCaptureV, tmpCaptureV);
			FTransformDouble ftransformDouble = UKismetMathLibrary.MakeTransformDouble(tmpCaptureT2.GetLocation().ToUeVector(false), tmpCaptureT2.GetRotation().Rotator(null).ToUeRotator(), Vector.OneVector);
			FVectorDouble fvectorDouble = tmpCaptureT.GetLocation().ToUeVector(false);
			FVectorDouble fvectorDouble2 = ftransformDouble.InverseTransformPosition(fvectorDouble);
			if (fvectorDouble2.X >= 0.0)
			{
				return false;
			}
			double num = (fvectorDouble2.Y > 0.0) ? (-tmpCaptureV.Y) : tmpCaptureV.Y;
			double num2 = (fvectorDouble2.Z > 0.0) ? (-tmpCaptureV.Z) : tmpCaptureV.Z;
			double num3 = -fvectorDouble2.X;
			double num4 = num - fvectorDouble2.Y;
			double num5 = num2 - fvectorDouble2.Z;
			double num6 = num3 * num3 + num4 * num4;
			if (num6 <= 9.999999747378752E-05)
			{
				return false;
			}
			double num7 = Math.Sqrt(num6);
			double num8 = Math.Atan2(num4, num3) - Math.Asin(MathCommon.Clamp(num / num7, -1.0, 1.0));
			double num9 = Math.Cos(num8);
			double num10 = Math.Sin(num8);
			double num11 = num9;
			double num12 = num10;
			double inX = -num10;
			double inY = num9;
			double num13 = num3 * num11 + num4 * num12;
			double num14 = num13 * num13 + num5 * num5;
			if (num14 <= 9.999999747378752E-05)
			{
				return false;
			}
			double num15 = Math.Sqrt(num14);
			double num16 = Math.Atan2(num5, num13) - Math.Asin(MathCommon.Clamp(num2 / num15, -1.0, 1.0));
			double num17 = Math.Cos(num16);
			double num18 = Math.Sin(num16);
			double num19 = num17 * num11;
			double num20 = num17 * num12;
			double num21 = num18;
			double inX2 = -num18 * num11;
			double inY2 = -num18 * num12;
			double inZ = num17;
			double num22 = num3 * num19 + num4 * num20 + num5 * num21;
			if (num22 <= 9.999999747378752E-05)
			{
				return false;
			}
			double num23 = Math.Max(tmpCaptureV.Y / num22, 9.999999747378752E-05);
			double num24 = Math.Max(tmpCaptureV.Z / num22, 9.999999747378752E-05);
			double num25 = Math.Atan(num23) * 57.295780181884766;
			FRotator rotation = UKismetMathLibrary.D_MakeRotationFromAxes(new FVectorDouble(num19, num20, num21), new FVectorDouble(inX, inY, 0.0), new FVectorDouble(inX2, inY2, inZ));
			FRotator rotation2 = UKismetMathLibrary.D_TransformRotation(ftransformDouble, rotation);
			FTransformDouble captureTransform = UKismetMathLibrary.MakeTransformDouble(tmpCaptureT.GetLocation().ToUeVector(false), rotation2, Vector.OneVector);
			capture.D_K2_SetWorldTransform(captureTransform, false, ref WorldGlobal.SweepHitResult, true);
			capture.FOVAngle = (float)(num25 * 2.0);
			capture.CustomAspectRatio = (float)(num23 / num24);
			capture.bUseCustomAspectRatio = true;
			capture.CustomNearClippingPlane = (float)num22;
			if (enableDebug)
			{
				this.DrawCaptureDebug(playerCameraTrans, sourcePortalWorld, targetPortalWorld, captureTransform, num22, 0.0, 0.0, tmpCaptureV.Y, tmpCaptureV.Z);
			}
			return true;
		}

		// Token: 0x0602DDA0 RID: 187808 RVA: 0x00A8B834 File Offset: 0x00A89A34
		public bool UpdateCaptureCameraOffAxis(Transform playerCameraTrans, FTransformDouble sourcePortalWorld, FTransformDouble targetPortalWorld, FVector sourcePortalBounds, USceneCaptureComponent2D capture, bool enableDebug = false)
		{
			Transform tmpOffAxisCamTrans = this.TmpOffAxisCamTrans;
			this.GetMappingCameraTransformToOtherPortal(playerCameraTrans, sourcePortalWorld, targetPortalWorld, tmpOffAxisCamTrans);
			Transform tmpOffAxisTargetTrans = this.TmpOffAxisTargetTrans;
			tmpOffAxisTargetTrans.FromUeTransform(targetPortalWorld);
			Vector tmpOffAxisBounds = this.TmpOffAxisBounds;
			tmpOffAxisBounds.FromUeVector(sourcePortalBounds);
			tmpOffAxisTargetTrans.GetScale3D().Multiply(tmpOffAxisBounds, tmpOffAxisBounds);
			FTransformDouble captureTransform = UKismetMathLibrary.MakeTransformDouble(tmpOffAxisCamTrans.GetLocation().ToUeVector(false), tmpOffAxisCamTrans.GetRotation().Rotator(null).ToUeRotator(), Vector.OneVector);
			FVectorDouble fvectorDouble = tmpOffAxisTargetTrans.GetLocation().ToUeVector(false);
			FVectorDouble fvectorDouble2 = captureTransform.InverseTransformPosition(fvectorDouble);
			double x = fvectorDouble2.X;
			if (x <= 9.999999747378752E-05)
			{
				return false;
			}
			double num = fvectorDouble2.Y / x;
			double num2 = fvectorDouble2.Z / x;
			double num3 = Math.Max(tmpOffAxisBounds.Y / x, 0.0001);
			double num4 = Math.Max(tmpOffAxisBounds.Z / x, 0.0001);
			double num5 = num - num3;
			double num6 = num + num3;
			double num7 = num2 - num4;
			double num8 = num2 + num4;
			capture.D_K2_SetWorldTransform(captureTransform, false, ref WorldGlobal.SweepHitResult, true);
			if (enableDebug)
			{
				this.DrawCaptureDebug(playerCameraTrans, sourcePortalWorld, targetPortalWorld, captureTransform, x, fvectorDouble2.Y, fvectorDouble2.Z, tmpOffAxisBounds.Y, tmpOffAxisBounds.Z);
			}
			return UKuroRenderingRuntimeBPPluginBPLibrary.SetSceneCaptureOffAxisProjection(capture, (float)num5, (float)num6, (float)num7, (float)num8, (float)x);
		}

		// Token: 0x0602DDA1 RID: 187809 RVA: 0x00A8B988 File Offset: 0x00A89B88
		public void GetMappingCameraTransformToOtherPortal(Transform playerCameraTrans, FTransformDouble sourcePortalWorld, FTransformDouble targetPortalWorld, Transform outTf)
		{
			FTransformDouble relativeTransform = playerCameraTrans.ToUeTransform().GetRelativeTransform(sourcePortalWorld);
			FTransformDouble ftransformDouble = relativeTransform * this.PortalRotateTf;
			FTransformDouble ftransformDouble2 = ftransformDouble * targetPortalWorld;
			Vector location = outTf.GetLocation();
			FVectorDouble location2 = ftransformDouble2.GetLocation();
			location.FromUeVector(location2);
			outTf.GetRotation().FromUeQuat(targetPortalWorld.GetRotation());
			outTf.GetScale3D().Set(1.0, 1.0, 1.0);
		}

		// Token: 0x0602DDA2 RID: 187810 RVA: 0x00A8BA10 File Offset: 0x00A89C10
		public EPortalCaptureLevel ComputeCapturePerformanceLevel(bool portalEnabled, Transform playerCameraTrans, FTransformDouble portalWorldTransform, [Nullable(2)] PortalCapturePerformanceConfig config = null)
		{
			if (!portalEnabled)
			{
				return EPortalCaptureLevel.VeryLow;
			}
			if (config == null)
			{
				config = this.DefaultCapturePerformanceConfig;
			}
			PortalPlatformCaptureConfig portalPlatformCaptureConfig = (PortalUtils.GetCurrentPlatform() == EPortalPlatform.Mobile) ? config.Mobile : config.Pc;
			Transform tmpCaptureT = this.TmpCaptureT3;
			tmpCaptureT.FromUeTransform(portalWorldTransform);
			double num = Vector.Distance(playerCameraTrans.GetLocation(), tmpCaptureT.GetLocation());
			Dictionary<EPortalCaptureLevel, double> levelMinDist = portalPlatformCaptureConfig.LevelMinDist;
			if (num > levelMinDist.GetValueOrDefault(EPortalCaptureLevel.VeryLow, 0.0))
			{
				return EPortalCaptureLevel.VeryLow;
			}
			if (num > levelMinDist.GetValueOrDefault(EPortalCaptureLevel.Low, 0.0))
			{
				return EPortalCaptureLevel.Low;
			}
			if (num > levelMinDist.GetValueOrDefault(EPortalCaptureLevel.Mid, 0.0))
			{
				return EPortalCaptureLevel.Mid;
			}
			return EPortalCaptureLevel.High;
		}

		// Token: 0x0602DDA3 RID: 187811 RVA: 0x00A8BAB0 File Offset: 0x00A89CB0
		[NullableContext(2)]
		public FSceneCaptureComponent2DParams ApplyCapturePerformance([Nullable(1)] USceneCaptureComponent2D capture, EPortalCaptureLevel configLevel, float captureMaxViewDistance, PortalCapturePerformanceConfig config = null)
		{
			if (config == null)
			{
				config = this.DefaultCapturePerformanceConfig;
			}
			FSceneCaptureComponent2DParams fsceneCaptureComponent2DParams;
			if (!((PortalUtils.GetCurrentPlatform() == EPortalPlatform.Mobile) ? config.Mobile : config.Pc).CaptureParams.TryGetValue(configLevel, out fsceneCaptureComponent2DParams))
			{
				return null;
			}
			FSceneCaptureComponent2DParams fsceneCaptureComponent2DParams2 = new FSceneCaptureComponent2DParams(fsceneCaptureComponent2DParams.CaptureInterval, fsceneCaptureComponent2DParams.CaptureMaxRTSize, fsceneCaptureComponent2DParams.CaptureMaxRTSizeXScale, fsceneCaptureComponent2DParams.CaptureMaxRTSizeYScale, fsceneCaptureComponent2DParams.MaxViewDistanceOverride, fsceneCaptureComponent2DParams.bEnableCapture, fsceneCaptureComponent2DParams.bCaptureSkeletal, fsceneCaptureComponent2DParams.bCaptureDynamicShadows, fsceneCaptureComponent2DParams.bCaptureParticles);
			if (Info.Instance.IsMacPlatform())
			{
				fsceneCaptureComponent2DParams2.bCaptureParticles = false;
			}
			fsceneCaptureComponent2DParams2.MaxViewDistanceOverride = captureMaxViewDistance;
			capture.UpdateCaptureParams(fsceneCaptureComponent2DParams2, false);
			return fsceneCaptureComponent2DParams2;
		}

		// Token: 0x0602DDA4 RID: 187812 RVA: 0x00A8BB52 File Offset: 0x00A89D52
		private static EPortalPlatform GetCurrentPlatform()
		{
			if (!Info.Instance.IsMobilePlatform())
			{
				return EPortalPlatform.Pc;
			}
			return EPortalPlatform.Mobile;
		}

		// Token: 0x0602DDA5 RID: 187813 RVA: 0x00A8BB63 File Offset: 0x00A89D63
		private void GravityPlaneProjection(Vector v, Vector up, Vector outV)
		{
			up.Multiply(v.DotProduct(up), this.TempProjectionScratch);
			v.Subtraction(this.TempProjectionScratch, outV);
		}

		// Token: 0x17007553 RID: 30035
		// (get) Token: 0x0602DDA6 RID: 187814 RVA: 0x00A8BB87 File Offset: 0x00A89D87
		public static PortalUtils Instance
		{
			get
			{
				if (PortalUtils._instance == null)
				{
					PortalUtils._instance = new PortalUtils();
					PortalUtils._instance.OnInit();
				}
				return PortalUtils._instance;
			}
		}

		// Token: 0x0602DDA7 RID: 187815 RVA: 0x00A8BBAA File Offset: 0x00A89DAA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DDA8 RID: 187816 RVA: 0x00A8BBAC File Offset: 0x00A89DAC
		public static void ResetStaticDefaultValue()
		{
			PortalUtils instance = PortalUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PortalUtils._instance = null;
		}

		// Token: 0x0602DDA9 RID: 187817 RVA: 0x00A8BBC5 File Offset: 0x00A89DC5
		static PortalUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PortalUtils.CreateStaticDefaultValue), new Action(PortalUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0602DDAA RID: 187818 RVA: 0x00A8BBE4 File Offset: 0x00A89DE4
		public PortalUtils()
		{
			FQuat fquat = new FQuat(ref Vector.ZAxisVector, 3.1415927f);
			this.PortalRotateTf = new FTransformDouble(ref fquat);
			this.TempTargetTfUpVec = Vector.Create();
			this.TempSourceForwardVec = Vector.Create();
			this.TempSourceRightVec = Vector.Create();
			this.TempMappedForwardVec = Vector.Create();
			this.TempMappedRightVec = Vector.Create();
			this.TempProjectedForwardVec = Vector.Create();
			this.TempProjectedRightVec = Vector.Create();
			this.TempNewForwardVec = Vector.Create();
			this.TempProjectionScratch = Vector.Create();
			this.TempMapFromOffsetDirVec = Vector.Create();
			this.TempMappedOffsetDirVec = Vector.Create();
			this.TempOffsetDirOnUpPlaneVec = Vector.Create();
			this.TempOffsetVec = Vector.Create();
			this.TempGroundFixGravityDir = Vector.Create();
			this.TempGroundFixPortalOutLocation = Vector.Create();
			this.TempGroundFixMapToLocation = Vector.Create();
			this.TempGroundFixOffsetVec = Vector.Create();
			this.TempGroundFixGravityProjection = Vector.Create();
			this.TempGroundFixTraceStart = Vector.Create();
			this.TempGroundFixTraceEnd = Vector.Create();
			this.TempGroundFixHitPoint = Vector.Create();
			this.TmpCaptureV1 = Vector.Create();
			this.TmpCaptureT1 = Transform.Create();
			this.TmpCaptureT2 = Transform.Create();
			this.TmpCaptureT3 = Transform.Create();
			this.TmpOffAxisCamTrans = Transform.Create();
			this.TmpOffAxisTargetTrans = Transform.Create();
			this.TmpOffAxisBounds = Vector.Create();
			this.DebugColorCyan = new FLinearColor(0f, 1f, 1f, 1f);
			this.DebugColorGreen = new FLinearColor(0f, 1f, 0f, 1f);
			this.DebugColorOrange = new FLinearColor(1f, 0.5f, 0f, 1f);
			this.DebugColorLightBlue = new FLinearColor(0.2f, 0.8f, 1f, 1f);
			this.DebugColorRed = new FLinearColor(1f, 0.3f, 0.3f, 1f);
			this.DebugColorYellow = new FLinearColor(1f, 1f, 0f, 1f);
			this.DebugColorMintGreen = new FLinearColor(0f, 1f, 0.2f, 1f);
			base..ctor();
		}

		// Token: 0x040187B7 RID: 100279
		private const float PORTAL_DEBUG_DURATION = 5f;

		// Token: 0x040187B8 RID: 100280
		private const float PORTAL_CAPTURE_DEBUG_DURATION = 0f;

		// Token: 0x040187B9 RID: 100281
		private const float PORTAL_DEBUG_THICKNESS = 2f;

		// Token: 0x040187BA RID: 100282
		private const float PORTAL_DEBUG_AXIS_SCALE = 80f;

		// Token: 0x040187BB RID: 100283
		private const float PORTAL_DEBUG_ARROW_SCALE = 120f;

		// Token: 0x040187BC RID: 100284
		private const float GROUND_FIX_LIFT_DISTANCE = 25f;

		// Token: 0x040187BD RID: 100285
		private const float GROUND_FIX_MIN_TRACE_DISTANCE = 25f;

		// Token: 0x040187BE RID: 100286
		private const float CAPTURE_MIN_TAN_HALF_FOV = 0.0001f;

		// Token: 0x040187BF RID: 100287
		private const double CAPTURE_MIN_HALF_TAN = 0.0001;

		// Token: 0x040187C0 RID: 100288
		private readonly FTransformDouble PortalRotateTf;

		// Token: 0x040187C1 RID: 100289
		private readonly Vector TempTargetTfUpVec;

		// Token: 0x040187C2 RID: 100290
		private readonly Vector TempSourceForwardVec;

		// Token: 0x040187C3 RID: 100291
		private readonly Vector TempSourceRightVec;

		// Token: 0x040187C4 RID: 100292
		private readonly Vector TempMappedForwardVec;

		// Token: 0x040187C5 RID: 100293
		private readonly Vector TempMappedRightVec;

		// Token: 0x040187C6 RID: 100294
		private readonly Vector TempProjectedForwardVec;

		// Token: 0x040187C7 RID: 100295
		private readonly Vector TempProjectedRightVec;

		// Token: 0x040187C8 RID: 100296
		private readonly Vector TempNewForwardVec;

		// Token: 0x040187C9 RID: 100297
		private readonly Vector TempProjectionScratch;

		// Token: 0x040187CA RID: 100298
		private readonly Vector TempMapFromOffsetDirVec;

		// Token: 0x040187CB RID: 100299
		private readonly Vector TempMappedOffsetDirVec;

		// Token: 0x040187CC RID: 100300
		private readonly Vector TempOffsetDirOnUpPlaneVec;

		// Token: 0x040187CD RID: 100301
		private readonly Vector TempOffsetVec;

		// Token: 0x040187CE RID: 100302
		private readonly Vector TempGroundFixGravityDir;

		// Token: 0x040187CF RID: 100303
		private readonly Vector TempGroundFixPortalOutLocation;

		// Token: 0x040187D0 RID: 100304
		private readonly Vector TempGroundFixMapToLocation;

		// Token: 0x040187D1 RID: 100305
		private readonly Vector TempGroundFixOffsetVec;

		// Token: 0x040187D2 RID: 100306
		private readonly Vector TempGroundFixGravityProjection;

		// Token: 0x040187D3 RID: 100307
		private readonly Vector TempGroundFixTraceStart;

		// Token: 0x040187D4 RID: 100308
		private readonly Vector TempGroundFixTraceEnd;

		// Token: 0x040187D5 RID: 100309
		private readonly Vector TempGroundFixHitPoint;

		// Token: 0x040187D6 RID: 100310
		private readonly Vector TmpCaptureV1;

		// Token: 0x040187D7 RID: 100311
		private readonly Transform TmpCaptureT1;

		// Token: 0x040187D8 RID: 100312
		private readonly Transform TmpCaptureT2;

		// Token: 0x040187D9 RID: 100313
		private readonly Transform TmpCaptureT3;

		// Token: 0x040187DA RID: 100314
		private readonly Transform TmpOffAxisCamTrans;

		// Token: 0x040187DB RID: 100315
		private readonly Transform TmpOffAxisTargetTrans;

		// Token: 0x040187DC RID: 100316
		private readonly Vector TmpOffAxisBounds;

		// Token: 0x040187DD RID: 100317
		private readonly FLinearColor DebugColorCyan;

		// Token: 0x040187DE RID: 100318
		private readonly FLinearColor DebugColorGreen;

		// Token: 0x040187DF RID: 100319
		private readonly FLinearColor DebugColorOrange;

		// Token: 0x040187E0 RID: 100320
		private readonly FLinearColor DebugColorLightBlue;

		// Token: 0x040187E1 RID: 100321
		private readonly FLinearColor DebugColorRed;

		// Token: 0x040187E2 RID: 100322
		private readonly FLinearColor DebugColorYellow;

		// Token: 0x040187E3 RID: 100323
		private readonly FLinearColor DebugColorMintGreen;

		// Token: 0x040187E4 RID: 100324
		[Nullable(2)]
		private PortalCapturePerformanceConfig DefaultCapturePerformanceConfigInstance;

		// Token: 0x040187E5 RID: 100325
		[Nullable(2)]
		private static PortalUtils _instance;
	}
}
