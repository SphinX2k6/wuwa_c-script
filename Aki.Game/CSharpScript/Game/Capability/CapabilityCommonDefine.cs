using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Capability
{
	// Token: 0x02006419 RID: 25625
	public static class CapabilityCommonDefine
	{
		// Token: 0x0603E34F RID: 254799 RVA: 0x01210E6C File Offset: 0x0120F06C
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

		// Token: 0x040211B2 RID: 135602
		[Nullable(1)]
		public static readonly IReadOnlyDictionary<ETickingGroup, string> ueTickingGroupName;

		// Token: 0x040211B3 RID: 135603
		[Nullable(1)]
		public const string CAPABILITY_DEBUG_KEY = "Capability";

		// Token: 0x0200BB94 RID: 48020
		public enum ECapabilityState
		{
			// Token: 0x04039BC2 RID: 236482
			Inactive,
			// Token: 0x04039BC3 RID: 236483
			Deactivated,
			// Token: 0x04039BC4 RID: 236484
			Active,
			// Token: 0x04039BC5 RID: 236485
			Blocked
		}

		// Token: 0x0200BB95 RID: 48021
		public enum ECapabilityDebugEvent
		{
			// Token: 0x04039BC7 RID: 236487
			Setup,
			// Token: 0x04039BC8 RID: 236488
			PreTick,
			// Token: 0x04039BC9 RID: 236489
			ShouldActivate,
			// Token: 0x04039BCA RID: 236490
			ShouldDeactivate,
			// Token: 0x04039BCB RID: 236491
			OnActivated,
			// Token: 0x04039BCC RID: 236492
			OnDeactivated,
			// Token: 0x04039BCD RID: 236493
			TickActive,
			// Token: 0x04039BCE RID: 236494
			Blocked,
			// Token: 0x04039BCF RID: 236495
			Unblocked,
			// Token: 0x04039BD0 RID: 236496
			Interrupted
		}
	}
}
