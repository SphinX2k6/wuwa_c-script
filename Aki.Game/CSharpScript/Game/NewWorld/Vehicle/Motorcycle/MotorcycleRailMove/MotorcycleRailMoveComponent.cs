using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Gameplay.MotorRailMove;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Common.Component;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061B6 RID: 25014
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleRailMoveComponent : EntityComponent
	{
		// Token: 0x0603C0DA RID: 245978 RVA: 0x011147E3 File Offset: 0x011129E3
		public bool GetIsInRailMoveMode()
		{
			return this.IsInRailMoveMode;
		}

		// Token: 0x17007152 RID: 29010
		// (get) Token: 0x0603C0DB RID: 245979 RVA: 0x011147EB File Offset: 0x011129EB
		[Nullable(1)]
		private MotorcycleRailMoveConfig CurrentRailMoveConfig
		{
			[NullableContext(1)]
			get
			{
				MotorcycleRailComponent currentRailComp = this.CurrentRailComp;
				return ((currentRailComp != null) ? currentRailComp.GetRailMoveConfig() : null) ?? this.DefaultRailMoveConfig;
			}
		}

		// Token: 0x0603C0DC RID: 245980 RVA: 0x0111480C File Offset: 0x01112A0C
		private unsafe void UpdateCurrentRailComp(MotorcycleRailComponent newRailComp)
		{
			if (newRailComp == this.CurrentRailComp)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.MotorRailMove;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[MotorcycleRailMoveComponent] 更新当前轨道";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "PbDataId";
			CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
			ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "OldRailSplineId";
			MotorcycleRailComponent currentRailComp = this.CurrentRailComp;
			ptr2 = new ValueTuple<string, object>(item2, (currentRailComp != null) ? new int?(currentRailComp.GetRailSplineId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NewRailSplineId", (newRailComp != null) ? new int?(newRailComp.GetRailSplineId()) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (this.CurrentRailComp != null)
			{
				this.OnLeaveRail();
			}
			this.CurrentRailComp = newRailComp;
			if (this.CurrentRailComp != null)
			{
				this.OnEnterRail();
			}
		}

		// Token: 0x0603C0DD RID: 245981 RVA: 0x0111491C File Offset: 0x01112B1C
		private void OnEnterRail()
		{
			if (this.CurrentRailComp == null)
			{
				return;
			}
			foreach (KeyValuePair<int, bool> keyValuePair in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyVehicleTagsOnEnterRail)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int tagId = num;
				bool enable = flag;
				this.SetSelfTagEnable(tagId, enable);
			}
			foreach (KeyValuePair<long, bool> keyValuePair2 in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyVehicleBuffsOnEnterRail)
			{
				bool flag;
				long num2;
				keyValuePair2.Deconstruct(out num2, out flag);
				long buffId = num2;
				bool bEnable = flag;
				this.SetSelfBuffEnable(buffId, bEnable, "摩托入轨修改Buff");
			}
			foreach (KeyValuePair<int, bool> keyValuePair in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyDriverPlayerTagsOnEnterRail)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int tagId2 = num;
				bool enable2 = flag;
				this.SetPlayerTagEnable(tagId2, enable2);
			}
			foreach (KeyValuePair<long, bool> keyValuePair2 in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyDriverBuffsOnEnterRail)
			{
				bool flag;
				long num2;
				keyValuePair2.Deconstruct(out num2, out flag);
				long buffId2 = num2;
				bool bEnable2 = flag;
				this.SetDriverBuffEnable(buffId2, bEnable2, "摩托入轨修改Buff");
			}
			long railCreatureDataId = this.CurrentRailComp.GetRailCreatureDataId();
			if (railCreatureDataId != 0L)
			{
				this.RequestEnterRail(railCreatureDataId);
			}
		}

		// Token: 0x0603C0DE RID: 245982 RVA: 0x01114AE0 File Offset: 0x01112CE0
		private void OnLeaveRail()
		{
			if (this.CurrentRailComp == null)
			{
				return;
			}
			foreach (KeyValuePair<int, bool> keyValuePair in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyVehicleTagsOnLeaveRail)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int tagId = num;
				bool enable = flag;
				this.SetSelfTagEnable(tagId, enable);
			}
			foreach (KeyValuePair<long, bool> keyValuePair2 in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyVehicleBuffsOnLeaveRail)
			{
				bool flag;
				long num2;
				keyValuePair2.Deconstruct(out num2, out flag);
				long buffId = num2;
				bool bEnable = flag;
				this.SetSelfBuffEnable(buffId, bEnable, "摩托离轨修改Buff");
			}
			foreach (KeyValuePair<int, bool> keyValuePair in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyDriverPlayerTagsOnLeaveRail)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int tagId2 = num;
				bool enable2 = flag;
				this.SetPlayerTagEnable(tagId2, enable2);
			}
			foreach (KeyValuePair<long, bool> keyValuePair2 in this.CurrentRailMoveConfig.BasicRailMoveConfig.ModifyDriverBuffsOnLeaveRail)
			{
				bool flag;
				long num2;
				keyValuePair2.Deconstruct(out num2, out flag);
				long buffId2 = num2;
				bool bEnable2 = flag;
				this.SetDriverBuffEnable(buffId2, bEnable2, "摩托离轨修改Buff");
			}
			long railCreatureDataId = this.CurrentRailComp.GetRailCreatureDataId();
			if (railCreatureDataId != 0L)
			{
				this.RequestLeaveRail(railCreatureDataId);
			}
			this.StartAutoEnterRailCd(this.CurrentRailMoveConfig.BasicRailMoveConfig.AutoEnterRailCdAfterLeaveRail * 1000f);
		}

		// Token: 0x0603C0DF RID: 245983 RVA: 0x01114CC0 File Offset: 0x01112EC0
		private unsafe void RequestLeaveRail(long oldRailCreatureDataId)
		{
			MotorSliderRequest motorSliderRequest = MotorSliderRequest.Create();
			motorSliderRequest.EntityId = oldRailCreatureDataId;
			motorSliderRequest.InteractType = MotorSliderInteractType.NormalExit;
			Net.Instance.Call(ERequestMessageId.MotorSliderRequest, motorSliderRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MotorSliderResponse motorSliderResponse = (MotorSliderResponse)msg;
				if (motorSliderResponse == null || motorSliderResponse.ErrorCode != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MotorRailMove;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[MotorcycleRailMoveComponent] 请求退出旧轨道失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent component = this.Entity.GetComponent<CreatureDataComponent>();
					ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OldRailCreatureDataId", oldRailCreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ErrorCode", (motorSliderResponse != null) ? new ErrorCode?(motorSliderResponse.ErrorCode) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				}
			}, 0);
		}

		// Token: 0x0603C0E0 RID: 245984 RVA: 0x01114D18 File Offset: 0x01112F18
		private unsafe void RequestEnterRail(long newRailCreatureDataId)
		{
			MotorSliderRequest motorSliderRequest = MotorSliderRequest.Create();
			motorSliderRequest.EntityId = newRailCreatureDataId;
			motorSliderRequest.InteractType = MotorSliderInteractType.Enter;
			Net.Instance.Call(ERequestMessageId.MotorSliderRequest, motorSliderRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MotorSliderResponse motorSliderResponse = (MotorSliderResponse)msg;
				if (motorSliderResponse == null || motorSliderResponse.ErrorCode != ErrorCode.Success)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MotorRailMove;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[MotorcycleRailMoveComponent] 请求进入新轨道失败";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent component = this.Entity.GetComponent<CreatureDataComponent>();
					ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("NewRailCreatureDataId", newRailCreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ErrorCode", (motorSliderResponse != null) ? new ErrorCode?(motorSliderResponse.ErrorCode) : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					MotorcycleRailComponent currentRailComp = this.CurrentRailComp;
					if (currentRailComp != null && currentRailComp.GetRailCreatureDataId() == newRailCreatureDataId)
					{
						this.SetFinishCurrentRailMove();
					}
				}
			}, 0);
		}

		// Token: 0x0603C0E1 RID: 245985 RVA: 0x01114D70 File Offset: 0x01112F70
		private void OnHandleClientEvent(FGameplayTag eventTag)
		{
			if (this.CurrentRailComp == null || !this.IsInRailMoveMode)
			{
				return;
			}
			RailMoveEventHandler railMoveEventHandler;
			if (!this.CurrentRailMoveConfig.BasicRailMoveConfig.ClientEventHandlers.TryGetValue(eventTag.TagId(), out railMoveEventHandler))
			{
				return;
			}
			foreach (KeyValuePair<int, bool> keyValuePair in railMoveEventHandler.ModifyCues)
			{
				int num;
				bool flag;
				keyValuePair.Deconstruct(out num, out flag);
				int cueId = num;
				if (flag)
				{
					this.PlayCue(cueId);
				}
				else
				{
					this.RemoveCue(cueId);
				}
			}
		}

		// Token: 0x0603C0E2 RID: 245986 RVA: 0x01114E10 File Offset: 0x01113010
		private void PlayCue(int cueId)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(base.Entity.Id);
			if (entityById == null || this.CueComp == null)
			{
				return;
			}
			GameplayCueParam value = new GameplayCueParam
			{
				Instigator = entityById
			};
			int num = this.CueComp.AddCue((long)cueId, new GameplayCueParam?(value));
			if (num == 0 || num == -1)
			{
				return;
			}
			HashSet<int> hashSet;
			if (!this.CurrentCueHandleMap.TryGetValue(cueId, out hashSet))
			{
				hashSet = new HashSet<int>();
				this.CurrentCueHandleMap[cueId] = hashSet;
			}
			hashSet.Add(num);
		}

		// Token: 0x0603C0E3 RID: 245987 RVA: 0x01114E9C File Offset: 0x0111309C
		private void RemoveCue(int cueId)
		{
			HashSet<int> hashSet;
			if (!this.CurrentCueHandleMap.TryGetValue(cueId, out hashSet))
			{
				return;
			}
			foreach (int num in hashSet)
			{
				BaseGameplayCueComponent cueComp = this.CueComp;
				if (cueComp != null)
				{
					cueComp.RemoveCueByHandle((long)num);
				}
			}
			this.CurrentCueHandleMap.Remove(cueId);
		}

		// Token: 0x0603C0E4 RID: 245988 RVA: 0x01114F14 File Offset: 0x01113114
		private void RemoveAllCue()
		{
			foreach (HashSet<int> hashSet in this.CurrentCueHandleMap.Values)
			{
				foreach (int num in hashSet)
				{
					BaseGameplayCueComponent cueComp = this.CueComp;
					if (cueComp != null)
					{
						cueComp.RemoveCueByHandle((long)num);
					}
				}
			}
			this.CurrentCueHandleMap.Clear();
		}

		// Token: 0x0603C0E5 RID: 245989 RVA: 0x01114FB8 File Offset: 0x011131B8
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe SMotorRailMoveConfig GetRailMoveConfigUeData(string rowName)
		{
			SMotorRailMoveConfig dataTableRow;
			if (!this.RailMoveConfigUeDataCacheMap.TryGetValue(rowName, out dataTableRow))
			{
				if (this.RailMoveConfigDataTable == null)
				{
					this.LoadRailMoveConfigDataTable(false);
				}
				dataTableRow = DataTableUtil.GetDataTableRow<SMotorRailMoveConfig>(this.RailMoveConfigDataTable, rowName);
				if (dataTableRow == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MotorRailMove;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[MotorcycleRailMoveComponent] 查询摩托滑轨配置失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
					ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RowName", rowName);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return null;
				}
				this.RailMoveConfigUeDataCacheMap[rowName] = dataTableRow;
			}
			return dataTableRow;
		}

		// Token: 0x0603C0E6 RID: 245990 RVA: 0x0111508E File Offset: 0x0111328E
		public void UpdateDefaultRailMoveConfig()
		{
			MotorcycleRailMoveUtils.Instance.UpdateRailMoveConfig("Default", this.DefaultRailMoveConfig, new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
		}

		// Token: 0x0603C0E7 RID: 245991 RVA: 0x011150B4 File Offset: 0x011132B4
		private unsafe void LoadRailMoveConfigDataTable(bool bAsync = true)
		{
			if (this.LoadConfigHandle != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadConfigHandle);
				this.LoadConfigHandle = -1;
			}
			if (this.RailMoveConfigDataTable != null)
			{
				return;
			}
			string dtPath = "/Game/Aki/Data/Gameplay/MotorRailMove/DT_MotorRailMoveConfig.DT_MotorRailMoveConfig";
			if (bAsync)
			{
				bool wasCallback = false;
				int num = ResourceSystem.Instance.LoadAsync<UDataTable>(dtPath, delegate([Nullable(2)] UDataTable asset, string path)
				{
					wasCallback = true;
					if (asset == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.MotorRailMove;
						ELogAuthor author2 = ELogAuthor.ZYL;
						string message2 = "[MotorcycleRailMoveComponent] 加载轨道移动配置DT表失败";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
						string item2 = "PbDataId";
						CreatureDataComponent component2 = this.Entity.GetComponent<CreatureDataComponent>();
						ptr2 = new ValueTuple<string, object>(item2, (component2 != null) ? new int?(component2.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("DtPath", dtPath);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						return;
					}
					this.RailMoveConfigDataTable = asset;
					if (this.LoadConfigHandle != -1)
					{
						ResourceSystem.Instance.CancelAsyncLoad(this.LoadConfigHandle);
						this.LoadConfigHandle = -1;
					}
				}, 100, "js_undefined");
				if (!wasCallback && num != -1)
				{
					this.LoadConfigHandle = num;
					return;
				}
			}
			else
			{
				UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(dtPath, "js_undefined");
				if (udataTable == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MotorRailMove;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[MotorcycleRailMoveComponent] 加载轨道移动配置DT表失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
					ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DtPath", dtPath);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.RailMoveConfigDataTable = udataTable;
			}
		}

		// Token: 0x0603C0E8 RID: 245992 RVA: 0x011151F2 File Offset: 0x011133F2
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.LoadRailMoveConfigDataTable(true);
			return true;
		}

		// Token: 0x0603C0E9 RID: 245993 RVA: 0x011151FC File Offset: 0x011133FC
		protected override bool OnInit()
		{
			this.ActorComp = base.Entity.GetComponent<VehicleActorComponent>();
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			return true;
		}

		// Token: 0x0603C0EA RID: 245994 RVA: 0x01115224 File Offset: 0x01113424
		protected override void OnActivate()
		{
			this.UpdateDefaultRailMoveConfig();
			this.PerformComp = base.Entity.GetComponent<VehiclePerformComponent>();
			this.TagComp = base.Entity.GetComponent<VehicleTagComponent>();
			this.CueComp = base.Entity.GetComponent<BaseGameplayCueComponent>();
			this.BuffComp = base.Entity.GetComponent<VehicleBuffComponent>();
			this.DebugMoveComp = base.Entity.GetComponent<ActorDebugMovementComponent>();
			if (!EventSystem.Instance.HasWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeforeSkill)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey(this, base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnBeforeSkill));
			}
			if (!EventSystem.Instance.HasWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey<VehiclePassengerInfo, bool>(this, base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			}
			if (!EventSystem.Instance.HasWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved)))
			{
				EventSystem.Instance.AddWithTargetUseHoldKey<VehiclePassengerInfo, bool>(this, base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			}
		}

		// Token: 0x0603C0EB RID: 245995 RVA: 0x01115358 File Offset: 0x01113558
		protected override bool OnEnd()
		{
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			this.StopDirectlyEnterRailCd();
			return true;
		}

		// Token: 0x0603C0EC RID: 245996 RVA: 0x01115370 File Offset: 0x01113570
		private unsafe void OnBeforeSkill(int skillId, bool isAutonomousProxy)
		{
			if (this.RailMoveConfigDataTable == null)
			{
				return;
			}
			VehicleActorComponent actorComp = this.ActorComp;
			if (actorComp == null || !actorComp.IsAutonomousProxy)
			{
				return;
			}
			if (skillId == this.CurrentRailMoveConfig.JumpAlongRailConfig.SkillId)
			{
				this.OnJumpAlongRailSkill();
				return;
			}
			if (skillId == this.CurrentRailMoveConfig.SwitchRailConfig.SkillId)
			{
				this.OnJumpSwitchRailSkill();
				return;
			}
			if (skillId == this.CurrentRailMoveConfig.JumpOffRailConfig.SkillId)
			{
				this.OnJumpOffRailSkill();
				return;
			}
			if (skillId == this.CurrentRailMoveConfig.JumpToRailConfig.SkillId)
			{
				this.OnJumpToRailSkill();
				return;
			}
			if ((this.CurrentRailMoveData != null || this.PendingRailMoveDataQueue.Size != 0) && !this.CurrentRailMoveConfig.BasicRailMoveConfig.AllowUseSkillIds.Contains(skillId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] 尝试使用滑轨中不允许的技能，自动退出摩托滑轨";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SkillId", skillId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.SetClearAllRailMoveAndTickImmediately();
			}
		}

		// Token: 0x0603C0ED RID: 245997 RVA: 0x011154C2 File Offset: 0x011136C2
		private void OnJumpAlongRailSkill()
		{
			if (!this.IsInRailMoveMode)
			{
				return;
			}
			this.TryJumpAlongRail();
		}

		// Token: 0x0603C0EE RID: 245998 RVA: 0x011154D4 File Offset: 0x011136D4
		private void OnJumpSwitchRailSkill()
		{
			if (!this.IsInRailMoveMode)
			{
				return;
			}
			InputModel instance = InputModel.Instance;
			Dictionary<EInputAxis, float> dictionary = (instance != null) ? instance.GetAxisValues() : null;
			float? num = (dictionary != null) ? dictionary.GetValueOrNull(EInputAxis.MoveRight) : null;
			if (num != null)
			{
				float? num2 = num;
				float num3 = 0f;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					num2 = num;
					num3 = 0f;
					if (num2.GetValueOrDefault() < num3 & num2 != null)
					{
						this.TrySwitchToSideRail(EMotorcycleSide.Left);
						return;
					}
					this.TrySwitchToSideRail(EMotorcycleSide.Right);
					return;
				}
			}
		}

		// Token: 0x0603C0EF RID: 245999 RVA: 0x01115568 File Offset: 0x01113768
		private void OnJumpOffRailSkill()
		{
			if (!this.IsInRailMoveMode)
			{
				return;
			}
			InputModel instance = InputModel.Instance;
			Dictionary<EInputAxis, float> dictionary = (instance != null) ? instance.GetAxisValues() : null;
			float? num = (dictionary != null) ? dictionary.GetValueOrNull(EInputAxis.MoveRight) : null;
			if (num != null)
			{
				float? num2 = num;
				float num3 = 0f;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					num2 = num;
					num3 = 0f;
					if (num2.GetValueOrDefault() < num3 & num2 != null)
					{
						this.TryJumpOffFromRail(EMotorcycleSide.Left);
						return;
					}
					this.TryJumpOffFromRail(EMotorcycleSide.Right);
					return;
				}
			}
		}

		// Token: 0x0603C0F0 RID: 246000 RVA: 0x011155FC File Offset: 0x011137FC
		private void OnJumpToRailSkill()
		{
			if (this.IsInRailMoveMode)
			{
				return;
			}
			this.TryJumpEnterRailMove();
		}

		// Token: 0x0603C0F1 RID: 246001 RVA: 0x0111560E File Offset: 0x0111380E
		[NullableContext(1)]
		protected void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
		{
		}

		// Token: 0x0603C0F2 RID: 246002 RVA: 0x01115610 File Offset: 0x01113810
		[NullableContext(1)]
		protected void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (info.IsDriver)
			{
				this.SetClearAllRailMoveAndTickImmediately();
			}
		}

		// Token: 0x0603C0F3 RID: 246003 RVA: 0x01115620 File Offset: 0x01113820
		protected override void OnTick(float delta)
		{
			if (this.RailMoveConfigDataTable == null)
			{
				return;
			}
			this.OnTickRailMove(delta * 0.001f);
			this.OnTickCheckRail();
			this.OnTickCheckInput();
			this.OnTickCheckSkill();
		}

		// Token: 0x0603C0F4 RID: 246004 RVA: 0x0111564C File Offset: 0x0111384C
		private unsafe void OnTickRailMove(float deltaSeconds)
		{
			MotorcycleRailMoveDataBase currentRailMoveData = this.CurrentRailMoveData;
			MotorcycleRailMoveDataBase currentRailMoveData2 = this.CurrentRailMoveData;
			if (currentRailMoveData2 != null && currentRailMoveData2.IsFinishMove)
			{
				if (this.CurrentRailMoveData.IsFinishMoveOnFailure)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.MotorRailMove;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "VehicleRailMoveData因失败而结束，清除后续滑轨移动";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", this.CurrentRailMoveData.Type);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					this.PendingRailMoveDataQueue.Clear();
				}
				this.CurrentRailMoveData.Exit();
				this.CurrentRailMoveData = null;
			}
			if (this.CurrentRailMoveData == null && this.PendingRailMoveDataQueue.Size > 0)
			{
				this.CurrentRailMoveData = this.PendingRailMoveDataQueue.Pop();
				if (!this.CurrentRailMoveData.Enter(currentRailMoveData))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.MotorRailMove;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[MotorcycleRailMoveComponent] 尝试进入目标MoveData失败，自动退出，并清除后续滑轨移动";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
					ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RailMoveDataType", this.CurrentRailMoveData.Type);
					instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.PendingRailMoveDataQueue.Clear();
					this.CurrentRailMoveData.Exit();
					this.CurrentRailMoveData = null;
				}
			}
			if (currentRailMoveData == null && this.CurrentRailMoveData != null)
			{
				this.UpdateCurrentRailComp(this.CurrentRailMoveData.RelatedRail);
				this.OnEnterRailMove();
			}
			else if (currentRailMoveData != null && this.CurrentRailMoveData == null)
			{
				this.OnLeaveRailMove();
				this.UpdateCurrentRailComp(null);
			}
			else
			{
				MotorcycleRailMoveDataBase currentRailMoveData3 = this.CurrentRailMoveData;
				this.UpdateCurrentRailComp((currentRailMoveData3 != null) ? currentRailMoveData3.RelatedRail : null);
			}
			if (!this.IsInRailMoveMode)
			{
				return;
			}
			if (this.CurrentRailMoveData != null)
			{
				if (deltaSeconds > 1f)
				{
					if (SundryModel.Instance.GetModuleDebugLevel("MotorRailMove") > 0)
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.MotorRailMove;
						ELogAuthor author3 = ELogAuthor.ZYL;
						string message3 = "[MotorcycleRailMoveComponent] Delta time too big!";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
						string item2 = "PbDataId";
						CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
						ptr2 = new ValueTuple<string, object>(item2, (component2 != null) ? new int?(component2.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("deltaSeconds", deltaSeconds);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
					else
					{
						Log instance4 = Log.Instance;
						ELogModule module4 = ELogModule.MotorRailMove;
						ELogAuthor author4 = ELogAuthor.ZYL;
						string message4 = "[MotorcycleRailMoveComponent] Delta time too big!";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr3 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0);
						string item3 = "PbDataId";
						CreatureDataComponent component3 = base.Entity.GetComponent<CreatureDataComponent>();
						ptr3 = new ValueTuple<string, object>(item3, (component3 != null) ? new int?(component3.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("deltaSeconds", deltaSeconds);
						instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
				}
				this.CurrentRailMoveData.Tick(deltaSeconds);
				this.ApplyRailMove(deltaSeconds);
			}
		}

		// Token: 0x0603C0F5 RID: 246005 RVA: 0x0111596C File Offset: 0x01113B6C
		private unsafe void ApplyRailMove(float deltaSeconds)
		{
			VehicleActorComponent actorComp = this.ActorComp;
			if (((actorComp != null) ? actorComp.VehicleMoveComp : null) == null)
			{
				return;
			}
			VehicleMoveComponent vehicleMoveComp = this.ActorComp.VehicleMoveComp;
			if (SundryModel.Instance.GetModuleDebugLevel("MotorRailMove") > 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] ApplyRailMove";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DeltaSec", deltaSeconds);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
				string item2 = "Dist";
				global::Transform vehicleRailMoveTransform = this.VehicleRailMoveTransform;
				ptr2 = new ValueTuple<string, object>(item2, (((vehicleRailMoveTransform != null) ? vehicleRailMoveTransform.GetLocation() : null) != null && this.ActorComp.Owner != null) ? global::Vector.Dist(this.VehicleRailMoveTransform.GetLocation(), this.ActorComp.ActorLocationProxy) : null);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			UKuroVehicleMovementComponent vehicleMovement = vehicleMoveComp.VehicleMovement;
			if (this.VehicleRailMoveVelocity != null)
			{
				vehicleMoveComp.SetForceSpeed(this.VehicleRailMoveVelocity);
				UMotorWheelDisplayInfoObject umotorWheelDisplayInfoObject = (vehicleMovement != null) ? vehicleMovement.WheelDisplayInfosObj : null;
				if (umotorWheelDisplayInfoObject != null && umotorWheelDisplayInfoObject.DisplayInfos.Num() >= 2)
				{
					float wheelSpeed = (float)this.VehicleRailMoveVelocity.Size() / 37f;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(0).WheelSpeed = wheelSpeed;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(1).WheelSpeed = wheelSpeed;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(0).WheelAccel = 113.097336f;
					umotorWheelDisplayInfoObject.DisplayInfos.Get(1).WheelAccel = 113.097336f;
				}
				this.ActorComp.ResetCachedVelocityTime();
			}
			if (this.VehicleRailMoveTransform != null && vehicleMovement != null)
			{
				vehicleMovement.UpdateMotorRailMoveTransform(deltaSeconds, this.VehicleRailMoveTransform.ToUeTransform(), true, this.SweepWhenApplyVehicleRailMove);
				ActorDebugMovementComponent debugMoveComp = this.DebugMoveComp;
				if (debugMoveComp != null)
				{
					debugMoveComp.MarkDebugRecord("MotorcycleRailMoveComponent应用移动后", new EKDMRecordType?(EKDMRecordType.KDM_ALL), false);
				}
				if (this.PerformComp != null)
				{
					foreach (VehiclePassengerInfo vehiclePassengerInfo in this.PerformComp.PassengerInfoMap.Values)
					{
						Entity passengerEntity = vehiclePassengerInfo.PassengerEntity;
						ActorDebugMovementComponent actorDebugMovementComponent = (passengerEntity != null) ? passengerEntity.GetComponent<ActorDebugMovementComponent>() : null;
						if (actorDebugMovementComponent != null)
						{
							actorDebugMovementComponent.MarkDebugRecord("MotorcycleRailMoveComponent应用移动后", new EKDMRecordType?(EKDMRecordType.KDM_ALL), false);
						}
					}
				}
				this.ActorComp.ResetLocationCachedTime();
				this.ActorComp.ResetRotationCachedTime();
			}
		}

		// Token: 0x0603C0F6 RID: 246006 RVA: 0x01115C1C File Offset: 0x01113E1C
		private void OnEnterRailMove()
		{
			if (this.IsInRailMoveMode)
			{
				return;
			}
			this.IsInRailMoveMode = true;
			VehicleActorComponent actorComp = this.ActorComp;
			if (((actorComp != null) ? actorComp.VehicleMoveComp : null) != null)
			{
				this.ActorComp.VehicleMoveComp.IsSpecialMove = true;
				this.ActorComp.VehicleMoveComp.DisableUeMovementTick("进入滑轨移动");
				UKuroVehicleMovementComponent vehicleMovement = this.ActorComp.VehicleMoveComp.VehicleMovement;
				if (vehicleMovement != null)
				{
					vehicleMovement.ResetMotorRailMoveData();
				}
			}
			this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.滑轨移动中"], true);
			this.SetPlayerTagEnable(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.滑轨移动中"], true);
			if (!EventSystem.Instance.Has<FGameplayTag>(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnHandleClientEvent)))
			{
				EventSystem.Instance.Add<FGameplayTag>(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnHandleClientEvent));
			}
		}

		// Token: 0x0603C0F7 RID: 246007 RVA: 0x01115CF4 File Offset: 0x01113EF4
		private void OnLeaveRailMove()
		{
			if (!this.IsInRailMoveMode)
			{
				return;
			}
			this.IsInRailMoveMode = false;
			this.VehicleRailMoveTransform = null;
			this.SweepWhenApplyVehicleRailMove = false;
			this.VehicleRailMoveVelocity = null;
			VehicleActorComponent actorComp = this.ActorComp;
			if (((actorComp != null) ? actorComp.VehicleMoveComp : null) != null)
			{
				this.ActorComp.VehicleMoveComp.IsSpecialMove = false;
				this.ActorComp.VehicleMoveComp.EnableUeMovementTick("退出滑轨移动");
				UKuroVehicleMovementComponent vehicleMovement = this.ActorComp.VehicleMoveComp.VehicleMovement;
				if (vehicleMovement != null)
				{
					vehicleMovement.ResetMotorRailMoveData();
				}
			}
			this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.滑轨移动中"], false);
			this.SetPlayerTagEnable(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.滑轨移动中"], false);
			if (EventSystem.Instance.Has<FGameplayTag>(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnHandleClientEvent)))
			{
				EventSystem.Instance.Remove<FGameplayTag>(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnHandleClientEvent));
			}
			this.RemoveAllCue();
			this.StartAutoEnterRailCd(this.CurrentRailMoveConfig.BasicRailMoveConfig.AutoEnterRailCdAfterLeaveRailMove * 1000f);
		}

		// Token: 0x0603C0F8 RID: 246008 RVA: 0x01115E04 File Offset: 0x01114004
		private void OnTickCheckRail()
		{
			VehiclePerformComponent performComp = this.PerformComp;
			if (((performComp != null) ? performComp.Driver : null) != null)
			{
				int id = this.PerformComp.Driver.Id;
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				int? num = (baseCharacter != null) ? new int?(baseCharacter.GetEntityIdNoBlueprint()) : null;
				if (id == num.GetValueOrDefault() & num != null)
				{
					if (this.ActorComp == null)
					{
						return;
					}
					this.TickCheckRailForEnter();
					this.TickCheckRailForSwitch();
					return;
				}
			}
		}

		// Token: 0x0603C0F9 RID: 246009 RVA: 0x01115E80 File Offset: 0x01114080
		private void TickCheckRailForEnter()
		{
			bool enable = false;
			MotorcycleRailComponent motorcycleRailComponent = this.FindRailAndDistForDirectlyEnter();
			if (motorcycleRailComponent != null)
			{
				this.AddDirectlyEnterTargetRailMove(motorcycleRailComponent);
			}
			else if (this.FindRailAndDistForJumpEnter() != null)
			{
				enable = true;
			}
			this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.能够跳跃上轨"], enable);
		}

		// Token: 0x0603C0FA RID: 246010 RVA: 0x01115EC4 File Offset: 0x011140C4
		private MotorcycleRailComponent FindRailAndDistForDirectlyEnter()
		{
			if (this.IsInDirectlyEnterRailCd)
			{
				return null;
			}
			if (this.ActorComp == null || this.IsInRailMoveMode)
			{
				return null;
			}
			if (!this.PendingRailMoveDataQueue.Empty)
			{
				return null;
			}
			if (this.CurrentRailMoveData != null)
			{
				return null;
			}
			if (this.IsInNotAllowedSkill())
			{
				return null;
			}
			double num = double.MaxValue;
			MotorcycleRailComponent motorcycleRailComponent = null;
			foreach (MotorcycleRailComponent motorcycleRailComponent2 in MotorcycleRailComponent.AllRailsThatPlayerInRange)
			{
				if (motorcycleRailComponent2.GetRailSplineType().GetValueOrDefault() == ESplineType.MotorSlide)
				{
					double distanceToRail = motorcycleRailComponent2.GetDistanceToRail(new TRailMoveGetter(this.VehicleRailMoveGetter));
					if (distanceToRail >= 0.0 && distanceToRail < num)
					{
						if (motorcycleRailComponent2.GetRailMoveConfig() == null)
						{
							motorcycleRailComponent2.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
						}
						if (motorcycleRailComponent2.CheckIsRailCanDirectlyEnter(new TRailMoveGetter(this.VehicleRailMoveGetter)))
						{
							num = distanceToRail;
							motorcycleRailComponent = motorcycleRailComponent2;
						}
					}
				}
			}
			if (motorcycleRailComponent != null)
			{
				return motorcycleRailComponent;
			}
			return null;
		}

		// Token: 0x0603C0FB RID: 246011 RVA: 0x01115FCC File Offset: 0x011141CC
		private MotorcycleRailComponent FindRailAndDistForJumpEnter()
		{
			if (this.ActorComp == null || this.IsInRailMoveMode)
			{
				return null;
			}
			if (!this.PendingRailMoveDataQueue.Empty)
			{
				return null;
			}
			if (this.CurrentRailMoveData != null)
			{
				return null;
			}
			if (this.IsInNotAllowedSkill())
			{
				return null;
			}
			double num = double.MaxValue;
			MotorcycleRailComponent motorcycleRailComponent = null;
			foreach (MotorcycleRailComponent motorcycleRailComponent2 in MotorcycleRailComponent.AllRailsThatPlayerInRange)
			{
				if (motorcycleRailComponent2.GetRailSplineType().GetValueOrDefault() == ESplineType.MotorSlide)
				{
					double distanceToRail = motorcycleRailComponent2.GetDistanceToRail(new TRailMoveGetter(this.VehicleRailMoveGetter));
					if (distanceToRail >= 0.0 && distanceToRail < num)
					{
						if (motorcycleRailComponent2.GetRailMoveConfig() == null)
						{
							motorcycleRailComponent2.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
						}
						if (motorcycleRailComponent2.CheckIsRailCanJumpEnter(new TRailMoveGetter(this.VehicleRailMoveGetter)))
						{
							num = distanceToRail;
							motorcycleRailComponent = motorcycleRailComponent2;
						}
					}
				}
			}
			if (motorcycleRailComponent != null)
			{
				return motorcycleRailComponent;
			}
			return null;
		}

		// Token: 0x0603C0FC RID: 246012 RVA: 0x011160CC File Offset: 0x011142CC
		private void TickCheckRailForSwitch()
		{
			bool flag = this.FindSideRailForSwitch(EMotorcycleSide.Left) != null;
			bool flag2 = this.FindSideRailForSwitch(EMotorcycleSide.Right) != null;
			this.SetPlayerTagEnable(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.能够左跳"], flag);
			this.SetPlayerTagEnable(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.滑轨.能够右跳"], flag2);
			this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.能够切轨"], flag || flag2);
		}

		// Token: 0x0603C0FD RID: 246013 RVA: 0x01116134 File Offset: 0x01114334
		private MotorcycleRailComponent FindSideRailForSwitch(EMotorcycleSide sideToFind)
		{
			if (this.ActorComp == null || !this.IsInRailMoveMode)
			{
				return null;
			}
			if (!this.PendingRailMoveDataQueue.Empty)
			{
				return null;
			}
			if (this.CurrentRailMoveData == null)
			{
				return null;
			}
			MotorcycleAccelerateAlongRailMoveData motorcycleAccelerateAlongRailMoveData = this.CurrentRailMoveData as MotorcycleAccelerateAlongRailMoveData;
			if (motorcycleAccelerateAlongRailMoveData == null)
			{
				return null;
			}
			IMotorSlideSplinePoint currentSegmentPointOption = motorcycleAccelerateAlongRailMoveData.GetCurrentSegmentPointOption();
			if (currentSegmentPointOption == null)
			{
				return null;
			}
			bool isMoveAlongSplineForward = motorcycleAccelerateAlongRailMoveData.GetIsMoveAlongSplineForward();
			int? num = null;
			if (sideToFind == EMotorcycleSide.Left)
			{
				num = (isMoveAlongSplineForward ? currentSegmentPointOption.LeftTargetId : currentSegmentPointOption.RightTargetId);
			}
			else
			{
				num = (isMoveAlongSplineForward ? currentSegmentPointOption.RightTargetId : currentSegmentPointOption.LeftTargetId);
			}
			if (num != null)
			{
				CreatureModel instance = CreatureModel.Instance;
				MotorcycleRailComponent motorcycleRailComponent;
				if (instance == null)
				{
					motorcycleRailComponent = null;
				}
				else
				{
					EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(num.Value);
					if (entityByPbDataId == null)
					{
						motorcycleRailComponent = null;
					}
					else
					{
						WorldEntity entity = entityByPbDataId.Entity;
						motorcycleRailComponent = ((entity != null) ? entity.GetComponent<MotorcycleRailComponent>() : null);
					}
				}
				MotorcycleRailComponent motorcycleRailComponent2 = motorcycleRailComponent;
				if (motorcycleRailComponent2 != null && motorcycleRailComponent2.GetRailSplineType().GetValueOrDefault() == ESplineType.MotorSlide)
				{
					if (motorcycleRailComponent2.GetRailMoveConfig() == null)
					{
						motorcycleRailComponent2.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
					}
					motorcycleRailComponent2.CheckIsRailCanSwitch(new TRailMoveGetter(this.VehicleRailMoveGetter));
					EMotorcycleSide? relativeSideOfTarget = motorcycleRailComponent2.GetRelativeSideOfTarget(new TRailMoveGetter(this.VehicleRailMoveGetter));
					if (relativeSideOfTarget.GetValueOrDefault() == sideToFind & relativeSideOfTarget != null)
					{
						return motorcycleRailComponent2;
					}
				}
			}
			return null;
		}

		// Token: 0x0603C0FE RID: 246014 RVA: 0x01116278 File Offset: 0x01114478
		private void OnTickCheckSkill()
		{
			if (this.CurrentRailMoveData != null && this.IsInNotAllowedSkill())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] 检测到使用滑轨中不允许的技能，自动退出摩托滑轨";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SetClearAllRailMove();
			}
		}

		// Token: 0x0603C0FF RID: 246015 RVA: 0x011162F0 File Offset: 0x011144F0
		private void OnTickCheckInput()
		{
			bool flag = false;
			if (this.IsInRailMoveMode)
			{
				InputModel instance = InputModel.Instance;
				Dictionary<EInputAxis, float> dictionary = (instance != null) ? instance.GetAxisValues() : null;
				float? num = (dictionary != null) ? dictionary.GetValueOrNull(EInputAxis.MoveRight) : null;
				bool flag2;
				if (num != null)
				{
					float? num2 = num;
					float num3 = 0f;
					flag2 = !(num2.GetValueOrDefault() == num3 & num2 != null);
				}
				else
				{
					flag2 = false;
				}
				flag = flag2;
			}
			this.SetSelfTagEnable(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.输入.左右输入"], flag);
			if (flag && this.GetSelfTagEnable(GameplayTagDefine.EGameplayTagId["载具.摩托.滑轨.能够切轨"]))
			{
				VehicleSkillComponent component = base.Entity.GetComponent<VehicleSkillComponent>();
				if (component == null)
				{
					return;
				}
				component.BeginSkillAsync(this.CurrentRailMoveConfig.SwitchRailConfig.SkillId, new SkillParam
				{
					Reason = "[MotorcycleRailMoveComponent] 释放切轨技能"
				});
			}
		}

		// Token: 0x0603C100 RID: 246016 RVA: 0x011163C4 File Offset: 0x011145C4
		private void SetPlayerTagEnable(int tagId, bool enable)
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			if (!FormationDataController.Instance.IsPlayerExist(playerId))
			{
				return;
			}
			bool flag = FormationDataController.Instance.HasPlayerTag(playerId, tagId, true);
			if (enable && !flag)
			{
				FormationDataController.Instance.AddPlayerTag(playerId, new int?(tagId));
				return;
			}
			if (!enable && flag)
			{
				FormationDataController.Instance.RemovePlayerTag(playerId, new int?(tagId));
			}
		}

		// Token: 0x0603C101 RID: 246017 RVA: 0x0111642C File Offset: 0x0111462C
		private void SetSelfTagEnable(int tagId, bool enable)
		{
			VehicleTagComponent tagComp = this.TagComp;
			if (tagComp == null)
			{
				return;
			}
			bool flag = tagComp.HasTag(tagId);
			if (enable && !flag)
			{
				tagComp.AddTag(new int?(tagId));
				return;
			}
			if (!enable && flag)
			{
				tagComp.RemoveTag(new int?(tagId));
			}
		}

		// Token: 0x0603C102 RID: 246018 RVA: 0x01116474 File Offset: 0x01114674
		private bool GetSelfTagEnable(int tagId)
		{
			VehicleTagComponent tagComp = this.TagComp;
			return tagComp != null && tagComp.HasTag(tagId);
		}

		// Token: 0x0603C103 RID: 246019 RVA: 0x01116494 File Offset: 0x01114694
		[NullableContext(1)]
		private void SetSelfBuffEnable(long buffId, bool bEnable, string reason)
		{
			if (this.CreatureDataComp == null || this.BuffComp == null)
			{
				return;
			}
			if (bEnable)
			{
				VehicleBuffComponent buffComp = this.BuffComp;
				if (buffComp == null)
				{
					return;
				}
				buffComp.AddBuff(buffId, new AddBuffParam
				{
					InstigatorId = this.CreatureDataComp.GetCreatureDataId(),
					Reason = reason,
					PreMessageId = new long?(this.CreatureDataComp.MotorContextId)
				});
				return;
			}
			else
			{
				VehicleBuffComponent buffComp2 = this.BuffComp;
				if (buffComp2 == null)
				{
					return;
				}
				buffComp2.RemoveBuff(buffId, -1, reason, new long?(this.CreatureDataComp.MotorContextId), null, null);
				return;
			}
		}

		// Token: 0x0603C104 RID: 246020 RVA: 0x01116530 File Offset: 0x01114730
		[NullableContext(1)]
		private void SetDriverBuffEnable(long buffId, bool bEnable, string reason)
		{
			if (this.CreatureDataComp == null)
			{
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			RoleBuffComponent roleBuffComponent;
			if (baseCharacter == null)
			{
				roleBuffComponent = null;
			}
			else
			{
				Entity entityNoBlueprint = baseCharacter.GetEntityNoBlueprint();
				roleBuffComponent = ((entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<RoleBuffComponent>() : null);
			}
			RoleBuffComponent roleBuffComponent2 = roleBuffComponent;
			if (roleBuffComponent2 == null)
			{
				return;
			}
			if (bEnable)
			{
				roleBuffComponent2.AddBuff(buffId, new AddBuffParam
				{
					InstigatorId = this.CreatureDataComp.GetCreatureDataId(),
					Reason = reason,
					PreMessageId = new long?(this.CreatureDataComp.MotorContextId)
				});
				return;
			}
			roleBuffComponent2.RemoveBuff(buffId, -1, reason, new long?(this.CreatureDataComp.MotorContextId), null, null);
		}

		// Token: 0x0603C105 RID: 246021 RVA: 0x011165D1 File Offset: 0x011147D1
		public void SetClearAllRailMove()
		{
			if (this.CurrentRailMoveData != null)
			{
				this.CurrentRailMoveData.IsFinishMove = true;
			}
			this.PendingRailMoveDataQueue.Clear();
		}

		// Token: 0x0603C106 RID: 246022 RVA: 0x011165F2 File Offset: 0x011147F2
		public void SetClearAllRailMoveAndTickImmediately()
		{
			if (this.CurrentRailMoveData != null)
			{
				this.CurrentRailMoveData.IsFinishMove = true;
			}
			this.PendingRailMoveDataQueue.Clear();
			this.OnTick(0f);
		}

		// Token: 0x0603C107 RID: 246023 RVA: 0x0111661E File Offset: 0x0111481E
		public void SetFinishCurrentRailMove()
		{
			if (this.CurrentRailMoveData != null)
			{
				this.CurrentRailMoveData.IsFinishMove = true;
			}
		}

		// Token: 0x0603C108 RID: 246024 RVA: 0x01116634 File Offset: 0x01114834
		[NullableContext(1)]
		public void TryJumpToSpecifiedRail(MotorcycleRailComponent railComp)
		{
			if (railComp == null || !railComp.Entity.IsInit)
			{
				return;
			}
			if (this.IsInRailMoveMode)
			{
				this.SetClearAllRailMove();
			}
			this.AddJumpToTargetRailMove(railComp);
		}

		// Token: 0x0603C109 RID: 246025 RVA: 0x01116662 File Offset: 0x01114862
		[NullableContext(1)]
		public void TryDirectlyEnterSpecifiedRail(MotorcycleRailComponent railComp)
		{
			if (railComp == null || !railComp.Entity.IsInit)
			{
				return;
			}
			if (this.IsInRailMoveMode)
			{
				this.SetClearAllRailMove();
			}
			this.AddDirectlyEnterTargetRailMove(railComp);
		}

		// Token: 0x0603C10A RID: 246026 RVA: 0x01116690 File Offset: 0x01114890
		[NullableContext(1)]
		private void AddJumpToTargetRailMove(MotorcycleRailComponent railComp)
		{
			bool railSplineComp = railComp.GetRailSplineComp() != null;
			SplineCurve railSplineCurve = railComp.GetRailSplineCurve();
			IMotorSlideSpline motorSlideSpline = railComp.GetRailSplineData() as IMotorSlideSpline;
			if (railComp.GetRailMoveConfig() == null)
			{
				railComp.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
			}
			MotorcycleRailMoveConfig railMoveConfig = railComp.GetRailMoveConfig();
			if (!railSplineComp || motorSlideSpline == null || railMoveConfig == null || railSplineCurve == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] AddJumpToTargetRailMove失败";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MotorcycleJumpToRailMoveData motorcycleJumpToRailMoveData = new MotorcycleJumpToRailMoveData(base.Entity, railComp);
			motorcycleJumpToRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleJumpToRailMoveData.TargetSpline = railSplineCurve;
			motorcycleJumpToRailMoveData.GravityDir.DeepCopy(GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp));
			motorcycleJumpToRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleJumpToRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleJumpToRailMoveData);
			MotorcycleAccelerateAlongRailMoveData motorcycleAccelerateAlongRailMoveData = new MotorcycleAccelerateAlongRailMoveData(base.Entity, railComp);
			motorcycleAccelerateAlongRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleAccelerateAlongRailMoveData.Spline = railSplineCurve;
			motorcycleAccelerateAlongRailMoveData.SplinePointOptions.AddRange(motorSlideSpline.Points);
			motorcycleAccelerateAlongRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleAccelerateAlongRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleAccelerateAlongRailMoveData);
		}

		// Token: 0x0603C10B RID: 246027 RVA: 0x01116810 File Offset: 0x01114A10
		[NullableContext(1)]
		private void AddDirectlyEnterTargetRailMove(MotorcycleRailComponent railComp)
		{
			bool railSplineComp = railComp.GetRailSplineComp() != null;
			SplineCurve railSplineCurve = railComp.GetRailSplineCurve();
			IMotorSlideSpline motorSlideSpline = railComp.GetRailSplineData() as IMotorSlideSpline;
			if (railComp.GetRailMoveConfig() == null)
			{
				railComp.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
			}
			MotorcycleRailMoveConfig railMoveConfig = railComp.GetRailMoveConfig();
			if (!railSplineComp || motorSlideSpline == null || railMoveConfig == null || railSplineCurve == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] AddDirectlyEnterTargetRailMove失败";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MotorcycleSimpleMoveToRailMoveData motorcycleSimpleMoveToRailMoveData = new MotorcycleSimpleMoveToRailMoveData(base.Entity, railComp);
			motorcycleSimpleMoveToRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleSimpleMoveToRailMoveData.TargetSpline = railSplineCurve;
			motorcycleSimpleMoveToRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleSimpleMoveToRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleSimpleMoveToRailMoveData);
			MotorcycleAccelerateAlongRailMoveData motorcycleAccelerateAlongRailMoveData = new MotorcycleAccelerateAlongRailMoveData(base.Entity, railComp);
			motorcycleAccelerateAlongRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleAccelerateAlongRailMoveData.Spline = railSplineCurve;
			motorcycleAccelerateAlongRailMoveData.SplinePointOptions.AddRange(motorSlideSpline.Points);
			motorcycleAccelerateAlongRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleAccelerateAlongRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleAccelerateAlongRailMoveData);
		}

		// Token: 0x0603C10C RID: 246028 RVA: 0x01116974 File Offset: 0x01114B74
		[NullableContext(1)]
		private void AddSwitchTargetRailMove(MotorcycleRailComponent railComp)
		{
			bool railSplineComp = railComp.GetRailSplineComp() != null;
			SplineCurve railSplineCurve = railComp.GetRailSplineCurve();
			IMotorSlideSpline motorSlideSpline = railComp.GetRailSplineData() as IMotorSlideSpline;
			if (railComp.GetRailMoveConfig() == null)
			{
				railComp.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
			}
			MotorcycleRailMoveConfig railMoveConfig = railComp.GetRailMoveConfig();
			if (!railSplineComp || motorSlideSpline == null || railMoveConfig == null || railSplineCurve == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] AddSwitchTargetRailMove失败";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MotorcycleSwitchRailMoveData motorcycleSwitchRailMoveData = new MotorcycleSwitchRailMoveData(base.Entity, this.CurrentRailComp);
			motorcycleSwitchRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleSwitchRailMoveData.TargetSpline = railSplineCurve;
			motorcycleSwitchRailMoveData.GravityDir.DeepCopy(GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp));
			motorcycleSwitchRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleSwitchRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleSwitchRailMoveData);
			MotorcycleAccelerateAlongRailMoveData motorcycleAccelerateAlongRailMoveData = new MotorcycleAccelerateAlongRailMoveData(base.Entity, railComp);
			motorcycleAccelerateAlongRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleAccelerateAlongRailMoveData.Spline = railSplineCurve;
			motorcycleAccelerateAlongRailMoveData.SplinePointOptions.AddRange(motorSlideSpline.Points);
			motorcycleAccelerateAlongRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleAccelerateAlongRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleAccelerateAlongRailMoveData);
		}

		// Token: 0x0603C10D RID: 246029 RVA: 0x01116AFC File Offset: 0x01114CFC
		[NullableContext(1)]
		private void AddJumpOffFromCurrentRailMove(MotorcycleRailComponent railComp, EMotorcycleSide side)
		{
			bool railSplineComp = railComp.GetRailSplineComp() != null;
			SplineCurve railSplineCurve = railComp.GetRailSplineCurve();
			IMotorSlideSpline motorSlideSpline = railComp.GetRailSplineData() as IMotorSlideSpline;
			if (railComp.GetRailMoveConfig() == null)
			{
				railComp.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
			}
			MotorcycleRailMoveConfig railMoveConfig = railComp.GetRailMoveConfig();
			if (!railSplineComp || motorSlideSpline == null || railMoveConfig == null || railSplineCurve == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] AddDirectlyEnterTargetRailMove失败";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MotorcycleJumpFromRailMoveData motorcycleJumpFromRailMoveData = new MotorcycleJumpFromRailMoveData(base.Entity, railComp);
			motorcycleJumpFromRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleJumpFromRailMoveData.Spline = railSplineCurve;
			motorcycleJumpFromRailMoveData.SplinePointOptions.AddRange(motorSlideSpline.Points);
			motorcycleJumpFromRailMoveData.JumpSideDir = side;
			motorcycleJumpFromRailMoveData.GravityDir.DeepCopy(GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp));
			motorcycleJumpFromRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleJumpFromRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleJumpFromRailMoveData);
		}

		// Token: 0x0603C10E RID: 246030 RVA: 0x01116C30 File Offset: 0x01114E30
		[NullableContext(1)]
		private void AddJumpAlongTargetRailMove(MotorcycleRailComponent railComp, bool bIsForward)
		{
			bool railSplineComp = railComp.GetRailSplineComp() != null;
			SplineCurve railSplineCurve = railComp.GetRailSplineCurve();
			IMotorSlideSpline motorSlideSpline = railComp.GetRailSplineData() as IMotorSlideSpline;
			if (railComp.GetRailMoveConfig() == null)
			{
				railComp.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
			}
			MotorcycleRailMoveConfig railMoveConfig = railComp.GetRailMoveConfig();
			if (!railSplineComp || motorSlideSpline == null || railMoveConfig == null || railSplineCurve == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorRailMove;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[MotorcycleRailMoveComponent] AddDirectlyEnterTargetRailMove失败";
				string item = "PbDataId";
				CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			MotorcycleJumpAlongRailMoveData motorcycleJumpAlongRailMoveData = new MotorcycleJumpAlongRailMoveData(base.Entity, railComp);
			motorcycleJumpAlongRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleJumpAlongRailMoveData.TargetSpline = railSplineCurve;
			motorcycleJumpAlongRailMoveData.TargetIsForward = bIsForward;
			motorcycleJumpAlongRailMoveData.GravityDir.DeepCopy(GravityUtils.Instance.GetGravityDirectForActor(this.ActorComp));
			motorcycleJumpAlongRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleJumpAlongRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleJumpAlongRailMoveData);
			MotorcycleAccelerateAlongRailMoveData motorcycleAccelerateAlongRailMoveData = new MotorcycleAccelerateAlongRailMoveData(base.Entity, railComp);
			motorcycleAccelerateAlongRailMoveData.MoveConfig.DeepCopy(railMoveConfig);
			motorcycleAccelerateAlongRailMoveData.Spline = railSplineCurve;
			motorcycleAccelerateAlongRailMoveData.SplinePointOptions.AddRange(motorSlideSpline.Points);
			motorcycleAccelerateAlongRailMoveData.MoveUpdater = new TRailMoveUpdater(this.VehicleRailMoveUpdater);
			motorcycleAccelerateAlongRailMoveData.MoveGetter = new TRailMoveGetter(this.VehicleRailMoveGetter);
			this.PendingRailMoveDataQueue.Push(motorcycleAccelerateAlongRailMoveData);
		}

		// Token: 0x0603C10F RID: 246031 RVA: 0x01116DB8 File Offset: 0x01114FB8
		private bool TrySwitchToSideRail(EMotorcycleSide side)
		{
			MotorcycleRailComponent motorcycleRailComponent = this.FindSideRailForSwitch(side);
			if (motorcycleRailComponent != null)
			{
				this.SetClearAllRailMove();
				this.AddSwitchTargetRailMove(motorcycleRailComponent);
				return true;
			}
			return false;
		}

		// Token: 0x0603C110 RID: 246032 RVA: 0x01116DE0 File Offset: 0x01114FE0
		private bool TryJumpEnterRailMove()
		{
			MotorcycleRailComponent motorcycleRailComponent = this.FindRailAndDistForJumpEnter();
			if (motorcycleRailComponent != null)
			{
				this.AddJumpToTargetRailMove(motorcycleRailComponent);
				return true;
			}
			return false;
		}

		// Token: 0x0603C111 RID: 246033 RVA: 0x01116E04 File Offset: 0x01115004
		private bool TryJumpOffFromRail(EMotorcycleSide side)
		{
			if (!this.IsInRailMoveMode)
			{
				return false;
			}
			if (this.CurrentRailMoveData == null || this.CurrentRailMoveData.IsFinishMove || !this.PendingRailMoveDataQueue.Empty)
			{
				return false;
			}
			if (!(this.CurrentRailMoveData is MotorcycleAccelerateAlongRailMoveData))
			{
				return false;
			}
			MotorcycleRailComponent relatedRail = this.CurrentRailMoveData.RelatedRail;
			if (relatedRail == null || relatedRail.GetRailSplineType().GetValueOrDefault() != ESplineType.MotorSlide)
			{
				return false;
			}
			this.SetClearAllRailMove();
			this.AddJumpOffFromCurrentRailMove(relatedRail, side);
			return true;
		}

		// Token: 0x0603C112 RID: 246034 RVA: 0x01116E80 File Offset: 0x01115080
		private bool TryJumpAlongRail()
		{
			if (this.IsInRailMoveMode && this.CurrentRailMoveData != null && !this.CurrentRailMoveData.IsFinishMove)
			{
				MotorcycleAccelerateAlongRailMoveData motorcycleAccelerateAlongRailMoveData = this.CurrentRailMoveData as MotorcycleAccelerateAlongRailMoveData;
				if (motorcycleAccelerateAlongRailMoveData != null)
				{
					bool isMoveAlongSplineForward = motorcycleAccelerateAlongRailMoveData.GetIsMoveAlongSplineForward();
					MotorcycleRailComponent relatedRail = motorcycleAccelerateAlongRailMoveData.RelatedRail;
					if (relatedRail != null && relatedRail.GetRailMoveConfig() == null)
					{
						relatedRail.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
					}
					if (relatedRail != null && relatedRail.CheckIsRailCanJumpAlongAtDirection(new TRailMoveGetter(this.VehicleRailMoveGetter), this.CurrentRailMoveData, null))
					{
						this.SetClearAllRailMove();
						this.AddJumpAlongTargetRailMove(relatedRail, isMoveAlongSplineForward);
						return true;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0603C113 RID: 246035 RVA: 0x01116F18 File Offset: 0x01115118
		private unsafe void VehicleRailMoveUpdater(global::Vector loc = null, global::Rotator rot = null, global::Vector vel = null, bool bSweep = false)
		{
			if (this.ActorComp == null)
			{
				return;
			}
			SundryModel.Instance.GetModuleDebugLevel("MotorRailMove");
			if (loc != null || rot != null)
			{
				global::Transform vehicleRailMoveTransform = this.VehicleRailMoveTransform;
				global::Vector vector = (vehicleRailMoveTransform != null) ? vehicleRailMoveTransform.GetLocation() : null;
				if (this.VehicleRailMoveTransform == null)
				{
					this.VehicleRailMoveTransform = global::Transform.Create(this.ActorComp.ActorQuatProxy, this.ActorComp.ActorLocationProxy, global::Vector.OneVectorProxy);
				}
				if (loc != null && vector != null && global::Vector.DistSquared(vector, loc) > 250000.0)
				{
					if (SundryModel.Instance.GetModuleDebugLevel("MotorRailMove") > 0)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.MotorRailMove;
						ELogAuthor author = ELogAuthor.ZYL;
						string message = "[MotorcycleRailMoveComponent] VehicleRailMove too far!";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
						string item = "PbDataId";
						CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
						ptr = new ValueTuple<string, object>(item, (component != null) ? new int?(component.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OldLoc", vector);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NewLoc", loc);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Dist", global::Vector.Dist(vector, loc));
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					}
					else
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.MotorRailMove;
						ELogAuthor author2 = ELogAuthor.ZYL;
						string message2 = "[MotorcycleRailMoveComponent] VehicleRailMove too far!";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
						string item2 = "PbDataId";
						CreatureDataComponent component2 = base.Entity.GetComponent<CreatureDataComponent>();
						ptr2 = new ValueTuple<string, object>(item2, (component2 != null) ? new int?(component2.GetPbDataId()) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("OldLoc", vector);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("NewLoc", loc);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("Dist", global::Vector.Dist(vector, loc));
						instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
					}
				}
				if (loc != null)
				{
					this.VehicleRailMoveTransform.SetLocation(loc);
				}
				if (rot != null)
				{
					this.VehicleRailMoveTransform.SetRotation(rot.Quaternion(null));
				}
			}
			this.SweepWhenApplyVehicleRailMove = bSweep;
			if (vel != null)
			{
				if (this.VehicleRailMoveVelocity == null)
				{
					this.VehicleRailMoveVelocity = global::Vector.Create();
				}
				vel.GetClampedToSize(0.0, 3500.0, this.VehicleRailMoveVelocity);
				this.VehicleRailMoveVelocity.Equals(vel, 9.999999747378752E-05);
			}
		}

		// Token: 0x0603C114 RID: 246036 RVA: 0x011171B0 File Offset: 0x011153B0
		private bool VehicleRailMoveGetter(global::Vector outLoc = null, global::Rotator outRot = null, global::Vector outVel = null)
		{
			if (this.ActorComp == null)
			{
				return false;
			}
			if (outLoc != null)
			{
				global::Transform vehicleRailMoveTransform = this.VehicleRailMoveTransform;
				outLoc.DeepCopy(((vehicleRailMoveTransform != null) ? vehicleRailMoveTransform.GetLocation() : null) ?? this.ActorComp.ActorLocationProxy);
			}
			if (outRot != null)
			{
				global::Transform vehicleRailMoveTransform2 = this.VehicleRailMoveTransform;
				outRot.DeepCopy(((vehicleRailMoveTransform2 != null) ? vehicleRailMoveTransform2.GetRotation().Rotator(null) : null) ?? this.ActorComp.ActorRotationProxy);
			}
			if (outVel == null)
			{
				return true;
			}
			MotorcycleRailMoveDataBase currentRailMoveData = this.CurrentRailMoveData;
			if (currentRailMoveData != null && currentRailMoveData.GetVelocity(outVel))
			{
				return true;
			}
			TsBaseVehicle actor = this.ActorComp.Actor;
			UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (actor != null) ? actor.VehicleMovementComponent : null;
			if (ukuroVehicleMovementComponent != null && ukuroVehicleMovementComponent.IsValid())
			{
				FVector velocity = ukuroVehicleMovementComponent.Velocity;
				outVel.FromUeVector(velocity);
				return true;
			}
			AActor owner = this.ActorComp.Owner;
			FVectorDouble? fvectorDouble = (owner != null) ? new FVectorDouble?(owner.D_GetVelocity()) : null;
			if (fvectorDouble != null)
			{
				FVectorDouble value = fvectorDouble.Value;
				outVel.FromUeVector(value);
				return true;
			}
			return false;
		}

		// Token: 0x0603C115 RID: 246037 RVA: 0x011172B8 File Offset: 0x011154B8
		private void StartAutoEnterRailCd(float intervel)
		{
			this.StopDirectlyEnterRailCd();
			if (intervel < 20f || intervel > 180000f)
			{
				this.IsInDirectlyEnterRailCd = false;
				return;
			}
			this.DirectlyEnterRailCdHandle = TimerSystem.Instance.Delay(delegate(float delta)
			{
				this.IsInDirectlyEnterRailCd = false;
				this.StopDirectlyEnterRailCd();
			}, intervel, null, null, true, 1f);
			TimerHandle directlyEnterRailCdHandle = this.DirectlyEnterRailCdHandle;
			if (directlyEnterRailCdHandle != null && directlyEnterRailCdHandle.Valid())
			{
				this.IsInDirectlyEnterRailCd = true;
			}
		}

		// Token: 0x0603C116 RID: 246038 RVA: 0x01117323 File Offset: 0x01115523
		private void StopDirectlyEnterRailCd()
		{
			TimerHandle directlyEnterRailCdHandle = this.DirectlyEnterRailCdHandle;
			if (directlyEnterRailCdHandle != null && directlyEnterRailCdHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.DirectlyEnterRailCdHandle);
			}
			this.DirectlyEnterRailCdHandle = null;
		}

		// Token: 0x0603C117 RID: 246039 RVA: 0x01117354 File Offset: 0x01115554
		public bool IsInNotAllowedSkill()
		{
			VehicleSkillComponent component = base.Entity.GetComponent<VehicleSkillComponent>();
			if (((component != null) ? component.CurrentSkill : null) == null)
			{
				return false;
			}
			int skillId = component.CurrentSkill.SkillId;
			return !this.CurrentRailMoveConfig.BasicRailMoveConfig.AllowUseSkillIds.Contains(skillId) && this.CurrentRailMoveConfig.JumpAlongRailConfig.SkillId != skillId && this.CurrentRailMoveConfig.SwitchRailConfig.SkillId != skillId && this.CurrentRailMoveConfig.JumpOffRailConfig.SkillId != skillId && this.CurrentRailMoveConfig.JumpToRailConfig.SkillId != skillId;
		}

		// Token: 0x0603C118 RID: 246040 RVA: 0x011173F0 File Offset: 0x011155F0
		public void GmForceReloadRailMoveConfig()
		{
			this.UpdateDefaultRailMoveConfig();
			foreach (MotorcycleRailComponent motorcycleRailComponent in MotorcycleRailComponent.AllRailsThatPlayerInRange)
			{
				if (motorcycleRailComponent.GetRailSplineType().GetValueOrDefault() == ESplineType.MotorSlide && motorcycleRailComponent.GetRailMoveConfig() != null)
				{
					motorcycleRailComponent.InitRailMoveConfig(new Func<string, SMotorRailMoveConfig>(this.GetRailMoveConfigUeData));
				}
			}
		}

		// Token: 0x0603C119 RID: 246041 RVA: 0x01117470 File Offset: 0x01115670
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleRailMoveComponent motorcycleRailMoveComponent = (MotorcycleRailMoveComponent)componentTemplate;
			this.IsInRailMoveMode = motorcycleRailMoveComponent.IsInRailMoveMode;
			if (motorcycleRailMoveComponent.CurrentRailMoveData == null)
			{
				this.CurrentRailMoveData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentRailMoveData), "CurrentRailMoveData"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.PendingRailMoveDataQueue != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingRailMoveDataQueue), "PendingRailMoveDataQueue"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.PerformComp == null)
			{
				this.PerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformComp), "PerformComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.CueComp == null)
			{
				this.CueComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CueComp), "CueComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.BuffComp == null)
			{
				this.BuffComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComp), "BuffComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.DebugMoveComp == null)
			{
				this.DebugMoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugMoveComp), "DebugMoveComp"))
			{
				return false;
			}
			this.IsInDirectlyEnterRailCd = motorcycleRailMoveComponent.IsInDirectlyEnterRailCd;
			if (motorcycleRailMoveComponent.DirectlyEnterRailCdHandle == null)
			{
				this.DirectlyEnterRailCdHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DirectlyEnterRailCdHandle), "DirectlyEnterRailCdHandle"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.CurrentRailComp == null)
			{
				this.CurrentRailComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentRailComp), "CurrentRailComp"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.DefaultRailMoveConfig != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultRailMoveConfig), "DefaultRailMoveConfig"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.RailMoveConfigDataTable == null)
			{
				this.RailMoveConfigDataTable = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RailMoveConfigDataTable), "RailMoveConfigDataTable"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.RailMoveConfigUeDataCacheMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.RailMoveConfigUeDataCacheMap), "RailMoveConfigUeDataCacheMap"))
			{
				return false;
			}
			this.LoadConfigHandle = motorcycleRailMoveComponent.LoadConfigHandle;
			if (motorcycleRailMoveComponent.CurrentCueHandleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentCueHandleMap), "CurrentCueHandleMap"))
			{
				return false;
			}
			if (motorcycleRailMoveComponent.VehicleRailMoveTransform == null)
			{
				this.VehicleRailMoveTransform = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleRailMoveTransform), "VehicleRailMoveTransform"))
			{
				return false;
			}
			this.SweepWhenApplyVehicleRailMove = motorcycleRailMoveComponent.SweepWhenApplyVehicleRailMove;
			if (motorcycleRailMoveComponent.VehicleRailMoveVelocity == null)
			{
				this.VehicleRailMoveVelocity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleRailMoveVelocity), "VehicleRailMoveVelocity"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x17007153 RID: 29011
		// (get) Token: 0x0603C11A RID: 246042 RVA: 0x01117777 File Offset: 0x01115977
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007154 RID: 29012
		// (get) Token: 0x0603C11B RID: 246043 RVA: 0x0111777A File Offset: 0x0111597A
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007155 RID: 29013
		// (get) Token: 0x0603C11C RID: 246044 RVA: 0x0111777D File Offset: 0x0111597D
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007156 RID: 29014
		// (get) Token: 0x0603C11D RID: 246045 RVA: 0x01117780 File Offset: 0x01115980
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FC18 RID: 130072
		private const int LOG_THRESHOLD_MOVE_TOO_FAR_DIST_SQUARED = 250000;

		// Token: 0x0401FC19 RID: 130073
		private const float LOG_THRESHOLD_DELTA_TIME_TOO_BIG = 1f;

		// Token: 0x0401FC1A RID: 130074
		private const float MORTOR_MAX_SPEED = 3500f;

		// Token: 0x0401FC1B RID: 130075
		private const float WHEEL_ACCEL = 113.097336f;

		// Token: 0x0401FC1C RID: 130076
		private const float WHEEL_RADIUS = 37f;

		// Token: 0x0401FC1D RID: 130077
		private bool IsInRailMoveMode;

		// Token: 0x0401FC1E RID: 130078
		private MotorcycleRailMoveDataBase CurrentRailMoveData;

		// Token: 0x0401FC1F RID: 130079
		[Nullable(1)]
		private readonly Queue<MotorcycleRailMoveDataBase> PendingRailMoveDataQueue = new Queue<MotorcycleRailMoveDataBase>(4);

		// Token: 0x0401FC20 RID: 130080
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401FC21 RID: 130081
		private VehicleActorComponent ActorComp;

		// Token: 0x0401FC22 RID: 130082
		private VehiclePerformComponent PerformComp;

		// Token: 0x0401FC23 RID: 130083
		private VehicleTagComponent TagComp;

		// Token: 0x0401FC24 RID: 130084
		private BaseGameplayCueComponent CueComp;

		// Token: 0x0401FC25 RID: 130085
		private VehicleBuffComponent BuffComp;

		// Token: 0x0401FC26 RID: 130086
		private ActorDebugMovementComponent DebugMoveComp;

		// Token: 0x0401FC27 RID: 130087
		private bool IsInDirectlyEnterRailCd;

		// Token: 0x0401FC28 RID: 130088
		private TimerHandle DirectlyEnterRailCdHandle;

		// Token: 0x0401FC29 RID: 130089
		private MotorcycleRailComponent CurrentRailComp;

		// Token: 0x0401FC2A RID: 130090
		[Nullable(1)]
		private readonly MotorcycleRailMoveConfig DefaultRailMoveConfig = new MotorcycleRailMoveConfig();

		// Token: 0x0401FC2B RID: 130091
		private UDataTable RailMoveConfigDataTable;

		// Token: 0x0401FC2C RID: 130092
		[Nullable(1)]
		private readonly Dictionary<string, SMotorRailMoveConfig> RailMoveConfigUeDataCacheMap = new Dictionary<string, SMotorRailMoveConfig>();

		// Token: 0x0401FC2D RID: 130093
		private int LoadConfigHandle = -1;

		// Token: 0x0401FC2E RID: 130094
		[Nullable(1)]
		private readonly Dictionary<int, HashSet<int>> CurrentCueHandleMap = new Dictionary<int, HashSet<int>>();

		// Token: 0x0401FC2F RID: 130095
		private global::Transform VehicleRailMoveTransform;

		// Token: 0x0401FC30 RID: 130096
		private bool SweepWhenApplyVehicleRailMove;

		// Token: 0x0401FC31 RID: 130097
		private global::Vector VehicleRailMoveVelocity;
	}
}
