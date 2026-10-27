using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA7 RID: 28583
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowVehicleMoveWithPathLine : LevelFlowActionBase
	{
		// Token: 0x06045794 RID: 284564 RVA: 0x0113BEE0 File Offset: 0x0113A0E0
		public LevelFlowVehicleMoveWithPathLine Init(VehicleMoveWithPathLine params_)
		{
			this.Params = params_;
			return this;
		}

		// Token: 0x06045795 RID: 284565 RVA: 0x0113BEEC File Offset: 0x0113A0EC
		protected override void OnExecute()
		{
			if (this.Params == null)
			{
				base.FinishExecute(false);
				return;
			}
			ETargetVehicle type = this.Params.TargetVehicle.Type;
			if (type == ETargetVehicle.Current)
			{
				this.Entity_ = this.GetVehicleEntityFromPlayerRole();
				this.ChangeControlState();
				return;
			}
			if (type != ETargetVehicle.Appointed)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "不支持的目标类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.Params.TargetVehicle.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			IAppointedVehicle appointedVehicle = this.Params.TargetVehicle as IAppointedVehicle;
			base.CreateWaitEntityTask(appointedVehicle.VehicleId);
		}

		// Token: 0x06045796 RID: 284566 RVA: 0x0113BF94 File Offset: 0x0113A194
		protected override void ExecuteWhenEntitiesReady()
		{
			this.GetTargetVehicleEntity(this.Params.TargetVehicle);
			this.ChangeControlState();
		}

		// Token: 0x06045797 RID: 284567 RVA: 0x0113BFB0 File Offset: 0x0113A1B0
		private void GetTargetVehicleEntity(ITargetVehicle config)
		{
			ETargetVehicle type = config.Type;
			if (type == ETargetVehicle.Current)
			{
				this.Entity_ = this.GetVehicleEntityFromPlayerRole();
				return;
			}
			if (type != ETargetVehicle.Appointed)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "不支持的目标类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", config.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			EntityHandle entityById = CreatureModel.Instance.GetEntityById((config as IAppointedVehicle).VehicleId);
			this.Entity_ = ((entityById != null) ? entityById.Entity : null);
		}

		// Token: 0x06045798 RID: 284568 RVA: 0x0113C034 File Offset: 0x0113A234
		[NullableContext(2)]
		private Entity GetVehicleEntityFromPlayerRole()
		{
			if (Global.BaseCharacter == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YJX, "获取玩家载具失败，找不到全局玩家角色", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			Entity entity = Global.BaseCharacter.CharacterActorComponent.Entity;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			if (characterDriveVehicleComponent == null)
			{
				return null;
			}
			return characterDriveVehicleComponent.VehicleEntity;
		}

		// Token: 0x06045799 RID: 284569 RVA: 0x0113C08C File Offset: 0x0113A28C
		private void ChangeControlState()
		{
			if (this.Entity_ == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YJX, "设置载具控制状态失败，无法找到目标实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			EVehicleControlType type = this.Params.ControlType.Type;
			if (type != EVehicleControlType.EnterPathMoving)
			{
				if (type == EVehicleControlType.ExitPathMoving)
				{
					int splineEntityId = this.Params.SplineEntityId;
					VehicleSplineMoveComponent component = this.Entity_.GetComponent<VehicleSplineMoveComponent>();
					if (component != null)
					{
						component.ResetExtraMoveParams();
					}
					if (component != null)
					{
						component.EndSplineMove(splineEntityId);
					}
				}
			}
			else
			{
				IVehicleEnterPathMove vehicleEnterPathMove = this.Params.ControlType as IVehicleEnterPathMove;
				int splineEntityId2 = this.Params.SplineEntityId;
				VehicleSplineMoveComponent component2 = this.Entity_.GetComponent<VehicleSplineMoveComponent>();
				if (component2 != null)
				{
					component2.SetExtraMoveParams(vehicleEnterPathMove.ControlParams);
				}
				if (component2 != null)
				{
					component2.StartSplineMove(splineEntityId2, vehicleEnterPathMove.Pattern, false);
				}
				if (LevelFlowModel.Instance.IsDebug)
				{
					USplineComponent splineComponent = GameSplineModel.Instance.LoadAndGetSplineComponent(splineEntityId2, this.Entity_.Id, EIdType.EntityId);
					this.DrawDebugInfo(splineComponent, vehicleEnterPathMove.Pattern.MaxOffsetDistance.GetValueOrDefault());
				}
			}
			base.FinishExecute(true);
		}

		// Token: 0x0604579A RID: 284570 RVA: 0x0113C1B0 File Offset: 0x0113A3B0
		protected unsafe override void LogExecuteInfo()
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelFlow;
			ELogAuthor author = ELogAuthor.BB;
			string message = "执行行为";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ActionId", this.ActionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionName", base.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ControlType", this.Params.ControlType.Type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("SplineEntityId", this.Params.SplineEntityId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}

		// Token: 0x0604579B RID: 284571 RVA: 0x0113C27C File Offset: 0x0113A47C
		private void DrawDebugInfo(USplineComponent splineComponent, float radius)
		{
			float splineLength = splineComponent.GetSplineLength();
			for (float num = 0f; num <= splineLength; num += 100f)
			{
				FVectorDouble? fvectorDouble = (splineComponent != null) ? new FVectorDouble?(splineComponent.D_GetLocationAtDistanceAlongSpline(num, ESplineCoordinateSpace.World)) : null;
				FVectorDouble? fvectorDouble2 = (splineComponent != null) ? new FVectorDouble?(splineComponent.D_GetDirectionAtDistanceAlongSpline(num, ESplineCoordinateSpace.World)) : null;
				FVectorDouble valueOrDefault = fvectorDouble2.GetValueOrDefault();
				valueOrDefault.Normalize(9.99999993922529E-09);
				FVectorDouble? fvectorDouble4;
				FVectorDouble? fvectorDouble3 = fvectorDouble4 = fvectorDouble;
				FVectorDouble? fvectorDouble5 = fvectorDouble2;
				double scale = (double)100;
				FVectorDouble? fvectorDouble6;
				if (fvectorDouble5 == null)
				{
					fvectorDouble6 = null;
				}
				else
				{
					valueOrDefault = fvectorDouble5.GetValueOrDefault();
					fvectorDouble6 = new FVectorDouble?(valueOrDefault * scale);
				}
				FVectorDouble? fvectorDouble7 = fvectorDouble6;
				FVectorDouble? fvectorDouble8;
				if (!(fvectorDouble4 != null & fvectorDouble7 != null))
				{
					fvectorDouble8 = null;
				}
				else
				{
					FVectorDouble valueOrDefault2 = fvectorDouble4.GetValueOrDefault();
					FVectorDouble valueOrDefault3 = fvectorDouble7.GetValueOrDefault();
					fvectorDouble8 = new FVectorDouble?(valueOrDefault2 + valueOrDefault3);
				}
				FVectorDouble? fvectorDouble9 = fvectorDouble8;
				UKismetSystemLibrary.D_DrawDebugCylinder(GlobalData.World, fvectorDouble3.GetValueOrDefault(), fvectorDouble9.GetValueOrDefault(), radius, 16, new FLinearColor?(new FLinearColor(0f, 1f, 0f, 1f)), 60f, 1f);
			}
		}

		// Token: 0x04024402 RID: 148482
		[Nullable(2)]
		private Entity Entity_;

		// Token: 0x04024403 RID: 148483
		[Nullable(2)]
		private VehicleMoveWithPathLine Params;
	}
}
