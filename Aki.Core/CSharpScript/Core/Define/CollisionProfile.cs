using System;
using UnrealEngine;

namespace CSharpScript.Core.Define
{
	// Token: 0x0200013C RID: 316
	public class CollisionProfile
	{
		// Token: 0x040006D4 RID: 1748
		[StaticVariableRuleIgnore]
		public static readonly FName Custom = FNameUtil.GetDynamicFName("Custom").Value;

		// Token: 0x040006D5 RID: 1749
		[StaticVariableRuleIgnore]
		public static readonly FName NoCollision = FNameUtil.GetDynamicFName("NoCollision").Value;
	}
}
