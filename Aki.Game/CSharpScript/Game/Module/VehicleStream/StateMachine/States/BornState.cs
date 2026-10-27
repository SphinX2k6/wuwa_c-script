using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Module.VehicleStream.StateMachineContainer;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.VehicleStream.StateMachine.States
{
	// Token: 0x020048B9 RID: 18617
	[NullableContext(1)]
	[Nullable(0)]
	public class BornState : VehicleStateBase
	{
		// Token: 0x06030A7C RID: 199292 RVA: 0x00B4BC8B File Offset: 0x00B49E8B
		public BornState(VehicleSmBlackBoard blackBoard) : base(EVehicleStateType.Born, blackBoard)
		{
		}

		// Token: 0x06030A7D RID: 199293 RVA: 0x00B4BC98 File Offset: 0x00B49E98
		[NullableContext(2)]
		protected unsafe override void OnEnter(EVehicleStateType lastState, string reason = null)
		{
			base.EnterNextRoadway();
			this.CalculateStartPointInfo();
			this.CalculateEndPointInfo();
			List<long> list = this.CheckSameRoadwayVehicleOverlap(this.BlackBoard.CurrentRootDistance);
			if (list != null && list.Count > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.VehicleStream;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "载具出生时与其他载具重叠";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("selfCreatureDataId", this.BlackBoard.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("重叠载具", list);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06030A7E RID: 199294 RVA: 0x00B4BD3C File Offset: 0x00B49F3C
		protected unsafe override void OnUpdate(float delta)
		{
			EVehicleStateType evehicleStateType = this.CheckGetNextState();
			if (evehicleStateType != EVehicleStateType.None)
			{
				List<long> list = this.CheckSameRoadwayVehicleOverlap(this.BlackBoard.CurrentRootDistance);
				if (list != null && list.Count > 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.VehicleStream;
					ELogAuthor author = ELogAuthor.YSQ;
					string message = "载具启动时与其他载具重叠";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("selfCreatureDataId", this.BlackBoard.CreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("重叠载具", list);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				this.BlackBoard.SwitchState(evehicleStateType, null);
			}
		}

		// Token: 0x06030A7F RID: 199295 RVA: 0x00B4BDE7 File Offset: 0x00B49FE7
		protected override void OnExit(EVehicleStateType nextState)
		{
			this.InitAudio();
		}

		// Token: 0x06030A80 RID: 199296 RVA: 0x00B4BDEF File Offset: 0x00B49FEF
		protected override EVehicleStateType CheckGetNextState()
		{
			if (!this.BlackBoard.IsLaunch)
			{
				return EVehicleStateType.None;
			}
			return EVehicleStateType.Running;
		}

		// Token: 0x06030A81 RID: 199297 RVA: 0x00B4BE04 File Offset: 0x00B4A004
		[NullableContext(2)]
		private List<long> CheckSameRoadwayVehicleOverlap(float currentFrameRootDistance)
		{
			UKuroRoadway currentRoadway = this.BlackBoard.CurrentRoadway;
			if (currentRoadway == null)
			{
				return null;
			}
			VehicleStreamModel instance = VehicleStreamModel.Instance;
			HashSet<long> allVehicleInRoadway = instance.GetAllVehicleInRoadway(currentRoadway.Id);
			if (allVehicleInRoadway == null)
			{
				return null;
			}
			List<long> list = new List<long>();
			foreach (long num in allVehicleInRoadway)
			{
				if (num != this.BlackBoard.CreatureDataId)
				{
					VehicleTeamMember vehicleTeamMember = instance.GetVehicleTeamMember(num);
					if (vehicleTeamMember != null && Math.Abs(vehicleTeamMember.GetRelativeLocation().Y - this.BlackBoard.RelativeLocationToStart.Y) <= (vehicleTeamMember.GetVehicleSize().Y + this.BlackBoard.VehicleSize.Y) * 0.5)
					{
						EPositionRelationship epositionRelationship = base.CheckPositionalRelationshipToTarget(currentFrameRootDistance, vehicleTeamMember.GetCurrentMeshHeadDistance(), vehicleTeamMember.GetCurrentMeshTailDistance());
						if (epositionRelationship == EPositionRelationship.OverlapBehind || epositionRelationship == EPositionRelationship.OverlapForward)
						{
							list.Add(num);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06030A82 RID: 199298 RVA: 0x00B4BF18 File Offset: 0x00B4A118
		private void CalculateStartPointInfo()
		{
			UKuroRoadway startRoadway = this.BlackBoard.StartRoadway;
			if (((startRoadway != null) ? startRoadway.RoadSpline : null) == null)
			{
				return;
			}
			USplineComponent roadSpline = startRoadway.RoadSpline;
			FVectorDouble fvectorDouble = this.BlackBoard.StartActorLocation.ToUeVector(false);
			float inKey = roadSpline.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			FTransformDouble ftransformDouble = startRoadway.RoadSpline.D_GetTransformAtSplineInputKey(inKey, ESplineCoordinateSpace.Local, false);
			fvectorDouble = this.BlackBoard.StartActorLocation.ToUeVector(false);
			FVectorDouble fvectorDouble2 = ftransformDouble.InverseTransformPosition(fvectorDouble);
			this.BlackBoard.RelativeLocationToStart.DeepCopy(fvectorDouble2);
			this.CheckAndSetZero(this.BlackBoard.RelativeLocationToStart);
			this.BlackBoard.RelativeLocationToStartWithoutX.DeepCopy(this.BlackBoard.RelativeLocationToStart);
			this.BlackBoard.RelativeLocationToStartWithoutX.X = 0.0;
			this.BlackBoard.CurrentSplineLength = startRoadway.RoadSpline.GetSplineLength();
			this.BlackBoard.CurrentRootDistance = startRoadway.RoadSpline.GetDistanceAlongSplineAtSplineInputKey(inKey);
		}

		// Token: 0x06030A83 RID: 199299 RVA: 0x00B4C014 File Offset: 0x00B4A214
		private void CalculateEndPointInfo()
		{
			UKuroRoadway endRoadway = this.BlackBoard.EndRoadway;
			if (((endRoadway != null) ? endRoadway.RoadSpline : null) == null)
			{
				return;
			}
			USplineComponent roadSpline = endRoadway.RoadSpline;
			FVectorDouble fvectorDouble = this.BlackBoard.EndLocationInRoad.ToUeVector(false);
			float inKey = roadSpline.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
			this.BlackBoard.EndPointInSplineDistance = endRoadway.RoadSpline.GetDistanceAlongSplineAtSplineInputKey(inKey);
		}

		// Token: 0x06030A84 RID: 199300 RVA: 0x00B4C074 File Offset: 0x00B4A274
		private void InitAudio()
		{
			Entity entity = this.BlackBoard.RoadNetworkNavigationComponent.Entity;
			if (entity == null || !entity.Valid)
			{
				return;
			}
			CustomAudioControlComponent component = entity.GetComponent<CustomAudioControlComponent>();
			if (component == null)
			{
				return;
			}
			IAudioControlType audioControlConfig = component.GetAudioControlConfig();
			if (audioControlConfig == null)
			{
				return;
			}
			ITrafficAudioControl trafficAudioControl = audioControlConfig as ITrafficAudioControl;
			if (trafficAudioControl != null && audioControlConfig.Type == EAudioControlType.Traffic)
			{
				this.BlackBoard.HornAudio = AudioSystem.Instance.parseAudioEventPath(trafficAudioControl.HornAudio);
				this.BlackBoard.BrakingAudio = AudioSystem.Instance.parseAudioEventPath(trafficAudioControl.BrakingAudio);
				this.BlackBoard.BrakingShortAudio = AudioSystem.Instance.parseAudioEventPath(trafficAudioControl.BrakingShortAudio);
				this.BlackBoard.EngineAudio = AudioSystem.Instance.parseAudioEventPath(trafficAudioControl.EngineAudio);
			}
		}

		// Token: 0x06030A85 RID: 199301 RVA: 0x00B4C134 File Offset: 0x00B4A334
		private void CheckAndSetZero(Vector relativeLocation)
		{
			if (Math.Abs(relativeLocation.X) < 9.999999747378752E-05)
			{
				relativeLocation.X = 0.0;
			}
			if (Math.Abs(relativeLocation.Y) < 9.999999747378752E-05)
			{
				relativeLocation.Y = 0.0;
			}
			if (Math.Abs(relativeLocation.Z) < 9.999999747378752E-05)
			{
				relativeLocation.Z = 0.0;
			}
		}
	}
}
