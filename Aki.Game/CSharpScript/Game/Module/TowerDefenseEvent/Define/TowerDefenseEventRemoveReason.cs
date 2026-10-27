using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Define
{
	// Token: 0x02004B17 RID: 19223
	public class TowerDefenseEventRemoveReason
	{
		// Token: 0x0401A932 RID: 108850
		public static readonly FName Preview = FNameUtil.GetCheckDynamicFName("Preview");

		// Token: 0x0401A933 RID: 108851
		public static readonly FName CombatDirty = FNameUtil.GetCheckDynamicFName("CombatDirty");

		// Token: 0x0401A934 RID: 108852
		public static readonly FName Destroy = FNameUtil.GetCheckDynamicFName("Destroy");
	}
}
