using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.UI.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072E2 RID: 29410
	[NullableContext(1)]
	[Nullable(0)]
	public class SettlementCamera
	{
		// Token: 0x060482E0 RID: 295648 RVA: 0x012876C9 File Offset: 0x012858C9
		public void Init(FightCameraLogicComponent camera)
		{
			this.Camera = camera;
			this.CameraSphereTrace = new UTraceSphereElement
			{
				bIsSingle = false,
				bTraceComplex = false,
				bIgnoreSelf = true
			};
		}

		// Token: 0x060482E1 RID: 295649 RVA: 0x012876F4 File Offset: 0x012858F4
		private void SetSettlementCamera(EDynamicSettlementType settlementConfigType)
		{
			SSettlementCamera dataTableRowFromName = DataTableUtil.GetDataTableRowFromName<SSettlementCamera>(EDataTable.FightSettlementCamera, settlementConfigType.ToEnumString());
			if (dataTableRowFromName == null)
			{
				global::Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "无结算镜头配置数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.SettlementCameraConfig = dataTableRowFromName;
			this.CameraModifier = dataTableRowFromName.CameraModifier;
			this.CameraModifierArmLength = this.CameraModifier.Settings.ArmLength;
			if (this.CameraModifierArmLength < 100f)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】臂长配置过小:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierArmLength);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(100);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierArmLength = 100f;
			}
			this.CameraModifierPitchMin = this.SettlementCameraConfig.MinRandomPitch;
			if (this.CameraModifierPitchMin > 90f || this.CameraModifierPitchMin < -90f)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】最小Pitch配置不正确:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierPitchMin);
				defaultInterpolatedStringHandler.AppendLiteral(",合理区间为(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(-90);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(90);
				defaultInterpolatedStringHandler.AppendLiteral("),将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(-5);
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierPitchMin = -5f;
			}
			this.CameraModifierPitchMax = this.SettlementCameraConfig.MaxRandomPitch;
			if (this.CameraModifierPitchMax > 90f || this.CameraModifierPitchMax < -90f)
			{
				global::Log instance3 = global::Log.Instance;
				ELogModule module3 = ELogModule.Camera;
				ELogAuthor author3 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】最大Pitch配置不正确:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierPitchMax);
				defaultInterpolatedStringHandler.AppendLiteral(",合理区间为(");
				defaultInterpolatedStringHandler.AppendFormatted<int>(-90);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<int>(90);
				defaultInterpolatedStringHandler.AppendLiteral("),将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(-8);
				instance3.Error(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierPitchMax = -8f;
			}
			this.CameraModifierTopAdditionZ = this.SettlementCameraConfig.TopAdditionZ;
			if (this.CameraModifierTopAdditionZ < 50f)
			{
				global::Log instance4 = global::Log.Instance;
				ELogModule module4 = ELogModule.Camera;
				ELogAuthor author4 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】探测合法值上限叠加值过小:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierTopAdditionZ);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(50);
				instance4.Error(module4, author4, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierTopAdditionZ = 50f;
			}
			this.CameraModifierBottomAdditionZ = this.SettlementCameraConfig.BottomAdditionZ;
			if (this.CameraModifierBottomAdditionZ < 50f)
			{
				global::Log instance5 = global::Log.Instance;
				ELogModule module5 = ELogModule.Camera;
				ELogAuthor author5 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】探测合法值下限叠加值过小:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierBottomAdditionZ);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(50);
				instance5.Error(module5, author5, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierBottomAdditionZ = 50f;
			}
			this.CameraModifierLeftYawRangeMin = this.SettlementCameraConfig.LeftMinYawRange;
			this.CameraModifierLeftYawRangeMax = this.SettlementCameraConfig.LeftMaxYawRange;
			if (this.CameraModifierLeftYawRangeMin < -180f)
			{
				global::Log instance6 = global::Log.Instance;
				ELogModule module6 = ELogModule.Camera;
				ELogAuthor author6 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】左侧Yaw区间合法值最小值过小:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierLeftYawRangeMin);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(-180);
				instance6.Error(module6, author6, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierLeftYawRangeMin = -180f;
			}
			if (this.CameraModifierLeftYawRangeMax > 0f)
			{
				global::Log instance7 = global::Log.Instance;
				ELogModule module7 = ELogModule.Camera;
				ELogAuthor author7 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】左侧Yaw区间合法值最大值过大:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierLeftYawRangeMax);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(0);
				instance7.Error(module7, author7, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierLeftYawRangeMax = 0f;
			}
			if (this.CameraModifierLeftYawRangeMax < this.CameraModifierLeftYawRangeMin)
			{
				global::Log instance8 = global::Log.Instance;
				ELogModule module8 = ELogModule.Camera;
				ELogAuthor author8 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】左侧Yaw区间合法值最小值大于最大值,最小值:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierLeftYawRangeMin);
				defaultInterpolatedStringHandler.AppendLiteral(",最大值:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierLeftYawRangeMax);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为,最小值:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(-180);
				defaultInterpolatedStringHandler.AppendLiteral(",最大值:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(0);
				instance8.Error(module8, author8, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierLeftYawRangeMin = -180f;
				this.CameraModifierLeftYawRangeMax = 0f;
			}
			this.CameraModifierRightYawRangeMin = this.SettlementCameraConfig.RightMinYawRange;
			this.CameraModifierRightYawRangeMax = this.SettlementCameraConfig.RightMaxYawRange;
			if (this.CameraModifierRightYawRangeMin < 0f)
			{
				global::Log instance9 = global::Log.Instance;
				ELogModule module9 = ELogModule.Camera;
				ELogAuthor author9 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】右侧Yaw区间合法值最小值过小:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierRightYawRangeMin);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(0);
				instance9.Error(module9, author9, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierRightYawRangeMin = 0f;
			}
			if (this.CameraModifierRightYawRangeMax > 180f)
			{
				global::Log instance10 = global::Log.Instance;
				ELogModule module10 = ELogModule.Camera;
				ELogAuthor author10 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(30, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】右侧Yaw区间合法值最大值过大:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierRightYawRangeMax);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(180);
				instance10.Error(module10, author10, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierRightYawRangeMax = 180f;
			}
			if (this.CameraModifierRightYawRangeMax < this.CameraModifierRightYawRangeMin)
			{
				global::Log instance11 = global::Log.Instance;
				ELogModule module11 = ELogModule.Camera;
				ELogAuthor author11 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(51, 4);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】右侧Yaw区间合法值最小值大于最大值,最小值:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierRightYawRangeMin);
				defaultInterpolatedStringHandler.AppendLiteral(",最大值:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierRightYawRangeMax);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为,最小值:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(0);
				defaultInterpolatedStringHandler.AppendLiteral(",最大值:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(180);
				instance11.Error(module11, author11, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierRightYawRangeMin = 0f;
				this.CameraModifierRightYawRangeMax = 180f;
			}
			this.CameraModifierValidRangeMin = this.SettlementCameraConfig.MinValidYawRange;
			if (this.CameraModifierValidRangeMin < 0f)
			{
				global::Log instance12 = global::Log.Instance;
				ELogModule module12 = ELogModule.Camera;
				ELogAuthor author12 = ELogAuthor.LJM;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 2);
				defaultInterpolatedStringHandler.AppendLiteral("【结算镜头】最小合法区间过小:");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.CameraModifierValidRangeMin);
				defaultInterpolatedStringHandler.AppendLiteral(",将自动修正为:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(0);
				instance12.Error(module12, author12, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifierValidRangeMin = 0f;
			}
			if (StringUtils.IsEmpty(this.CameraModifier.Settings.ModifySettingsAdditional.Name))
			{
				global::Log.Instance.Error(ELogModule.Camera, ELogAuthor.LJM, "【结算镜头】没有配置CameraModifier名称，将自动修正为 SettlementCamera", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.CameraModifier.Settings.ModifySettingsAdditional.Name = "SettlementCamera";
			}
			Vector cameraModifierCharacterOffset = this.CameraModifierCharacterOffset;
			FVector characterOffset = this.SettlementCameraConfig.CharacterOffset;
			FVectorDouble fvectorDouble = characterOffset;
			cameraModifierCharacterOffset.DeepCopy(fvectorDouble);
		}

		// Token: 0x060482E2 RID: 295650 RVA: 0x01287E88 File Offset: 0x01286088
		public void PlaySettlementCamera(EDynamicSettlementType settlementType)
		{
			if (CameraController.Instance.IsSequenceCameraInCinematic(this.Camera.CameraModel.CameraName))
			{
				return;
			}
			if (this.Camera.ContainsTag(SettlementCamera.BanSettlementCamera, false))
			{
				return;
			}
			this.SetSettlementCamera(settlementType);
			if (this.SettlementCameraConfig == null || this.CameraModifier == null)
			{
				return;
			}
			this.PlayerYaw = this.Camera.PlayerRotatorInGravity.Yaw;
			this.PlayerLocation = this.Camera.PlayerLocation;
			this.CameraSphereRadius = Math.Max(this.Camera.FinalCameraDistance, this.CameraModifierArmLength);
			this.CameraSphereTrace.bTraceComplex = false;
			UKuroHitResult hitResult = this.CameraSphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			this.CameraSphereTrace.WorldContextObject = GlobalData.World;
			this.CameraSphereTrace.Radius = this.CameraSphereRadius;
			this.CameraSphereTrace.ActorsToIgnore.Add(this.Camera.Character);
			this.CameraSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Camera);
			this.CameraSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			this.CameraSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			this.CameraSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
			TraceElementCommon.Instance.SetStartLocation(this.CameraSphereTrace, this.Camera.PlayerLocation);
			TraceElementCommon.Instance.SetEndLocation(this.CameraSphereTrace, this.Camera.PlayerLocation);
			TraceElementCommon.Instance.SphereTrace(this.CameraSphereTrace, "FightCameraLogicComponent_TraceValidRange_Camera");
			this.UpdateRotator(this.CameraSphereTrace.HitResult);
			this.PlaySettlementCameraInternal();
			BP_EventManager_C bpEventManager = GlobalData.BpEventManager;
			if (bpEventManager.IsValid())
			{
				bpEventManager.当触发结算镜头时.Broadcast();
			}
		}

		// Token: 0x060482E3 RID: 295651 RVA: 0x01288047 File Offset: 0x01286247
		public void UpdateRotator(UKuroHitResult hitResult)
		{
			this.UpdateHitActorMap(hitResult);
			this.UpdateInvalidYawRangeArray(hitResult);
			this.UpdateValidYawRangeArray();
			this.UpdateFinalRotator();
		}

		// Token: 0x060482E4 RID: 295652 RVA: 0x01288064 File Offset: 0x01286264
		public void UpdateFinalRotator()
		{
			this.TmpYawRange.Clear();
			foreach (SettlementCamera.YawRange yawRange in this.LeftYawRangeArray)
			{
				if (yawRange.Max - yawRange.Min > this.CameraModifierValidRangeMin)
				{
					this.TmpYawRange.Add(yawRange);
				}
			}
			foreach (SettlementCamera.YawRange yawRange2 in this.RightYawRangeArray)
			{
				if (yawRange2.Max - yawRange2.Min > this.CameraModifierValidRangeMin)
				{
					this.TmpYawRange.Add(yawRange2);
				}
			}
			if (this.TmpYawRange.Count > 0)
			{
				SettlementCamera.YawRange randomArrayItem = ObjectUtils.GetRandomArrayItem<SettlementCamera.YawRange>(this.TmpYawRange);
				double num = (double)(MathUtils.Instance.Lerp(randomArrayItem.Min, randomArrayItem.Max, MathUtils.Instance.Random.NextSingle()) + this.PlayerYaw);
				this.FinalRotator.Pitch = MathUtils.Instance.Lerp(this.CameraModifierPitchMin, this.CameraModifierPitchMax, MathUtils.Instance.Random.NextSingle());
				this.FinalRotator.Yaw = (float)MathCommon.WrapAngle(num + 180.0);
				this.FinalRotator.Roll = 0f;
				return;
			}
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.CameraForward.ToOrientationRotator(this.FinalRotator);
				return;
			}
			CameraUtility.GetVectorInGravity(this.Camera.CameraForward, this.TmpVector);
			this.TmpVector.Rotation(this.FinalRotator);
		}

		// Token: 0x060482E5 RID: 295653 RVA: 0x01288230 File Offset: 0x01286430
		public void PlaySettlementCameraInternal()
		{
			CameraController.Instance.StopAllCameraShakes();
			this.FinalRotator.SubtractionEqual(this.Camera.PlayerRotatorInGravity);
			this.CameraModifier.Settings.ArmRotation = new FRotator(this.FinalRotator.Pitch, this.FinalRotator.Yaw, this.FinalRotator.Roll);
			this.CameraModifier.Settings.ModifySettingsAdditional.ArmOffset.Set((float)this.CameraModifierCharacterOffset.X, (float)this.CameraModifierCharacterOffset.Y, (float)this.CameraModifierCharacterOffset.Z);
			this.Camera.CameraModifyController.ApplyCameraModify(null, this.CameraModifier.Duration, this.CameraModifier.BlendInTime, this.CameraModifier.BlendOutTime, this.CameraModifier.BreakBlendOutTime, this.CameraModifier.Settings, null, new OneOf<CurveBase, SBaseCurve>(this.CameraModifier.BlendInCurve), new OneOf<CurveBase, SBaseCurve>(this.CameraModifier.BlendOutCurve), this.Camera.Character, "HitCase", default(OneOf<TsBaseCharacter, TsBaseVehicle>));
		}

		// Token: 0x060482E6 RID: 295654 RVA: 0x01288368 File Offset: 0x01286568
		public bool IsPlayingSettlementCamera()
		{
			return this.Camera.CameraModifyController.IsModified && !(this.CameraModifier == null) && this.Camera.CameraModifyController.ModifySettings.Name == this.CameraModifier.Settings.ModifySettingsAdditional.Name;
		}

		// Token: 0x060482E7 RID: 295655 RVA: 0x012883C8 File Offset: 0x012865C8
		[NullableContext(2)]
		private unsafe void UpdateHitActorMap(UKuroHitResult hitResult)
		{
			this.ActorHitResultIndexMap.Clear();
			this.ActorHitResultIndexArrayMap.Clear();
			this.HitResultIndexRadiusMap.Clear();
			if (hitResult == null)
			{
				return;
			}
			int hitCount = hitResult.GetHitCount();
			double num = this.Camera.PlayerLocationInGravity.Z + (double)this.CameraModifierTopAdditionZ;
			double num2 = this.Camera.PlayerLocationInGravity.Z - (double)this.CameraModifierBottomAdditionZ;
			for (int i = 0; i < hitCount; i++)
			{
				AActor aactor = hitResult.Actors.Get(i);
				if (aactor != null)
				{
					TArray<TWeakObjectPtr<UPrimitiveComponent>> components = hitResult.Components;
					TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr = (components != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components.Get(i)) : null;
					USceneComponent usceneComponent = (tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null;
					if (usceneComponent != null)
					{
						TraceElementCommon.Instance.GetImpactPoint(this.CameraSphereTrace.HitResult, i, this.TmpVector);
						double num3 = (double)CameraUtility.GetZnInGravity(this.TmpVector);
						if (num3 >= num2 && num3 <= num)
						{
							if (usceneComponent is UStaticMeshComponent)
							{
								if (!this.ActorHitResultIndexMap.TryAdd(aactor, i))
								{
									int index = this.ActorHitResultIndexMap[aactor];
									TraceElementCommon.Instance.GetImpactPoint(this.CameraSphereTrace.HitResult, index, this.TmpVector2);
									double num4 = Vector.DistSquared(this.TmpVector, this.Camera.PlayerLocation);
									if (Vector.DistSquared(this.TmpVector2, this.Camera.PlayerLocation) < num4)
									{
										this.ActorHitResultIndexMap[aactor] = i;
									}
								}
							}
							else
							{
								UShapeComponent ushapeComponent = usceneComponent as UShapeComponent;
								if (ushapeComponent != null && (double)this.GetShapeComponentRadius(ushapeComponent) > 30.0)
								{
									List<int> list;
									if (!this.ActorHitResultIndexArrayMap.TryGetValue(aactor, out list))
									{
										Dictionary<AActor, List<int>> actorHitResultIndexArrayMap = this.ActorHitResultIndexArrayMap;
										AActor key = aactor;
										int num5 = 1;
										List<int> list2 = new List<int>(num5);
										CollectionsMarshal.SetCount<int>(list2, num5);
										Span<int> span = CollectionsMarshal.AsSpan<int>(list2);
										int index2 = 0;
										*span[index2] = i;
										actorHitResultIndexArrayMap[key] = list2;
									}
									else
									{
										list.Add(i);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060482E8 RID: 295656 RVA: 0x012885E0 File Offset: 0x012867E0
		[NullableContext(0)]
		private ValueTuple<double, double> GetActorBoundExtent(FTransformDouble transform, [Nullable(1)] UStaticMeshComponent staticMeshComponent)
		{
			FVector fvector = default(FVector);
			staticMeshComponent.GetLocalBounds(ref fvector, ref this.Extent);
			double item = (double)(this.Extent.X * transform.GetScale3D().X);
			double item2 = (double)(this.Extent.Y * transform.GetScale3D().Y);
			return new ValueTuple<double, double>(item, item2);
		}

		// Token: 0x060482E9 RID: 295657 RVA: 0x0128863C File Offset: 0x0128683C
		private void UpdateInvalidYawRangeArray(UKuroHitResult hitResult)
		{
			this.InvalidYawRangeArray.Clear();
			foreach (KeyValuePair<AActor, int> keyValuePair in this.ActorHitResultIndexMap)
			{
				AActor key = keyValuePair.Key;
				int value = keyValuePair.Value;
				TArray<TWeakObjectPtr<UPrimitiveComponent>> components = hitResult.Components;
				TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr = (components != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components.Get(value)) : null;
				USceneComponent usceneComponent = (tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null;
				if (usceneComponent != null)
				{
					TraceElementCommon.Instance.GetImpactPoint(hitResult, value, this.TmpVector);
					this.InvalidYawRangeArray.Add(this.GetStaticMeshInvalidYawRange(key.D_GetTransform(), usceneComponent as UStaticMeshComponent, this.TmpVector));
				}
			}
			Comparison<int> <>9__0;
			foreach (KeyValuePair<AActor, List<int>> keyValuePair2 in this.ActorHitResultIndexArrayMap)
			{
				List<int> value2 = keyValuePair2.Value;
				List<int> list = value2;
				Comparison<int> comparison;
				if ((comparison = <>9__0) == null)
				{
					comparison = (<>9__0 = delegate(int a, int b)
					{
						TArray<TWeakObjectPtr<UPrimitiveComponent>> components3 = hitResult.Components;
						TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr2 = (components3 != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components3.Get(a)) : null;
						USceneComponent usceneComponent3 = (tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null;
						TArray<TWeakObjectPtr<UPrimitiveComponent>> components4 = hitResult.Components;
						tweakObjectPtr2 = ((components4 != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components4.Get(b)) : null);
						USceneComponent usceneComponent4 = (tweakObjectPtr2 != null) ? tweakObjectPtr2.GetValueOrDefault() : null;
						if (usceneComponent4 == null)
						{
							return -1;
						}
						if (usceneComponent3 == null)
						{
							return 1;
						}
						double value3 = (double)this.GetHitComponentRadius(usceneComponent3 as UShapeComponent, a);
						return ((double)this.GetHitComponentRadius(usceneComponent4 as UShapeComponent, b)).CompareTo(value3);
					});
				}
				list.Sort(comparison);
				int num = 0;
				while (num < value2.Count && num < 4)
				{
					TArray<TWeakObjectPtr<UPrimitiveComponent>> components2 = hitResult.Components;
					TWeakObjectPtr<UPrimitiveComponent>? tweakObjectPtr = (components2 != null) ? new TWeakObjectPtr<UPrimitiveComponent>?(components2.Get(value2[num])) : null;
					USceneComponent usceneComponent2 = (tweakObjectPtr != null) ? tweakObjectPtr.GetValueOrDefault() : null;
					if (usceneComponent2 != null)
					{
						this.InvalidYawRangeArray.Add(this.GetShapeInvalidYawRange(usceneComponent2 as UShapeComponent, value2[num]));
					}
					num++;
				}
			}
		}

		// Token: 0x060482EA RID: 295658 RVA: 0x01288844 File Offset: 0x01286A44
		private SettlementCamera.YawRange GetShapeInvalidYawRange(UShapeComponent hitComponent, int hitComponentIndex)
		{
			Vector tmpVector = this.TmpVector;
			FVectorDouble fvectorDouble = hitComponent.D_K2_GetComponentLocation();
			tmpVector.DeepCopy(fvectorDouble);
			float cameraSphereRadius = this.CameraSphereRadius;
			float hitComponentRadius = this.GetHitComponentRadius(hitComponent, hitComponentIndex);
			float num = (float)Vector.Dist2D(this.Camera.PlayerLocation, this.TmpVector);
			float num2 = this.ConvertPointToAngle(this.TmpVector);
			float num3;
			if (num < cameraSphereRadius)
			{
				num3 = (float)Math.Atan((double)(hitComponentRadius / num));
			}
			else
			{
				num3 = (float)MathUtils.Instance.GetObliqueTriangleAngle((double)cameraSphereRadius, (double)num, (double)hitComponentRadius);
			}
			num3 *= 57.29578f;
			return new SettlementCamera.YawRange(num2 - num3, num2 + num3);
		}

		// Token: 0x060482EB RID: 295659 RVA: 0x012888D4 File Offset: 0x01286AD4
		private SettlementCamera.YawRange GetStaticMeshInvalidYawRange(FTransformDouble hitTransform, UStaticMeshComponent hitComponent, Vector impactPoint)
		{
			FVectorDouble fvectorDouble = this.PlayerLocation.ToUeVector(false);
			FVectorDouble fvectorDouble2 = hitTransform.InverseTransformPositionNoScale(fvectorDouble);
			fvectorDouble = impactPoint.ToUeVector(false);
			FVectorDouble fvectorDouble3 = hitTransform.InverseTransformPositionNoScale(fvectorDouble);
			double num = (double)this.CameraSphereRadius;
			ValueTuple<double, double> actorBoundExtent = this.GetActorBoundExtent(hitTransform, hitComponent);
			double item = actorBoundExtent.Item1;
			double item2 = actorBoundExtent.Item2;
			Vector vector = Vector.Create();
			Vector vector2 = Vector.Create();
			if (fvectorDouble2.Y >= -item2 && fvectorDouble2.Y <= item2)
			{
				double num2 = item2 + fvectorDouble2.Y;
				double num3 = item2 - fvectorDouble2.Y;
				double num4 = fvectorDouble3.X - fvectorDouble2.X;
				double num5;
				if (num2 * num2 + num4 * num4 > num * num)
				{
					num5 = fvectorDouble2.Y - Math.Sqrt(num * num - num4 * num4);
				}
				else
				{
					num5 = fvectorDouble2.Y - num2;
				}
				double num6;
				if (num3 * num3 + num4 * num4 > num * num)
				{
					num6 = fvectorDouble2.Y + Math.Sqrt(num * num - num4 * num4);
				}
				else
				{
					num6 = fvectorDouble2.Y + num3;
				}
				vector.X = fvectorDouble3.X;
				vector.Y = (double)((float)((fvectorDouble2.X <= 0.0) ? num5 : num6));
				vector.Z = fvectorDouble3.Z;
				vector2.X = fvectorDouble3.X;
				vector2.Y = (double)((float)((fvectorDouble2.X > 0.0) ? num5 : num6));
				vector2.Z = fvectorDouble3.Z;
			}
			else if (fvectorDouble2.X >= -item && fvectorDouble2.X <= item)
			{
				double num7 = item - fvectorDouble2.X;
				double num8 = item + fvectorDouble2.X;
				double num9 = fvectorDouble3.Y - fvectorDouble2.Y;
				double num5;
				if (num7 * num7 + num9 * num9 > num * num)
				{
					num5 = fvectorDouble2.X - Math.Sqrt(num * num - num9 * num9);
				}
				else
				{
					num5 = fvectorDouble2.X - num7;
				}
				double num6;
				if (num8 * num8 + num9 * num9 > num * num)
				{
					num6 = fvectorDouble2.X + Math.Sqrt(num * num - num9 * num9);
				}
				else
				{
					num6 = fvectorDouble2.X + num8;
				}
				vector.X = ((fvectorDouble2.Y <= 0.0) ? num5 : num6);
				vector.Y = (double)((float)fvectorDouble3.Y);
				vector.Z = fvectorDouble3.Z;
				vector2.X = ((fvectorDouble2.Y > 0.0) ? num5 : num6);
				vector2.Y = (double)((float)fvectorDouble3.Y);
				vector2.Z = fvectorDouble3.Z;
			}
			else if (fvectorDouble2.Y < -item2 && fvectorDouble2.X < -item)
			{
				double num10 = item - fvectorDouble2.X;
				double num11 = item2 - fvectorDouble2.Y;
				double num12 = fvectorDouble3.X - fvectorDouble2.X;
				double num13 = fvectorDouble3.Y - fvectorDouble2.Y;
				double num5;
				if (num10 * num10 + num13 * num13 > num * num)
				{
					num5 = fvectorDouble2.X + Math.Sqrt(num * num - num13 * num13);
				}
				else
				{
					num5 = fvectorDouble2.X + num10;
				}
				double num6;
				if (num11 * num11 + num12 * num12 > num * num)
				{
					num6 = fvectorDouble2.Y + Math.Sqrt(num * num - num12 * num12);
				}
				else
				{
					num6 = fvectorDouble2.Y + num11;
				}
				vector.X = num5;
				vector.Y = (double)((float)fvectorDouble3.Y);
				vector.Z = fvectorDouble3.Z;
				vector2.X = fvectorDouble3.X;
				vector2.Y = (double)((float)num6);
				vector2.Z = fvectorDouble3.Z;
			}
			else if (fvectorDouble2.Y > item2 && fvectorDouble2.X < -item)
			{
				double num14 = item - fvectorDouble2.X;
				double num15 = item2 + fvectorDouble2.Y;
				double num16 = fvectorDouble3.X - fvectorDouble2.X;
				double num17 = fvectorDouble3.Y - fvectorDouble2.Y;
				double num5;
				if (num14 * num14 + num17 * num17 > num * num)
				{
					num5 = fvectorDouble2.X + Math.Sqrt(num * num - num17 * num17);
				}
				else
				{
					num5 = fvectorDouble2.X + num14;
				}
				double num6;
				if (num15 * num15 + num16 * num16 > num * num)
				{
					num6 = fvectorDouble2.Y - Math.Sqrt(num * num - num16 * num16);
				}
				else
				{
					num6 = fvectorDouble2.Y - num15;
				}
				vector2.X = num5;
				vector2.Y = (double)((float)fvectorDouble3.Y);
				vector2.Z = fvectorDouble3.Z;
				vector.X = fvectorDouble3.X;
				vector.Y = (double)((float)num6);
				vector.Z = fvectorDouble3.Z;
			}
			else if (fvectorDouble2.Y < -item2 && fvectorDouble2.X > item)
			{
				double num18 = item + fvectorDouble2.X;
				double num19 = item2 - fvectorDouble2.Y;
				double num20 = fvectorDouble3.X - fvectorDouble2.X;
				double num21 = fvectorDouble3.Y - fvectorDouble2.Y;
				double num5;
				if (num18 * num18 + num21 * num21 > num * num)
				{
					num5 = fvectorDouble2.X - Math.Sqrt(num * num - num21 * num21);
				}
				else
				{
					num5 = fvectorDouble2.X - num18;
				}
				double num6;
				if (num19 * num19 + num20 * num20 > num * num)
				{
					num6 = fvectorDouble2.Y + Math.Sqrt(num * num - num20 * num20);
				}
				else
				{
					num6 = fvectorDouble2.Y + num19;
				}
				vector.X = fvectorDouble3.X;
				vector.Y = (double)((float)num6);
				vector.Z = fvectorDouble3.Z;
				vector2.X = num5;
				vector2.Y = (double)((float)fvectorDouble3.Y);
				vector2.Z = fvectorDouble3.Z;
			}
			else if (fvectorDouble2.Y > item2 && fvectorDouble2.X > item)
			{
				double num22 = item + fvectorDouble2.X;
				double num23 = item2 + fvectorDouble2.Y;
				double num24 = fvectorDouble3.X - fvectorDouble2.X;
				double num25 = fvectorDouble3.Y - fvectorDouble2.Y;
				double num5;
				if (num22 * num22 + num25 * num25 > num * num)
				{
					num5 = fvectorDouble2.X - Math.Sqrt(num * num - num25 * num25);
				}
				else
				{
					num5 = fvectorDouble2.X - num22;
				}
				double num6;
				if (num23 * num23 + num24 * num24 > num * num)
				{
					num6 = fvectorDouble2.Y - Math.Sqrt(num * num - num24 * num24);
				}
				else
				{
					num6 = fvectorDouble2.Y - num23;
				}
				vector.X = num5;
				vector.Y = (double)((float)fvectorDouble3.Y);
				vector.Z = fvectorDouble3.Z;
				vector2.X = fvectorDouble3.X;
				vector2.Y = (double)((float)num6);
				vector2.Z = fvectorDouble3.Z;
			}
			fvectorDouble = vector.ToUeVector(false);
			FVectorDouble uePoint = hitTransform.TransformPositionNoScale(fvectorDouble);
			fvectorDouble = vector2.ToUeVector(false);
			FVectorDouble uePoint2 = hitTransform.TransformPositionNoScale(fvectorDouble);
			float num26 = this.ConvertUePointToAngle(uePoint);
			float num27 = this.ConvertUePointToAngle(uePoint2);
			if (this.Camera.IsInNormalGravityMode())
			{
				return new SettlementCamera.YawRange(num26, num27);
			}
			double num28 = (double)Math.Abs(num26 - num27);
			double num29 = MathUtils.Instance.WrapAngle((double)(num26 + num27) * 0.5);
			return new SettlementCamera.YawRange((float)MathUtils.Instance.WrapAngle(num29 - num28 / 2.0), (float)MathUtils.Instance.WrapAngle(num29 + num28 / 2.0));
		}

		// Token: 0x060482EC RID: 295660 RVA: 0x01289038 File Offset: 0x01287238
		private void UpdateValidYawRangeArray()
		{
			this.LeftYawRangeArray.Clear();
			this.RightYawRangeArray.Clear();
			this.LeftYawRangeArray.Add(new SettlementCamera.YawRange(this.CameraModifierLeftYawRangeMin, this.CameraModifierLeftYawRangeMax));
			this.RightYawRangeArray.Add(new SettlementCamera.YawRange(this.CameraModifierRightYawRangeMin, this.CameraModifierRightYawRangeMax));
			foreach (SettlementCamera.YawRange yawRange in this.InvalidYawRangeArray)
			{
				float num = MathCommon.WrapAngle(yawRange.Max - this.PlayerYaw);
				float num2 = MathCommon.WrapAngle(yawRange.Min - this.PlayerYaw);
				float num3 = 0f;
				float num4 = 0f;
				float num5 = 0f;
				float num6 = 0f;
				float num7 = 0f;
				float num8 = 0f;
				float num9 = 0f;
				float num10 = 0f;
				int num11 = 0;
				int num12 = 0;
				if (num < 0f && num2 < 0f)
				{
					if (num < num2)
					{
						num11 = 1;
						num3 = num;
						num4 = num2;
					}
					else
					{
						num11 = 2;
						num3 = -180f;
						num4 = num2;
						num5 = num;
						num6 = 0f;
						num12 = 1;
						num7 = 0f;
						num8 = 180f;
					}
				}
				else if (num > 0f && num2 > 0f)
				{
					if (num < num2)
					{
						num12 = 1;
						num7 = num;
						num8 = num2;
					}
					else
					{
						num12 = 2;
						num7 = 0f;
						num8 = num2;
						num9 = num;
						num10 = 180f;
						num11 = 1;
						num3 = -180f;
						num4 = 0f;
					}
				}
				else if (num < 0f && num2 > 0f)
				{
					num11 = 1;
					num12 = 1;
					num3 = num;
					num4 = 0f;
					num7 = 0f;
					num8 = num2;
				}
				else if (num > 0f && num2 < 0f)
				{
					num11 = 1;
					num12 = 1;
					num3 = -180f;
					num4 = num2;
					num7 = num;
					num8 = 180f;
				}
				for (int i = this.LeftYawRangeArray.Count - 1; i >= 0; i--)
				{
					bool flag = true;
					SettlementCamera.YawRange yawRange2 = this.LeftYawRangeArray[i];
					if (num11 >= 2 && yawRange2.Min <= num6 && yawRange2.Max >= num5)
					{
						float from = Math.Max(yawRange2.Min, num5);
						float to = Math.Min(yawRange2.Max, num6);
						this.LeftYawRangeArray.Add(new SettlementCamera.YawRange(from, to));
					}
					if (num11 >= 1 && yawRange2.Min <= num4 && yawRange2.Max >= num3)
					{
						flag = false;
						yawRange2.Min = Math.Max(yawRange2.Min, num3);
						yawRange2.Max = Math.Min(yawRange2.Max, num4);
					}
					if (flag)
					{
						this.LeftYawRangeArray.RemoveAt(i);
					}
				}
				for (int j = this.RightYawRangeArray.Count - 1; j >= 0; j--)
				{
					bool flag2 = true;
					SettlementCamera.YawRange yawRange3 = this.RightYawRangeArray[j];
					if (num12 >= 2 && yawRange3.Min <= num10 && yawRange3.Max >= num9)
					{
						float from2 = Math.Max(yawRange3.Min, num9);
						float to2 = Math.Min(yawRange3.Max, num10);
						this.RightYawRangeArray.Add(new SettlementCamera.YawRange(from2, to2));
					}
					if (num12 >= 1 && yawRange3.Min <= num8 && yawRange3.Max >= num7)
					{
						flag2 = false;
						yawRange3.Min = Math.Max(yawRange3.Min, num7);
						yawRange3.Max = Math.Min(yawRange3.Max, num8);
					}
					if (flag2)
					{
						this.RightYawRangeArray.RemoveAt(j);
					}
				}
			}
		}

		// Token: 0x060482ED RID: 295661 RVA: 0x012893E4 File Offset: 0x012875E4
		private float GetHitComponentRadius(UShapeComponent hitComponent, int index)
		{
			if (!this.HitResultIndexRadiusMap.ContainsKey(index))
			{
				this.HitResultIndexRadiusMap[index] = this.GetShapeComponentRadius(hitComponent);
			}
			return this.HitResultIndexRadiusMap[index];
		}

		// Token: 0x060482EE RID: 295662 RVA: 0x01289414 File Offset: 0x01287614
		[NullableContext(2)]
		private float GetShapeComponentRadius(UShapeComponent hitComponent)
		{
			if (hitComponent == null)
			{
				return 0f;
			}
			UCapsuleComponent ucapsuleComponent = hitComponent as UCapsuleComponent;
			if (ucapsuleComponent != null)
			{
				return ucapsuleComponent.CapsuleRadius;
			}
			UBoxComponent uboxComponent = hitComponent as UBoxComponent;
			if (uboxComponent != null)
			{
				return Math.Max(uboxComponent.BoxExtent.X, uboxComponent.BoxExtent.Y);
			}
			USphereComponent usphereComponent = hitComponent as USphereComponent;
			if (usphereComponent != null)
			{
				return usphereComponent.SphereRadius;
			}
			return 0f;
		}

		// Token: 0x060482EF RID: 295663 RVA: 0x01289477 File Offset: 0x01287677
		private float ConvertUePointToAngle(FVectorDouble uePoint)
		{
			this.TmpVector.Set(uePoint.X, uePoint.Y, uePoint.Z);
			return this.ConvertPointToAngle(this.TmpVector);
		}

		// Token: 0x060482F0 RID: 295664 RVA: 0x012894A4 File Offset: 0x012876A4
		private float ConvertPointToAngle(Vector point)
		{
			point.Subtraction(this.PlayerLocation, this.TmpVector);
			if (this.Camera.IsInNormalGravityMode())
			{
				return (float)(this.TmpVector.HeadingAngle() * 57.295780181884766);
			}
			CameraUtility.GetVectorInGravity(this.TmpVector, this.TmpVector);
			this.TmpVector.Rotation(this.TmpRotator);
			return MathUtils.Instance.WrapAngle(this.TmpRotator.Yaw);
		}

		// Token: 0x060482F1 RID: 295665 RVA: 0x01289520 File Offset: 0x01287720
		[Conditional("DEBUG")]
		public void SetDrawDebugEnable(bool isEnable)
		{
		}

		// Token: 0x060482F2 RID: 295666 RVA: 0x01289522 File Offset: 0x01287722
		[Conditional("DEBUG")]
		private void DrawDebugInvalidRange()
		{
		}

		// Token: 0x060482F3 RID: 295667 RVA: 0x01289524 File Offset: 0x01287724
		[Conditional("DEBUG")]
		private void DrawDebugValidRange()
		{
		}

		// Token: 0x060482F4 RID: 295668 RVA: 0x01289528 File Offset: 0x01287728
		private void DrawDebugCameraFocus()
		{
			FTransformDouble actorTransform = this.Camera.Character.CharacterActorComponent.ActorTransform;
			FVectorDouble fvectorDouble = this.CameraModifierCharacterOffset.ToUeVector(false);
			FVectorDouble center = actorTransform.TransformPositionNoScale(fvectorDouble);
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, center, 10f, 12, new FLinearColor?(new FLinearColor()), 10f, 0f);
		}

		// Token: 0x060482F5 RID: 295669 RVA: 0x01289588 File Offset: 0x01287788
		[Conditional("DEBUG")]
		private void DrawDebugFinalDirection()
		{
		}

		// Token: 0x060482F6 RID: 295670 RVA: 0x0128958C File Offset: 0x0128778C
		public void Clear()
		{
			if (this.CameraSphereTrace != null)
			{
				this.CameraSphereTrace.Dispose();
				this.CameraSphereTrace = null;
			}
			this.Camera = null;
			this.ActorHitResultIndexMap.Clear();
			this.ActorHitResultIndexArrayMap.Clear();
			this.HitResultIndexRadiusMap.Clear();
			this.InvalidYawRangeArray.Clear();
			this.LeftYawRangeArray.Clear();
			this.RightYawRangeArray.Clear();
			this.TmpYawRange.Clear();
		}

		// Token: 0x040261B3 RID: 156083
		private const int MIN_CAMERA_DISTANCE = 100;

		// Token: 0x040261B4 RID: 156084
		private const int TARGET_PITCH_MIN = -5;

		// Token: 0x040261B5 RID: 156085
		private const int TARGET_PITCH_MAX = -8;

		// Token: 0x040261B6 RID: 156086
		private const int TRACE_TOP_ADDITION_Z = 50;

		// Token: 0x040261B7 RID: 156087
		private const int TRACE_BOTTOM_ADDITION_Z = 50;

		// Token: 0x040261B8 RID: 156088
		private const int LEFT_YAW_RANGE_MIN = -180;

		// Token: 0x040261B9 RID: 156089
		private const int LEFT_YAW_RANGE_MAX = 0;

		// Token: 0x040261BA RID: 156090
		private const int RIGHT_YAW_RANGE_MIN = 0;

		// Token: 0x040261BB RID: 156091
		private const int RIGHT_YAW_RANGE_MAX = 180;

		// Token: 0x040261BC RID: 156092
		private const int MIN_VALID_YAW_RANGE = 0;

		// Token: 0x040261BD RID: 156093
		private const int MIN_SHAPE_RADUIS = 30;

		// Token: 0x040261BE RID: 156094
		private const int MAX_CACHE_CAPSULE_COUNT = 4;

		// Token: 0x040261BF RID: 156095
		private const int PITCH_MAX = 90;

		// Token: 0x040261C0 RID: 156096
		private const int PITCH_MIN = -90;

		// Token: 0x040261C1 RID: 156097
		private const int MINUS_FLAT_ANGLE = -180;

		// Token: 0x040261C2 RID: 156098
		private const int FLAT_ANGLE = 180;

		// Token: 0x040261C3 RID: 156099
		private const string PROFILE_KEY = "FightCameraLogicComponent_TraceValidRange_Camera";

		// Token: 0x040261C4 RID: 156100
		[StaticVariableRuleIgnore]
		private static readonly int BanSettlementCamera = GameplayTagDefine.EGameplayTagId["功能.通用镜头.屏蔽终结镜头"];

		// Token: 0x040261C5 RID: 156101
		private const double DEBUG_DRAW_DURATION = 10.0;

		// Token: 0x040261C6 RID: 156102
		private const double DEBUG_DRAW_RADIUS = 10.0;

		// Token: 0x040261C7 RID: 156103
		private const int DEBUG_DRAW_SEGMENTS = 12;

		// Token: 0x040261C8 RID: 156104
		private const double THICKNESS = 5.0;

		// Token: 0x040261C9 RID: 156105
		[Nullable(2)]
		private FightCameraLogicComponent Camera;

		// Token: 0x040261CA RID: 156106
		private float CameraSphereRadius = 100f;

		// Token: 0x040261CB RID: 156107
		[Nullable(2)]
		private UTraceSphereElement CameraSphereTrace;

		// Token: 0x040261CC RID: 156108
		[Nullable(2)]
		private SSettlementCamera SettlementCameraConfig;

		// Token: 0x040261CD RID: 156109
		[Nullable(2)]
		private SCameraModifier CameraModifier;

		// Token: 0x040261CE RID: 156110
		private float CameraModifierArmLength = 100f;

		// Token: 0x040261CF RID: 156111
		private float CameraModifierPitchMin = -5f;

		// Token: 0x040261D0 RID: 156112
		private float CameraModifierPitchMax = -8f;

		// Token: 0x040261D1 RID: 156113
		private float CameraModifierTopAdditionZ = 50f;

		// Token: 0x040261D2 RID: 156114
		private float CameraModifierBottomAdditionZ = 50f;

		// Token: 0x040261D3 RID: 156115
		private float CameraModifierLeftYawRangeMin = -180f;

		// Token: 0x040261D4 RID: 156116
		private float CameraModifierLeftYawRangeMax;

		// Token: 0x040261D5 RID: 156117
		private float CameraModifierRightYawRangeMin;

		// Token: 0x040261D6 RID: 156118
		private float CameraModifierRightYawRangeMax = 180f;

		// Token: 0x040261D7 RID: 156119
		private float CameraModifierValidRangeMin;

		// Token: 0x040261D8 RID: 156120
		private readonly Vector CameraModifierCharacterOffset = Vector.Create();

		// Token: 0x040261D9 RID: 156121
		private float PlayerYaw;

		// Token: 0x040261DA RID: 156122
		[Nullable(2)]
		private Vector PlayerLocation;

		// Token: 0x040261DB RID: 156123
		private readonly Rotator FinalRotator = Rotator.Create();

		// Token: 0x040261DC RID: 156124
		private readonly Dictionary<AActor, int> ActorHitResultIndexMap = new Dictionary<AActor, int>();

		// Token: 0x040261DD RID: 156125
		private readonly Dictionary<AActor, List<int>> ActorHitResultIndexArrayMap = new Dictionary<AActor, List<int>>();

		// Token: 0x040261DE RID: 156126
		private readonly Dictionary<int, float> HitResultIndexRadiusMap = new Dictionary<int, float>();

		// Token: 0x040261DF RID: 156127
		private FVector Extent = new FVector();

		// Token: 0x040261E0 RID: 156128
		private readonly List<SettlementCamera.YawRange> InvalidYawRangeArray = new List<SettlementCamera.YawRange>();

		// Token: 0x040261E1 RID: 156129
		private readonly List<SettlementCamera.YawRange> LeftYawRangeArray = new List<SettlementCamera.YawRange>();

		// Token: 0x040261E2 RID: 156130
		private readonly List<SettlementCamera.YawRange> RightYawRangeArray = new List<SettlementCamera.YawRange>();

		// Token: 0x040261E3 RID: 156131
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x040261E4 RID: 156132
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x040261E5 RID: 156133
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x040261E6 RID: 156134
		private readonly List<SettlementCamera.YawRange> TmpYawRange = new List<SettlementCamera.YawRange>();

		// Token: 0x040261E7 RID: 156135
		public bool EnableDebugDraw;

		// Token: 0x0200CFD5 RID: 53205
		[NullableContext(0)]
		public class YawRange
		{
			// Token: 0x06052292 RID: 336530 RVA: 0x0164E841 File Offset: 0x0164CA41
			public YawRange(float from, float to)
			{
			}

			// Token: 0x0403E7CF RID: 255951
			public float Min = from;

			// Token: 0x0403E7D0 RID: 255952
			public float Max = to;
		}
	}
}
