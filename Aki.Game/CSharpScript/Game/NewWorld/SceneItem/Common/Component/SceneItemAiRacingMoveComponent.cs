using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.AIGearStrategy.AIRaceStrategy;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x02007215 RID: 29205
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemAiRacingMoveComponent : EntityComponent
	{
		// Token: 0x060477EB RID: 292843 RVA: 0x01237D36 File Offset: 0x01235F36
		protected override bool OnStart()
		{
			this.MoveComp = base.Entity.GetComponent<SceneItemMoveComponent>();
			return true;
		}

		// Token: 0x060477EC RID: 292844 RVA: 0x01237D4A File Offset: 0x01235F4A
		protected override void OnActivate()
		{
			this.ToggleTick(this.EnableAiRace, "OnActivate时检查EnableAiRace并开关Tick");
		}

		// Token: 0x060477ED RID: 292845 RVA: 0x01237D60 File Offset: 0x01235F60
		protected override void OnTick(float delta)
		{
			if (!this.EnableAiRace)
			{
				this.ToggleTick(false, "OnTick中检查EnableAiRace并保底关闭");
				return;
			}
			if (this.MoveComp != null && this.SplineComp != null && this.AiInfo != null)
			{
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				if (component == null || !component.GetRemoveState())
				{
					this.UpdateAiPerceptionData(delta);
					this.CalcTargetMoveData();
					this.ApplyTargetMoveData(false);
					return;
				}
			}
			this.AiPerceptionData = null;
		}

		// Token: 0x060477EE RID: 292846 RVA: 0x01237DD0 File Offset: 0x01235FD0
		private void UpdateAiPerceptionData(float delta)
		{
			if (this.AiPerceptionData == null)
			{
				this.AiPerceptionData = new AiRacingPerceptionData();
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent;
			if (baseCharacter == null)
			{
				characterActorComponent = null;
			}
			else
			{
				Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
				characterActorComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterActorComponent>() : null);
			}
			CharacterActorComponent characterActorComponent2 = characterActorComponent;
			TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
			RoleDriveVehicleComponent roleDriveVehicleComponent;
			if (baseCharacter2 == null)
			{
				roleDriveVehicleComponent = null;
			}
			else
			{
				Entity entityNoBlueprint2 = baseCharacter2.GetEntityNoBlueprint();
				roleDriveVehicleComponent = ((entityNoBlueprint2 != null) ? entityNoBlueprint2.GetComponent<RoleDriveVehicleComponent>() : null);
			}
			RoleDriveVehicleComponent roleDriveVehicleComponent2 = roleDriveVehicleComponent;
			BaseActorComponent component = base.Entity.GetComponent<BaseActorComponent>();
			if (!this.AiPerceptionData.SelfLocation.IsZero() && ((component != null) ? component.ActorLocationProxy : null) != null)
			{
				component.ActorLocationProxy.Subtraction(this.AiPerceptionData.SelfLocation, this.AiPerceptionData.SelfEstimationVelocity);
				this.AiPerceptionData.SelfEstimationVelocity.MultiplyEqual((double)(1f / (delta * 0.001f)));
			}
			this.AiPerceptionData.PlayerLocation.DeepCopy(((characterActorComponent2 != null) ? characterActorComponent2.ActorLocationProxy : null) ?? Vector.ZeroVectorProxy);
			this.AiPerceptionData.SelfLocation.DeepCopy(((component != null) ? component.ActorLocationProxy : null) ?? Vector.ZeroVectorProxy);
			bool flag = true;
			if (!this.AiPerceptionData.SelfEstimationVelocity.IsZero() && !this.AiPerceptionData.PlayerLocation.IsZero() && !this.AiPerceptionData.SelfLocation.IsZero())
			{
				this.AiPerceptionData.SelfLocation.Subtraction(this.AiPerceptionData.PlayerLocation, MathUtils.Instance.CommonTempVector);
				flag = (MathUtils.Instance.CommonTempVector.DotProduct(this.AiPerceptionData.SelfEstimationVelocity) > 0.0);
			}
			this.AiPerceptionData.DistanceBetween = (float)(Vector.Dist(this.AiPerceptionData.PlayerLocation, this.AiPerceptionData.SelfLocation) * (double)(flag ? 1f : -1f));
			Vector vector;
			if (roleDriveVehicleComponent2 == null || !roleDriveVehicleComponent2.IsOnVehicle)
			{
				vector = ((characterActorComponent2 != null) ? characterActorComponent2.SafeActorVelocityProxy : null);
			}
			else
			{
				Entity vehicleEntity = roleDriveVehicleComponent2.VehicleEntity;
				if (vehicleEntity == null)
				{
					vector = null;
				}
				else
				{
					BaseActorComponent component2 = vehicleEntity.GetComponent<BaseActorComponent>();
					vector = ((component2 != null) ? component2.SafeActorVelocityProxy : null);
				}
			}
			Vector vector2 = vector;
			this.AiPerceptionData.PlayerVelocity.DeepCopy(vector2 ?? Vector.ZeroVectorProxy);
			this.AiPerceptionData.PlayerAbsSpeed = (float)this.AiPerceptionData.PlayerVelocity.Size();
			AiRacingPerceptionData aiPerceptionData = this.AiPerceptionData;
			SceneItemMoveComponent moveComp = this.MoveComp;
			aiPerceptionData.SelfSplineMoveData = ((moveComp != null) ? moveComp.GetSplineMoveDynamicSpeedData() : null);
			AiRacingPerceptionData aiPerceptionData2 = this.AiPerceptionData;
			AiRacingPerceptionData aiPerceptionData3 = this.AiPerceptionData;
			aiPerceptionData2.SelfAbsSpeed = ((aiPerceptionData3.SelfSplineMoveData != null) ? aiPerceptionData3.SelfSplineMoveData.GetValueOrDefault().CurrentSpeed : 0f);
			this.AiPerceptionData.DeltaAbsSpeed = (float)((double)this.AiPerceptionData.SelfAbsSpeed - this.AiPerceptionData.PlayerVelocity.Size());
			SceneItemMoveComponent moveComp2 = this.MoveComp;
			if (moveComp2 != null && moveComp2.IsMoving)
			{
				this.AiPerceptionData.SelfKeepMovingTime += delta * 0.001f;
			}
			else
			{
				this.AiPerceptionData.SelfKeepMovingTime = 0f;
			}
			SundryModel.Instance.GetModuleDebugLevel("AI_RACING_DEBUG");
		}

		// Token: 0x060477EF RID: 292847 RVA: 0x012380E0 File Offset: 0x012362E0
		private void CalcTargetMoveData()
		{
			if (this.SplineComp == null || this.AiInfo == null)
			{
				return;
			}
			if (this.TargetStartMoveParam == null)
			{
				this.TargetStartMoveParam = new SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedParam(this.SplineComp)
				{
					InitSpeed = this.AiInfo.DefaultSpeed,
					TargetSpeed = this.AiInfo.DefaultSpeed,
					IsCycle = true,
					Acceleration = 0f,
					MaxMoveTimes = -1,
					IsKeepLookAt = true
				};
			}
			if (this.AiPerceptionData == null)
			{
				return;
			}
			if (this.TargetEditableParam == null)
			{
				this.TargetEditableParam = new SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam();
			}
			if (this.LastEditableParam == null)
			{
				this.LastEditableParam = new SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam();
			}
			SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam targetEditableParam = this.TargetEditableParam;
			SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam lastEditableParam = this.LastEditableParam;
			this.LastEditableParam = targetEditableParam;
			this.TargetEditableParam = lastEditableParam;
			this.TargetEditableParam.Clear();
			List<float> list = new List<float>();
			list.Add(this.AiInfo.DefaultSpeed);
			if (this.AiInfo.CorrectionByDistanceConfig.Enable)
			{
				TArray<SAiRaceStrategyOneParamFunction> calcTargetSpeedByDistanceBetweenConfig = this.AiInfo.CorrectionByDistanceConfig.CalcTargetSpeedByDistanceBetweenConfig;
				for (int i = 0; i < calcTargetSpeedByDistanceBetweenConfig.Num(); i++)
				{
					SAiRaceStrategyOneParamFunction func = calcTargetSpeedByDistanceBetweenConfig.Get(i);
					float? num = this.CalcAiRaceStrategyOneParamFunction(func, this.AiPerceptionData.DistanceBetween);
					if (num != null)
					{
						list.Add(num.Value);
						break;
					}
				}
			}
			if (this.AiInfo.CorrectionBySpeedConfig.Enable)
			{
				TArray<SAiRaceStrategyOneParamFunction> calcTargetSpeedByDeltaAbsSpeedConfig = this.AiInfo.CorrectionBySpeedConfig.CalcTargetSpeedByDeltaAbsSpeedConfig;
				for (int j = 0; j < calcTargetSpeedByDeltaAbsSpeedConfig.Num(); j++)
				{
					SAiRaceStrategyOneParamFunction func2 = calcTargetSpeedByDeltaAbsSpeedConfig.Get(j);
					float? num2 = this.CalcAiRaceStrategyOneParamFunction(func2, this.AiPerceptionData.DeltaAbsSpeed);
					if (num2 != null)
					{
						list.Add(num2.Value);
						break;
					}
				}
				TArray<SAiRaceStrategyOneParamFunction> calcTargetSpeedByRivalAbsSpeedConfig = this.AiInfo.CorrectionBySpeedConfig.CalcTargetSpeedByRivalAbsSpeedConfig;
				for (int k = 0; k < calcTargetSpeedByRivalAbsSpeedConfig.Num(); k++)
				{
					SAiRaceStrategyOneParamFunction func3 = calcTargetSpeedByRivalAbsSpeedConfig.Get(k);
					float? num3 = this.CalcAiRaceStrategyOneParamFunction(func3, this.AiPerceptionData.PlayerAbsSpeed);
					if (num3 != null)
					{
						list.Add(num3.Value);
						break;
					}
				}
			}
			if (this.AiInfo.CorrectionByTimeConfig.Enable)
			{
				TArray<SAiRaceStrategyOneParamFunction> calcTargetSpeedByRunningTimeConfig = this.AiInfo.CorrectionByTimeConfig.CalcTargetSpeedByRunningTimeConfig;
				for (int l = 0; l < calcTargetSpeedByRunningTimeConfig.Num(); l++)
				{
					SAiRaceStrategyOneParamFunction func4 = calcTargetSpeedByRunningTimeConfig.Get(l);
					float? num4 = this.CalcAiRaceStrategyOneParamFunction(func4, this.AiPerceptionData.SelfKeepMovingTime);
					if (num4 != null)
					{
						list.Add(num4.Value);
						break;
					}
				}
			}
			float? num5 = this.CalcAiRaceStrategyMultiParamFunction(this.AiInfo.CalcTargetSpeedConfig, list);
			this.TargetEditableParam.TargetSpeed = new float?(num5 ?? this.AiInfo.DefaultSpeed);
			float selfAbsSpeed = this.AiPerceptionData.SelfAbsSpeed;
			float? targetSpeed = this.TargetEditableParam.TargetSpeed;
			if (selfAbsSpeed < targetSpeed.GetValueOrDefault() & targetSpeed != null)
			{
				this.TargetEditableParam.Acceleration = new float?(this.AiInfo.DefaultAcceleration);
			}
			else
			{
				float selfAbsSpeed2 = this.AiPerceptionData.SelfAbsSpeed;
				targetSpeed = this.TargetEditableParam.TargetSpeed;
				if (selfAbsSpeed2 > targetSpeed.GetValueOrDefault() & targetSpeed != null)
				{
					this.TargetEditableParam.Acceleration = new float?(-this.AiInfo.DefaultDeceleration);
				}
				else
				{
					this.TargetEditableParam.Acceleration = new float?(0f);
				}
			}
			this.TargetEditableParam.CurrentSpeed = null;
		}

		// Token: 0x060477F0 RID: 292848 RVA: 0x0123847C File Offset: 0x0123667C
		private void ApplyTargetMoveData(bool force = false)
		{
			if (this.MoveComp == null || this.TargetStartMoveParam == null)
			{
				return;
			}
			if (!this.MoveComp.IsSplineMoving())
			{
				this.MoveComp.StartSplineMoveAtDynamicSpeedImplement(this.TargetStartMoveParam, null, true);
				SundryModel.Instance.GetModuleDebugLevel("AI_RACING_DEBUG");
			}
			if (this.TargetEditableParam != null && (force || !this.TargetEditableParam.Equals(this.LastEditableParam)))
			{
				this.MoveComp.UpdatePatrolAtDynamicSpeedEditableParam(this.TargetEditableParam);
			}
		}

		// Token: 0x060477F1 RID: 292849 RVA: 0x01238500 File Offset: 0x01236700
		[NullableContext(1)]
		private float? CalcAiRaceStrategyOneParamFunction(SAiRaceStrategyOneParamFunction func, float param)
		{
			FFloatRangeBound lowerBound = func.ParamRange.LowerBound;
			if ((lowerBound.Type == ERangeBoundTypes.Inclusive && param < lowerBound.Value) || (lowerBound.Type == ERangeBoundTypes.Exclusive && param <= lowerBound.Value))
			{
				return null;
			}
			FFloatRangeBound upperBound = func.ParamRange.UpperBound;
			if ((upperBound.Type == ERangeBoundTypes.Inclusive && param > upperBound.Value) || (upperBound.Type == ERangeBoundTypes.Exclusive && param >= upperBound.Value))
			{
				return null;
			}
			TArray<float> coefficientList = func.CoefficientList;
			int num = coefficientList.Num();
			float? result = null;
			switch (func.FunctionType)
			{
			case EAiRaceStrategyOneParamFuncType.Constant:
				result = ((num < 1) ? null : new float?(coefficientList.Get(0)));
				break;
			case EAiRaceStrategyOneParamFuncType.Linear:
				result = ((num < 2) ? null : new float?(coefficientList.Get(0) * param + coefficientList.Get(1)));
				break;
			case EAiRaceStrategyOneParamFuncType.Quadratic:
				result = ((num < 3) ? null : new float?(coefficientList.Get(0) * param * param + coefficientList.Get(1) * param + coefficientList.Get(2)));
				break;
			case EAiRaceStrategyOneParamFuncType.Comparison:
				if (num >= 4)
				{
					float num2 = coefficientList.Get(0);
					if (param > num2)
					{
						result = new float?(coefficientList.Get(1));
					}
					else if (Math.Abs(param - num2) < 1.1754944E-38f)
					{
						result = new float?(coefficientList.Get(2));
					}
					else
					{
						result = new float?(coefficientList.Get(3));
					}
				}
				break;
			}
			return result;
		}

		// Token: 0x060477F2 RID: 292850 RVA: 0x012386C4 File Offset: 0x012368C4
		[NullableContext(1)]
		private float? CalcAiRaceStrategyMultiParamFunction(SAiRaceStrategyMultiParamFunction func, IList<float> parameters)
		{
			if (parameters.Count <= 0)
			{
				return null;
			}
			float? num = null;
			switch (func.FunctionType)
			{
			case EAiRaceStrategyMultiParamFuncType.Sum:
				num = new float?(0f);
				foreach (float num2 in parameters)
				{
					num += num2;
				}
				return num;
			case EAiRaceStrategyMultiParamFuncType.Max:
				break;
			case EAiRaceStrategyMultiParamFuncType.Min:
				num = new float?(float.MaxValue);
				using (IEnumerator<float> enumerator = parameters.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						float num3 = enumerator.Current;
						float num4 = num3;
						float? num5 = num;
						if (num4 < num5.GetValueOrDefault() & num5 != null)
						{
							num = new float?(num3);
						}
					}
					return num;
				}
				break;
			case EAiRaceStrategyMultiParamFuncType.Avg:
				goto IL_E8;
			default:
				return num;
			}
			num = new float?(float.MinValue);
			using (IEnumerator<float> enumerator = parameters.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					float num6 = enumerator.Current;
					float num7 = num6;
					float? num5 = num;
					if (num7 > num5.GetValueOrDefault() & num5 != null)
					{
						num = new float?(num6);
					}
				}
				return num;
			}
			IL_E8:
			num = new float?(0f);
			foreach (float num8 in parameters)
			{
				num += num8;
			}
			num /= (float)parameters.Count;
			return num;
		}

		// Token: 0x060477F3 RID: 292851 RVA: 0x012388D0 File Offset: 0x01236AD0
		public void RegisterAiInfo(BP_AIRaceStrategy_C config, int splineId)
		{
			this.AiInfo = config;
			this.SplineComp = GameSplineModel.Instance.LoadAndGetSplineComponent(splineId, base.Entity.Id, EIdType.EntityId);
			this.SplineActor = GameSplineModel.Instance.GetSplineActorBySplineId(splineId);
			USplineComponent splineComp = this.SplineComp;
			if (splineComp != null && splineComp.IsValid())
			{
				TsGameSplineActor splineActor = this.SplineActor;
				if (splineActor != null && splineActor.IsValid())
				{
					return;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Level;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[AiRacingMove] Spline获取失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SplineEntityId", splineId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060477F4 RID: 292852 RVA: 0x0123896C File Offset: 0x01236B6C
		public void RefreshAiEnable(bool enable)
		{
			if (this.AiInfo == null)
			{
				return;
			}
			if (this.EnableAiRace == enable)
			{
				return;
			}
			this.EnableAiRace = enable;
			this.ToggleTick(enable, "RefreshAiEnable");
		}

		// Token: 0x060477F5 RID: 292853 RVA: 0x01238994 File Offset: 0x01236B94
		[NullableContext(1)]
		public void ToggleTick(bool enable, string reason)
		{
			if (enable && this.DisableHandle != null)
			{
				base.Enable(new int?(this.DisableHandle.Value), reason);
				this.AiPerceptionData = null;
				return;
			}
			if (!enable && this.DisableHandle == null)
			{
				this.DisableHandle = new int?(base.Disable(reason));
				this.AiPerceptionData = null;
			}
		}

		// Token: 0x060477F6 RID: 292854 RVA: 0x012389FC File Offset: 0x01236BFC
		[NullableContext(1)]
		public string GetDebugString()
		{
			string text = "";
			if (this.AiPerceptionData != null)
			{
				text += "AiPerceptionData:\n";
				string str = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\t距离: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.AiPerceptionData.DistanceBetween, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
				string str2 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\t玩家速度: ");
				defaultInterpolatedStringHandler.AppendFormatted<double>(this.AiPerceptionData.PlayerVelocity.Size(), "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
				string str3 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\t速度差值: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.AiPerceptionData.DeltaAbsSpeed, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
				string str4 = text;
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 1);
				defaultInterpolatedStringHandler.AppendLiteral("\t运动时长: ");
				defaultInterpolatedStringHandler.AppendFormatted<float>(this.AiPerceptionData.SelfKeepMovingTime, "F2");
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str4 + defaultInterpolatedStringHandler.ToStringAndClear();
				if (this.AiPerceptionData.SelfSplineMoveData != null)
				{
					text += "\tSplineMoveData:\n";
					string str5 = text;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\t\t当前速度: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(this.AiPerceptionData.SelfSplineMoveData.Value.CurrentSpeed, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str5 + defaultInterpolatedStringHandler.ToStringAndClear();
					string str6 = text;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\t\t目标速度: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(this.AiPerceptionData.SelfSplineMoveData.Value.TargetSpeed, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str6 + defaultInterpolatedStringHandler.ToStringAndClear();
					string str7 = text;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("\t\t当前加速度: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(this.AiPerceptionData.SelfSplineMoveData.Value.Acceleration, "F2");
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str7 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			return text;
		}

		// Token: 0x060477F7 RID: 292855 RVA: 0x01238C58 File Offset: 0x01236E58
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemAiRacingMoveComponent sceneItemAiRacingMoveComponent = (SceneItemAiRacingMoveComponent)componentTemplate;
			if (base.CanResetComponentProperty("AiInfo"))
			{
				if (sceneItemAiRacingMoveComponent.AiInfo == null)
				{
					this.AiInfo = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BP_AIRaceStrategy_C>(this.AiInfo), "AiInfo"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SplineComp"))
			{
				if (sceneItemAiRacingMoveComponent.SplineComp == null)
				{
					this.SplineComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<USplineComponent>(this.SplineComp), "SplineComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SplineActor"))
			{
				if (sceneItemAiRacingMoveComponent.SplineActor == null)
				{
					this.SplineActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TsGameSplineActor>(this.SplineActor), "SplineActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EnableAiRace"))
			{
				this.EnableAiRace = sceneItemAiRacingMoveComponent.EnableAiRace;
			}
			if (base.CanResetComponentProperty("DisableHandle"))
			{
				this.DisableHandle = sceneItemAiRacingMoveComponent.DisableHandle;
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (sceneItemAiRacingMoveComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("AiPerceptionData"))
			{
				if (sceneItemAiRacingMoveComponent.AiPerceptionData == null)
				{
					this.AiPerceptionData = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AiRacingPerceptionData>(this.AiPerceptionData), "AiPerceptionData"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetStartMoveParam"))
			{
				if (sceneItemAiRacingMoveComponent.TargetStartMoveParam == null)
				{
					this.TargetStartMoveParam = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedParam>(this.TargetStartMoveParam), "TargetStartMoveParam"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastEditableParam"))
			{
				if (sceneItemAiRacingMoveComponent.LastEditableParam == null)
				{
					this.LastEditableParam = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam>(this.LastEditableParam), "LastEditableParam"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TargetEditableParam"))
			{
				if (sceneItemAiRacingMoveComponent.TargetEditableParam == null)
				{
					this.TargetEditableParam = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam>(this.TargetEditableParam), "TargetEditableParam"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040259D5 RID: 154069
		[Nullable(1)]
		private const string AI_RACING_DEBUG_KEY = "AI_RACING_DEBUG";

		// Token: 0x040259D6 RID: 154070
		private BP_AIRaceStrategy_C AiInfo;

		// Token: 0x040259D7 RID: 154071
		private USplineComponent SplineComp;

		// Token: 0x040259D8 RID: 154072
		private TsGameSplineActor SplineActor;

		// Token: 0x040259D9 RID: 154073
		private bool EnableAiRace;

		// Token: 0x040259DA RID: 154074
		private int? DisableHandle;

		// Token: 0x040259DB RID: 154075
		private SceneItemMoveComponent MoveComp;

		// Token: 0x040259DC RID: 154076
		private AiRacingPerceptionData AiPerceptionData;

		// Token: 0x040259DD RID: 154077
		private SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedParam TargetStartMoveParam;

		// Token: 0x040259DE RID: 154078
		private SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam LastEditableParam;

		// Token: 0x040259DF RID: 154079
		private SceneItemMoveComponent.SceneItemSplineMoveAtDynamicSpeedEditableParam TargetEditableParam;
	}
}
