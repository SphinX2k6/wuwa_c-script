using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x0200729A RID: 29338
	public static class CapabilityCommonDefine
	{
		// Token: 0x06047F89 RID: 294793 RVA: 0x0126FE20 File Offset: 0x0126E020
		// Note: this type is marked as 'beforefieldinit'.
		static CapabilityCommonDefine()
		{
			Dictionary<ETickingGroup, string> dictionary = new Dictionary<ETickingGroup, string>();
			dictionary[ETickingGroup.TG_PrePhysics] = "PrePhysics";
			dictionary[ETickingGroup.TG_StartPhysics] = "StartPhysics";
			dictionary[ETickingGroup.TG_DuringPhysics] = "DuringPhysics";
			dictionary[ETickingGroup.TG_EndPhysics] = "EndPhysics";
			dictionary[ETickingGroup.TG_PostPhysics] = "PostPhysics";
			dictionary[ETickingGroup.TG_PostUpdateWork] = "PostUpdateWork";
			dictionary[ETickingGroup.TG_LastDemotable] = "LastDemotable";
			dictionary[ETickingGroup.TG_NewlySpawned] = "NewlySpawned";
			dictionary[ETickingGroup.TG_MAX] = "MAX";
			CapabilityCommonDefine.ueTickingGroupName = dictionary;
		}

		// Token: 0x04025EDF RID: 155359
		[Nullable(1)]
		public static readonly IReadOnlyDictionary<ETickingGroup, string> ueTickingGroupName;

		// Token: 0x04025EE0 RID: 155360
		[Nullable(1)]
		public const string CAPABILITY_DEBUG_KEY = "Capability";

		// Token: 0x0200CFBA RID: 53178
		public enum ECapabilityState
		{
			// Token: 0x0403E788 RID: 255880
			Inactive,
			// Token: 0x0403E789 RID: 255881
			Deactivated,
			// Token: 0x0403E78A RID: 255882
			Active,
			// Token: 0x0403E78B RID: 255883
			Blocked
		}

		// Token: 0x0200CFBB RID: 53179
		public enum ECapabilityDebugEvent
		{
			// Token: 0x0403E78D RID: 255885
			Setup,
			// Token: 0x0403E78E RID: 255886
			PreTick,
			// Token: 0x0403E78F RID: 255887
			ShouldActivate,
			// Token: 0x0403E790 RID: 255888
			ShouldDeactivate,
			// Token: 0x0403E791 RID: 255889
			OnActivated,
			// Token: 0x0403E792 RID: 255890
			OnDeactivated,
			// Token: 0x0403E793 RID: 255891
			TickActive,
			// Token: 0x0403E794 RID: 255892
			Blocked,
			// Token: 0x0403E795 RID: 255893
			Unblocked,
			// Token: 0x0403E796 RID: 255894
			Interrupted
		}
	}
}
