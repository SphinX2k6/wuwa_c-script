using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Capability.Editor;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200729F RID: 29343
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CapabilityModel : ModelBase
	{
		// Token: 0x06047FCB RID: 294859 RVA: 0x0127153F File Offset: 0x0126F73F
		public void BumpScheduleGeneration()
		{
			this.ScheduleGeneration++;
		}

		// Token: 0x06047FCC RID: 294860 RVA: 0x0127154F File Offset: 0x0126F74F
		private void ClearDebugger()
		{
			this.Debugger.Clear();
			if (!Info.Instance.IsBuildShipping)
			{
				CapabilityTimelineDebugger timelineDebugger = this.TimelineDebugger;
				if (timelineDebugger != null)
				{
					timelineDebugger.Hide();
				}
				this.TimelineDebugger = null;
			}
		}

		// Token: 0x06047FCD RID: 294861 RVA: 0x01271580 File Offset: 0x0126F780
		protected override bool OnInit()
		{
			if (!Info.Instance.IsBuildShipping)
			{
				this.TimelineDebugger = new CapabilityTimelineDebugger(this.Debugger);
				this.TimelineDebugger.SetWindowSeconds(20f);
			}
			return true;
		}

		// Token: 0x06047FCE RID: 294862 RVA: 0x012715B0 File Offset: 0x0126F7B0
		protected override bool OnLeaveLevel()
		{
			this.ClearDebugger();
			return true;
		}

		// Token: 0x06047FCF RID: 294863 RVA: 0x012715B9 File Offset: 0x0126F7B9
		protected override bool OnChangeMode()
		{
			this.ClearDebugger();
			return true;
		}

		// Token: 0x06047FD0 RID: 294864 RVA: 0x012715C2 File Offset: 0x0126F7C2
		protected override bool OnClear()
		{
			this.ClearDebugger();
			return true;
		}

		// Token: 0x17009F04 RID: 40708
		// (get) Token: 0x06047FD1 RID: 294865 RVA: 0x012715CB File Offset: 0x0126F7CB
		public static CapabilityModel Instance
		{
			get
			{
				return CapabilityModel._Instance;
			}
		}

		// Token: 0x06047FD2 RID: 294866 RVA: 0x012715D2 File Offset: 0x0126F7D2
		public static CapabilityModel GetOrCreateInstance()
		{
			if (CapabilityModel._Instance == null)
			{
				CapabilityModel.CreateInstance();
			}
			return CapabilityModel._Instance;
		}

		// Token: 0x06047FD3 RID: 294867 RVA: 0x012715E6 File Offset: 0x0126F7E6
		public static bool CreateInstance()
		{
			if (CapabilityModel._Instance != null)
			{
				return true;
			}
			CapabilityModel._Instance = new CapabilityModel();
			return true;
		}

		// Token: 0x06047FD4 RID: 294868 RVA: 0x012715FC File Offset: 0x0126F7FC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06047FD5 RID: 294869 RVA: 0x012715FE File Offset: 0x0126F7FE
		public static void ResetStaticDefaultValue()
		{
			CapabilityModel._Instance = null;
		}

		// Token: 0x06047FD6 RID: 294870 RVA: 0x01271606 File Offset: 0x0126F806
		static CapabilityModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CapabilityModel.CreateStaticDefaultValue), new Action(CapabilityModel.ResetStaticDefaultValue));
		}

		// Token: 0x04025EF4 RID: 155380
		public readonly HashSet<ICapabilityGameObject> GameObjects = new HashSet<ICapabilityGameObject>();

		// Token: 0x04025EF5 RID: 155381
		public readonly CapabilityDebugger Debugger = new CapabilityDebugger();

		// Token: 0x04025EF6 RID: 155382
		[Nullable(2)]
		public CapabilityTimelineDebugger TimelineDebugger;

		// Token: 0x04025EF7 RID: 155383
		public readonly Dictionary<ETickingGroup, int> RegisteredTickGroups = new Dictionary<ETickingGroup, int>();

		// Token: 0x04025EF8 RID: 155384
		public int ScheduleGeneration;

		// Token: 0x04025EF9 RID: 155385
		public readonly Dictionary<ETickingGroup, List<IScheduledEntry>> GroupScheduleCache = new Dictionary<ETickingGroup, List<IScheduledEntry>>();

		// Token: 0x04025EFA RID: 155386
		public int GroupScheduleCacheGeneration = -1;

		// Token: 0x04025EFB RID: 155387
		public readonly WeakMap<ICapabilityGameObject, HostDefaultScheduleCacheEntry> HostDefaultScheduleCache = new WeakMap<ICapabilityGameObject, HostDefaultScheduleCacheEntry>();

		// Token: 0x04025EFC RID: 155388
		[Nullable(2)]
		private static CapabilityModel _Instance;
	}
}
