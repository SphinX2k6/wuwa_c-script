using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Ai;
using Aki.Protocol.CombatMessage;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.Vehicle.Common;
using CSharpScript.Game.Utils;
using CSharpScript.Typing;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.CombatMessage
{
	// Token: 0x02004B88 RID: 19336
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class CombatMessageController : ControllerBase
	{
		// Token: 0x170060BE RID: 24766
		// (get) Token: 0x060304AB RID: 197803 RVA: 0x00D73E16 File Offset: 0x00D72016
		protected override bool IsTickEvenPausedInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170060BF RID: 24767
		// (get) Token: 0x060304AC RID: 197804 RVA: 0x00D73E19 File Offset: 0x00D72019
		public CombatMessageModel Model
		{
			get
			{
				return CombatMessageModel.Instance;
			}
		}

		// Token: 0x060304AD RID: 197805 RVA: 0x00D73E20 File Offset: 0x00D72020
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ResetLocationForZRangeNotify, new Action<IMessage, Net.CallbackStatus>(this.ResetLocationForZRangeNotify));
			Net.Instance.Register(ENotifyMessageId.MovePackageNotify, new Action<IMessage, Net.CallbackStatus>(this.MovePackageNotify));
			Net.Instance.Register(ENotifyMessageId.UDPMovePackageNotify, new Action<IMessage, Net.CallbackStatus>(this.UDPMovePackageNotify));
			Net.Instance.Register(ENotifyMessageId.MotorAnimReplaySampleUdpNotify, new Action<IMessage, Net.CallbackStatus>(this.UDPMotorAnimNotify));
			Net.Instance.Register(ENotifyMessageId.SceneItemMoveTargetNotify, new Action<IMessage, Net.CallbackStatus>(this.SceneItemMoveTargetNotify));
			Net.Instance.Register(ENotifyMessageId.AiControlSwitchNotify, new Action<IMessage, Net.CallbackStatus>(this.AiControlSwitchNotify));
			Net.Instance.Register(ENotifyMessageId.PreAiControlSwitchNotify, new Action<IMessage, Net.CallbackStatus>(this.PreAiControlSwitchNotify));
			Net.Instance.Register(ENotifyMessageId.CombatReceivePackNotify, new Action<IMessage, Net.CallbackStatus>(this.OnPackNotify));
			Net.Instance.Register(ENotifyMessageId.SplineMoveNotify, new Action<IMessage, Net.CallbackStatus>(this.SplineMoveNotify));
			EventSystem.Instance.Add<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.RegisterAiHateEntity));
			return true;
		}

		// Token: 0x060304AE RID: 197806 RVA: 0x00D73F48 File Offset: 0x00D72148
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ResetLocationForZRangeNotify);
			Net.Instance.UnRegister(ENotifyMessageId.MovePackageNotify);
			Net.Instance.UnRegister(ENotifyMessageId.UDPMovePackageNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SceneItemMoveTargetNotify);
			Net.Instance.UnRegister(ENotifyMessageId.AiControlSwitchNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PreAiControlSwitchNotify);
			Net.Instance.UnRegister(ENotifyMessageId.CombatReceivePackNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SplineMoveNotify);
			EventSystem.Instance.Remove<EAddEntityType, EntityHandle, AActor>(EEventName.AddEntity, new Action<EAddEntityType, EntityHandle, AActor>(this.RegisterAiHateEntity));
			EventSystem.Instance.RemoveAllTargetUseKey(this);
			return true;
		}

		// Token: 0x060304AF RID: 197807 RVA: 0x00D74000 File Offset: 0x00D72200
		[return: Nullable(2)]
		private Stat GetCombatStat(string name)
		{
			Stat stat;
			if (!this.CombatStatMap.TryGetValue(name, out stat))
			{
				stat = Stat.CreateNoFlameGraph(name, "", "STATGROUP_KuroBattle");
				this.CombatStatMap[name] = stat;
			}
			return stat;
		}

		// Token: 0x060304B0 RID: 197808 RVA: 0x00D7403C File Offset: 0x00D7223C
		[NullableContext(2)]
		private void OnPackNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (CombatReceiveData combatReceiveData in ((CombatReceivePackNotify)msg).Data)
			{
				if (combatReceiveData.CombatNotifyData != null)
				{
					CombatNotifyData combatNotifyData = combatReceiveData.CombatNotifyData;
					this.GetCombatStat(combatNotifyData.MessageCase.ToString());
					this.OnCombatNotify(combatNotifyData.CombatCommon, combatNotifyData);
				}
				else if (combatReceiveData.CombatResponseData != null)
				{
					CombatResponseData combatResponseData = combatReceiveData.CombatResponseData;
					this.GetCombatStat(combatResponseData.MessageCase.ToString());
					this.OnCombatResponse(combatResponseData.CombatCommon, combatResponseData);
				}
			}
		}

		// Token: 0x060304B1 RID: 197809 RVA: 0x00D74100 File Offset: 0x00D72300
		private unsafe void OnCombatNotify(CombatCommon combatCommon, CombatNotifyData notify)
		{
			CombatExactNotifyDataPack exactNotifyDataPack = notify.GetExactNotifyDataPack();
			string value = notify.MessageCase.ToString();
			ECombatNotifyDataMessage ecombatNotifyDataMessage;
			if (exactNotifyDataPack == null || !Enum.TryParse<ECombatNotifyDataMessage>(value, true, out ecombatNotifyDataMessage))
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Message;
				Entity entity = null;
				string message = "无法解析协议数据";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MessageCase :", notify.MessageCase);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CombatCommon :", combatCommon);
				instance.Error(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			CombatDebugController.Instance.CombatInfoMessage(CombatLog.EDebugModule.Notify, (EMessageId)ecombatNotifyDataMessage, combatCommon);
			long entityId = combatCommon.EntityId;
			EntityHandle entity2 = CreatureModel.Instance.GetEntity(entityId);
			Entity entity3 = (entity2 != null) ? entity2.Entity : null;
			if (entity3 == null)
			{
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag2 = CombatLog.EDebugModule.Notify;
				long entityId2 = entityId;
				string message2 = "服务器下发打包协议找不到实体";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("MessageCase :", notify.MessageCase);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CombatCommon :", combatCommon);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("msg", notify);
				instance2.Warn(flag2, entityId2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			IHandler handler;
			if (!CombatNet.Instance.NotifyMap.TryGetValue((ENotifyMessageId)ecombatNotifyDataMessage, out handler))
			{
				Log instance3 = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.ZQR;
				string message3 = "协议找不到对应的监听器";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("MessageCase :", notify.MessageCase);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("CombatCommon :", combatCommon);
				instance3.Error(module, author, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
			}
			long originator = combatCommon.Originator;
			CombatMessageBuffer messageBuffer = this.Model.GetMessageBuffer(originator);
			if (entity2 != null && !entity2.IsInit && handler != null)
			{
				bool flag3 = !(handler.IsCache ?? false);
				if (flag3)
				{
					CombatLog instance4 = CombatLog.Instance;
					CombatLog.EDebugModule flag4 = CombatLog.EDebugModule.Notify;
					long entityId3 = entityId;
					string message4 = "协议丢弃，实体未加载完成";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("MessageCase :", notify.MessageCase);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("CombatCommon :", combatCommon);
					instance4.Warn(flag4, entityId3, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
					return;
				}
				if (messageBuffer != null)
				{
					messageBuffer.AddToQueue((ENotifyMessageId)ecombatNotifyDataMessage, entity3, combatCommon, exactNotifyDataPack.Message);
					return;
				}
			}
			else if (handler != null)
			{
				EHandlerType type = handler.Type;
				if (type != EHandlerType.Static)
				{
					return;
				}
				StaticHandler staticHandler = handler as StaticHandler;
				if (staticHandler != null)
				{
					Func<Entity, IMessage, CombatCommon, bool> preprocessor = staticHandler.Preprocessor;
					if (preprocessor == null || preprocessor(entity3, exactNotifyDataPack.Message, combatCommon))
					{
						bool? isSync = handler.IsSync;
						if (isSync != null && isSync.GetValueOrDefault() && messageBuffer != null && GameModeModel.Instance.IsMulti)
						{
							messageBuffer.AddToQueue((ENotifyMessageId)ecombatNotifyDataMessage, entity3, combatCommon, exactNotifyDataPack.Message);
							return;
						}
						Action<Entity, IMessage, CombatCommon> listener = staticHandler.Listener;
						if (listener == null)
						{
							return;
						}
						listener(entity3, exactNotifyDataPack.Message, combatCommon);
					}
				}
			}
		}

		// Token: 0x060304B2 RID: 197810 RVA: 0x00D7441C File Offset: 0x00D7261C
		[Conditional("DEBUG")]
		[Conditional("DEBUG_EDITOR")]
		[Conditional("DEVELOPMENT")]
		[Conditional("DEVELOPMENT_EDITOR")]
		private void NotifyDataReport(ECombatNotifyDataMessage id, [Nullable(2)] EntityHandle handle, CombatNotifyData notify)
		{
		}

		// Token: 0x060304B3 RID: 197811 RVA: 0x00D74420 File Offset: 0x00D72620
		private unsafe void OnCombatResponse(CombatCommon combatCommon, CombatResponseData response)
		{
			Dictionary<int, Action<IMessage>> requestMap = CombatNet.Instance.RequestMap;
			int requestId = response.RequestId;
			Action<IMessage> action;
			if (!requestMap.TryGetValue(requestId, out action))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.ZQR;
				string message = "unexpected response RPC id from server";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("messageType", response.MessageCase);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			CombatExactResponseDataPack exactResponseDataPack = response.GetExactResponseDataPack();
			requestMap.Remove(requestId);
			if (exactResponseDataPack == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.MultiplayerCombat;
				ELogAuthor author2 = ELogAuthor.ZQR;
				string message2 = "unexpected null combat response";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("messageType", response.MessageCase);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			try
			{
				if (action != null)
				{
					action(exactResponseDataPack.Message);
				}
			}
			catch (Exception ex)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.CombatInfo;
				ELogAuthor author3 = ELogAuthor.WCL;
				string message3 = "战斗协议执行response异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("response", exactResponseDataPack.Message);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance3.ErrorWithStack(module3, author3, message3, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x060304B4 RID: 197812 RVA: 0x00D74550 File Offset: 0x00D72750
		public void Process(ENotifyMessageId id, Entity entity, IMessage message, CombatCommon combatCommon)
		{
			IHandler handler;
			if (CombatNet.Instance.NotifyMap.TryGetValue(id, out handler))
			{
				StaticHandler staticHandler = handler as StaticHandler;
				if (staticHandler != null)
				{
					Action<Entity, IMessage, CombatCommon> listener = staticHandler.Listener;
					if (listener == null)
					{
						return;
					}
					listener(entity, message, combatCommon);
					return;
				}
			}
			Action<Entity, object> action;
			if (this.NotifyHandles.TryGetValue((int)id, out action))
			{
				action(entity, message);
			}
		}

		// Token: 0x060304B5 RID: 197813 RVA: 0x00D745A8 File Offset: 0x00D727A8
		public void RegisterAiHateEntity(EAddEntityType addType, EntityHandle handle, [Nullable(2)] AActor actor)
		{
			if (handle.EntityType != 2 && handle.EntityType != 7)
			{
				return;
			}
			if (!this.AiHateEntities.Add(handle))
			{
				Log.Instance.Warn(ELogModule.CombatInfo, ELogAuthor.WCL, "[CombatMessageController.RegisterAiHateEntity] 当前已经注册过Monster", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.UnregisterMonster));
		}

		// Token: 0x060304B6 RID: 197814 RVA: 0x00D74614 File Offset: 0x00D72814
		public void UnregisterMonster(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (handle.EntityType != 2 && handle.EntityType != 7)
			{
				return;
			}
			if (!this.AiHateEntities.Remove(handle))
			{
				Log.Instance.Warn(ELogModule.CombatInfo, ELogAuthor.WCL, "[CombatMessageController.RegisterAiHateEntity] 当前Monster未被注册", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EventSystem.Instance.RemoveWithTargetUseKey<ERemoveEntityType, EntityHandle>(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.UnregisterMonster));
		}

		// Token: 0x060304B7 RID: 197815 RVA: 0x00D74680 File Offset: 0x00D72880
		public void RegisterPreTick(EntityComponent comp, Action<float> func)
		{
			if (!this.PreTickFunctions.TryAdd(comp, func))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "[CombatMessageController.RegisterPreTick] 当前Comp已经注册过PreTick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060304B8 RID: 197816 RVA: 0x00D746CC File Offset: 0x00D728CC
		public void UnregisterPreTick(EntityComponent comp)
		{
			if (!this.PreTickFunctions.Remove(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "[CombatMessageController.RegisterPreTick] 当前Comp未注册过PreTick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060304B9 RID: 197817 RVA: 0x00D74718 File Offset: 0x00D72918
		public void RegisterAfterTick(EntityComponent comp, Action<float> func)
		{
			if (!this.AfterTickFunctions.TryAdd(comp, func))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "[CombatMessageController.RegisterAfterTick] 当前Comp已经注册过AfterTick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060304BA RID: 197818 RVA: 0x00D74764 File Offset: 0x00D72964
		public void UnregisterAfterTick(EntityComponent comp)
		{
			if (!this.AfterTickFunctions.Remove(comp))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CombatInfo;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "[CombatMessageController.UnregisterAfterTick] 当前Comp未注册过AfterTick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Comp", comp.ToString());
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x060304BB RID: 197819 RVA: 0x00D747B0 File Offset: 0x00D729B0
		public unsafe void TickPriority1(float delta)
		{
			if (!Net.Instance.IsServerConnected() || !GameModeModel.Instance.MapDone)
			{
				return;
			}
			float delta2 = delta * 0.001f;
			foreach (CombatMessageBuffer combatMessageBuffer in this.Model.CombatMessageBufferMap.Values)
			{
				combatMessageBuffer.OnTick(delta2);
			}
			foreach (KeyValuePair<EntityComponent, Action<float>> keyValuePair in this.PreTickFunctions)
			{
				EntityComponent key = keyValuePair.Key;
				Action<float> value = keyValuePair.Value;
				try
				{
					Entity entity = key.Entity;
					if (entity != null && entity.Valid)
					{
						value(delta);
					}
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.CombatInfo;
					ELogAuthor author = ELogAuthor.WCL;
					string message = "处理方法执行异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("comp", key);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x060304BC RID: 197820 RVA: 0x00D74914 File Offset: 0x00D72B14
		protected unsafe override void OnAfterTick(float delta)
		{
			if (!Net.Instance.IsServerConnected() || !GameModeModel.Instance.MapDone)
			{
				return;
			}
			foreach (KeyValuePair<EntityComponent, Action<float>> keyValuePair in this.AfterTickFunctions)
			{
				EntityComponent key = keyValuePair.Key;
				Action<float> value = keyValuePair.Value;
				try
				{
					Entity entity = key.Entity;
					if (entity != null && entity.Valid)
					{
						if (!key.Entity.Active && !this.LastEntityActive.Contains(key.Entity))
						{
							this.LastEntityActive.Remove(key.Entity);
						}
						else
						{
							value(delta);
							if (key.Entity.Active)
							{
								this.LastEntityActive.Add(key.Entity);
							}
							else
							{
								this.LastEntityActive.Remove(key.Entity);
							}
						}
					}
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.CombatInfo;
					ELogAuthor author = ELogAuthor.WCL;
					string message = "处理方法执行异常";
					Exception error = ex;
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("comp", key.ToString());
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			if (Time.Instance.NowSeconds > this.LastPushAiInformationTime + 1.0 || this.Model.AnyHateChange)
			{
				bool flag = false;
				foreach (EntityHandle entityHandle in this.AiHateEntities)
				{
					if (entityHandle.IsInit)
					{
						if (!flag)
						{
							WorldEntity entity2 = entityHandle.Entity;
							CharacterUnifiedStateComponent characterUnifiedStateComponent = (entity2 != null) ? entity2.GetComponent<CharacterUnifiedStateComponent>() : null;
							flag = (characterUnifiedStateComponent != null && characterUnifiedStateComponent.IsInFightState());
						}
						AiHatePush aiHatePush = new AiHatePush();
						bool flag2 = GameModeModel.Instance.IsMulti || this.Model.AnyHateChange;
						if (flag2)
						{
							WorldEntity entity3 = entityHandle.Entity;
							CharacterAiComponent characterAiComponent = (entity3 != null) ? entity3.GetComponent<CharacterAiComponent>() : null;
							if (characterAiComponent != null)
							{
								foreach (KeyValuePair<int, HatredItem> keyValuePair2 in characterAiComponent.AiController.AiHateList.GetHatredMap())
								{
									AiHateEntity aiHateEntity = new AiHateEntity();
									aiHateEntity.EntityId = CreatureModel.Instance.GetCreatureDataId(keyValuePair2.Key);
									aiHateEntity.HatredValue = (int)keyValuePair2.Value.HatredValue;
									aiHatePush.HateList.Add(aiHateEntity);
								}
							}
						}
						if (aiHatePush.HateList.Count > 100)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.MultiplayerCombat;
							ELogAuthor author2 = ELogAuthor.ZQR;
							string message2 = "仇恨数据过大";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CreatureData", entityHandle.CreatureDataId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("HateList", aiHatePush.HateList.Count);
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
						}
						if (flag2)
						{
							CombatNet.Instance.Send(EPushMessageId.AiHatePush, entityHandle.Entity, aiHatePush, null, null, null);
						}
					}
				}
				this.LastPushAiInformationTime = Time.Instance.NowSeconds;
			}
			this.Model.AnyHateChange = false;
			if (GameModeModel.Instance.IsMulti && BlackboardController.Instance.PendingBlackboardParams.Count > 0)
			{
				foreach (EntityHandle entityHandle2 in this.AiHateEntities)
				{
					if (entityHandle2.IsInit)
					{
						AiBlackboardsPush aiBlackboardsPush = new AiBlackboardsPush();
						Dictionary<string, BlackboardParam> dictionary;
						if (BlackboardController.Instance.PendingBlackboardParams.TryGetValue(entityHandle2.CreatureDataId, out dictionary))
						{
							aiBlackboardsPush.AiBlackboards.AddRange(dictionary.Values);
							CombatNet.Instance.Send(EPushMessageId.AiBlackboardsPush, entityHandle2.Entity, aiBlackboardsPush, null, null, null);
						}
						if (aiBlackboardsPush.AiBlackboards.Count > 100)
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.MultiplayerCombat;
							ELogAuthor author3 = ELogAuthor.ZQR;
							string message3 = "黑板数据过大";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CreatureData", entityHandle2.CreatureDataId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("AiBlackboards", aiBlackboardsPush.AiBlackboards.Count);
							instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
						}
					}
				}
				BlackboardController.Instance.PendingBlackboardParams.Clear();
			}
			if ((!CombatMessageModel.Instance.MoveSyncUdpMode || !GameModeModel.Instance.IsMulti) && CombatMessageModel.Instance.NeedPushMove)
			{
				MovePackagePush movePackagePush = new MovePackagePush();
				movePackagePush.SceneOwnerId = (GameModeModel.Instance.IsMulti ? OnlineModel.Instance.OwnerId : CreatureModel.Instance.GetPlayerId());
				foreach (IMoveSync moveSync in CombatMessageModel.Instance.MoveSyncSet)
				{
					MovingEntityData movingEntityData = moveSync.CollectPendingMoveInfos();
					if (movingEntityData != null)
					{
						movePackagePush.MovingEntities.Add(movingEntityData);
					}
				}
				if (movePackagePush.MovingEntities.Count > 0)
				{
					Net.Instance.Send(EPushMessageId.MovePackagePush, movePackagePush);
				}
				CombatMessageModel.Instance.NeedPushMove = false;
			}
			this.FlushMessagePack();
			if (CombatMessageModel.Instance.SkillDirtySet.Count > 0)
			{
				foreach (long num in CombatMessageModel.Instance.SkillDirtySet)
				{
					int num2 = (int)num;
					CombatMessageModel instance4 = CombatMessageModel.Instance;
					if (instance4 != null)
					{
						instance4.TryClearSkillCount((long)num2);
					}
				}
				CombatMessageModel.Instance.SkillDirtySet.Clear();
			}
		}

		// Token: 0x060304BD RID: 197821 RVA: 0x00D75000 File Offset: 0x00D73200
		public void FlushMessagePack()
		{
			List<string> list = new List<string>();
			CombatSendPackRequest messagePack = this.Model.MessagePack;
			messagePack.HostPlayerId = CreatureModel.Instance.GetWorldOwner();
			if (messagePack.Data.Count > 0 && Time.Instance.SystemNowSeconds >= CombatMessageModel.Instance.CombatMessageSendLastTime + (double)CombatMessageModel.Instance.CombatMessageSendInterval)
			{
				foreach (CombatSendData combatSendData in messagePack.Data)
				{
					CombatRequestData request = combatSendData.Request;
					if (request != null)
					{
						string text = request.MessageCase.ToString();
						ECombatRequestDataMessage messageName;
						Enum.TryParse<ECombatRequestDataMessage>(text, true, out messageName);
						CombatDebugController.Instance.CombatContextInfoMessage(CombatLog.EDebugModule.Request, (EMessageId)messageName, request);
						list.Add(text);
					}
				}
				Net.Instance.Call(ERequestMessageId.CombatSendPackRequest, messagePack, delegate(IMessage msg, Net.CallbackStatus _)
				{
					CombatSendPackResponse combatSendPackResponse = (CombatSendPackResponse)msg;
					if (combatSendPackResponse.ReceivePackNotify != null)
					{
						this.OnPackNotify(combatSendPackResponse.ReceivePackNotify, _);
					}
				}, 0);
				this.Model.MessagePack = new CombatSendPackRequest();
				CombatMessageModel.Instance.CombatMessageSendLastTime = Time.Instance.SystemNowSeconds;
			}
		}

		// Token: 0x060304BE RID: 197822 RVA: 0x00D75120 File Offset: 0x00D73320
		[NullableContext(2)]
		private void ResetLocationForZRangeNotify(IMessage msg, Net.CallbackStatus status)
		{
			ResetLocationForZRangeNotify resetLocationForZRangeNotify = (ResetLocationForZRangeNotify)msg;
			long entityId = resetLocationForZRangeNotify.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity == null || !entity.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Level;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[ResetLocationForZRangeNotify] 找不到对应的Entity";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ResetLocationForZRangeInternal(entity, resetLocationForZRangeNotify);
		}

		// Token: 0x060304BF RID: 197823 RVA: 0x00D75190 File Offset: 0x00D73390
		private unsafe void ResetLocationForZRangeInternal(EntityHandle handle, ResetLocationForZRangeNotify data)
		{
			global::Vector vector = global::Vector.Create(data.ResetLocation);
			WorldEntity entity = handle.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			WorldEntity entity2 = handle.Entity;
			BaseActorComponent baseActorComponent = (entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null;
			if (handle.IsInit)
			{
				CharacterActorComponent characterActorComponent = baseActorComponent as CharacterActorComponent;
				if (characterActorComponent != null)
				{
					if (!characterActorComponent.FixBornLocation("ResetLocationForZRangeNotify", true, vector, false, true, true) && baseActorComponent != null)
					{
						baseActorComponent.SetActorLocation(vector.ToUeVector(false), "ResetLocationForZRangeNotify", false);
					}
				}
				else
				{
					VehicleActorComponent vehicleActorComponent = baseActorComponent as VehicleActorComponent;
					if (vehicleActorComponent != null)
					{
						vehicleActorComponent.FixBornLocation(vector, "ResetLocationForZRangeNotify");
					}
					else if (baseActorComponent != null)
					{
						baseActorComponent.SetActorLocation(vector.ToUeVector(false), "ResetLocationForZRangeNotify", false);
					}
				}
				if (data.NotifyRot)
				{
					FRotator frotator = WorldGlobal.ToUeRotator(data.Rotation);
					if (baseActorComponent != null)
					{
						baseActorComponent.SetActorRotation(frotator, "ResetLocationForZRangeNotify", true);
					}
					WorldEntity entity3 = handle.Entity;
					if (((entity3 != null) ? entity3.GetComponent<NpcMoveComponent>() : null) != null)
					{
						CharacterActorComponent characterActorComponent2 = baseActorComponent as CharacterActorComponent;
						if (characterActorComponent2 != null)
						{
							characterActorComponent2.SetInputRotator(frotator);
						}
					}
				}
				WorldEntity entity4 = handle.Entity;
				object obj = (entity4 != null) ? entity4.GetComponent<CharacterMoveComponent>() : null;
				WorldEntity entity5 = handle.Entity;
				VehicleMoveComponent vehicleMoveComponent = (entity5 != null) ? entity5.GetComponent<VehicleMoveComponent>() : null;
				object obj2 = obj;
				if (obj2 != null)
				{
					obj2.SetForceSpeed(global::Vector.ZeroVectorProxy);
				}
				if (vehicleMoveComponent != null)
				{
					vehicleMoveComponent.SetForceSpeed(global::Vector.ZeroVectorProxy);
				}
				WorldEntity entity6 = handle.Entity;
				BaseMovementSyncComponent baseMovementSyncComponent = (entity6 != null) ? entity6.GetComponent<BaseMovementSyncComponent>() : null;
				if (baseMovementSyncComponent != null)
				{
					baseMovementSyncComponent.ClearReplaySamples();
				}
				WorldEntity entity7 = handle.Entity;
				SceneItemManipulatableComponent sceneItemManipulatableComponent = (entity7 != null) ? entity7.GetComponent<SceneItemManipulatableComponent>() : null;
				if (sceneItemManipulatableComponent != null)
				{
					sceneItemManipulatableComponent.ResetManipulatableState();
				}
			}
			else
			{
				if (creatureDataComponent != null)
				{
					creatureDataComponent.SetLocation(vector.ToProtocolVector());
				}
				if (data.NotifyRot && creatureDataComponent != null)
				{
					creatureDataComponent.SetRotation(data.Rotation);
				}
			}
			if (data.ChangeInitPos)
			{
				if (creatureDataComponent != null)
				{
					creatureDataComponent.SetInitLocation(vector.ToProtocolVector());
				}
				WorldEntity entity8 = handle.Entity;
				CharacterActorComponent characterActorComponent3 = (entity8 != null) ? entity8.GetComponent<CharacterActorComponent>() : null;
				if (characterActorComponent3 != null)
				{
					characterActorComponent3.SetInitLocation(vector.ToProtocolVector());
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.WCL;
			string message = "ResetLocationForZRangeNotify 重置实体位置";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", handle.CreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", handle.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityId", handle.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ChangeInitPos", data.ChangeInitPos);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("IsInit", handle.IsInit);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Location", vector.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("FinalLocation", (baseActorComponent != null) ? baseActorComponent.ActorLocationProxy : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}

		// Token: 0x060304C0 RID: 197824 RVA: 0x00D75494 File Offset: 0x00D73694
		private void MoveInfoHandle(MovingEntityData data)
		{
			long entityId = data.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			long originator = data.Originator;
			bool isDebugMessageLog = this.IsDebugMessageLog;
			if (entity == null)
			{
				return;
			}
			if (data.MoveInfos == null || data.MoveInfos.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.WCL;
				string message = "[CombatMessageController.MoveInfosHandle], MoveInfos 是空的";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Originator", originator);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			float timeStamp = data.MoveInfos[0].TimeStamp;
			if (!entity.Entity.Active)
			{
				if (!entity.IsInit)
				{
					return;
				}
				BaseMovementSyncComponent component = entity.Entity.GetComponent<BaseMovementSyncComponent>();
				CharacterDriveVehicleComponent component2 = entity.Entity.GetComponent<CharacterDriveVehicleComponent>();
				if (component2 != null && component2.Seat >= 0)
				{
					if (component != null)
					{
						component.ClearReplaySamples();
					}
					return;
				}
				RepeatedField<MoveReplaySample> moveInfos = data.MoveInfos;
				MoveReplaySample moveReplaySample = moveInfos[moveInfos.Count - 1];
				this.CopyToUeVector(moveReplaySample.Location, ref this.LocationCatch);
				this.CopyToUeRotator(moveReplaySample.Rotation, ref this.RotationCatch);
				CharacterActorComponent component3 = entity.Entity.GetComponent<CharacterActorComponent>();
				if (component3 != null)
				{
					component3.SetActorLocationAndRotation(this.LocationCatch, this.RotationCatch, "MoveInfosHandle", false, null);
				}
				if (component != null)
				{
					component.ClearReplaySamples();
				}
				return;
			}
			else
			{
				CombatMessageBuffer messageBuffer = this.Model.GetMessageBuffer(originator);
				if (messageBuffer != null)
				{
					CreatureDataComponent component4 = entity.Entity.GetComponent<CreatureDataComponent>();
					this.Model.SetEntityMap(entity.Id, originator);
					messageBuffer.RecordMessageTime((double)timeStamp, component4.GetPbDataId(), true);
				}
				BaseMovementSyncComponent component5 = entity.Entity.GetComponent<BaseMovementSyncComponent>();
				if (component5 != null)
				{
					component5.ReceiveMoveInfos(data.MoveInfos, (int)originator, timeStamp);
					return;
				}
				CombatLog instance2 = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
				Entity entity2 = entity.Entity;
				string message2 = "entity不存在组件CharacterMovementSyncComponent";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("creatureDataId", entityId);
				instance2.Warn(flag, entity2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
		}

		// Token: 0x060304C1 RID: 197825 RVA: 0x00D7567C File Offset: 0x00D7387C
		private void MotorAnimInfoHandle(MotorAnimEntity data)
		{
			long entityId = data.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity == null)
			{
				return;
			}
			if (data.MotorAnimInfos == null || data.MotorAnimInfos.Count <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MultiplayerCombat;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "[CombatMessageController.MotorAnimInfoHandle], MotorAnimInfos 是空的";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("creatureDataId", entityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			WorldEntity entity2 = entity.Entity;
			MotorAnimationSyncComponent motorAnimationSyncComponent = (entity2 != null) ? entity2.GetComponent<MotorAnimationSyncComponent>() : null;
			if (motorAnimationSyncComponent != null)
			{
				motorAnimationSyncComponent.ReceiveMotorAnimSample(data.MotorAnimInfos);
			}
		}

		// Token: 0x060304C2 RID: 197826 RVA: 0x00D75708 File Offset: 0x00D73908
		[NullableContext(2)]
		private void MovePackageNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (MovingEntityData data in ((MovePackageNotify)msg).MovingEntities)
			{
				this.MoveInfoHandle(data);
			}
		}

		// Token: 0x060304C3 RID: 197827 RVA: 0x00D7575C File Offset: 0x00D7395C
		[NullableContext(2)]
		private void UDPMovePackageNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (MovingEntityData data in ((UDPMovePackageNotify)msg).MovingEntities)
			{
				this.MoveInfoHandle(data);
			}
		}

		// Token: 0x060304C4 RID: 197828 RVA: 0x00D757B0 File Offset: 0x00D739B0
		[NullableContext(2)]
		private void UDPMotorAnimNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (MotorAnimEntity data in ((MotorAnimReplaySampleUdpNotify)msg).MotorAnimEntities)
			{
				this.MotorAnimInfoHandle(data);
			}
		}

		// Token: 0x060304C5 RID: 197829 RVA: 0x00D75804 File Offset: 0x00D73A04
		[NullableContext(2)]
		private void SceneItemMoveTargetNotify(IMessage msg, Net.CallbackStatus status)
		{
			SceneItemMoveTargetNotify sceneItemMoveTargetNotify = (SceneItemMoveTargetNotify)msg;
			long entityId = sceneItemMoveTargetNotify.MoveInfo.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity == null)
			{
				return;
			}
			WorldEntity entity2 = entity.Entity;
			SceneItemMoveComponent sceneItemMoveComponent = (entity2 != null) ? entity2.GetComponent<SceneItemMoveComponent>() : null;
			if (sceneItemMoveComponent != null)
			{
				sceneItemMoveComponent.HandleMoveToTarget(sceneItemMoveTargetNotify);
			}
		}

		// Token: 0x060304C6 RID: 197830 RVA: 0x00D75854 File Offset: 0x00D73A54
		[CombatListen(ENotifyMessageId.EntityIsVisibleNotify, true, true)]
		public static void EntityIsVisibleNotify(Entity entity, EntityIsVisibleNotify data, [Nullable(2)] CombatCommon combatCommon = null)
		{
			if (entity.IsInit)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Actor;
				string message = "Entity通知设置显隐";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", data.IsVisible);
				instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				CreatureController.Instance.SetEntityEnable(entity, data.IsVisible, "CombatMessageController.EntityIsVisibleNotify", false);
				return;
			}
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component == null)
			{
				return;
			}
			component.SetVisible(data.IsVisible);
		}

		// Token: 0x060304C7 RID: 197831 RVA: 0x00D758C8 File Offset: 0x00D73AC8
		[CombatListen(ENotifyMessageId.ActorVisibleNotify, true, true)]
		public static void ActorIsVisibleNotify(Entity entity, ActorVisibleNotify data, [Nullable(2)] CombatCommon combatCommon = null)
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component != null)
			{
				component.ActorVisible = data.IsActorVisible;
			}
			if (!entity.IsInit)
			{
				return;
			}
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Actor;
			string message = "Actor通知设置显隐";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("v", data.IsActorVisible);
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CreatureController.Instance.SetActorVisible(entity, data.IsActorVisible, data.IsActorVisible, data.IsActorVisible, "ActorIsVisibleNotify", false);
		}

		// Token: 0x060304C8 RID: 197832 RVA: 0x00D75948 File Offset: 0x00D73B48
		private void OnSyncAiInformation(AiControlSwitch switchInfo)
		{
			long entityId = switchInfo.EntityId;
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			if (entity == null)
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Ai, entityId, "OnSyncAiInformation 不存在实体", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			WorldEntity entity2 = entity.Entity;
			CharacterAiComponent characterAiComponent = (entity2 != null) ? entity2.GetComponent<CharacterAiComponent>() : null;
			if (characterAiComponent == null)
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Ai, entityId, "OnSyncAiInformation 不存在CharacterAiComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			characterAiComponent.OnSyncAiInformation(switchInfo);
		}

		// Token: 0x060304C9 RID: 197833 RVA: 0x00D759C0 File Offset: 0x00D73BC0
		[NullableContext(2)]
		private void AiControlSwitchNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (AiControlSwitch switchInfo in ((AiControlSwitchNotify)msg).AiControlSwitchInfos)
			{
				this.OnSyncAiInformation(switchInfo);
			}
		}

		// Token: 0x060304CA RID: 197834 RVA: 0x00D75A14 File Offset: 0x00D73C14
		[NullableContext(2)]
		protected void PreAiControlSwitchNotify(IMessage msg, Net.CallbackStatus status)
		{
			foreach (long num in ((PreAiControlSwitchNotify)msg).EntityIds)
			{
				EntityHandle entity = CreatureModel.Instance.GetEntity(num);
				if (entity == null)
				{
					CombatLog instance = CombatLog.Instance;
					CombatLog.EDebugModule flag = CombatLog.EDebugModule.Ai;
					long entityId = num;
					string message = "PreAiControlSwitchNotify 不存在实体";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", num);
					instance.Warn(flag, entityId, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					WorldEntity entity2 = entity.Entity;
					CharacterAiComponent characterAiComponent = (entity2 != null) ? entity2.GetComponent<CharacterAiComponent>() : null;
					if (characterAiComponent != null)
					{
						characterAiComponent.AiController.PreSwitchControl();
					}
				}
			}
		}

		// Token: 0x060304CB RID: 197835 RVA: 0x00D75AC0 File Offset: 0x00D73CC0
		[CombatListen(ENotifyMessageId.EntityLoadCompleteNotify, false, false)]
		public static void EntityLoadCompleteNotify(Entity entity, EntityLoadCompleteNotify data, [Nullable(2)] CombatCommon combatCommon = null)
		{
			int playerId = data.PlayerId;
			foreach (long creatureDataId in data.EntityIds)
			{
				EntityHandle entity2 = CreatureModel.Instance.GetEntity(creatureDataId);
				if (entity2 != null)
				{
					WorldEntity entity3 = entity2.Entity;
					CharacterAiComponent characterAiComponent = (entity3 != null) ? entity3.GetComponent<CharacterAiComponent>() : null;
					if (characterAiComponent != null)
					{
						characterAiComponent.SetLoadCompletePlayer(playerId);
					}
				}
			}
		}

		// Token: 0x060304CC RID: 197836 RVA: 0x00D75B3C File Offset: 0x00D73D3C
		[CombatListen(ENotifyMessageId.PlayerRebackSceneNotify, false, false)]
		public static void PlayerRebackSceneNotify(Entity entity, PlayerRebackSceneNotify data, [Nullable(2)] CombatCommon combatCommon = null)
		{
			long curControlEntityId = data.CurControlEntityId;
			EntityHandle entity2 = CreatureModel.Instance.GetEntity(curControlEntityId);
			if (entity2 == null)
			{
				return;
			}
			entity2.Entity.GetComponent<CharacterMovementSyncComponent>().ClearReplaySamples();
		}

		// Token: 0x060304CD RID: 197837 RVA: 0x00D75B70 File Offset: 0x00D73D70
		[CombatListen(ENotifyMessageId.MaterialNotify, true, true)]
		public static void MaterialNotify(Entity entity, MaterialNotify data, [Nullable(2)] CombatCommon combatCommon = null)
		{
			if (string.IsNullOrEmpty(data.MaterialInfo.AssetName) || data.MaterialInfo.AssetName == "None")
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Material, entity, "材质同步失败，参数非法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseCharacterComponent baseChar = (entity != null) ? entity.GetComponent<BaseCharacterComponent>() : null;
			BaseCharacterComponent baseChar2 = baseChar;
			if (((baseChar2 != null) ? baseChar2.Actor : null) == null)
			{
				CombatLog.Instance.Warn(CombatLog.EDebugModule.Material, entity, "材质同步失败，Actor为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (data.MaterialInfo.IsGroup)
			{
				ResourceSystem.Instance.LoadAsync<PD_CharacterControllerDataGroup_C>(data.MaterialInfo.AssetName, delegate([Nullable(2)] PD_CharacterControllerDataGroup_C asset, string assetPath)
				{
					if (asset == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.YZ;
						string message = "无法找到材质效果";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data.MaterialInfo.AssetName", data.MaterialInfo.AssetName);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					baseChar.Actor.CharRenderingComponent.AddMaterialControllerDataGroup(asset);
				}, 100, "js_undefined");
				return;
			}
			ResourceSystem.Instance.LoadAsync<PD_CharacterControllerData_C>(data.MaterialInfo.AssetName, delegate([Nullable(2)] PD_CharacterControllerData_C asset, string assetPath)
			{
				if (asset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Battle;
					ELogAuthor author = ELogAuthor.YZ;
					string message = "无法找到材质效果组";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data.MaterialInfo.AssetName", data.MaterialInfo.AssetName);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				baseChar.Actor.CharRenderingComponent.AddMaterialControllerData(asset);
			}, 100, "js_undefined");
		}

		// Token: 0x060304CE RID: 197838 RVA: 0x00D75C8C File Offset: 0x00D73E8C
		[NullableContext(2)]
		private void SplineMoveNotify(IMessage msg, Net.CallbackStatus status)
		{
			SplineMoveNotify splineMoveNotify = (SplineMoveNotify)msg;
			EntityHandle entity = CreatureModel.Instance.GetEntity(splineMoveNotify.EntityId);
			if (entity == null || !entity.IsInit)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Notify;
				Entity entity2 = null;
				string message = "SplineMoveNotify实体不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", splineMoveNotify.EntityId);
				instance.Warn(flag, entity2, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			WorldEntity entity3 = entity.Entity;
			VehicleMovementSyncComponent vehicleMovementSyncComponent = (entity3 != null) ? entity3.GetComponent<VehicleMovementSyncComponent>() : null;
			if (vehicleMovementSyncComponent != null)
			{
				vehicleMovementSyncComponent.HandleSplineMoveNotify(splineMoveNotify.PathId, splineMoveNotify.PathRatio);
			}
		}

		// Token: 0x060304CF RID: 197839 RVA: 0x00D75D1A File Offset: 0x00D73F1A
		private void CopyToUeVector(Aki.Protocol.Vector inV, ref FVectorDouble outV)
		{
			outV.X = (double)inV.X;
			outV.Y = (double)inV.Y;
			outV.Z = (double)inV.Z;
		}

		// Token: 0x060304D0 RID: 197840 RVA: 0x00D75D43 File Offset: 0x00D73F43
		private void CopyToUeRotator(Aki.Protocol.Rotator inV, ref FRotator outV)
		{
			outV.Pitch = inV.Pitch;
			outV.Roll = inV.Roll;
			outV.Yaw = inV.Yaw;
		}

		// Token: 0x170060C0 RID: 24768
		// (get) Token: 0x060304D1 RID: 197841 RVA: 0x00D75D69 File Offset: 0x00D73F69
		public static CombatMessageController Instance
		{
			get
			{
				return CombatMessageController._Instance;
			}
		}

		// Token: 0x060304D2 RID: 197842 RVA: 0x00D75D70 File Offset: 0x00D73F70
		public static CombatMessageController GetOrCreateInstance()
		{
			if (CombatMessageController._Instance == null)
			{
				CombatMessageController.CreateInstance();
			}
			return CombatMessageController._Instance;
		}

		// Token: 0x060304D3 RID: 197843 RVA: 0x00D75D84 File Offset: 0x00D73F84
		public static bool CreateInstance()
		{
			if (CombatMessageController._Instance != null)
			{
				return true;
			}
			CombatMessageController._Instance = new CombatMessageController();
			return true;
		}

		// Token: 0x060304D4 RID: 197844 RVA: 0x00D75D9A File Offset: 0x00D73F9A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060304D5 RID: 197845 RVA: 0x00D75D9C File Offset: 0x00D73F9C
		public static void ResetStaticDefaultValue()
		{
			CombatMessageController._Instance = null;
		}

		// Token: 0x060304D6 RID: 197846 RVA: 0x00D75DA4 File Offset: 0x00D73FA4
		static CombatMessageController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CombatMessageController.CreateStaticDefaultValue), new Action(CombatMessageController.ResetStaticDefaultValue));
		}

		// Token: 0x04019966 RID: 104806
		public bool IsDebugMessageLog;

		// Token: 0x04019967 RID: 104807
		public bool IsDebugMoveMessage;

		// Token: 0x04019968 RID: 104808
		public float StartTime;

		// Token: 0x04019969 RID: 104809
		public int MoveData;

		// Token: 0x0401996A RID: 104810
		public int MoveDataCount;

		// Token: 0x0401996B RID: 104811
		public int StateData;

		// Token: 0x0401996C RID: 104812
		public int StateDataCount;

		// Token: 0x0401996D RID: 104813
		private readonly Dictionary<int, Action<Entity, object>> NotifyHandles = new Dictionary<int, Action<Entity, object>>();

		// Token: 0x0401996E RID: 104814
		private readonly Dictionary<EntityComponent, Action<float>> PreTickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x0401996F RID: 104815
		private readonly Dictionary<EntityComponent, Action<float>> AfterTickFunctions = new Dictionary<EntityComponent, Action<float>>();

		// Token: 0x04019970 RID: 104816
		private readonly HashSet<EntityHandle> AiHateEntities = new HashSet<EntityHandle>();

		// Token: 0x04019971 RID: 104817
		private readonly HashSet<Entity> LastEntityActive = new HashSet<Entity>();

		// Token: 0x04019972 RID: 104818
		private readonly Dictionary<string, Stat> CombatStatMap = new Dictionary<string, Stat>();

		// Token: 0x04019973 RID: 104819
		private FVectorDouble LocationCatch = new FVectorDouble();

		// Token: 0x04019974 RID: 104820
		private FRotator RotationCatch = new FRotator();

		// Token: 0x04019975 RID: 104821
		private double LastPushAiInformationTime;

		// Token: 0x04019976 RID: 104822
		private const float SendAiInformationInterval = 1f;

		// Token: 0x04019977 RID: 104823
		private const int MAX_AI_INFO_COUNT = 100;

		// Token: 0x04019978 RID: 104824
		private readonly int? IS_WITH_EDITOR = KuroApplication.IsWithEditor() ? new int?(1) : null;

		// Token: 0x04019979 RID: 104825
		private readonly Stat CombatReceivePackNotifyStat = Stat.Create("CombatPackNotify.CombatReceivePackNotifyStat", "", "STATGROUP_KuroBattle");

		// Token: 0x0401997A RID: 104826
		private readonly Stat CombatMessageBufferStat = Stat.Create("CombatMessageBuffer", "", "");

		// Token: 0x0401997B RID: 104827
		private readonly Stat CombatMessageHatredStat = Stat.Create("CombatMessageHatred", "", "");

		// Token: 0x0401997C RID: 104828
		[Nullable(2)]
		private static CombatMessageController _Instance;
	}
}
