using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.Transport;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D0F RID: 23823
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventStartMotorCruise : LevelEventBase
	{
		// Token: 0x0603A425 RID: 238629 RVA: 0x01076C41 File Offset: 0x01074E41
		public LevelEventStartMotorCruise(int id) : base(id)
		{
		}

		// Token: 0x0603A426 RID: 238630 RVA: 0x01076C4C File Offset: 0x01074E4C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.InParams = (inParams as StartMotorCruise);
			UKuroRoadway roadWay = TransportNetworkController.Instance.GetTransportSystem().GetRoadWay(this.InParams.StartPoint.Spline);
			if (roadWay == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelEvent;
				ELogAuthor author = ELogAuthor.CB;
				string message = "巡航起点样条线id不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SplineId", this.InParams.StartPoint.Spline);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.FinishExecute(false, false, true);
				return;
			}
			USplineComponent roadSpline = roadWay.RoadSpline;
			FVectorDouble? fvectorDouble = (roadSpline != null) ? new FVectorDouble?(roadSpline.D_GetLocationAtSplinePoint(this.InParams.StartPoint.PointId, ESplineCoordinateSpace.World)) : null;
			USplineComponent roadSpline2 = roadWay.RoadSpline;
			FRotator? frotator = (roadSpline2 != null) ? new FRotator?(roadSpline2.GetRotationAtSplinePoint(this.InParams.StartPoint.PointId, ESplineCoordinateSpace.World)) : null;
			if (fvectorDouble == null || frotator == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelEvent;
				ELogAuthor author2 = ELogAuthor.CB;
				string message2 = "巡航起点样条线上的点id不存在";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("PointId", this.InParams.StartPoint.PointId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				base.FinishExecute(false, false, true);
				return;
			}
			this.HandleTeleport(fvectorDouble.Value, frotator.Value);
		}

		// Token: 0x0603A427 RID: 238631 RVA: 0x01076DA0 File Offset: 0x01074FA0
		private UniTask HandleTeleport(FVectorDouble startPoint, FRotator rotator)
		{
			LevelEventStartMotorCruise.<HandleTeleport>d__3 <HandleTeleport>d__;
			<HandleTeleport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleTeleport>d__.<>4__this = this;
			<HandleTeleport>d__.startPoint = startPoint;
			<HandleTeleport>d__.rotator = rotator;
			<HandleTeleport>d__.<>1__state = -1;
			<HandleTeleport>d__.<>t__builder.Start<LevelEventStartMotorCruise.<HandleTeleport>d__3>(ref <HandleTeleport>d__);
			return <HandleTeleport>d__.<>t__builder.Task;
		}

		// Token: 0x0603A428 RID: 238632 RVA: 0x01076DF4 File Offset: 0x01074FF4
		private UniTask HandleAutoPilot()
		{
			LevelEventStartMotorCruise.<HandleAutoPilot>d__4 <HandleAutoPilot>d__;
			<HandleAutoPilot>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleAutoPilot>d__.<>4__this = this;
			<HandleAutoPilot>d__.<>1__state = -1;
			<HandleAutoPilot>d__.<>t__builder.Start<LevelEventStartMotorCruise.<HandleAutoPilot>d__4>(ref <HandleAutoPilot>d__);
			return <HandleAutoPilot>d__.<>t__builder.Task;
		}

		// Token: 0x0603A429 RID: 238633 RVA: 0x01076E38 File Offset: 0x01075038
		private void OnAutoPilotStateChange(bool isInAutoPilot)
		{
			if (!isInAutoPilot)
			{
				global::Log.Instance.Info(ELogModule.LevelEvent, ELogAuthor.CB, "StartMotorCruise:巡航完成", default(ReadOnlySpan<ValueTuple<string, object>>));
				AutoPilotModel instance = AutoPilotModel.Instance;
				if (instance != null)
				{
					instance.SetIsCanShowSkipBtn(false);
				}
				AutoPilotModel instance2 = AutoPilotModel.Instance;
				if (instance2 != null)
				{
					instance2.ClearTrackingData();
				}
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x0603A42A RID: 238634 RVA: 0x01076E8E File Offset: 0x0107508E
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0401EC12 RID: 125970
		[Nullable(2)]
		private StartMotorCruise InParams;
	}
}
