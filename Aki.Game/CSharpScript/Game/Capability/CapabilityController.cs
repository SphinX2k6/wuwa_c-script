using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200641A RID: 25626
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class CapabilityController : ControllerBase
	{
		// Token: 0x0603E350 RID: 254800 RVA: 0x01210EEF File Offset: 0x0120F0EF
		public CapabilityDebugger GetDebugger()
		{
			return CapabilityModel.Instance.Debugger;
		}

		// Token: 0x0603E351 RID: 254801 RVA: 0x01210EFB File Offset: 0x0120F0FB
		protected override bool OnClear()
		{
			this.UnregisterAllTickGroups();
			CapabilityModel instance = CapabilityModel.Instance;
			if (instance != null)
			{
				instance.GroupScheduleCache.Clear();
			}
			if (instance != null)
			{
				instance.BumpScheduleGeneration();
			}
			return true;
		}

		// Token: 0x0603E352 RID: 254802 RVA: 0x01210F25 File Offset: 0x0120F125
		public void RegisterGameObject(ICapabilityGameObject go)
		{
			CapabilityModel.Instance.GameObjects.Add(go);
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x0603E353 RID: 254803 RVA: 0x01210F42 File Offset: 0x0120F142
		public void UnregisterGameObject(ICapabilityGameObject go)
		{
			CapabilityModel.Instance.GameObjects.Remove(go);
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x0603E354 RID: 254804 RVA: 0x01210F60 File Offset: 0x0120F160
		public void OnCapabilityAdded(Capability cap)
		{
			this.GetDebugger().LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.Setup, null, null);
			this.EnsureTickGroupRegisteredFor(cap);
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x0603E355 RID: 254805 RVA: 0x01210FA0 File Offset: 0x0120F1A0
		public void OnCapabilityRemoved(Capability cap)
		{
			CapabilityDebugger debugger = this.GetDebugger();
			if (cap.IsActive())
			{
				debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.OnDeactivated, "removed", null);
				debugger.EndActiveSpan(Time.Instance.NowSeconds, cap);
			}
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x0603E356 RID: 254806 RVA: 0x01210FF8 File Offset: 0x0120F1F8
		public void OnCapabilityBlocked(Capability cap, int tag)
		{
			CapabilityDebugger debugger = this.GetDebugger();
			debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.Blocked, GameplayTagUtils.GetNameByTagId(tag), null);
			if (cap.IsActive())
			{
				debugger.EndActiveSpan(Time.Instance.NowSeconds, cap);
			}
		}

		// Token: 0x0603E357 RID: 254807 RVA: 0x01211048 File Offset: 0x0120F248
		public void OnCapabilityUnblocked(Capability cap, int tag)
		{
			this.GetDebugger().LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.Unblocked, GameplayTagUtils.GetNameByTagId(tag), null);
		}

		// Token: 0x0603E358 RID: 254808 RVA: 0x0121107B File Offset: 0x0120F27B
		protected override void OnTick(float deltaMilliseconds)
		{
		}

		// Token: 0x0603E359 RID: 254809 RVA: 0x01211080 File Offset: 0x0120F280
		public void TickHostDefaultGroup(ICapabilityGameObject host, float deltaMilliseconds)
		{
			if (!host.IsValid())
			{
				return;
			}
			List<IScheduledEntry> orBuildHostDefaultSchedule = this.GetOrBuildHostDefaultSchedule(host);
			if (orBuildHostDefaultSchedule.Count == 0)
			{
				return;
			}
			this.RunSchedule(orBuildHostDefaultSchedule, deltaMilliseconds);
		}

		// Token: 0x0603E35A RID: 254810 RVA: 0x012110B0 File Offset: 0x0120F2B0
		public void TickGroup(ETickingGroup group, float deltaMilliseconds)
		{
			List<IScheduledEntry> orBuildGroupSchedule = this.GetOrBuildGroupSchedule(group);
			if (orBuildGroupSchedule.Count == 0)
			{
				return;
			}
			this.RunSchedule(orBuildGroupSchedule, deltaMilliseconds);
		}

		// Token: 0x0603E35B RID: 254811 RVA: 0x012110D8 File Offset: 0x0120F2D8
		private List<IScheduledEntry> GetOrBuildGroupSchedule(ETickingGroup group)
		{
			CapabilityModel instance = CapabilityModel.Instance;
			if (instance.GroupScheduleCacheGeneration == instance.ScheduleGeneration)
			{
				List<IScheduledEntry> valueOrDefault = instance.GroupScheduleCache.GetValueOrDefault(group);
				if (valueOrDefault != null)
				{
					return valueOrDefault;
				}
			}
			else
			{
				instance.GroupScheduleCache.Clear();
				instance.GroupScheduleCacheGeneration = instance.ScheduleGeneration;
			}
			List<IScheduledEntry> list = new List<IScheduledEntry>();
			foreach (ICapabilityGameObject capabilityGameObject in instance.GameObjects)
			{
				if (capabilityGameObject.IsValid())
				{
					foreach (Capability cap in capabilityGameObject.GetCapabilities().Values)
					{
						ScheduledEntry scheduledEntry = this.MakeScheduledEntry(cap);
						ETickingGroup? effectiveGroup = scheduledEntry.EffectiveGroup;
						if (effectiveGroup.GetValueOrDefault() == group & effectiveGroup != null)
						{
							list.Add(scheduledEntry);
						}
					}
				}
			}
			list.Sort((IScheduledEntry a, IScheduledEntry b) => a.EffectiveOrder - b.EffectiveOrder);
			instance.GroupScheduleCache[group] = list;
			return list;
		}

		// Token: 0x0603E35C RID: 254812 RVA: 0x0121121C File Offset: 0x0120F41C
		private List<IScheduledEntry> GetOrBuildHostDefaultSchedule(ICapabilityGameObject host)
		{
			CapabilityModel instance = CapabilityModel.Instance;
			HostDefaultScheduleCacheEntry hostDefaultScheduleCacheEntry;
			if (instance.HostDefaultScheduleCache.TryGetValue(host, out hostDefaultScheduleCacheEntry) && hostDefaultScheduleCacheEntry.Generation == instance.ScheduleGeneration)
			{
				return hostDefaultScheduleCacheEntry.Schedule;
			}
			List<IScheduledEntry> list = new List<IScheduledEntry>();
			foreach (Capability cap in host.GetCapabilities().Values)
			{
				ScheduledEntry scheduledEntry = this.MakeScheduledEntry(cap);
				if (scheduledEntry.EffectiveGroup == null)
				{
					list.Add(scheduledEntry);
				}
			}
			list.Sort((IScheduledEntry a, IScheduledEntry b) => a.EffectiveOrder - b.EffectiveOrder);
			instance.HostDefaultScheduleCache.Set(host, new HostDefaultScheduleCacheEntry
			{
				Generation = instance.ScheduleGeneration,
				Schedule = list
			});
			return list;
		}

		// Token: 0x0603E35D RID: 254813 RVA: 0x01211308 File Offset: 0x0120F508
		private void RunSchedule(List<IScheduledEntry> schedule, float deltaMilliseconds)
		{
			foreach (IScheduledEntry scheduledEntry in schedule)
			{
				double now = Time.Instance.Now;
				try
				{
					scheduledEntry.Cap.PreTick(deltaMilliseconds);
				}
				catch (Exception err)
				{
					this.LogError("PreTick", scheduledEntry.Cap, err);
				}
				this.GetDebugger().LogEvent(Time.Instance.NowSeconds, scheduledEntry.Cap, CapabilityCommonDefine.ECapabilityDebugEvent.PreTick, null, new double?(Time.Instance.Now - now));
			}
			foreach (IScheduledEntry scheduledEntry2 in schedule)
			{
				Capability cap = scheduledEntry2.Cap;
				if (cap.IsActive())
				{
					this.TickActiveCapability(cap, deltaMilliseconds);
				}
				else
				{
					this.TryActivateCapability(cap, deltaMilliseconds);
				}
			}
		}

		// Token: 0x0603E35E RID: 254814 RVA: 0x01211410 File Offset: 0x0120F610
		private void EnsureTickGroupRegisteredFor(Capability cap)
		{
			ICapabilityConfig config = cap.GetConfig();
			if (config.TickGroup != null)
			{
				this.EnsureTickGroupRegistered(config.TickGroup.Value);
			}
			if (config.InactiveTickGroup != null)
			{
				this.EnsureTickGroupRegistered(config.InactiveTickGroup.Value);
			}
		}

		// Token: 0x0603E35F RID: 254815 RVA: 0x0121146C File Offset: 0x0120F66C
		private void EnsureTickGroupRegistered(ETickingGroup group)
		{
			CapabilityModel instance = CapabilityModel.Instance;
			if (instance.RegisteredTickGroups.ContainsKey(group))
			{
				return;
			}
			string text;
			if ((text = CapabilityCommonDefine.ueTickingGroupName.GetValueOrDefault(group)) == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Group");
				defaultInterpolatedStringHandler.AppendFormatted<ETickingGroup>(group);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string str = text;
			Action<float> handle = delegate(float deltaMilliseconds)
			{
				this.TickGroup(group, deltaMilliseconds);
			};
			Ticker ticker = TickSystem.Instance.Add(handle, "Capability_" + str, group, false, 0, false);
			if (ticker != null)
			{
				instance.RegisteredTickGroups[group] = ticker.Id;
			}
		}

		// Token: 0x0603E360 RID: 254816 RVA: 0x01211530 File Offset: 0x0120F730
		private void UnregisterAllTickGroups()
		{
			CapabilityModel instance = CapabilityModel.Instance;
			foreach (int id in instance.RegisteredTickGroups.Values)
			{
				TickSystem.Instance.Remove(id);
			}
			instance.RegisteredTickGroups.Clear();
		}

		// Token: 0x0603E361 RID: 254817 RVA: 0x012115A0 File Offset: 0x0120F7A0
		private ScheduledEntry MakeScheduledEntry(Capability cap)
		{
			ICapabilityConfig config = cap.GetConfig();
			bool flag = !cap.IsActive() && config.InactiveTickGroup != null && config.InactiveTickGroupOrder != null;
			return new ScheduledEntry
			{
				Cap = cap,
				EffectiveGroup = (flag ? config.InactiveTickGroup : config.TickGroup),
				EffectiveOrder = (flag ? config.InactiveTickGroupOrder.Value : config.TickGroupOrder)
			};
		}

		// Token: 0x0603E362 RID: 254818 RVA: 0x01211620 File Offset: 0x0120F820
		private void TryActivateCapability(Capability cap, float dt)
		{
			if (cap.IsBlocked())
			{
				return;
			}
			CapabilityDebugger debugger = this.GetDebugger();
			bool flag = false;
			try
			{
				flag = cap.ShouldActivate();
			}
			catch (Exception err)
			{
				this.LogError("ShouldActivate", cap, err);
			}
			debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.ShouldActivate, flag ? "true" : "false", null);
			if (!flag)
			{
				return;
			}
			List<int> interruptsTags = cap.GetConfig().InterruptsTags;
			if (interruptsTags.Count > 0)
			{
				this.InterruptByTags(cap, interruptsTags);
			}
			try
			{
				cap.OnActivated();
			}
			catch (Exception err2)
			{
				this.LogError("OnActivated", cap, err2);
			}
			cap.InternalSetActive();
			CapabilityModel.Instance.BumpScheduleGeneration();
			debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.OnActivated, null, null);
			debugger.BeginActiveSpan(Time.Instance.NowSeconds, cap);
			this.TickActiveCapability(cap, dt);
		}

		// Token: 0x0603E363 RID: 254819 RVA: 0x01211724 File Offset: 0x0120F924
		private void InterruptByTags(Capability activator, IReadOnlyList<int> interruptTags)
		{
			CapabilityDebugger debugger = this.GetDebugger();
			ICapabilityGameObject ownerGameObject = activator.OwnerGameObject;
			foreach (Capability capability in (((ownerGameObject != null) ? ownerGameObject.GetCapabilities().Values : null) ?? new List<Capability>()))
			{
				if (capability != activator && capability.IsActive())
				{
					List<int> tags = capability.GetConfig().Tags;
					bool flag = false;
					foreach (int item in interruptTags)
					{
						if (tags.Contains(item))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						debugger.LogEvent(Time.Instance.NowSeconds, capability, CapabilityCommonDefine.ECapabilityDebugEvent.Interrupted, activator.GetCapabilityId(), null);
						try
						{
							capability.OnDeactivated();
						}
						catch (Exception err)
						{
							this.LogError("OnDeactivated(Interrupt)", capability, err);
						}
						capability.InternalSetDeactivated();
						CapabilityModel.Instance.BumpScheduleGeneration();
						debugger.EndActiveSpan(Time.Instance.NowSeconds, capability);
					}
				}
			}
		}

		// Token: 0x0603E364 RID: 254820 RVA: 0x01211868 File Offset: 0x0120FA68
		private void TickActiveCapability(Capability cap, float dt)
		{
			CapabilityDebugger debugger = this.GetDebugger();
			bool flag = false;
			try
			{
				flag = cap.ShouldDeactivate();
			}
			catch (Exception err)
			{
				this.LogError("ShouldDeactivate", cap, err);
			}
			debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.ShouldDeactivate, flag ? "true" : "false", null);
			if (flag)
			{
				try
				{
					cap.OnDeactivated();
				}
				catch (Exception err2)
				{
					this.LogError("OnDeactivated", cap, err2);
				}
				cap.InternalSetDeactivated();
				CapabilityModel.Instance.BumpScheduleGeneration();
				debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.OnDeactivated, null, null);
				debugger.EndActiveSpan(Time.Instance.NowSeconds, cap);
				return;
			}
			double now = Time.Instance.Now;
			try
			{
				cap.TickActive(dt);
			}
			catch (Exception err3)
			{
				this.LogError("TickActive", cap, err3);
			}
			debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.TickActive, null, new double?(Time.Instance.Now - now));
		}

		// Token: 0x0603E365 RID: 254821 RVA: 0x01211990 File Offset: 0x0120FB90
		private unsafe void LogError(string stage, Capability cap, object err)
		{
			Exception ex = err as Exception;
			if (ex != null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Capability;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "Capability 生命周期回调异常";
				Exception error = ex;
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("stage", stage);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("capability", cap.GetCapabilityId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Capability;
			ELogAuthor author2 = ELogAuthor.XDW;
			string message2 = "Capability 生命周期回调异常";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("stage", stage);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("capability", cap.GetCapabilityId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("error", err.ToString());
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}

		// Token: 0x17007665 RID: 30309
		// (get) Token: 0x0603E366 RID: 254822 RVA: 0x01211A99 File Offset: 0x0120FC99
		public static CapabilityController Instance
		{
			get
			{
				return CapabilityController._Instance;
			}
		}

		// Token: 0x0603E367 RID: 254823 RVA: 0x01211AA0 File Offset: 0x0120FCA0
		public static CapabilityController GetOrCreateInstance()
		{
			if (CapabilityController._Instance == null)
			{
				CapabilityController.CreateInstance();
			}
			return CapabilityController._Instance;
		}

		// Token: 0x0603E368 RID: 254824 RVA: 0x01211AB4 File Offset: 0x0120FCB4
		public static bool CreateInstance()
		{
			if (CapabilityController._Instance != null)
			{
				return true;
			}
			CapabilityController._Instance = new CapabilityController();
			return true;
		}

		// Token: 0x0603E369 RID: 254825 RVA: 0x01211ACA File Offset: 0x0120FCCA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E36A RID: 254826 RVA: 0x01211ACC File Offset: 0x0120FCCC
		public static void ResetStaticDefaultValue()
		{
			CapabilityController._Instance = null;
		}

		// Token: 0x0603E36B RID: 254827 RVA: 0x01211AD4 File Offset: 0x0120FCD4
		static CapabilityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CapabilityController.CreateStaticDefaultValue), new Action(CapabilityController.ResetStaticDefaultValue));
		}

		// Token: 0x040211B4 RID: 135604
		private readonly Stat StatTickGroup = Stat.Create("Capability.TickGroup", "", "");

		// Token: 0x040211B5 RID: 135605
		private readonly Stat StatTickHostDefaultGroup = Stat.Create("Capability.TickHostDefaultGroup", "", "");

		// Token: 0x040211B6 RID: 135606
		private readonly Stat StatCollectSchedule = Stat.Create("Capability.CollectSchedule", "", "");

		// Token: 0x040211B7 RID: 135607
		private readonly Stat StatRunSchedule = Stat.Create("Capability.RunSchedule", "", "");

		// Token: 0x040211B8 RID: 135608
		private readonly Stat StatPreTick = Stat.Create("Capability.PreTick", "", "");

		// Token: 0x040211B9 RID: 135609
		private readonly Stat StatTickActive = Stat.Create("Capability.TickActive", "", "");

		// Token: 0x040211BA RID: 135610
		private readonly Stat StatTryActivate = Stat.Create("Capability.TryActivate", "", "");

		// Token: 0x040211BB RID: 135611
		private readonly Stat StatInterruptByTags = Stat.Create("Capability.InterruptByTags", "", "");

		// Token: 0x040211BC RID: 135612
		[Nullable(2)]
		private static CapabilityController _Instance;
	}
}
