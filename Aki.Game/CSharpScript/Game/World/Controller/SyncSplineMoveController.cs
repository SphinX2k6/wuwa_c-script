using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003467 RID: 13415
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SyncSplineMoveController : ControllerBase
	{
		// Token: 0x060223FB RID: 140283 RVA: 0x009B325A File Offset: 0x009B145A
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.MoveSplineStatusNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMoveSplineStatusNotify));
			return true;
		}

		// Token: 0x060223FC RID: 140284 RVA: 0x009B3279 File Offset: 0x009B1479
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MoveSplineStatusNotify);
			return true;
		}

		// Token: 0x060223FD RID: 140285 RVA: 0x009B328C File Offset: 0x009B148C
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

		// Token: 0x060223FE RID: 140286 RVA: 0x009B32FC File Offset: 0x009B14FC
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

		// Token: 0x060223FF RID: 140287 RVA: 0x009B3354 File Offset: 0x009B1554
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

		// Token: 0x06022400 RID: 140288 RVA: 0x009B33FC File Offset: 0x009B15FC
		public unsafe void SendSyncSceneItemSplineMoveRunning(long creatureDataId, int splineId, float? curDistanceAlongSpline, IVector curPos, [Nullable(2)] IRotator curRot)
		{
			if (!Net.Instance.IsServerConnected())
			{
				return;
			}
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

		// Token: 0x06022401 RID: 140289 RVA: 0x009B3540 File Offset: 0x009B1740
		public unsafe void SendSyncSceneItemSplineMoveEnd(long creatureDataId, int splineId, float? curDistanceAlongSpline, IVector curPos, [Nullable(2)] IRotator curRot, bool isInterrupt)
		{
			if (!Net.Instance.IsServerConnected())
			{
				return;
			}
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

		// Token: 0x06022402 RID: 140290 RVA: 0x009B368C File Offset: 0x009B188C
		public unsafe void SendSyncSceneItemSplineMoveSwitch(long creatureDataId, int newSplineId, MoveSplineConfig newMoveSplineConfig, IVector curPos, [Nullable(2)] IRotator curRot)
		{
			if (!Net.Instance.IsServerConnected())
			{
				return;
			}
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

		// Token: 0x06022403 RID: 140291 RVA: 0x009B37D0 File Offset: 0x009B19D0
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

		// Token: 0x06022404 RID: 140292 RVA: 0x009B380C File Offset: 0x009B1A0C
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

		// Token: 0x06022405 RID: 140293 RVA: 0x009B38E4 File Offset: 0x009B1AE4
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

		// Token: 0x06022406 RID: 140294 RVA: 0x009B396C File Offset: 0x009B1B6C
		public void SyncVehicleStopMove(Entity entity)
		{
			VehicleMoveComponent component = entity.GetComponent<VehicleMoveComponent>();
			if (component == null)
			{
				return;
			}
			component.StopMove();
		}

		// Token: 0x17004801 RID: 18433
		// (get) Token: 0x06022407 RID: 140295 RVA: 0x009B398A File Offset: 0x009B1B8A
		public static SyncSplineMoveController Instance
		{
			get
			{
				return SyncSplineMoveController._Instance;
			}
		}

		// Token: 0x06022408 RID: 140296 RVA: 0x009B3991 File Offset: 0x009B1B91
		public static SyncSplineMoveController GetOrCreateInstance()
		{
			if (SyncSplineMoveController._Instance == null)
			{
				SyncSplineMoveController.CreateInstance();
			}
			return SyncSplineMoveController._Instance;
		}

		// Token: 0x06022409 RID: 140297 RVA: 0x009B39A5 File Offset: 0x009B1BA5
		public static bool CreateInstance()
		{
			if (SyncSplineMoveController._Instance != null)
			{
				return true;
			}
			SyncSplineMoveController._Instance = new SyncSplineMoveController();
			return true;
		}

		// Token: 0x0602240A RID: 140298 RVA: 0x009B39BB File Offset: 0x009B1BBB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602240B RID: 140299 RVA: 0x009B39BD File Offset: 0x009B1BBD
		public static void ResetStaticDefaultValue()
		{
			SyncSplineMoveController._Instance = null;
		}

		// Token: 0x0602240C RID: 140300 RVA: 0x009B39C5 File Offset: 0x009B1BC5
		static SyncSplineMoveController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SyncSplineMoveController.CreateStaticDefaultValue), new Action(SyncSplineMoveController.ResetStaticDefaultValue));
		}

		// Token: 0x0602240D RID: 140301 RVA: 0x009B39E4 File Offset: 0x009B1BE4
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

		// Token: 0x04012DA4 RID: 77220
		private readonly Dictionary<MoveStatus, string> SplineMoveStatusLogString;

		// Token: 0x04012DA5 RID: 77221
		private const int WAIT_ENTITY_TIMEOUT = 60000;

		// Token: 0x04012DA6 RID: 77222
		[Nullable(2)]
		private static SyncSplineMoveController _Instance;
	}
}
