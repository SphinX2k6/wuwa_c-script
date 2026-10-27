using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Capability.Editor;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200729B RID: 29339
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class CapabilityController : ControllerBase
	{
		// Token: 0x06047F8A RID: 294794 RVA: 0x0126FEA3 File Offset: 0x0126E0A3
		public CapabilityDebugger GetDebugger()
		{
			return CapabilityModel.Instance.Debugger;
		}

		// Token: 0x06047F8B RID: 294795 RVA: 0x0126FEAF File Offset: 0x0126E0AF
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

		// Token: 0x06047F8C RID: 294796 RVA: 0x0126FED9 File Offset: 0x0126E0D9
		public void RegisterGameObject(ICapabilityGameObject go)
		{
			CapabilityModel.Instance.GameObjects.Add(go);
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x06047F8D RID: 294797 RVA: 0x0126FEF6 File Offset: 0x0126E0F6
		public void UnregisterGameObject(ICapabilityGameObject go)
		{
			CapabilityModel.Instance.GameObjects.Remove(go);
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x06047F8E RID: 294798 RVA: 0x0126FF14 File Offset: 0x0126E114
		public void OnCapabilityAdded(Capability cap)
		{
			this.GetDebugger().LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.Setup, null, null);
			this.EnsureTickGroupRegisteredFor(cap);
			CapabilityModel.Instance.BumpScheduleGeneration();
		}

		// Token: 0x06047F8F RID: 294799 RVA: 0x0126FF54 File Offset: 0x0126E154
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

		// Token: 0x06047F90 RID: 294800 RVA: 0x0126FFAC File Offset: 0x0126E1AC
		public void OnCapabilityBlocked(Capability cap, int tag)
		{
			CapabilityDebugger debugger = this.GetDebugger();
			debugger.LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.Blocked, GameplayTagUtils.GetNameByTagId(tag), null);
			if (cap.IsActive())
			{
				debugger.EndActiveSpan(Time.Instance.NowSeconds, cap);
			}
		}

		// Token: 0x06047F91 RID: 294801 RVA: 0x0126FFFC File Offset: 0x0126E1FC
		public void OnCapabilityUnblocked(Capability cap, int tag)
		{
			this.GetDebugger().LogEvent(Time.Instance.NowSeconds, cap, CapabilityCommonDefine.ECapabilityDebugEvent.Unblocked, GameplayTagUtils.GetNameByTagId(tag), null);
		}

		// Token: 0x06047F92 RID: 294802 RVA: 0x01270030 File Offset: 0x0126E230
		protected override void OnTick(float deltaMilliseconds)
		{
			if (!Info.Instance.IsBuildShipping)
			{
				if (SundryModel.Instance.GetModuleDebugLevel("Capability") > 0)
				{
					CapabilityTimelineDebugger timelineDebugger = CapabilityModel.Instance.TimelineDebugger;
					if (timelineDebugger == null)
					{
						return;
					}
					timelineDebugger.Show();
					return;
				}
				else
				{
					CapabilityTimelineDebugger timelineDebugger2 = CapabilityModel.Instance.TimelineDebugger;
					if (timelineDebugger2 == null)
					{
						return;
					}
					timelineDebugger2.Hide();
				}
			}
		}

		// Token: 0x06047F93 RID: 294803 RVA: 0x01270084 File Offset: 0x0126E284
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

		// Token: 0x06047F94 RID: 294804 RVA: 0x012700B4 File Offset: 0x0126E2B4
		public void TickGroup(ETickingGroup group, float deltaMilliseconds)
		{
			List<IScheduledEntry> orBuildGroupSchedule = this.GetOrBuildGroupSchedule(group);
			if (orBuildGroupSchedule.Count == 0)
			{
				return;
			}
			this.RunSchedule(orBuildGroupSchedule, deltaMilliseconds);
		}

		// Token: 0x06047F95 RID: 294805 RVA: 0x012700DC File Offset: 0x0126E2DC
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

		// Token: 0x06047F96 RID: 294806 RVA: 0x01270220 File Offset: 0x0126E420
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

		// Token: 0x06047F97 RID: 294807 RVA: 0x0127030C File Offset: 0x0126E50C
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

		// Token: 0x06047F98 RID: 294808 RVA: 0x01270414 File Offset: 0x0126E614
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

		// Token: 0x06047F99 RID: 294809 RVA: 0x01270470 File Offset: 0x0126E670
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

		// Token: 0x06047F9A RID: 294810 RVA: 0x01270534 File Offset: 0x0126E734
		private void UnregisterAllTickGroups()
		{
			CapabilityModel instance = CapabilityModel.Instance;
			foreach (int id in instance.RegisteredTickGroups.Values)
			{
				TickSystem.Instance.Remove(id);
			}
			instance.RegisteredTickGroups.Clear();
		}

		// Token: 0x06047F9B RID: 294811 RVA: 0x012705A4 File Offset: 0x0126E7A4
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

		// Token: 0x06047F9C RID: 294812 RVA: 0x01270624 File Offset: 0x0126E824
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

		// Token: 0x06047F9D RID: 294813 RVA: 0x01270728 File Offset: 0x0126E928
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

		// Token: 0x06047F9E RID: 294814 RVA: 0x0127086C File Offset: 0x0126EA6C
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

		// Token: 0x06047F9F RID: 294815 RVA: 0x01270994 File Offset: 0x0126EB94
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

		// Token: 0x17009F03 RID: 40707
		// (get) Token: 0x06047FA0 RID: 294816 RVA: 0x01270A9D File Offset: 0x0126EC9D
		public static CapabilityController Instance
		{
			get
			{
				return CapabilityController._Instance;
			}
		}

		// Token: 0x06047FA1 RID: 294817 RVA: 0x01270AA4 File Offset: 0x0126ECA4
		public static CapabilityController GetOrCreateInstance()
		{
			if (CapabilityController._Instance == null)
			{
				CapabilityController.CreateInstance();
			}
			return CapabilityController._Instance;
		}

		// Token: 0x06047FA2 RID: 294818 RVA: 0x01270AB8 File Offset: 0x0126ECB8
		public static bool CreateInstance()
		{
			if (CapabilityController._Instance != null)
			{
				return true;
			}
			CapabilityController._Instance = new CapabilityController();
			return true;
		}

		// Token: 0x06047FA3 RID: 294819 RVA: 0x01270ACE File Offset: 0x0126ECCE
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047FA4 RID: 294820 RVA: 0x01270AD0 File Offset: 0x0126ECD0
		public static void ResetStaticDefaultValue()
		{
			CapabilityController._Instance = null;
		}

		// Token: 0x06047FA5 RID: 294821 RVA: 0x01270AD8 File Offset: 0x0126ECD8
		static CapabilityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CapabilityController.CreateStaticDefaultValue), new Action(CapabilityController.ResetStaticDefaultValue));
		}

		// Token: 0x04025EE1 RID: 155361
		private readonly Stat StatTickGroup = Stat.Create("Capability.TickGroup", "", "");

		// Token: 0x04025EE2 RID: 155362
		private readonly Stat StatTickHostDefaultGroup = Stat.Create("Capability.TickHostDefaultGroup", "", "");

		// Token: 0x04025EE3 RID: 155363
		private readonly Stat StatCollectSchedule = Stat.Create("Capability.CollectSchedule", "", "");

		// Token: 0x04025EE4 RID: 155364
		private readonly Stat StatRunSchedule = Stat.Create("Capability.RunSchedule", "", "");

		// Token: 0x04025EE5 RID: 155365
		private readonly Stat StatPreTick = Stat.Create("Capability.PreTick", "", "");

		// Token: 0x04025EE6 RID: 155366
		private readonly Stat StatTickActive = Stat.Create("Capability.TickActive", "", "");

		// Token: 0x04025EE7 RID: 155367
		private readonly Stat StatTryActivate = Stat.Create("Capability.TryActivate", "", "");

		// Token: 0x04025EE8 RID: 155368
		private readonly Stat StatInterruptByTags = Stat.Create("Capability.InterruptByTags", "", "");

		// Token: 0x04025EE9 RID: 155369
		[Nullable(2)]
		private static CapabilityController _Instance;
	}
}
