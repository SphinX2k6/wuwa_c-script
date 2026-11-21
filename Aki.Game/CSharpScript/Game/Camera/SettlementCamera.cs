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
	// Token: 0x02006465 RID: 25701
	[NullableContext(1)]
	[Nullable(0)]
	public class SettlementCamera
	{
		// Token: 0x0603E724 RID: 255780 RVA: 0x0122A10D File Offset: 0x0122830D
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

		// Token: 0x0603E725 RID: 255781 RVA: 0x0122A138 File Offset: 0x01228338
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

		// Token: 0x0603E726 RID: 255782 RVA: 0x0122A8CC File Offset: 0x01228ACC
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

		// Token: 0x0603E727 RID: 255783 RVA: 0x0122AA8B File Offset: 0x01228C8B
		public void UpdateRotator(UKuroHitResult hitResult)
		{
			this.UpdateHitActorMap(hitResult);
			this.UpdateInvalidYawRangeArray(hitResult);
			this.UpdateValidYawRangeArray();
			this.UpdateFinalRotator();
		}

		// Token: 0x0603E728 RID: 255784 RVA: 0x0122AAA8 File Offset: 0x01228CA8
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

		// Token: 0x0603E729 RID: 255785 RVA: 0x0122AC74 File Offset: 0x01228E74
		public void PlaySettlementCameraInternal()
		{
			CameraController.Instance.StopAllCameraShakes();
			this.FinalRotator.SubtractionEqual(this.Camera.PlayerRotatorInGravity);
			this.CameraModifier.Settings.ArmRotation = new FRotator(this.FinalRotator.Pitch, this.FinalRotator.Yaw, this.FinalRotator.Roll);
			this.CameraModifier.Settings.ModifySettingsAdditional.ArmOffset.Set((float)this.CameraModifierCharacterOffset.X, (float)this.CameraModifierCharacterOffset.Y, (float)this.CameraModifierCharacterOffset.Z);
			this.Camera.CameraModifyController.ApplyCameraModify(null, this.CameraModifier.Duration, this.CameraModifier.BlendInTime, this.CameraModifier.BlendOutTime, this.CameraModifier.BreakBlendOutTime, this.CameraModifier.Settings, null, new OneOf<CurveBase, SBaseCurve>(this.CameraModifier.BlendInCurve), new OneOf<CurveBase, SBaseCurve>(this.CameraModifier.BlendOutCurve), this.Camera.Character, "HitCase", default(OneOf<TsBaseCharacter, TsBaseVehicle>));
		}

		// Token: 0x0603E72A RID: 255786 RVA: 0x0122ADAC File Offset: 0x01228FAC
		public bool IsPlayingSettlementCamera()
		{
			return this.Camera.CameraModifyController.IsModified && !(this.CameraModifier == null) && this.Camera.CameraModifyController.ModifySettings.Name == this.CameraModifier.Settings.ModifySettingsAdditional.Name;
		}

		// Token: 0x0603E72B RID: 255787 RVA: 0x0122AE0C File Offset: 0x0122900C
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

		// Token: 0x0603E72C RID: 255788 RVA: 0x0122B024 File Offset: 0x01229224
		[NullableContext(0)]
		private ValueTuple<double, double> GetActorBoundExtent(FTransformDouble transform, [Nullable(1)] UStaticMeshComponent staticMeshComponent)
		{
			FVector fvector = default(FVector);
			staticMeshComponent.GetLocalBounds(ref fvector, ref this.Extent);
			double item = (double)(this.Extent.X * transform.GetScale3D().X);
			double item2 = (double)(this.Extent.Y * transform.GetScale3D().Y);
			return new ValueTuple<double, double>(item, item2);
		}

		// Token: 0x0603E72D RID: 255789 RVA: 0x0122B080 File Offset: 0x01229280
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

		// Token: 0x0603E72E RID: 255790 RVA: 0x0122B288 File Offset: 0x01229488
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

		// Token: 0x0603E72F RID: 255791 RVA: 0x0122B318 File Offset: 0x01229518
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

		// Token: 0x0603E730 RID: 255792 RVA: 0x0122BA7C File Offset: 0x01229C7C
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

		// Token: 0x0603E731 RID: 255793 RVA: 0x0122BE28 File Offset: 0x0122A028
		private float GetHitComponentRadius(UShapeComponent hitComponent, int index)
		{
			if (!this.HitResultIndexRadiusMap.ContainsKey(index))
			{
				this.HitResultIndexRadiusMap[index] = this.GetShapeComponentRadius(hitComponent);
			}
			return this.HitResultIndexRadiusMap[index];
		}

		// Token: 0x0603E732 RID: 255794 RVA: 0x0122BE58 File Offset: 0x0122A058
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

		// Token: 0x0603E733 RID: 255795 RVA: 0x0122BEBB File Offset: 0x0122A0BB
		private float ConvertUePointToAngle(FVectorDouble uePoint)
		{
			this.TmpVector.Set(uePoint.X, uePoint.Y, uePoint.Z);
			return this.ConvertPointToAngle(this.TmpVector);
		}

		// Token: 0x0603E734 RID: 255796 RVA: 0x0122BEE8 File Offset: 0x0122A0E8
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

		// Token: 0x0603E735 RID: 255797 RVA: 0x0122BF64 File Offset: 0x0122A164
		[Conditional("DEBUG")]
		public void SetDrawDebugEnable(bool isEnable)
		{
		}

		// Token: 0x0603E736 RID: 255798 RVA: 0x0122BF66 File Offset: 0x0122A166
		[Conditional("DEBUG")]
		private void DrawDebugInvalidRange()
		{
		}

		// Token: 0x0603E737 RID: 255799 RVA: 0x0122BF68 File Offset: 0x0122A168
		[Conditional("DEBUG")]
		private void DrawDebugValidRange()
		{
		}

		// Token: 0x0603E738 RID: 255800 RVA: 0x0122BF6C File Offset: 0x0122A16C
		private void DrawDebugCameraFocus()
		{
			FTransformDouble actorTransform = this.Camera.Character.CharacterActorComponent.ActorTransform;
			FVectorDouble fvectorDouble = this.CameraModifierCharacterOffset.ToUeVector(false);
			FVectorDouble center = actorTransform.TransformPositionNoScale(fvectorDouble);
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, center, 10f, 12, new FLinearColor?(new FLinearColor()), 10f, 0f);
		}

		// Token: 0x0603E739 RID: 255801 RVA: 0x0122BFCC File Offset: 0x0122A1CC
		[Conditional("DEBUG")]
		private void DrawDebugFinalDirection()
		{
		}

		// Token: 0x0603E73A RID: 255802 RVA: 0x0122BFD0 File Offset: 0x0122A1D0
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

		// Token: 0x0402149E RID: 136350
		private const int MIN_CAMERA_DISTANCE = 100;

		// Token: 0x0402149F RID: 136351
		private const int TARGET_PITCH_MIN = -5;

		// Token: 0x040214A0 RID: 136352
		private const int TARGET_PITCH_MAX = -8;

		// Token: 0x040214A1 RID: 136353
		private const int TRACE_TOP_ADDITION_Z = 50;

		// Token: 0x040214A2 RID: 136354
		private const int TRACE_BOTTOM_ADDITION_Z = 50;

		// Token: 0x040214A3 RID: 136355
		private const int LEFT_YAW_RANGE_MIN = -180;

		// Token: 0x040214A4 RID: 136356
		private const int LEFT_YAW_RANGE_MAX = 0;

		// Token: 0x040214A5 RID: 136357
		private const int RIGHT_YAW_RANGE_MIN = 0;

		// Token: 0x040214A6 RID: 136358
		private const int RIGHT_YAW_RANGE_MAX = 180;

		// Token: 0x040214A7 RID: 136359
		private const int MIN_VALID_YAW_RANGE = 0;

		// Token: 0x040214A8 RID: 136360
		private const int MIN_SHAPE_RADUIS = 30;

		// Token: 0x040214A9 RID: 136361
		private const int MAX_CACHE_CAPSULE_COUNT = 4;

		// Token: 0x040214AA RID: 136362
		private const int PITCH_MAX = 90;

		// Token: 0x040214AB RID: 136363
		private const int PITCH_MIN = -90;

		// Token: 0x040214AC RID: 136364
		private const int MINUS_FLAT_ANGLE = -180;

		// Token: 0x040214AD RID: 136365
		private const int FLAT_ANGLE = 180;

		// Token: 0x040214AE RID: 136366
		private const string PROFILE_KEY = "FightCameraLogicComponent_TraceValidRange_Camera";

		// Token: 0x040214AF RID: 136367
		[StaticVariableRuleIgnore]
		private static readonly int BanSettlementCamera = GameplayTagDefine.EGameplayTagId["功能.通用镜头.屏蔽终结镜头"];

		// Token: 0x040214B0 RID: 136368
		private const double DEBUG_DRAW_DURATION = 10.0;

		// Token: 0x040214B1 RID: 136369
		private const double DEBUG_DRAW_RADIUS = 10.0;

		// Token: 0x040214B2 RID: 136370
		private const int DEBUG_DRAW_SEGMENTS = 12;

		// Token: 0x040214B3 RID: 136371
		private const double THICKNESS = 5.0;

		// Token: 0x040214B4 RID: 136372
		[Nullable(2)]
		private FightCameraLogicComponent Camera;

		// Token: 0x040214B5 RID: 136373
		private float CameraSphereRadius = 100f;

		// Token: 0x040214B6 RID: 136374
		[Nullable(2)]
		private UTraceSphereElement CameraSphereTrace;

		// Token: 0x040214B7 RID: 136375
		[Nullable(2)]
		private SSettlementCamera SettlementCameraConfig;

		// Token: 0x040214B8 RID: 136376
		[Nullable(2)]
		private SCameraModifier CameraModifier;

		// Token: 0x040214B9 RID: 136377
		private float CameraModifierArmLength = 100f;

		// Token: 0x040214BA RID: 136378
		private float CameraModifierPitchMin = -5f;

		// Token: 0x040214BB RID: 136379
		private float CameraModifierPitchMax = -8f;

		// Token: 0x040214BC RID: 136380
		private float CameraModifierTopAdditionZ = 50f;

		// Token: 0x040214BD RID: 136381
		private float CameraModifierBottomAdditionZ = 50f;

		// Token: 0x040214BE RID: 136382
		private float CameraModifierLeftYawRangeMin = -180f;

		// Token: 0x040214BF RID: 136383
		private float CameraModifierLeftYawRangeMax;

		// Token: 0x040214C0 RID: 136384
		private float CameraModifierRightYawRangeMin;

		// Token: 0x040214C1 RID: 136385
		private float CameraModifierRightYawRangeMax = 180f;

		// Token: 0x040214C2 RID: 136386
		private float CameraModifierValidRangeMin;

		// Token: 0x040214C3 RID: 136387
		private readonly Vector CameraModifierCharacterOffset = Vector.Create();

		// Token: 0x040214C4 RID: 136388
		private float PlayerYaw;

		// Token: 0x040214C5 RID: 136389
		[Nullable(2)]
		private Vector PlayerLocation;

		// Token: 0x040214C6 RID: 136390
		private readonly Rotator FinalRotator = Rotator.Create();

		// Token: 0x040214C7 RID: 136391
		private readonly Dictionary<AActor, int> ActorHitResultIndexMap = new Dictionary<AActor, int>();

		// Token: 0x040214C8 RID: 136392
		private readonly Dictionary<AActor, List<int>> ActorHitResultIndexArrayMap = new Dictionary<AActor, List<int>>();

		// Token: 0x040214C9 RID: 136393
		private readonly Dictionary<int, float> HitResultIndexRadiusMap = new Dictionary<int, float>();

		// Token: 0x040214CA RID: 136394
		private FVector Extent = new FVector();

		// Token: 0x040214CB RID: 136395
		private readonly List<SettlementCamera.YawRange> InvalidYawRangeArray = new List<SettlementCamera.YawRange>();

		// Token: 0x040214CC RID: 136396
		private readonly List<SettlementCamera.YawRange> LeftYawRangeArray = new List<SettlementCamera.YawRange>();

		// Token: 0x040214CD RID: 136397
		private readonly List<SettlementCamera.YawRange> RightYawRangeArray = new List<SettlementCamera.YawRange>();

		// Token: 0x040214CE RID: 136398
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x040214CF RID: 136399
		private readonly Vector TmpVector2 = Vector.Create();

		// Token: 0x040214D0 RID: 136400
		private readonly Rotator TmpRotator = Rotator.Create();

		// Token: 0x040214D1 RID: 136401
		private readonly List<SettlementCamera.YawRange> TmpYawRange = new List<SettlementCamera.YawRange>();

		// Token: 0x040214D2 RID: 136402
		public bool EnableDebugDraw;

		// Token: 0x0200BBB1 RID: 48049
		[NullableContext(0)]
		public class YawRange
		{
			// Token: 0x06048B2D RID: 297773 RVA: 0x0162397F File Offset: 0x01621B7F
			public YawRange(float from, float to)
			{
			}

			// Token: 0x04039C0F RID: 236559
			public float Min = from;

			// Token: 0x04039C10 RID: 236560
			public float Max = to;
		}
	}
}
