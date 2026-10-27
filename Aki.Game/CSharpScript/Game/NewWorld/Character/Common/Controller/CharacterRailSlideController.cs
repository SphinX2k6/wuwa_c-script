using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.RailSlideFollower;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B9 RID: 28857
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CharacterRailSlideController : ControllerBase
	{
		// Token: 0x060465BF RID: 288191 RVA: 0x011A1EB0 File Offset: 0x011A00B0
		public void SetEntityRail(int entityId, int railId)
		{
			int num;
			int num2;
			if (this.EntityRailMap.TryGetValue(entityId, out num) && num != railId && this.RailToEntityMap.TryGetValue(num, out num2) && num2 == entityId)
			{
				this.RailToEntityMap.Remove(num);
			}
			this.EntityRailMap[entityId] = railId;
			this.RailToEntityMap[railId] = entityId;
			this.TriggerFollowers(railId);
		}

		// Token: 0x060465C0 RID: 288192 RVA: 0x011A1F14 File Offset: 0x011A0114
		public void RemoveEntityRail(int entityId)
		{
			int key;
			if (this.EntityRailMap.TryGetValue(entityId, out key))
			{
				this.EntityRailMap.Remove(entityId);
				int num;
				if (this.RailToEntityMap.TryGetValue(key, out num) && num == entityId)
				{
					this.RailToEntityMap.Remove(key);
				}
			}
		}

		// Token: 0x060465C1 RID: 288193 RVA: 0x011A1F60 File Offset: 0x011A0160
		public int? GetEntityRailId(int entityId)
		{
			int value;
			if (!this.EntityRailMap.TryGetValue(entityId, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060465C2 RID: 288194 RVA: 0x011A1F90 File Offset: 0x011A0190
		public void AddRailFollower(int pbDataId, int railId, string followerDaPath, string daPath)
		{
			RailSlideFollowerParams railSlideFollowerParams = this.InitRailSlideFollowerParams(followerDaPath, pbDataId);
			if (railSlideFollowerParams == null)
			{
				return;
			}
			List<CharacterRailSlideController.RailFollowerEntry> list;
			if (!this.RailFollowerMap.TryGetValue(railId, out list))
			{
				list = new List<CharacterRailSlideController.RailFollowerEntry>();
				this.RailFollowerMap[railId] = list;
			}
			CharacterRailSlideController.RailFollowerEntry railFollowerEntry = list.Find((CharacterRailSlideController.RailFollowerEntry f) => f.PbDataId == pbDataId && f.RailId == railId);
			if (railFollowerEntry != null)
			{
				railFollowerEntry.Params = railSlideFollowerParams;
			}
			else
			{
				list.Add(new CharacterRailSlideController.RailFollowerEntry
				{
					PbDataId = pbDataId,
					Params = railSlideFollowerParams,
					DaPath = daPath,
					RailId = railId
				});
			}
			if (this.GetRailActiveEntity(railId) != 0)
			{
				if (railSlideFollowerParams.DelayStartFollow > 20f)
				{
					TimerSystem.FlowTimeInstance.Delay(delegate(float delta)
					{
						this.TriggerFollowers(railId);
					}, MathUtils.Instance.Clamp(railSlideFollowerParams.DelayStartFollow, 20f, 180000f), null, null, true, 1f);
					return;
				}
				this.TriggerFollowers(railId);
			}
		}

		// Token: 0x060465C3 RID: 288195 RVA: 0x011A20AC File Offset: 0x011A02AC
		private int GetRailActiveEntity(int railId)
		{
			int result;
			if (!this.RailToEntityMap.TryGetValue(railId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x060465C4 RID: 288196 RVA: 0x011A20CC File Offset: 0x011A02CC
		private void TriggerFollowers(int railId)
		{
			List<CharacterRailSlideController.RailFollowerEntry> list;
			if (!this.RailFollowerMap.TryGetValue(railId, out list) || list.Count == 0)
			{
				return;
			}
			List<CharacterRailSlideController.RailFollowerEntry> list2 = new List<CharacterRailSlideController.RailFollowerEntry>(list);
			list.Clear();
			this.RailFollowerMap.Remove(railId);
			foreach (CharacterRailSlideController.RailFollowerEntry railFollowerEntry in list2)
			{
				if (!this.ActiveFollowerMap.ContainsKey(railFollowerEntry.PbDataId))
				{
					CreatureModel instance = CreatureModel.Instance;
					WorldEntity worldEntity;
					if (instance == null)
					{
						worldEntity = null;
					}
					else
					{
						EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(railFollowerEntry.PbDataId);
						worldEntity = ((entityByPbDataId != null) ? entityByPbDataId.Entity : null);
					}
					WorldEntity worldEntity2 = worldEntity;
					if (worldEntity2 != null && !worldEntity2.IsInit)
					{
						CharacterRailSlideController.<>c__DisplayClass23_0 CS$<>8__locals1 = new CharacterRailSlideController.<>c__DisplayClass23_0();
						CS$<>8__locals1.<>4__this = this;
						CS$<>8__locals1.capturedEntity = worldEntity2;
						CS$<>8__locals1.capturedFollower = railFollowerEntry;
						CS$<>8__locals1.capturedRailId = railId;
						EventSystem.Instance.AddWithTarget<int>(worldEntity2, EEventName.CharBornFinished, new Action<int>(CS$<>8__locals1.<TriggerFollowers>g__Handler|0));
					}
					else
					{
						CharacterRailSlideComponent characterRailSlideComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<CharacterRailSlideComponent>() : null;
						this.ActiveFollowerMap[railFollowerEntry.PbDataId] = new CharacterRailSlideController.ActiveFollowerState
						{
							Params = railFollowerEntry.Params,
							LastDist = ((characterRailSlideComponent != null) ? characterRailSlideComponent.GetCurrentRailDistance() : 0f),
							CurrentSide = railFollowerEntry.Params.FollowOnRight,
							RadVelocity = 0f,
							SmoothedLeaderRad = 0f
						};
						if (characterRailSlideComponent != null)
						{
							characterRailSlideComponent.StartFollowerRailSlide(railId, railFollowerEntry.DaPath, false, null);
						}
					}
				}
			}
		}

		// Token: 0x060465C5 RID: 288197 RVA: 0x011A2268 File Offset: 0x011A0468
		private unsafe RailSlideFollowerParams InitRailSlideFollowerParams(string daPath, int pbDataId)
		{
			BP_RailSlideFollowerConfig_C bp_RailSlideFollowerConfig_C = ResourceSystem.Instance.Load<BP_RailSlideFollowerConfig_C>(daPath, "js_undefined");
			if (bp_RailSlideFollowerConfig_C == null || !bp_RailSlideFollowerConfig_C.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "[RailSlide] 获取Follower参数DA失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", pbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DaPath", daPath);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			return new RailSlideFollowerParams(bp_RailSlideFollowerConfig_C);
		}

		// Token: 0x060465C6 RID: 288198 RVA: 0x011A22F8 File Offset: 0x011A04F8
		public float GetRailSlideFollowerDist(int pbDataId, int railId, float followerCurrentDist, float splineLength, float deltaMs)
		{
			CharacterRailSlideController.IActiveFollowerState activeFollowerState;
			if (!this.ActiveFollowerMap.TryGetValue(pbDataId, out activeFollowerState))
			{
				return followerCurrentDist;
			}
			int railActiveEntity = this.GetRailActiveEntity(railId);
			if (railActiveEntity == 0)
			{
				return followerCurrentDist;
			}
			CreatureModel instance = CreatureModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle entityById = instance.GetEntityById(railActiveEntity);
				obj = ((entityById != null) ? entityById.Entity : null);
			}
			object obj2 = obj;
			CharacterRailSlideComponent characterRailSlideComponent = (obj2 != null) ? obj2.GetComponent<CharacterRailSlideComponent>() : null;
			if (characterRailSlideComponent == null)
			{
				return followerCurrentDist;
			}
			float num = Math.Min(characterRailSlideComponent.GetCurrentRailDistance() + activeFollowerState.Params.FrontDistance, splineLength - 1f);
			float num2 = num - followerCurrentDist;
			float num3 = deltaMs * 0.001f;
			float val = activeFollowerState.Params.FollowerLerpSpeed * num3;
			float value = num2 * (1f - (float)Math.Exp((double)(-(double)activeFollowerState.Params.FollowSpeedStepRate * num3)));
			float num4 = (float)Math.Sign(num2) * Math.Min(Math.Abs(value), val);
			float num5 = (Math.Abs(num2) <= Math.Max(Math.Abs(num4), 20f)) ? num : (followerCurrentDist + num4);
			activeFollowerState.LastDist = num5;
			return num5;
		}

		// Token: 0x060465C7 RID: 288199 RVA: 0x011A23F4 File Offset: 0x011A05F4
		public float GetFollowerTargetRad(int followerPbDataId, int railId, float followerCurrentRad, float followerRadius, float deltaMs, float effectiveMaxLinearVelocity)
		{
			CharacterRailSlideController.IActiveFollowerState activeFollowerState;
			if (!this.ActiveFollowerMap.TryGetValue(followerPbDataId, out activeFollowerState) || followerRadius <= 0f)
			{
				return followerCurrentRad;
			}
			RailSlideFollowerParams @params = activeFollowerState.Params;
			int railActiveEntity = this.GetRailActiveEntity(railId);
			if (railActiveEntity == 0)
			{
				return followerCurrentRad;
			}
			CreatureModel instance = CreatureModel.Instance;
			object obj;
			if (instance == null)
			{
				obj = null;
			}
			else
			{
				EntityHandle entityById = instance.GetEntityById(railActiveEntity);
				obj = ((entityById != null) ? entityById.Entity : null);
			}
			object obj2 = obj;
			CharacterRailSlideComponent characterRailSlideComponent = (obj2 != null) ? obj2.GetComponent<CharacterRailSlideComponent>() : null;
			if (characterRailSlideComponent == null)
			{
				return followerCurrentRad;
			}
			float currentRad = characterRailSlideComponent.GetCurrentRad();
			float num = deltaMs * 0.001f;
			float num2 = 1f;
			activeFollowerState.SmoothedLeaderRad += (currentRad - activeFollowerState.SmoothedLeaderRad) * (1f - (float)Math.Exp((double)(-(double)num2 * num)));
			bool flag = activeFollowerState.CurrentSide;
			if (@params.AutoChangeSide && @params.DynamicDistance > 0f && Math.Abs(currentRad * followerRadius) > @params.DynamicDistance && currentRad > 0f == flag)
			{
				flag = !flag;
				activeFollowerState.CurrentSide = flag;
			}
			float num3 = (flag ? activeFollowerState.Params.SideDistance.Item2 : activeFollowerState.Params.SideDistance.Item1) / followerRadius;
			float num4 = activeFollowerState.SmoothedLeaderRad + (flag ? num3 : (-num3));
			float num5 = Math.Abs(activeFollowerState.LastDist - characterRailSlideComponent.GetCurrentRailDistance());
			float num6 = 80f;
			if (num5 < num6)
			{
				float num7 = num6 / followerRadius;
				if (Math.Abs(num4 - activeFollowerState.SmoothedLeaderRad) < num7)
				{
					num4 = activeFollowerState.SmoothedLeaderRad + (flag ? num7 : (-num7));
				}
			}
			float maxAngVel = effectiveMaxLinearVelocity / followerRadius;
			float num8 = this.StepFollowerApproach(followerCurrentRad, num4, followerRadius, num, maxAngVel, @params.ToleranceDistance, activeFollowerState);
			if (num5 < num6)
			{
				float num9 = num6 / followerRadius;
				if (Math.Abs(num8 - currentRad) < num9)
				{
					num8 = currentRad + (flag ? num9 : (-num9));
					activeFollowerState.RadVelocity = 0f;
				}
			}
			return num8;
		}

		// Token: 0x060465C8 RID: 288200 RVA: 0x011A25D0 File Offset: 0x011A07D0
		private float StepFollowerApproach(float current, float target, float radius, float dt, float maxAngVel, float toleranceDist, CharacterRailSlideController.IActiveFollowerState activeData)
		{
			float value = target - current;
			float num = Math.Abs(value) * radius;
			bool flag = Math.Abs(activeData.RadVelocity) < 0.001f;
			float num2 = 3f;
			float num3 = 5f;
			float num4;
			if (flag && num < toleranceDist)
			{
				num4 = 0f;
			}
			else if (!flag && num < toleranceDist * 0.5f)
			{
				num4 = 0f;
			}
			else
			{
				num4 = (float)Math.Sign(value) * Math.Min(maxAngVel, Math.Abs(value) * num2);
			}
			float num5 = maxAngVel * num3;
			float value2 = num4 - activeData.RadVelocity;
			float num6 = num5 * dt;
			if (Math.Abs(value2) > num6)
			{
				activeData.RadVelocity += (float)Math.Sign(value2) * num6;
			}
			else
			{
				activeData.RadVelocity = num4;
			}
			if (Math.Abs(activeData.RadVelocity) < 0.001f)
			{
				activeData.RadVelocity = 0f;
				return current;
			}
			float num7 = activeData.RadVelocity * dt;
			if (Math.Abs(num7) >= Math.Abs(value))
			{
				activeData.RadVelocity = 0f;
				return target;
			}
			return current + num7;
		}

		// Token: 0x060465C9 RID: 288201 RVA: 0x011A26E6 File Offset: 0x011A08E6
		public void RemoveActiveFollower(int pbDataId)
		{
			this.ActiveFollowerMap.Remove(pbDataId);
		}

		// Token: 0x060465CA RID: 288202 RVA: 0x011A26F8 File Offset: 0x011A08F8
		public float CalcParabolicHeight(IJumpProjectileParams projectileParams, float rate)
		{
			float num = rate * projectileParams.Length;
			return projectileParams.ProjectileA * num * num + projectileParams.ProjectileB * num;
		}

		// Token: 0x060465CB RID: 288203 RVA: 0x011A2724 File Offset: 0x011A0924
		public IJumpProjectileParams CalcParabolicCoefficients(float h0, float linearDist, float splineLength, RailSlideParams config, float halfHeightOffset = 0f)
		{
			float num = (float)Math.Log10((double)Math.Max(1f, Math.Min((float)config.MaxJumpDistance, linearDist) * 0.01f)) * (float)config.MaxJumpHeight + (float)config.BaseJumpHeight + Math.Max(0f, h0) - halfHeightOffset;
			float num2 = (float)Math.Sqrt((double)(num * (num - h0)));
			float projectileB = 2f * (num + num2) / splineLength;
			float projectileA = -1f * (2f * num + 2f * num2 - h0) / (splineLength * splineLength);
			float allTime = (float)config.AllTimeForJump * 0.001f;
			return new JumpProjectileParams
			{
				Length = splineLength,
				Height0 = h0,
				AllTime = allTime,
				ProjectileA = projectileA,
				ProjectileB = projectileB
			};
		}

		// Token: 0x060465CC RID: 288204 RVA: 0x011A27EC File Offset: 0x011A09EC
		[return: Nullable(0)]
		public ValueTuple<float, float> CalcEnterRailDistance(float horSpeed, float verSpeed, float startDist, float splineLength, Vector startLocation, Vector nearestPoint, Vector direction, Vector gravityDirect, float halfHeight)
		{
			float height = Math.Max((float)Vector.PointPlaneDist(nearestPoint, startLocation, gravityDirect), halfHeight);
			float num = this.CalcHorizontalLandingDistance(horSpeed, verSpeed, height);
			float num2 = Math.Max(100f, num) + startDist;
			if (startDist == 0f)
			{
				float num3 = (float)Vector.PointPlaneDist(startLocation, nearestPoint, direction);
				if (num3 < 0f)
				{
					num2 = Math.Max(num2 + num3, 1f);
				}
			}
			if (num2 >= splineLength)
			{
				num2 = splineLength - 1f;
			}
			return new ValueTuple<float, float>(num2, num);
		}

		// Token: 0x060465CD RID: 288205 RVA: 0x011A2868 File Offset: 0x011A0A68
		public SplineCurve BuildTwoPointSplineCurve(Vector start, Vector end, Vector startTangent = null)
		{
			InterpCurvePointVector interpCurvePointVector = new InterpCurvePointVector((startTangent != null) ? global::EInterpCurveMode.CurveAutoClamped : global::EInterpCurveMode.Linear);
			interpCurvePointVector.InVal = 0f;
			interpCurvePointVector.OutVal.DeepCopy(start);
			if (startTangent != null)
			{
				interpCurvePointVector.ArriveTangent.DeepCopy(startTangent);
				interpCurvePointVector.LeaveTangent.DeepCopy(startTangent);
			}
			InterpCurvePointVector interpCurvePointVector2 = new InterpCurvePointVector(global::EInterpCurveMode.CurveAutoClamped);
			interpCurvePointVector2.InVal = 1f;
			interpCurvePointVector2.OutVal.DeepCopy(end);
			SplineCurve splineCurve = new SplineCurve(10);
			splineCurve.InitPoints(new List<InterpCurvePointVector>
			{
				interpCurvePointVector,
				interpCurvePointVector2
			}, null);
			return splineCurve;
		}

		// Token: 0x060465CE RID: 288206 RVA: 0x011A28F4 File Offset: 0x011A0AF4
		[return: Nullable(0)]
		public ValueTuple<float, float> CalcJumpOffsetWithCorrection(float startDist, float speed, RailSlideParams config, Vector startLocation, Vector nearestPoint, Vector direction, bool addBlendDistance, float splineLength)
		{
			ValueTuple<float, float> valueTuple = this.CalcJumpOffsetDistance(startDist, speed, config, addBlendDistance);
			float item = valueTuple.Item1;
			float item2 = valueTuple.Item2;
			float num = item;
			if (startDist == 0f)
			{
				double num2 = Vector.PointPlaneDist(startLocation, nearestPoint, direction);
				if (num2 < 0.0)
				{
					num = Math.Max(100f, (float)((double)num + num2));
				}
			}
			if (num >= splineLength)
			{
				num = splineLength - 1f;
			}
			return new ValueTuple<float, float>(num, item2);
		}

		// Token: 0x060465CF RID: 288207 RVA: 0x011A2960 File Offset: 0x011A0B60
		private float CalcHorizontalLandingDistance(float horSpeed, float verSpeed, float height)
		{
			float num = Math.Max(0f, height);
			float num2 = verSpeed * 0.0010204081f;
			return ((float)Math.Sqrt((double)(num2 * num2 + 2f * num * 0.0010204081f)) - num2) * horSpeed;
		}

		// Token: 0x060465D0 RID: 288208 RVA: 0x011A29A0 File Offset: 0x011A0BA0
		[NullableContext(0)]
		private ValueTuple<float, float> CalcJumpOffsetDistance(float startDist, float speed, [Nullable(1)] RailSlideParams config, bool addBlendDistance)
		{
			int jumpAcceleration = config.JumpAcceleration;
			int targetSpeedForJump = config.TargetSpeedForJump;
			float num = (float)config.JumpBlendTime * 0.001f;
			float num2 = Math.Abs(((float)targetSpeedForJump - speed) / (float)jumpAcceleration);
			float num3 = 0f;
			float num4 = startDist;
			if (addBlendDistance)
			{
				if (num2 > num)
				{
					num3 = speed * num + (float)jumpAcceleration * num * num * 0.5f;
				}
				else
				{
					num3 = speed * num2 + (float)jumpAcceleration * num2 * num2 * 0.5f + (float)targetSpeedForJump * (num - num2);
				}
				num4 += num3;
			}
			num4 += (float)(targetSpeedForJump * config.AllTimeForJump) * 0.001f * config.BaseJumpDistanceRate;
			return new ValueTuple<float, float>(Math.Max(100f, num4), num3);
		}

		// Token: 0x060465D1 RID: 288209 RVA: 0x011A2A54 File Offset: 0x011A0C54
		[return: Nullable(0)]
		public ValueTuple<float, float> CalcSlopeAngle(Vector moveDirection, Vector gravityUp)
		{
			float num = (float)moveDirection.DotProduct(gravityUp);
			return new ValueTuple<float, float>(Math.Abs((float)Math.Acos((double)Math.Max(-1f, Math.Min(1f, num))) * 57.29578f - 90f), num);
		}

		// Token: 0x060465D2 RID: 288210 RVA: 0x011A2AA0 File Offset: 0x011A0CA0
		[return: Nullable(0)]
		public ValueTuple<float, float, float> DecomposeVelocity(Vector velocity, Vector tangentDirection, Vector gravityDirect, float fallbackHorSpeed)
		{
			bool flag = velocity.IsNearlyZero(9.999999747378752E-05);
			float num = (float)velocity.DotProduct(tangentDirection);
			object obj = (num > 0f && !flag) ? num : fallbackHorSpeed;
			float num2 = (float)velocity.DotProduct(gravityDirect);
			float num3 = (num2 > 0f && !flag) ? num2 : 0f;
			object obj2 = obj;
			float item = (float)Math.Sqrt(obj2 * obj2 + num3 * num3);
			return new ValueTuple<float, float, float>(obj2, num3, item);
		}

		// Token: 0x060465D3 RID: 288211 RVA: 0x011A2B0C File Offset: 0x011A0D0C
		public float CalcSpeedStep(float currentSpeed, float targetSpeed, float acceleration, float deltaMs, float slopeAngle, float maxSlopeAngle)
		{
			float num = Math.Min(slopeAngle, maxSlopeAngle) / maxSlopeAngle;
			float num2 = deltaMs * Math.Min(Math.Abs(acceleration), Math.Abs(targetSpeed)) * 0.001f * ((slopeAngle > 1f) ? num : 1f);
			float num3 = currentSpeed - targetSpeed;
			if (Math.Abs(num3) > num2)
			{
				return currentSpeed + ((num3 > 0f) ? (-num2) : num2);
			}
			return targetSpeed;
		}

		// Token: 0x060465D4 RID: 288212 RVA: 0x011A2B74 File Offset: 0x011A0D74
		public void StepDampedOscillator(IRailControlData data, float input, float deltaMs)
		{
			float num = deltaMs * 0.001f;
			float num2 = Math.Max(-1f, Math.Min(1f, input));
			float num3 = 1f;
			if (!data.IgnoreMaxAngle)
			{
				float num4 = Math.Abs(data.Rad) / data.MaxAngle;
				float num5 = Math.Max(0f, 1f - num4);
				num3 = ((num2 * data.Rad > 0f) ? (num5 * num5) : 1f);
			}
			float num6 = num2 * num3 * data.InputCoefficient - data.RegressionSpeed * data.Rad - data.Damping * data.AngularVelocity;
			float num7 = data.AngularVelocity + num6 * num;
			float num8 = (data.Radius > 1f) ? Math.Min(data.GetLimitLinearVelocity() / data.Radius, data.MaxAngularVelocity) : data.MaxAngularVelocity;
			num7 = Math.Max(-num8, Math.Min(num8, num7));
			float num9 = data.Rad + num7 * num;
			if (!data.IgnoreMaxAngle)
			{
				num9 = Math.Max(-data.MaxAngle, Math.Min(data.MaxAngle, num9));
				if ((num9 >= data.MaxAngle && num7 > 0f) || (num9 <= -data.MaxAngle && num7 < 0f))
				{
					num7 = 0f;
				}
			}
			data.Rad = num9;
			data.AngularVelocity = num7;
		}

		// Token: 0x060465D5 RID: 288213 RVA: 0x011A2CD8 File Offset: 0x011A0ED8
		public void CalcCircularArcOffset(IRailControlData data, Vector outOffset, Rotator outRotator, Vector tmpVector)
		{
			float num = data.Rad * 57.29578f;
			outOffset.DeepCopy(data.ToCenterVector);
			outOffset.RotateAngleAxis((double)num, data.SplineForwardVector, outOffset);
			tmpVector.DeepCopy(outOffset);
			if (!data.InnerArc)
			{
				tmpVector.UnaryNegation(tmpVector);
			}
			MathUtils.Instance.LookRotationForwardFirst(data.SplineForwardVector, tmpVector, outRotator);
			outRotator.Normalize(outRotator);
			outOffset.MultiplyEqual((double)(-(double)data.Radius));
			outOffset.AdditionEqual(data.CenterLocation);
			tmpVector.MultiplyEqual((double)data.HalfHeight);
			outOffset.AdditionEqual(tmpVector);
			outOffset.SubtractionEqual(data.DefaultLocation);
		}

		// Token: 0x060465D6 RID: 288214 RVA: 0x011A2D82 File Offset: 0x011A0F82
		public void DebugDrawSphere(bool debug, Vector location, FLinearColor color, float duration = 15f)
		{
			if (GlobalData.IsPlayInEditor && debug)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, location.ToUeVector(false), 20f, 10, new FLinearColor?(color), duration, 0f);
			}
		}

		// Token: 0x060465D7 RID: 288215 RVA: 0x011A2DB2 File Offset: 0x011A0FB2
		public void DebugDrawArrow(bool debug, Vector start, Vector end, FLinearColor color)
		{
			if (GlobalData.IsPlayInEditor && debug)
			{
				UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, start.ToUeVector(false), end.ToUeVector(false), 100f, color, 0f, 0f);
			}
		}

		// Token: 0x060465D8 RID: 288216 RVA: 0x011A2DE8 File Offset: 0x011A0FE8
		public void DebugDrawCurve(bool debug, SplineCurve curve, Vector outVector, FLinearColor color)
		{
		}

		// Token: 0x17009C84 RID: 40068
		// (get) Token: 0x060465D9 RID: 288217 RVA: 0x011A2DF5 File Offset: 0x011A0FF5
		public static CharacterRailSlideController Instance
		{
			get
			{
				return CharacterRailSlideController._Instance;
			}
		}

		// Token: 0x060465DA RID: 288218 RVA: 0x011A2DFC File Offset: 0x011A0FFC
		public static CharacterRailSlideController GetOrCreateInstance()
		{
			if (CharacterRailSlideController._Instance == null)
			{
				CharacterRailSlideController.CreateInstance();
			}
			return CharacterRailSlideController._Instance;
		}

		// Token: 0x060465DB RID: 288219 RVA: 0x011A2E10 File Offset: 0x011A1010
		public static bool CreateInstance()
		{
			if (CharacterRailSlideController._Instance != null)
			{
				return true;
			}
			CharacterRailSlideController._Instance = new CharacterRailSlideController();
			return true;
		}

		// Token: 0x060465DC RID: 288220 RVA: 0x011A2E26 File Offset: 0x011A1026
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060465DD RID: 288221 RVA: 0x011A2E28 File Offset: 0x011A1028
		public static void ResetStaticDefaultValue()
		{
			CharacterRailSlideController._Instance = null;
		}

		// Token: 0x060465DE RID: 288222 RVA: 0x011A2E30 File Offset: 0x011A1030
		static CharacterRailSlideController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterRailSlideController.CreateStaticDefaultValue), new Action(CharacterRailSlideController.ResetStaticDefaultValue));
		}

		// Token: 0x04024DD1 RID: 150993
		private const float MS_TO_SECOUND = 0.001f;

		// Token: 0x04024DD2 RID: 150994
		private const float CENTIMETER_TO_METER = 0.01f;

		// Token: 0x04024DD3 RID: 150995
		private const float GRAVITY_ACCELERATION = 980f;

		// Token: 0x04024DD4 RID: 150996
		private const float GRAVITY_ACCELERATION_RECIPROCAL = 0.0010204081f;

		// Token: 0x04024DD5 RID: 150997
		private const float MIN_EFFECTIVE_RADIUS = 1f;

		// Token: 0x04024DD6 RID: 150998
		private const float FOLLOWER_TOLERANCE_DIST = 20f;

		// Token: 0x04024DD7 RID: 150999
		private const float SAFE_DISTANCE = 80f;

		// Token: 0x04024DD8 RID: 151000
		private const float DEBUG_DRAW_RADIUS = 20f;

		// Token: 0x04024DD9 RID: 151001
		private const float DEBUG_DRAW_DURATION = 15f;

		// Token: 0x04024DDA RID: 151002
		private const int DEBUG_DRAW_SEGMENTS = 10;

		// Token: 0x04024DDB RID: 151003
		private const float MIN_ENTER_RAIL_DISTANCE = 100f;

		// Token: 0x04024DDC RID: 151004
		private readonly Dictionary<int, int> EntityRailMap = new Dictionary<int, int>();

		// Token: 0x04024DDD RID: 151005
		private readonly Dictionary<int, int> RailToEntityMap = new Dictionary<int, int>();

		// Token: 0x04024DDE RID: 151006
		private readonly Dictionary<int, CharacterRailSlideController.IActiveFollowerState> ActiveFollowerMap = new Dictionary<int, CharacterRailSlideController.IActiveFollowerState>();

		// Token: 0x04024DDF RID: 151007
		private readonly Dictionary<int, List<CharacterRailSlideController.RailFollowerEntry>> RailFollowerMap = new Dictionary<int, List<CharacterRailSlideController.RailFollowerEntry>>();

		// Token: 0x04024DE0 RID: 151008
		[Nullable(2)]
		private static CharacterRailSlideController _Instance;

		// Token: 0x0200CE5D RID: 52829
		private interface IActiveFollowerState
		{
			// Token: 0x1700A2BF RID: 41663
			// (get) Token: 0x06051E6B RID: 335467
			// (set) Token: 0x06051E6C RID: 335468
			RailSlideFollowerParams Params { get; set; }

			// Token: 0x1700A2C0 RID: 41664
			// (get) Token: 0x06051E6D RID: 335469
			// (set) Token: 0x06051E6E RID: 335470
			float LastDist { get; set; }

			// Token: 0x1700A2C1 RID: 41665
			// (get) Token: 0x06051E6F RID: 335471
			// (set) Token: 0x06051E70 RID: 335472
			bool CurrentSide { get; set; }

			// Token: 0x1700A2C2 RID: 41666
			// (get) Token: 0x06051E71 RID: 335473
			// (set) Token: 0x06051E72 RID: 335474
			float RadVelocity { get; set; }

			// Token: 0x1700A2C3 RID: 41667
			// (get) Token: 0x06051E73 RID: 335475
			// (set) Token: 0x06051E74 RID: 335476
			float SmoothedLeaderRad { get; set; }
		}

		// Token: 0x0200CE5E RID: 52830
		[Nullable(0)]
		private class ActiveFollowerState : CharacterRailSlideController.IActiveFollowerState
		{
			// Token: 0x1700A2C4 RID: 41668
			// (get) Token: 0x06051E75 RID: 335477 RVA: 0x01641C45 File Offset: 0x0163FE45
			// (set) Token: 0x06051E76 RID: 335478 RVA: 0x01641C4D File Offset: 0x0163FE4D
			public RailSlideFollowerParams Params { get; set; }

			// Token: 0x1700A2C5 RID: 41669
			// (get) Token: 0x06051E77 RID: 335479 RVA: 0x01641C56 File Offset: 0x0163FE56
			// (set) Token: 0x06051E78 RID: 335480 RVA: 0x01641C5E File Offset: 0x0163FE5E
			public float LastDist { get; set; }

			// Token: 0x1700A2C6 RID: 41670
			// (get) Token: 0x06051E79 RID: 335481 RVA: 0x01641C67 File Offset: 0x0163FE67
			// (set) Token: 0x06051E7A RID: 335482 RVA: 0x01641C6F File Offset: 0x0163FE6F
			public bool CurrentSide { get; set; }

			// Token: 0x1700A2C7 RID: 41671
			// (get) Token: 0x06051E7B RID: 335483 RVA: 0x01641C78 File Offset: 0x0163FE78
			// (set) Token: 0x06051E7C RID: 335484 RVA: 0x01641C80 File Offset: 0x0163FE80
			public float RadVelocity { get; set; }

			// Token: 0x1700A2C8 RID: 41672
			// (get) Token: 0x06051E7D RID: 335485 RVA: 0x01641C89 File Offset: 0x0163FE89
			// (set) Token: 0x06051E7E RID: 335486 RVA: 0x01641C91 File Offset: 0x0163FE91
			public float SmoothedLeaderRad { get; set; }
		}

		// Token: 0x0200CE5F RID: 52831
		[Nullable(0)]
		private class RailFollowerEntry
		{
			// Token: 0x0403E219 RID: 254489
			public int PbDataId;

			// Token: 0x0403E21A RID: 254490
			public RailSlideFollowerParams Params;

			// Token: 0x0403E21B RID: 254491
			public string DaPath;

			// Token: 0x0403E21C RID: 254492
			public int RailId;
		}
	}
}
