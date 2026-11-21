using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Capability.Editor;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200641E RID: 25630
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class CapabilityModel : ModelBase
	{
		// Token: 0x0603E391 RID: 254865 RVA: 0x0121253B File Offset: 0x0121073B
		public void BumpScheduleGeneration()
		{
			this.ScheduleGeneration++;
		}

		// Token: 0x0603E392 RID: 254866 RVA: 0x0121254B File Offset: 0x0121074B
		private void ClearDebugger()
		{
			this.Debugger.Clear();
		}

		// Token: 0x0603E393 RID: 254867 RVA: 0x01212558 File Offset: 0x01210758
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603E394 RID: 254868 RVA: 0x0121255B File Offset: 0x0121075B
		protected override bool OnLeaveLevel()
		{
			this.ClearDebugger();
			return true;
		}

		// Token: 0x0603E395 RID: 254869 RVA: 0x01212564 File Offset: 0x01210764
		protected override bool OnChangeMode()
		{
			this.ClearDebugger();
			return true;
		}

		// Token: 0x0603E396 RID: 254870 RVA: 0x0121256D File Offset: 0x0121076D
		protected override bool OnClear()
		{
			this.ClearDebugger();
			return true;
		}

		// Token: 0x17007666 RID: 30310
		// (get) Token: 0x0603E397 RID: 254871 RVA: 0x01212576 File Offset: 0x01210776
		public static CapabilityModel Instance
		{
			get
			{
				return CapabilityModel._Instance;
			}
		}

		// Token: 0x0603E398 RID: 254872 RVA: 0x0121257D File Offset: 0x0121077D
		public static CapabilityModel GetOrCreateInstance()
		{
			if (CapabilityModel._Instance == null)
			{
				CapabilityModel.CreateInstance();
			}
			return CapabilityModel._Instance;
		}

		// Token: 0x0603E399 RID: 254873 RVA: 0x01212591 File Offset: 0x01210791
		public static bool CreateInstance()
		{
			if (CapabilityModel._Instance != null)
			{
				return true;
			}
			CapabilityModel._Instance = new CapabilityModel();
			return true;
		}

		// Token: 0x0603E39A RID: 254874 RVA: 0x012125A7 File Offset: 0x012107A7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E39B RID: 254875 RVA: 0x012125A9 File Offset: 0x012107A9
		public static void ResetStaticDefaultValue()
		{
			CapabilityModel._Instance = null;
		}

		// Token: 0x0603E39C RID: 254876 RVA: 0x012125B1 File Offset: 0x012107B1
		static CapabilityModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CapabilityModel.CreateStaticDefaultValue), new Action(CapabilityModel.ResetStaticDefaultValue));
		}

		// Token: 0x040211C7 RID: 135623
		public readonly HashSet<ICapabilityGameObject> GameObjects = new HashSet<ICapabilityGameObject>();

		// Token: 0x040211C8 RID: 135624
		public readonly CapabilityDebugger Debugger = new CapabilityDebugger();

		// Token: 0x040211C9 RID: 135625
		[Nullable(2)]
		public CapabilityTimelineDebugger TimelineDebugger;

		// Token: 0x040211CA RID: 135626
		public readonly Dictionary<ETickingGroup, int> RegisteredTickGroups = new Dictionary<ETickingGroup, int>();

		// Token: 0x040211CB RID: 135627
		public int ScheduleGeneration;

		// Token: 0x040211CC RID: 135628
		public readonly Dictionary<ETickingGroup, List<IScheduledEntry>> GroupScheduleCache = new Dictionary<ETickingGroup, List<IScheduledEntry>>();

		// Token: 0x040211CD RID: 135629
		public int GroupScheduleCacheGeneration = -1;

		// Token: 0x040211CE RID: 135630
		public readonly WeakMap<ICapabilityGameObject, HostDefaultScheduleCacheEntry> HostDefaultScheduleCache = new WeakMap<ICapabilityGameObject, HostDefaultScheduleCacheEntry>();

		// Token: 0x040211CF RID: 135631
		[Nullable(2)]
		private static CapabilityModel _Instance;
	}
}
