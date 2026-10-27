using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x02000106 RID: 262
	public static class SoPatchDefine
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x0003EA2B File Offset: 0x0003CC2B
		[NullableContext(1)]
		public static void CheckCondition(string expect, string value, CheckConditions condition, int num)
		{
			condition.ExpectChange(num);
			if (string.IsNullOrEmpty(expect) || expect == value)
			{
				condition.ValueChange(num);
			}
		}
	}
}
