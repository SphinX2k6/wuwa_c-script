using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.SoPatch
{
	// Token: 0x0200010A RID: 266
	public static class SoPatchDefine
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x00040DCB File Offset: 0x0003EFCB
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
