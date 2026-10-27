using System;
using UnrealEngine;

namespace CSharpScript.Core.Define
{
	// Token: 0x02000138 RID: 312
	public class CollisionProfile
	{
		// Token: 0x040006C6 RID: 1734
		[StaticVariableRuleIgnore]
		public static readonly FName Custom = FNameUtil.GetDynamicFName("Custom").Value;

		// Token: 0x040006C7 RID: 1735
		[StaticVariableRuleIgnore]
		public static readonly FName NoCollision = FNameUtil.GetDynamicFName("NoCollision").Value;
	}
}
