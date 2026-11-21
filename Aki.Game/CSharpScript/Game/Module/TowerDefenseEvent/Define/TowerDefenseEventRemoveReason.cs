using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Define
{
	// Token: 0x02003ABF RID: 15039
	public class TowerDefenseEventRemoveReason
	{
		// Token: 0x04015284 RID: 86660
		public static readonly FName Preview = FNameUtil.GetCheckDynamicFName("Preview");

		// Token: 0x04015285 RID: 86661
		public static readonly FName CombatDirty = FNameUtil.GetCheckDynamicFName("CombatDirty");

		// Token: 0x04015286 RID: 86662
		public static readonly FName Destroy = FNameUtil.GetCheckDynamicFName("Destroy");
	}
}
