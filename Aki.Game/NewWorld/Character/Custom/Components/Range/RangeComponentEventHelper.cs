using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using UnrealEngine;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F6E RID: 12142
	[NullableContext(1)]
	[Nullable(0)]
	public class RangeComponentEventHelper
	{
		// Token: 0x17002D7C RID: 11644
		// (get) Token: 0x0601CC09 RID: 117769 RVA: 0x008C672B File Offset: 0x008C492B
		[Nullable(2)]
		private Entity OwnerEntity
		{
			[NullableContext(2)]
			get
			{
				RangeComponent owner = this.Owner;
				if (owner == null)
				{
					return null;
				}
				return owner.Entity;
			}
		}

		// Token: 0x17002D7D RID: 11645
		// (get) Token: 0x0601CC0A RID: 117770 RVA: 0x008C673E File Offset: 0x008C493E
		[Nullable(2)]
		private CreatureDataComponent CreatureDataComp
		{
			[NullableContext(2)]
			get
			{
				Entity ownerEntity = this.OwnerEntity;
				if (ownerEntity == null)
				{
					return null;
				}
				return ownerEntity.GetComponent<CreatureDataComponent>();
			}
		}

		// Token: 0x17002D7E RID: 11646
		// (get) Token: 0x0601CC0B RID: 117771 RVA: 0x008C6751 File Offset: 0x008C4951
		private long CreatureDataId
		{
			get
			{
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				if (creatureDataComp == null)
				{
					return 0L;
				}
				return creatureDataComp.GetCreatureDataId();
			}
		}

		// Token: 0x17002D7F RID: 11647
		// (get) Token: 0x0601CC0C RID: 117772 RVA: 0x008C6765 File Offset: 0x008C4965
		private int ConfigId
		{
			get
			{
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				if (creatureDataComp == null)
				{
					return 0;
				}
				return creatureDataComp.GetPbDataId();
			}
		}

		// Token: 0x0601CC0D RID: 117773 RVA: 0x008C6778 File Offset: 0x008C4978
		public void Init(RangeComponent owner, bool isEnablePendingEmit)
		{
			this.Owner = owner;
			this.IsEnablePendingEmit = isEnablePendingEmit;
		}

		// Token: 0x0601CC0E RID: 117774 RVA: 0x008C6788 File Offset: 0x008C4988
		public void Clear()
		{
			if (this.PendingEmitTimerHandle != null && TimerSystem.Instance.Has(this.PendingEmitTimerHandle))
			{
				TimerSystem.Instance.Remove(this.PendingEmitTimerHandle);
			}
			this.PendingEmitTimerHandle = null;
			Queue<RangeComponentEventHelper.EmitEventParams> eventsPendingEmit = this.EventsPendingEmit;
			if (eventsPendingEmit != null)
			{
				eventsPendingEmit.Clear();
			}
			Queue<RangeComponentEventHelper.EmitEventParams> pendingEmitDrainBuffer = this.PendingEmitDrainBuffer;
			if (pendingEmitDrainBuffer != null)
			{
				pendingEmitDrainBuffer.Clear();
			}
			this.OnMyPlayerOverlapCallbackList.Clear();
			this.OnEntityOverlapCallbackList.Clear();
			this.OnActorOverlapCallbackList.Clear();
			this.EmitMyPlayerOverlapEventLock = false;
			this.EmitActorOverlapEventLock = false;
			this.EmitEntityOverlapEventLock = false;
			this.PendingEmitReentryStreak = 0;
			this.IsEnablePendingEmit = false;
			this.Owner = null;
		}

		// Token: 0x0601CC0F RID: 117775 RVA: 0x008C6834 File Offset: 0x008C4A34
		public void NotifyActorLocal(AActor actor, bool isEnter)
		{
			this.CallActorOverlapCallback(isEnter, actor);
			this.EmitActorOverlapEvent(isEnter, actor, false);
		}

		// Token: 0x0601CC10 RID: 117776 RVA: 0x008C6847 File Offset: 0x008C4A47
		public void NotifyEntityLocal(EntityHandle handle, bool isEnter)
		{
			this.CallEntityOverlapCallback(isEnter, handle);
			this.EmitEntityOverlapEvent(isEnter, handle, false);
		}

		// Token: 0x0601CC11 RID: 117777 RVA: 0x008C685C File Offset: 0x008C4A5C
		public void NotifyPlayerLocal(bool isEnter)
		{
			for (int i = this.OnMyPlayerOverlapCallbackList.Count - 1; i >= 0; i--)
			{
				Action<bool> action = this.OnMyPlayerOverlapCallbackList[i];
				try
				{
					if (action != null)
					{
						action(isEnter);
					}
				}
				catch
				{
					Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.ZYL, "[RangeComp] 范围组件回调异常，请检查之前的报错", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}
			this.EmitMyPlayerOverlapEvent(isEnter, false);
		}

		// Token: 0x0601CC12 RID: 117778 RVA: 0x008C68D4 File Offset: 0x008C4AD4
		public void EmitEntityInOutRangeOnlineEvent(EntityHandle handle, bool isEnter)
		{
			EventSystem.Instance.EmitWithTarget<bool, EntityHandle>(this.OwnerEntity, EEventName.OnEntityInOutRangeOnline, isEnter, handle);
		}

		// Token: 0x0601CC13 RID: 117779 RVA: 0x008C68EE File Offset: 0x008C4AEE
		public void EmitPlayerInOutRangeOnlineEvent(int playerId, bool isEnter)
		{
			EventSystem.Instance.EmitWithTarget<bool, int>(this.OwnerEntity, EEventName.OnPlayerInOutRangeOnline, isEnter, playerId);
		}

		// Token: 0x0601CC14 RID: 117780 RVA: 0x008C6908 File Offset: 0x008C4B08
		public void AddOnPlayerOverlapCallback(Action<bool> callback)
		{
			this.OnMyPlayerOverlapCallbackList.Add(callback);
		}

		// Token: 0x0601CC15 RID: 117781 RVA: 0x008C6916 File Offset: 0x008C4B16
		public void RemoveOnPlayerOverlapCallback(Action<bool> callback)
		{
			this.OnMyPlayerOverlapCallbackList.Remove(callback);
		}

		// Token: 0x0601CC16 RID: 117782 RVA: 0x008C6925 File Offset: 0x008C4B25
		public void AddOnEntityOverlapCallback(Action<bool, EntityHandle> callback)
		{
			this.OnEntityOverlapCallbackList.Add(callback);
		}

		// Token: 0x0601CC17 RID: 117783 RVA: 0x008C6933 File Offset: 0x008C4B33
		public void RemoveOnEntityOverlapCallback(Action<bool, EntityHandle> callback)
		{
			this.OnEntityOverlapCallbackList.Remove(callback);
		}

		// Token: 0x0601CC18 RID: 117784 RVA: 0x008C6942 File Offset: 0x008C4B42
		public void AddOnActorOverlapCallback(Action<bool, AActor> callback)
		{
			this.OnActorOverlapCallbackList.Add(callback);
		}

		// Token: 0x0601CC19 RID: 117785 RVA: 0x008C6950 File Offset: 0x008C4B50
		public void RemoveOnActorOverlapCallback(Action<bool, AActor> callback)
		{
			this.OnActorOverlapCallbackList.Remove(callback);
		}

		// Token: 0x0601CC1A RID: 117786 RVA: 0x008C6960 File Offset: 0x008C4B60
		private unsafe void CallEntityOverlapCallback(bool isEnter, EntityHandle handle)
		{
			for (int i = this.OnEntityOverlapCallbackList.Count - 1; i >= 0; i--)
			{
				Action<bool, EntityHandle> action = this.OnEntityOverlapCallbackList[i];
				try
				{
					if (action != null)
					{
						action(isEnter, handle);
					}
				}
				catch
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[RangeComp] 范围组件回调异常，请检查之前的报错";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsEnter", isEnter);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0601CC1B RID: 117787 RVA: 0x008C6A1C File Offset: 0x008C4C1C
		private unsafe void CallActorOverlapCallback(bool isEnter, AActor actor)
		{
			for (int i = this.OnActorOverlapCallbackList.Count - 1; i >= 0; i--)
			{
				Action<bool, AActor> action = this.OnActorOverlapCallbackList[i];
				try
				{
					if (action != null)
					{
						action(isEnter, actor);
					}
				}
				catch
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[RangeComp] 范围组件回调异常，请检查之前的报错";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsEnter", isEnter);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}

		// Token: 0x0601CC1C RID: 117788 RVA: 0x008C6AD8 File Offset: 0x008C4CD8
		private unsafe void EmitMyPlayerOverlapEvent(bool isEnter, bool neverPendingEmit = false)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("RangeComponent") >= 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[RangeComponent] EmitOverlapEvent: OnMyPlayerInOutRangeLocal";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigId", this.ConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EmitMyPlayerOverlapEventLock", this.EmitMyPlayerOverlapEventLock);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsEnablePendingEmit", this.IsEnablePendingEmit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("NeverPendingEmit", neverPendingEmit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("IsEnter", isEnter);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			bool flag = this.EventsPendingEmit == null || this.EventsPendingEmit.Empty;
			if (!this.EmitMyPlayerOverlapEventLock && (neverPendingEmit || (!this.IsEnablePendingEmit && flag)))
			{
				this.EmitMyPlayerOverlapEventLock = true;
				try
				{
					EventSystem.Instance.EmitWithTarget<bool>(this.OwnerEntity, EEventName.OnMyPlayerInOutRangeLocal, isEnter);
				}
				finally
				{
					this.EmitMyPlayerOverlapEventLock = false;
				}
				return;
			}
			if (this.EventsPendingEmit == null)
			{
				this.EventsPendingEmit = new Queue<RangeComponentEventHelper.EmitEventParams>(4);
			}
			this.EventsPendingEmit.Push(new RangeComponentEventHelper.EmitPlayerEventParams
			{
				IsEnter = isEnter
			});
			this.EnsurePendingEmitTimer();
		}

		// Token: 0x0601CC1D RID: 117789 RVA: 0x008C6C78 File Offset: 0x008C4E78
		private unsafe void EmitActorOverlapEvent(bool isEnter, AActor otherActor, bool neverPendingEmit = false)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("RangeComponent") >= 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[RangeComponent] EmitOverlapEvent: OnActorInOutRangeLocal";
				<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray8<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigId", this.ConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EmitActorOverlapEventLock", this.EmitActorOverlapEventLock);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsEnablePendingEmit", this.IsEnablePendingEmit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("NeverPendingEmit", neverPendingEmit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("IsEnter", isEnter);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("OtherActorPathName", UKismetSystemLibrary.GetPathName(otherActor));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("OtherActorDisplayName", UKismetSystemLibrary.GetDisplayName(otherActor));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 8));
			}
			bool flag = this.EventsPendingEmit == null || this.EventsPendingEmit.Empty;
			if (!this.EmitActorOverlapEventLock && (neverPendingEmit || (!this.IsEnablePendingEmit && flag)))
			{
				this.EmitActorOverlapEventLock = true;
				try
				{
					EventSystem.Instance.EmitWithTarget<bool, AActor>(this.OwnerEntity, EEventName.OnActorInOutRangeLocal, isEnter, otherActor);
				}
				finally
				{
					this.EmitActorOverlapEventLock = false;
				}
				return;
			}
			if (this.EventsPendingEmit == null)
			{
				this.EventsPendingEmit = new Queue<RangeComponentEventHelper.EmitEventParams>(4);
			}
			this.EventsPendingEmit.Push(new RangeComponentEventHelper.EmitActorEventParams
			{
				IsEnter = isEnter,
				OtherActor = otherActor
			});
			this.EnsurePendingEmitTimer();
		}

		// Token: 0x0601CC1E RID: 117790 RVA: 0x008C6E5C File Offset: 0x008C505C
		private unsafe void EmitEntityOverlapEvent(bool isEnter, EntityHandle otherEntityHandle, bool neverPendingEmit = false)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("RangeComponent") >= 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[RangeComponent] EmitOverlapEvent: OnEntityInOutRangeLocal";
				<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ConfigId", this.ConfigId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EmitEntityOverlapEventLock", this.EmitEntityOverlapEventLock);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsEnablePendingEmit", this.IsEnablePendingEmit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("NeverPendingEmit", neverPendingEmit);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("IsEnter", isEnter);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("OtherEntityId", otherEntityHandle.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("OtherEntityConfigId", otherEntityHandle.PbDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("OtherEntityServerId", otherEntityHandle.CreatureDataId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
			}
			bool flag = this.EventsPendingEmit == null || this.EventsPendingEmit.Empty;
			if (!this.EmitEntityOverlapEventLock && (neverPendingEmit || (!this.IsEnablePendingEmit && flag)))
			{
				this.EmitEntityOverlapEventLock = true;
				try
				{
					EventSystem.Instance.EmitWithTarget<bool, EntityHandle>(this.OwnerEntity, EEventName.OnEntityInOutRangeLocal, isEnter, otherEntityHandle);
				}
				finally
				{
					this.EmitEntityOverlapEventLock = false;
				}
				return;
			}
			if (this.EventsPendingEmit == null)
			{
				this.EventsPendingEmit = new Queue<RangeComponentEventHelper.EmitEventParams>(4);
			}
			this.EventsPendingEmit.Push(new RangeComponentEventHelper.EmitEntityEventParams
			{
				IsEnter = isEnter,
				OtherEntityHandle = otherEntityHandle
			});
			this.EnsurePendingEmitTimer();
		}

		// Token: 0x0601CC1F RID: 117791 RVA: 0x008C706C File Offset: 0x008C526C
		private void EnsurePendingEmitTimer()
		{
			if (this.PendingEmitTimerHandle == null || !TimerSystem.Instance.Has(this.PendingEmitTimerHandle))
			{
				this.PendingEmitTimerHandle = TimerSystem.Instance.Next(delegate(float _)
				{
					this.EmitPendingEvents();
				}, null, null);
			}
		}

		// Token: 0x0601CC20 RID: 117792 RVA: 0x008C70A8 File Offset: 0x008C52A8
		private unsafe void EmitPendingEvents()
		{
			if (this.PendingEmitTimerHandle != null && TimerSystem.Instance.Has(this.PendingEmitTimerHandle))
			{
				TimerSystem.Instance.Remove(this.PendingEmitTimerHandle);
			}
			this.PendingEmitTimerHandle = null;
			Queue<RangeComponentEventHelper.EmitEventParams> pendingEmitDrainBuffer = this.PendingEmitDrainBuffer;
			if (pendingEmitDrainBuffer != null)
			{
				pendingEmitDrainBuffer.Clear();
			}
			Queue<RangeComponentEventHelper.EmitEventParams> eventsPendingEmit = this.EventsPendingEmit;
			Queue<RangeComponentEventHelper.EmitEventParams> pendingEmitDrainBuffer2 = this.PendingEmitDrainBuffer;
			this.PendingEmitDrainBuffer = eventsPendingEmit;
			this.EventsPendingEmit = pendingEmitDrainBuffer2;
			while (this.PendingEmitDrainBuffer != null && !this.PendingEmitDrainBuffer.Empty)
			{
				RangeComponentEventHelper.EmitEventParams emitEventParams = this.PendingEmitDrainBuffer.Pop();
				RangeComponentEventHelper.EmitActorEventParams emitActorEventParams = emitEventParams as RangeComponentEventHelper.EmitActorEventParams;
				if (emitActorEventParams == null)
				{
					RangeComponentEventHelper.EmitEntityEventParams emitEntityEventParams = emitEventParams as RangeComponentEventHelper.EmitEntityEventParams;
					if (emitEntityEventParams == null)
					{
						RangeComponentEventHelper.EmitPlayerEventParams emitPlayerEventParams = emitEventParams as RangeComponentEventHelper.EmitPlayerEventParams;
						if (emitPlayerEventParams != null)
						{
							this.EmitMyPlayerOverlapEvent(emitPlayerEventParams.IsEnter, true);
						}
					}
					else
					{
						this.EmitEntityOverlapEvent(emitEntityEventParams.IsEnter, emitEntityEventParams.OtherEntityHandle, true);
					}
				}
				else
				{
					this.EmitActorOverlapEvent(emitActorEventParams.IsEnter, emitActorEventParams.OtherActor, true);
				}
			}
			if (this.EventsPendingEmit != null && !this.EventsPendingEmit.Empty)
			{
				this.PendingEmitReentryStreak++;
				if (this.PendingEmitReentryStreak % 10 == 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[RangeComponent] 检测到进出范围反复自触发(单帧死循环已被双缓冲拦截)，请策划检查配置(比如触发器，进出范围都触发移动，且正好骑在触发器边界)";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ConfigId", this.ConfigId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureDataId", this.CreatureDataId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("连续自喂帧数", this.PendingEmitReentryStreak);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("残留事件数", this.EventsPendingEmit.Size);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4);
					string item = "残留事件类型";
					RangeComponentEventHelper.EmitEventParams front = this.EventsPendingEmit.Front;
					ptr = new ValueTuple<string, object>(item, (front != null) ? front.GetType().Name : null);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
					return;
				}
			}
			else
			{
				this.PendingEmitReentryStreak = 0;
			}
		}

		// Token: 0x0400F24F RID: 62031
		private const string DEBUG_DETAIL_KEY = "RangeComponent";

		// Token: 0x0400F250 RID: 62032
		private const int PENDING_EMIT_REENTRY_ERROR_THRESHOLD = 10;

		// Token: 0x0400F251 RID: 62033
		private readonly List<Action<bool>> OnMyPlayerOverlapCallbackList = new List<Action<bool>>();

		// Token: 0x0400F252 RID: 62034
		private readonly List<Action<bool, EntityHandle>> OnEntityOverlapCallbackList = new List<Action<bool, EntityHandle>>();

		// Token: 0x0400F253 RID: 62035
		private readonly List<Action<bool, AActor>> OnActorOverlapCallbackList = new List<Action<bool, AActor>>();

		// Token: 0x0400F254 RID: 62036
		[Nullable(2)]
		private RangeComponent Owner;

		// Token: 0x0400F255 RID: 62037
		private bool IsEnablePendingEmit;

		// Token: 0x0400F256 RID: 62038
		private bool EmitMyPlayerOverlapEventLock;

		// Token: 0x0400F257 RID: 62039
		private bool EmitActorOverlapEventLock;

		// Token: 0x0400F258 RID: 62040
		private bool EmitEntityOverlapEventLock;

		// Token: 0x0400F259 RID: 62041
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<RangeComponentEventHelper.EmitEventParams> EventsPendingEmit;

		// Token: 0x0400F25A RID: 62042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Queue<RangeComponentEventHelper.EmitEventParams> PendingEmitDrainBuffer;

		// Token: 0x0400F25B RID: 62043
		[Nullable(2)]
		private TimerHandle PendingEmitTimerHandle;

		// Token: 0x0400F25C RID: 62044
		private int PendingEmitReentryStreak;

		// Token: 0x02008C09 RID: 35849
		[NullableContext(0)]
		[RequiredMember]
		private abstract class EmitEventParams
		{
			// Token: 0x06042C3D RID: 273469 RVA: 0x013DC78A File Offset: 0x013DA98A
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			protected EmitEventParams()
			{
			}

			// Token: 0x0402C5B5 RID: 181685
			[RequiredMember]
			public bool IsEnter;
		}

		// Token: 0x02008C0A RID: 35850
		[NullableContext(0)]
		[RequiredMember]
		private sealed class EmitActorEventParams : RangeComponentEventHelper.EmitEventParams
		{
			// Token: 0x06042C3E RID: 273470 RVA: 0x013DC792 File Offset: 0x013DA992
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EmitActorEventParams()
			{
			}

			// Token: 0x0402C5B6 RID: 181686
			[Nullable(1)]
			[RequiredMember]
			public AActor OtherActor;
		}

		// Token: 0x02008C0B RID: 35851
		[NullableContext(0)]
		[RequiredMember]
		private sealed class EmitEntityEventParams : RangeComponentEventHelper.EmitEventParams
		{
			// Token: 0x06042C3F RID: 273471 RVA: 0x013DC79A File Offset: 0x013DA99A
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EmitEntityEventParams()
			{
			}

			// Token: 0x0402C5B7 RID: 181687
			[Nullable(1)]
			[RequiredMember]
			public EntityHandle OtherEntityHandle;
		}

		// Token: 0x02008C0C RID: 35852
		[NullableContext(0)]
		private sealed class EmitPlayerEventParams : RangeComponentEventHelper.EmitEventParams
		{
			// Token: 0x06042C40 RID: 273472 RVA: 0x013DC7A2 File Offset: 0x013DA9A2
			[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
			[CompilerFeatureRequired("RequiredMembers")]
			public EmitPlayerEventParams()
			{
			}
		}
	}
}
