using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Portal;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using UnrealEngine;

namespace CSharpScript.Game.Utils
{
	// Token: 0x0200347B RID: 13435
	[NullableContext(1)]
	[Nullable(0)]
	public class PortalUtils : Singleton
	{
		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x06022470 RID: 140400 RVA: 0x009B5CA0 File Offset: 0x009B3EA0
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
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 1000000f,
								CaptureMaxRTSize = 64,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = false,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = true
							}
						},
						{
							EPortalCaptureLevel.Low,
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 0.033333f,
								CaptureMaxRTSize = 256,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = true,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = true
							}
						},
						{
							EPortalCaptureLevel.Mid,
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 0.033333f,
								CaptureMaxRTSize = 512,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = true,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = true
							}
						},
						{
							EPortalCaptureLevel.High,
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 0.016667f,
								CaptureMaxRTSize = 1024,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = true,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = true
							}
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
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 1000000f,
								CaptureMaxRTSize = 64,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = false,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = false
							}
						},
						{
							EPortalCaptureLevel.Low,
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 0.066667f,
								CaptureMaxRTSize = 128,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = true,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = false
							}
						},
						{
							EPortalCaptureLevel.Mid,
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 0.066667f,
								CaptureMaxRTSize = 256,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = true,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = true
							}
						},
						{
							EPortalCaptureLevel.High,
							new FSceneCaptureComponent2DParams
							{
								CaptureInterval = 0.066667f,
								CaptureMaxRTSize = 256,
								CaptureMaxRTSizeXScale = 1,
								CaptureMaxRTSizeYScale = 1,
								MaxViewDistanceOverride = 2000f,
								bEnableCapture = true,
								bCaptureSkeletal = false,
								bCaptureDynamicShadows = false,
								bCaptureParticles = true
							}
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

		// Token: 0x06022471 RID: 140401 RVA: 0x009B5FF8 File Offset: 0x009B41F8
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

		// Token: 0x06022472 RID: 140402 RVA: 0x009B60D8 File Offset: 0x009B42D8
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

		// Token: 0x06022473 RID: 140403 RVA: 0x009B62AC File Offset: 0x009B44AC
		private void DrawDebugSphere(FVectorDouble position, FLinearColor color, float radius = 18f, float duration = 5f)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, position, radius, 12, new FLinearColor?(color), duration, 2f);
		}

		// Token: 0x06022474 RID: 140404 RVA: 0x009B62C9 File Offset: 0x009B44C9
		private void DrawDebugArrow(FVectorDouble start, FVectorDouble end, FLinearColor color)
		{
			UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, start, end, 24f, color, 5f, 2f);
		}

		// Token: 0x06022475 RID: 140405 RVA: 0x009B62E8 File Offset: 0x009B44E8
		private void DrawDebugDirection(FVectorDouble start, IVector direction, FLinearColor color, float scale = 120f)
		{
			FVectorDouble end = new FVectorDouble(start.X + direction.X * (double)scale, start.Y + direction.Y * (double)scale, start.Z + direction.Z * (double)scale);
			this.DrawDebugArrow(start, end, color);
		}

		// Token: 0x06022476 RID: 140406 RVA: 0x009B6338 File Offset: 0x009B4538
		private void DrawDebugTransform(FTransformDouble transform, float scale = 80f, float duration = 5f)
		{
			UKismetSystemLibrary.D_DrawDebugCoordinateSystem(GlobalData.World, transform.GetLocation(), transform.Rotator(), scale, duration, 2f);
		}

		// Token: 0x06022477 RID: 140407 RVA: 0x009B6359 File Offset: 0x009B4559
		private void DrawDebugLine(FVectorDouble start, FVectorDouble end, FLinearColor color, float duration = 5f)
		{
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.World, start, end, color, duration, 2f);
		}

		// Token: 0x06022478 RID: 140408 RVA: 0x009B6370 File Offset: 0x009B4570
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

		// Token: 0x06022479 RID: 140409 RVA: 0x009B63E4 File Offset: 0x009B45E4
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

		// Token: 0x0602247A RID: 140410 RVA: 0x009B6458 File Offset: 0x009B4658
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

		// Token: 0x0602247B RID: 140411 RVA: 0x009B6550 File Offset: 0x009B4750
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

		// Token: 0x0602247C RID: 140412 RVA: 0x009B65CC File Offset: 0x009B47CC
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

		// Token: 0x0602247D RID: 140413 RVA: 0x009B6650 File Offset: 0x009B4850
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

		// Token: 0x0602247E RID: 140414 RVA: 0x009B66D4 File Offset: 0x009B48D4
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

		// Token: 0x0602247F RID: 140415 RVA: 0x009B6888 File Offset: 0x009B4A88
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

		// Token: 0x06022480 RID: 140416 RVA: 0x009B6970 File Offset: 0x009B4B70
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

		// Token: 0x06022481 RID: 140417 RVA: 0x009B6BB8 File Offset: 0x009B4DB8
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

		// Token: 0x06022482 RID: 140418 RVA: 0x009B6F14 File Offset: 0x009B5114
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

		// Token: 0x06022483 RID: 140419 RVA: 0x009B7068 File Offset: 0x009B5268
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

		// Token: 0x06022484 RID: 140420 RVA: 0x009B70F0 File Offset: 0x009B52F0
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

		// Token: 0x06022485 RID: 140421 RVA: 0x009B7190 File Offset: 0x009B5390
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
			FSceneCaptureComponent2DParams fsceneCaptureComponent2DParams2 = new FSceneCaptureComponent2DParams
			{
				CaptureInterval = fsceneCaptureComponent2DParams.CaptureInterval,
				CaptureMaxRTSize = fsceneCaptureComponent2DParams.CaptureMaxRTSize,
				CaptureMaxRTSizeXScale = fsceneCaptureComponent2DParams.CaptureMaxRTSizeXScale,
				CaptureMaxRTSizeYScale = fsceneCaptureComponent2DParams.CaptureMaxRTSizeYScale,
				MaxViewDistanceOverride = fsceneCaptureComponent2DParams.MaxViewDistanceOverride,
				bEnableCapture = fsceneCaptureComponent2DParams.bEnableCapture,
				bCaptureSkeletal = fsceneCaptureComponent2DParams.bCaptureSkeletal,
				bCaptureDynamicShadows = fsceneCaptureComponent2DParams.bCaptureDynamicShadows,
				bCaptureParticles = fsceneCaptureComponent2DParams.bCaptureParticles
			};
			if (Info.Instance.IsMacPlatform())
			{
				fsceneCaptureComponent2DParams2.bCaptureParticles = false;
			}
			fsceneCaptureComponent2DParams2.MaxViewDistanceOverride = captureMaxViewDistance;
			capture.UpdateCaptureParams(fsceneCaptureComponent2DParams2, false);
			return fsceneCaptureComponent2DParams2;
		}

		// Token: 0x06022486 RID: 140422 RVA: 0x009B7268 File Offset: 0x009B5468
		private static EPortalPlatform GetCurrentPlatform()
		{
			if (!Info.Instance.IsMobilePlatform())
			{
				return EPortalPlatform.Pc;
			}
			return EPortalPlatform.Mobile;
		}

		// Token: 0x06022487 RID: 140423 RVA: 0x009B7279 File Offset: 0x009B5479
		private void GravityPlaneProjection(Vector v, Vector up, Vector outV)
		{
			up.Multiply(v.DotProduct(up), this.TempProjectionScratch);
			v.Subtraction(this.TempProjectionScratch, outV);
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x06022488 RID: 140424 RVA: 0x009B729D File Offset: 0x009B549D
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

		// Token: 0x06022489 RID: 140425 RVA: 0x009B72C0 File Offset: 0x009B54C0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602248A RID: 140426 RVA: 0x009B72C2 File Offset: 0x009B54C2
		public static void ResetStaticDefaultValue()
		{
			PortalUtils instance = PortalUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			PortalUtils._instance = null;
		}

		// Token: 0x0602248B RID: 140427 RVA: 0x009B72DB File Offset: 0x009B54DB
		static PortalUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PortalUtils.CreateStaticDefaultValue), new Action(PortalUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0602248C RID: 140428 RVA: 0x009B72FC File Offset: 0x009B54FC
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

		// Token: 0x04012DF1 RID: 77297
		private const float PORTAL_DEBUG_DURATION = 5f;

		// Token: 0x04012DF2 RID: 77298
		private const float PORTAL_CAPTURE_DEBUG_DURATION = 0f;

		// Token: 0x04012DF3 RID: 77299
		private const float PORTAL_DEBUG_THICKNESS = 2f;

		// Token: 0x04012DF4 RID: 77300
		private const float PORTAL_DEBUG_AXIS_SCALE = 80f;

		// Token: 0x04012DF5 RID: 77301
		private const float PORTAL_DEBUG_ARROW_SCALE = 120f;

		// Token: 0x04012DF6 RID: 77302
		private const float GROUND_FIX_LIFT_DISTANCE = 25f;

		// Token: 0x04012DF7 RID: 77303
		private const float GROUND_FIX_MIN_TRACE_DISTANCE = 25f;

		// Token: 0x04012DF8 RID: 77304
		private const float CAPTURE_MIN_TAN_HALF_FOV = 0.0001f;

		// Token: 0x04012DF9 RID: 77305
		private const double CAPTURE_MIN_HALF_TAN = 0.0001;

		// Token: 0x04012DFA RID: 77306
		private readonly FTransformDouble PortalRotateTf;

		// Token: 0x04012DFB RID: 77307
		private readonly Vector TempTargetTfUpVec;

		// Token: 0x04012DFC RID: 77308
		private readonly Vector TempSourceForwardVec;

		// Token: 0x04012DFD RID: 77309
		private readonly Vector TempSourceRightVec;

		// Token: 0x04012DFE RID: 77310
		private readonly Vector TempMappedForwardVec;

		// Token: 0x04012DFF RID: 77311
		private readonly Vector TempMappedRightVec;

		// Token: 0x04012E00 RID: 77312
		private readonly Vector TempProjectedForwardVec;

		// Token: 0x04012E01 RID: 77313
		private readonly Vector TempProjectedRightVec;

		// Token: 0x04012E02 RID: 77314
		private readonly Vector TempNewForwardVec;

		// Token: 0x04012E03 RID: 77315
		private readonly Vector TempProjectionScratch;

		// Token: 0x04012E04 RID: 77316
		private readonly Vector TempMapFromOffsetDirVec;

		// Token: 0x04012E05 RID: 77317
		private readonly Vector TempMappedOffsetDirVec;

		// Token: 0x04012E06 RID: 77318
		private readonly Vector TempOffsetDirOnUpPlaneVec;

		// Token: 0x04012E07 RID: 77319
		private readonly Vector TempOffsetVec;

		// Token: 0x04012E08 RID: 77320
		private readonly Vector TempGroundFixGravityDir;

		// Token: 0x04012E09 RID: 77321
		private readonly Vector TempGroundFixPortalOutLocation;

		// Token: 0x04012E0A RID: 77322
		private readonly Vector TempGroundFixMapToLocation;

		// Token: 0x04012E0B RID: 77323
		private readonly Vector TempGroundFixOffsetVec;

		// Token: 0x04012E0C RID: 77324
		private readonly Vector TempGroundFixGravityProjection;

		// Token: 0x04012E0D RID: 77325
		private readonly Vector TempGroundFixTraceStart;

		// Token: 0x04012E0E RID: 77326
		private readonly Vector TempGroundFixTraceEnd;

		// Token: 0x04012E0F RID: 77327
		private readonly Vector TempGroundFixHitPoint;

		// Token: 0x04012E10 RID: 77328
		private readonly Vector TmpCaptureV1;

		// Token: 0x04012E11 RID: 77329
		private readonly Transform TmpCaptureT1;

		// Token: 0x04012E12 RID: 77330
		private readonly Transform TmpCaptureT2;

		// Token: 0x04012E13 RID: 77331
		private readonly Transform TmpCaptureT3;

		// Token: 0x04012E14 RID: 77332
		private readonly Transform TmpOffAxisCamTrans;

		// Token: 0x04012E15 RID: 77333
		private readonly Transform TmpOffAxisTargetTrans;

		// Token: 0x04012E16 RID: 77334
		private readonly Vector TmpOffAxisBounds;

		// Token: 0x04012E17 RID: 77335
		private readonly FLinearColor DebugColorCyan;

		// Token: 0x04012E18 RID: 77336
		private readonly FLinearColor DebugColorGreen;

		// Token: 0x04012E19 RID: 77337
		private readonly FLinearColor DebugColorOrange;

		// Token: 0x04012E1A RID: 77338
		private readonly FLinearColor DebugColorLightBlue;

		// Token: 0x04012E1B RID: 77339
		private readonly FLinearColor DebugColorRed;

		// Token: 0x04012E1C RID: 77340
		private readonly FLinearColor DebugColorYellow;

		// Token: 0x04012E1D RID: 77341
		private readonly FLinearColor DebugColorMintGreen;

		// Token: 0x04012E1E RID: 77342
		[Nullable(2)]
		private PortalCapturePerformanceConfig DefaultCapturePerformanceConfigInstance;

		// Token: 0x04012E1F RID: 77343
		[Nullable(2)]
		private static PortalUtils _instance;
	}
}
