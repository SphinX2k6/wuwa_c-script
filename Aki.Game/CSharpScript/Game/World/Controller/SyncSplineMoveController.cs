using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200453F RID: 17727
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SyncSplineMoveController : ControllerBase
	{
		// Token: 0x0602DD19 RID: 187673 RVA: 0x00A87B4A File Offset: 0x00A85D4A
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.MoveSplineStatusNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMoveSplineStatusNotify));
			return true;
		}

		// Token: 0x0602DD1A RID: 187674 RVA: 0x00A87B69 File Offset: 0x00A85D69
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MoveSplineStatusNotify);
			return true;
		}

		// Token: 0x0602DD1B RID: 187675 RVA: 0x00A87B7C File Offset: 0x00A85D7C
		[NullableContext(2)]
		private unsafe void OnMoveSplineStatusNotify(IMessage msg, Net.CallbackStatus _)
		{
			MoveSplineStatusNotify data = (MoveSplineStatusNotify)msg;
			if (data == null)
			{
				return;
			}
			long creatureId = MathUtils.Instance.LongToNumber(data.EntityId);
			WaitEntityTask.Create("MoveSplineStatusNotify", creatureId, delegate(bool? waitResult)
			{
				if (!waitResult.GetValueOrDefault())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[MoveSplineStatusNotify] 实体等待出错";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureId", creatureId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", data.SplineEntityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Status", this.SplineMoveStatusLogString[data.MoveStatus]);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
				EntityHandle entity = CreatureModel.Instance.GetEntity(creatureId);
				if (entity == null || !entity.Valid)
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Movement;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[MoveSplineStatusNotify] 无法获取对应实体";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureId", creatureId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SplineId", data.SplineEntityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Status", this.SplineMoveStatusLogString[data.MoveStatus]);
					instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
					return;
				}
				if (entity == null || !entity.IsInit)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Movement;
					ELogAuthor author3 = ELogAuthor.ZYL;
					string message3 = "[MoveSplineStatusNotify] 实体未初始化";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureId", creatureId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("SplineId", data.SplineEntityId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("Status", this.SplineMoveStatusLogString[data.MoveStatus]);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
					return;
				}
				this.RecvSyncSplineMoveStatus(entity.Entity, data);
			}, 60000, true, true);
		}

		// Token: 0x0602DD1C RID: 187676 RVA: 0x00A87BEC File Offset: 0x00A85DEC
		private void RecvSyncSplineMoveStatus(Entity entity, MoveSplineStatusNotify data)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			EEntityType? eentityType = (component != null) ? new EEntityType?(component.GetEntityType()) : null;
			if (eentityType != null)
			{
				EEntityType valueOrDefault = eentityType.GetValueOrDefault();
				if (valueOrDefault != EEntityType.SceneItem)
				{
					if (valueOrDefault == EEntityType.Vehicle)
					{
						this.RecvSyncVehicleSplineMoveStatus(entity, data);
						return;
					}
				}
				else
				{
					this.RecvSyncSceneItemSplineMoveStatus(entity, data);
				}
			}
		}

		// Token: 0x0602DD1D RID: 187677 RVA: 0x00A87C44 File Offset: 0x00A85E44
		private void RecvSyncSceneItemSplineMoveStatus(Entity entity, MoveSplineStatusNotify data)
		{
			SceneItemMoveComponent component = entity.GetComponent<SceneItemMoveComponent>();
			if (component == null || !component.Valid)
			{
				return;
			}
			switch (data.MoveStatus)
			{
			case MoveStatus.Stop:
				component.OnRecvSyncSplineStop(data.SplineEntityId, data.MoveSplineConfig, data.SceneItemRuntimeData);
				return;
			case MoveStatus.Moving:
				component.OnRecvSyncSplineMoving(data.SplineEntityId, data.MoveSplineConfig, data.SceneItemRuntimeData);
				return;
			case MoveStatus.Interrupt:
				component.OnRecvSyncSplineInterrupt(data.SplineEntityId, data.MoveSplineConfig, data.SceneItemRuntimeData);
				return;
			case MoveStatus.Switch:
				component.OnRecvSyncSplineSwitch(data.SplineEntityId, data.MoveSplineConfig, data.SceneItemRuntimeData);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602DD1E RID: 187678 RVA: 0x00A87CEC File Offset: 0x00A85EEC
		public unsafe void SendSyncSceneItemSplineMoveRunning(long creatureDataId, int splineId, float? curDistanceAlongSpline, IVector curPos, [Nullable(2)] IRotator curRot)
		{
			SceneItemMoveSplineRequest sceneItemMoveSplineRequest = SceneItemMoveSplineRequest.Create();
			sceneItemMoveSplineRequest.EntityId = creatureDataId;
			sceneItemMoveSplineRequest.SplineEntityId = splineId;
			sceneItemMoveSplineRequest.MoveStatus = MoveStatus.Moving;
			sceneItemMoveSplineRequest.RuntimeData = SceneItemSplineRuntimeData.Create();
			sceneItemMoveSplineRequest.RuntimeData.DistanceAlongPath = curDistanceAlongSpline.GetValueOrDefault(-1f);
			sceneItemMoveSplineRequest.RuntimeData.CurPos = Aki.Protocol.Vector.Create();
			sceneItemMoveSplineRequest.RuntimeData.CurPos.X = (float)curPos.X;
			sceneItemMoveSplineRequest.RuntimeData.CurPos.Y = (float)curPos.Y;
			sceneItemMoveSplineRequest.RuntimeData.CurPos.Z = (float)curPos.Z;
			if (curRot != null)
			{
				sceneItemMoveSplineRequest.RuntimeData.CurRot = Aki.Protocol.Rotator.Create();
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Roll = curRot.Roll;
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Pitch = curRot.Pitch;
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Yaw = curRot.Yaw;
			}
			Net.Instance.Call(ERequestMessageId.SceneItemMoveSplineRequest, sceneItemMoveSplineRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneItemMoveSplineResponse sceneItemMoveSplineResponse = (SceneItemMoveSplineResponse)msg;
				if (sceneItemMoveSplineResponse == null || sceneItemMoveSplineResponse.ErrorCode != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SyncSplineMoveController.SendSyncSceneItemSplineMoveRunning] 发送同步场景物件样条移动运行中信息: 失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ErrorCode", (sceneItemMoveSplineResponse != null) ? new ErrorCode?(sceneItemMoveSplineResponse.ErrorCode) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}, 0);
		}

		// Token: 0x0602DD1F RID: 187679 RVA: 0x00A87E24 File Offset: 0x00A86024
		public unsafe void SendSyncSceneItemSplineMoveEnd(long creatureDataId, int splineId, float? curDistanceAlongSpline, IVector curPos, [Nullable(2)] IRotator curRot, bool isInterrupt)
		{
			SceneItemMoveSplineRequest sceneItemMoveSplineRequest = SceneItemMoveSplineRequest.Create();
			sceneItemMoveSplineRequest.EntityId = creatureDataId;
			sceneItemMoveSplineRequest.SplineEntityId = splineId;
			sceneItemMoveSplineRequest.MoveStatus = (isInterrupt ? MoveStatus.Interrupt : MoveStatus.Stop);
			sceneItemMoveSplineRequest.RuntimeData = SceneItemSplineRuntimeData.Create();
			sceneItemMoveSplineRequest.RuntimeData.DistanceAlongPath = curDistanceAlongSpline.GetValueOrDefault(-1f);
			sceneItemMoveSplineRequest.RuntimeData.CurPos = Aki.Protocol.Vector.Create();
			sceneItemMoveSplineRequest.RuntimeData.CurPos.X = (float)curPos.X;
			sceneItemMoveSplineRequest.RuntimeData.CurPos.Y = (float)curPos.Y;
			sceneItemMoveSplineRequest.RuntimeData.CurPos.Z = (float)curPos.Z;
			if (curRot != null)
			{
				sceneItemMoveSplineRequest.RuntimeData.CurRot = Aki.Protocol.Rotator.Create();
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Roll = curRot.Roll;
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Pitch = curRot.Pitch;
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Yaw = curRot.Yaw;
			}
			Net.Instance.Call(ERequestMessageId.SceneItemMoveSplineRequest, sceneItemMoveSplineRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneItemMoveSplineResponse sceneItemMoveSplineResponse = (SceneItemMoveSplineResponse)msg;
				if (sceneItemMoveSplineResponse == null || sceneItemMoveSplineResponse.ErrorCode != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SyncSplineMoveController.SendSyncSceneItemSplineMoveEnd] 发送同步场景物件样条移动中断/结束信息: 失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ErrorCode", (sceneItemMoveSplineResponse != null) ? new ErrorCode?(sceneItemMoveSplineResponse.ErrorCode) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}, 0);
		}

		// Token: 0x0602DD20 RID: 187680 RVA: 0x00A87F64 File Offset: 0x00A86164
		public unsafe void SendSyncSceneItemSplineMoveSwitch(long creatureDataId, int newSplineId, MoveSplineConfig newMoveSplineConfig, IVector curPos, [Nullable(2)] IRotator curRot)
		{
			SceneItemMoveSplineRequest sceneItemMoveSplineRequest = SceneItemMoveSplineRequest.Create();
			sceneItemMoveSplineRequest.EntityId = creatureDataId;
			sceneItemMoveSplineRequest.SplineEntityId = newSplineId;
			sceneItemMoveSplineRequest.MoveStatus = MoveStatus.Switch;
			sceneItemMoveSplineRequest.MoveSplineConfig = newMoveSplineConfig;
			sceneItemMoveSplineRequest.RuntimeData = SceneItemSplineRuntimeData.Create();
			sceneItemMoveSplineRequest.RuntimeData.DistanceAlongPath = -1f;
			sceneItemMoveSplineRequest.RuntimeData.CurPos = Aki.Protocol.Vector.Create();
			sceneItemMoveSplineRequest.RuntimeData.CurPos.X = (float)curPos.X;
			sceneItemMoveSplineRequest.RuntimeData.CurPos.Y = (float)curPos.Y;
			sceneItemMoveSplineRequest.RuntimeData.CurPos.Z = (float)curPos.Z;
			if (curRot != null)
			{
				sceneItemMoveSplineRequest.RuntimeData.CurRot = Aki.Protocol.Rotator.Create();
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Roll = curRot.Roll;
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Pitch = curRot.Pitch;
				sceneItemMoveSplineRequest.RuntimeData.CurRot.Yaw = curRot.Yaw;
			}
			Net.Instance.Call(ERequestMessageId.SceneItemMoveSplineRequest, sceneItemMoveSplineRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneItemMoveSplineResponse sceneItemMoveSplineResponse = (SceneItemMoveSplineResponse)msg;
				if (sceneItemMoveSplineResponse == null || sceneItemMoveSplineResponse.ErrorCode != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SyncSplineMoveController.SendSyncSceneItemSplineMoveSwitch] 发送同步场景物件样条移动切换样条信息: 失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewSplineId", newSplineId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ErrorCode", (sceneItemMoveSplineResponse != null) ? new ErrorCode?(sceneItemMoveSplineResponse.ErrorCode) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}, 0);
		}

		// Token: 0x0602DD21 RID: 187681 RVA: 0x00A8809C File Offset: 0x00A8629C
		private void RecvSyncVehicleSplineMoveStatus(Entity entity, MoveSplineStatusNotify data)
		{
			switch (data.MoveStatus)
			{
			case MoveStatus.Stop:
			case MoveStatus.Interrupt:
				this.SyncVehicleStopMove(entity);
				return;
			case MoveStatus.Moving:
				this.SyncVehicleMoveAlongPath(entity, data.SplineEntityId);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602DD22 RID: 187682 RVA: 0x00A880D8 File Offset: 0x00A862D8
		private unsafe void SendSyncVehicleSplineMoveEndRequest(Entity entity, int splineId, bool bInterrupt)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Movement;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[SyncSplineMoveController.MoveSplineStatusNotify] 结束时无法获取对应实体CreatureData";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsInterrupt", bInterrupt);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			long creatureDataId = component.GetCreatureDataId();
			StopMoveSplineRequest stopMoveSplineRequest = StopMoveSplineRequest.Create();
			stopMoveSplineRequest.EntityId = MathUtils.Instance.NumberToLong(creatureDataId);
			stopMoveSplineRequest.SplineEntityId = splineId;
			stopMoveSplineRequest.IsInterrupt = bInterrupt;
			Net.Instance.Call(ERequestMessageId.StopMoveSplineRequest, stopMoveSplineRequest, null, 0);
		}

		// Token: 0x0602DD23 RID: 187683 RVA: 0x00A881B0 File Offset: 0x00A863B0
		public void SyncVehicleMoveAlongPath(Entity entity, int splineId)
		{
			SyncSplineMoveController.<>c__DisplayClass12_0 CS$<>8__locals1 = new SyncSplineMoveController.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.entity = entity;
			CS$<>8__locals1.splineId = splineId;
			VehicleMoveComponent component = CS$<>8__locals1.entity.GetComponent<VehicleMoveComponent>();
			if (component == null)
			{
				return;
			}
			int movingSplineId = component.GetMovingSplineId();
			if (movingSplineId != 0 && movingSplineId != CS$<>8__locals1.splineId)
			{
				component.StopMove();
			}
			component.MoveAlongPath(new IMoveVehicleConfig
			{
				SplineId = CS$<>8__locals1.splineId,
				StartFromNearest = new bool?(true),
				OnMoveEndHandle = new Action<bool>(CS$<>8__locals1.<SyncVehicleMoveAlongPath>g__OnMoveEndWrapper|0)
			});
		}

		// Token: 0x0602DD24 RID: 187684 RVA: 0x00A88238 File Offset: 0x00A86438
		public void SyncVehicleStopMove(Entity entity)
		{
			VehicleMoveComponent component = entity.GetComponent<VehicleMoveComponent>();
			if (component == null)
			{
				return;
			}
			component.StopMove();
		}

		// Token: 0x1700754A RID: 30026
		// (get) Token: 0x0602DD25 RID: 187685 RVA: 0x00A88256 File Offset: 0x00A86456
		public static SyncSplineMoveController Instance
		{
			get
			{
				return SyncSplineMoveController._Instance;
			}
		}

		// Token: 0x0602DD26 RID: 187686 RVA: 0x00A8825D File Offset: 0x00A8645D
		public static SyncSplineMoveController GetOrCreateInstance()
		{
			if (SyncSplineMoveController._Instance == null)
			{
				SyncSplineMoveController.CreateInstance();
			}
			return SyncSplineMoveController._Instance;
		}

		// Token: 0x0602DD27 RID: 187687 RVA: 0x00A88271 File Offset: 0x00A86471
		public static bool CreateInstance()
		{
			if (SyncSplineMoveController._Instance != null)
			{
				return true;
			}
			SyncSplineMoveController._Instance = new SyncSplineMoveController();
			return true;
		}

		// Token: 0x0602DD28 RID: 187688 RVA: 0x00A88287 File Offset: 0x00A86487
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DD29 RID: 187689 RVA: 0x00A88289 File Offset: 0x00A86489
		public static void ResetStaticDefaultValue()
		{
			SyncSplineMoveController._Instance = null;
		}

		// Token: 0x0602DD2A RID: 187690 RVA: 0x00A88291 File Offset: 0x00A86491
		static SyncSplineMoveController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SyncSplineMoveController.CreateStaticDefaultValue), new Action(SyncSplineMoveController.ResetStaticDefaultValue));
		}

		// Token: 0x0602DD2B RID: 187691 RVA: 0x00A882B0 File Offset: 0x00A864B0
		public SyncSplineMoveController()
		{
			Dictionary<MoveStatus, string> dictionary = new Dictionary<MoveStatus, string>();
			dictionary[MoveStatus.Interrupt] = "中断";
			dictionary[MoveStatus.Moving] = "运行";
			dictionary[MoveStatus.Stop] = "停止";
			dictionary[MoveStatus.Switch] = "切换";
			this.SplineMoveStatusLogString = dictionary;
			base..ctor();
		}

		// Token: 0x0401876A RID: 100202
		private readonly Dictionary<MoveStatus, string> SplineMoveStatusLogString;

		// Token: 0x0401876B RID: 100203
		private const int WAIT_ENTITY_TIMEOUT = 60000;

		// Token: 0x0401876C RID: 100204
		[Nullable(2)]
		private static SyncSplineMoveController _Instance;
	}
}
