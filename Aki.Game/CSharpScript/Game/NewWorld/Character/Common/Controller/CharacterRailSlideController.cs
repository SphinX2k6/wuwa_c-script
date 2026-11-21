using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.RailSlideFollower;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006318 RID: 25368
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CharacterRailSlideController : ControllerBase
	{
		// Token: 0x0603D669 RID: 251497 RVA: 0x011BF784 File Offset: 0x011BD984
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

		// Token: 0x0603D66A RID: 251498 RVA: 0x011BF7E8 File Offset: 0x011BD9E8
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

		// Token: 0x0603D66B RID: 251499 RVA: 0x011BF834 File Offset: 0x011BDA34
		public int? GetEntityRailId(int entityId)
		{
			int value;
			if (!this.EntityRailMap.TryGetValue(entityId, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0603D66C RID: 251500 RVA: 0x011BF864 File Offset: 0x011BDA64
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

		// Token: 0x0603D66D RID: 251501 RVA: 0x011BF980 File Offset: 0x011BDB80
		private int GetRailActiveEntity(int railId)
		{
			int result;
			if (!this.RailToEntityMap.TryGetValue(railId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0603D66E RID: 251502 RVA: 0x011BF9A0 File Offset: 0x011BDBA0
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

		// Token: 0x0603D66F RID: 251503 RVA: 0x011BFB3C File Offset: 0x011BDD3C
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

		// Token: 0x0603D670 RID: 251504 RVA: 0x011BFBCC File Offset: 0x011BDDCC
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

		// Token: 0x0603D671 RID: 251505 RVA: 0x011BFCC8 File Offset: 0x011BDEC8
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

		// Token: 0x0603D672 RID: 251506 RVA: 0x011BFEA4 File Offset: 0x011BE0A4
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

		// Token: 0x0603D673 RID: 251507 RVA: 0x011BFFBA File Offset: 0x011BE1BA
		public void RemoveActiveFollower(int pbDataId)
		{
			this.ActiveFollowerMap.Remove(pbDataId);
		}

		// Token: 0x0603D674 RID: 251508 RVA: 0x011BFFCC File Offset: 0x011BE1CC
		public float CalcParabolicHeight(IJumpProjectileParams projectileParams, float rate)
		{
			float num = rate * projectileParams.Length;
			return projectileParams.ProjectileA * num * num + projectileParams.ProjectileB * num;
		}

		// Token: 0x0603D675 RID: 251509 RVA: 0x011BFFF8 File Offset: 0x011BE1F8
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

		// Token: 0x0603D676 RID: 251510 RVA: 0x011C00C0 File Offset: 0x011BE2C0
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

		// Token: 0x0603D677 RID: 251511 RVA: 0x011C013C File Offset: 0x011BE33C
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

		// Token: 0x0603D678 RID: 251512 RVA: 0x011C01C8 File Offset: 0x011BE3C8
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

		// Token: 0x0603D679 RID: 251513 RVA: 0x011C0234 File Offset: 0x011BE434
		private float CalcHorizontalLandingDistance(float horSpeed, float verSpeed, float height)
		{
			float num = Math.Max(0f, height);
			float num2 = verSpeed * 0.0010204081f;
			return ((float)Math.Sqrt((double)(num2 * num2 + 2f * num * 0.0010204081f)) - num2) * horSpeed;
		}

		// Token: 0x0603D67A RID: 251514 RVA: 0x011C0274 File Offset: 0x011BE474
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

		// Token: 0x0603D67B RID: 251515 RVA: 0x011C0328 File Offset: 0x011BE528
		[return: Nullable(0)]
		public ValueTuple<float, float> CalcSlopeAngle(Vector moveDirection, Vector gravityUp)
		{
			float num = (float)moveDirection.DotProduct(gravityUp);
			return new ValueTuple<float, float>(Math.Abs((float)Math.Acos((double)Math.Max(-1f, Math.Min(1f, num))) * 57.29578f - 90f), num);
		}

		// Token: 0x0603D67C RID: 251516 RVA: 0x011C0374 File Offset: 0x011BE574
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

		// Token: 0x0603D67D RID: 251517 RVA: 0x011C03E0 File Offset: 0x011BE5E0
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

		// Token: 0x0603D67E RID: 251518 RVA: 0x011C0448 File Offset: 0x011BE648
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

		// Token: 0x0603D67F RID: 251519 RVA: 0x011C05AC File Offset: 0x011BE7AC
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

		// Token: 0x0603D680 RID: 251520 RVA: 0x011C0656 File Offset: 0x011BE856
		public void DebugDrawSphere(bool debug, Vector location, FLinearColor color, float duration = 15f)
		{
			if (GlobalData.IsPlayInEditor && debug)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, location.ToUeVector(false), 20f, 10, new FLinearColor?(color), duration, 0f);
			}
		}

		// Token: 0x0603D681 RID: 251521 RVA: 0x011C0686 File Offset: 0x011BE886
		public void DebugDrawArrow(bool debug, Vector start, Vector end, FLinearColor color)
		{
			if (GlobalData.IsPlayInEditor && debug)
			{
				UKismetSystemLibrary.D_DrawDebugArrow(GlobalData.World, start.ToUeVector(false), end.ToUeVector(false), 100f, color, 0f, 0f);
			}
		}

		// Token: 0x0603D682 RID: 251522 RVA: 0x011C06BC File Offset: 0x011BE8BC
		public void DebugDrawCurve(bool debug, SplineCurve curve, Vector outVector, FLinearColor color)
		{
		}

		// Token: 0x17007478 RID: 29816
		// (get) Token: 0x0603D683 RID: 251523 RVA: 0x011C06C9 File Offset: 0x011BE8C9
		public static CharacterRailSlideController Instance
		{
			get
			{
				return CharacterRailSlideController._Instance;
			}
		}

		// Token: 0x0603D684 RID: 251524 RVA: 0x011C06D0 File Offset: 0x011BE8D0
		public static CharacterRailSlideController GetOrCreateInstance()
		{
			if (CharacterRailSlideController._Instance == null)
			{
				CharacterRailSlideController.CreateInstance();
			}
			return CharacterRailSlideController._Instance;
		}

		// Token: 0x0603D685 RID: 251525 RVA: 0x011C06E4 File Offset: 0x011BE8E4
		public static bool CreateInstance()
		{
			if (CharacterRailSlideController._Instance != null)
			{
				return true;
			}
			CharacterRailSlideController._Instance = new CharacterRailSlideController();
			return true;
		}

		// Token: 0x0603D686 RID: 251526 RVA: 0x011C06FA File Offset: 0x011BE8FA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D687 RID: 251527 RVA: 0x011C06FC File Offset: 0x011BE8FC
		public static void ResetStaticDefaultValue()
		{
			CharacterRailSlideController._Instance = null;
		}

		// Token: 0x0603D688 RID: 251528 RVA: 0x011C0704 File Offset: 0x011BE904
		static CharacterRailSlideController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterRailSlideController.CreateStaticDefaultValue), new Action(CharacterRailSlideController.ResetStaticDefaultValue));
		}

		// Token: 0x040208F8 RID: 133368
		private const float MS_TO_SECOUND = 0.001f;

		// Token: 0x040208F9 RID: 133369
		private const float CENTIMETER_TO_METER = 0.01f;

		// Token: 0x040208FA RID: 133370
		private const float GRAVITY_ACCELERATION = 980f;

		// Token: 0x040208FB RID: 133371
		private const float GRAVITY_ACCELERATION_RECIPROCAL = 0.0010204081f;

		// Token: 0x040208FC RID: 133372
		private const float MIN_EFFECTIVE_RADIUS = 1f;

		// Token: 0x040208FD RID: 133373
		private const float FOLLOWER_TOLERANCE_DIST = 20f;

		// Token: 0x040208FE RID: 133374
		private const float SAFE_DISTANCE = 80f;

		// Token: 0x040208FF RID: 133375
		private const float DEBUG_DRAW_RADIUS = 20f;

		// Token: 0x04020900 RID: 133376
		private const float DEBUG_DRAW_DURATION = 15f;

		// Token: 0x04020901 RID: 133377
		private const int DEBUG_DRAW_SEGMENTS = 10;

		// Token: 0x04020902 RID: 133378
		private const float MIN_ENTER_RAIL_DISTANCE = 100f;

		// Token: 0x04020903 RID: 133379
		private readonly Dictionary<int, int> EntityRailMap = new Dictionary<int, int>();

		// Token: 0x04020904 RID: 133380
		private readonly Dictionary<int, int> RailToEntityMap = new Dictionary<int, int>();

		// Token: 0x04020905 RID: 133381
		private readonly Dictionary<int, CharacterRailSlideController.IActiveFollowerState> ActiveFollowerMap = new Dictionary<int, CharacterRailSlideController.IActiveFollowerState>();

		// Token: 0x04020906 RID: 133382
		private readonly Dictionary<int, List<CharacterRailSlideController.RailFollowerEntry>> RailFollowerMap = new Dictionary<int, List<CharacterRailSlideController.RailFollowerEntry>>();

		// Token: 0x04020907 RID: 133383
		[Nullable(2)]
		private static CharacterRailSlideController _Instance;

		// Token: 0x0200BB30 RID: 47920
		private interface IActiveFollowerState
		{
			// Token: 0x17007A76 RID: 31350
			// (get) Token: 0x060488D6 RID: 297174
			// (set) Token: 0x060488D7 RID: 297175
			RailSlideFollowerParams Params { get; set; }

			// Token: 0x17007A77 RID: 31351
			// (get) Token: 0x060488D8 RID: 297176
			// (set) Token: 0x060488D9 RID: 297177
			float LastDist { get; set; }

			// Token: 0x17007A78 RID: 31352
			// (get) Token: 0x060488DA RID: 297178
			// (set) Token: 0x060488DB RID: 297179
			bool CurrentSide { get; set; }

			// Token: 0x17007A79 RID: 31353
			// (get) Token: 0x060488DC RID: 297180
			// (set) Token: 0x060488DD RID: 297181
			float RadVelocity { get; set; }

			// Token: 0x17007A7A RID: 31354
			// (get) Token: 0x060488DE RID: 297182
			// (set) Token: 0x060488DF RID: 297183
			float SmoothedLeaderRad { get; set; }
		}

		// Token: 0x0200BB31 RID: 47921
		[Nullable(0)]
		private class ActiveFollowerState : CharacterRailSlideController.IActiveFollowerState
		{
			// Token: 0x17007A7B RID: 31355
			// (get) Token: 0x060488E0 RID: 297184 RVA: 0x0161F652 File Offset: 0x0161D852
			// (set) Token: 0x060488E1 RID: 297185 RVA: 0x0161F65A File Offset: 0x0161D85A
			public RailSlideFollowerParams Params { get; set; }

			// Token: 0x17007A7C RID: 31356
			// (get) Token: 0x060488E2 RID: 297186 RVA: 0x0161F663 File Offset: 0x0161D863
			// (set) Token: 0x060488E3 RID: 297187 RVA: 0x0161F66B File Offset: 0x0161D86B
			public float LastDist { get; set; }

			// Token: 0x17007A7D RID: 31357
			// (get) Token: 0x060488E4 RID: 297188 RVA: 0x0161F674 File Offset: 0x0161D874
			// (set) Token: 0x060488E5 RID: 297189 RVA: 0x0161F67C File Offset: 0x0161D87C
			public bool CurrentSide { get; set; }

			// Token: 0x17007A7E RID: 31358
			// (get) Token: 0x060488E6 RID: 297190 RVA: 0x0161F685 File Offset: 0x0161D885
			// (set) Token: 0x060488E7 RID: 297191 RVA: 0x0161F68D File Offset: 0x0161D88D
			public float RadVelocity { get; set; }

			// Token: 0x17007A7F RID: 31359
			// (get) Token: 0x060488E8 RID: 297192 RVA: 0x0161F696 File Offset: 0x0161D896
			// (set) Token: 0x060488E9 RID: 297193 RVA: 0x0161F69E File Offset: 0x0161D89E
			public float SmoothedLeaderRad { get; set; }
		}

		// Token: 0x0200BB32 RID: 47922
		[Nullable(0)]
		private class RailFollowerEntry
		{
			// Token: 0x04039949 RID: 235849
			public int PbDataId;

			// Token: 0x0403994A RID: 235850
			public RailSlideFollowerParams Params;

			// Token: 0x0403994B RID: 235851
			public string DaPath;

			// Token: 0x0403994C RID: 235852
			public int RailId;
		}
	}
}
