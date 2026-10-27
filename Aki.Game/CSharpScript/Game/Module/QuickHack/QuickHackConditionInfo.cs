using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F61 RID: 20321
	public class QuickHackConditionInfo
	{
		// Token: 0x06034118 RID: 213272 RVA: 0x00C36438 File Offset: 0x00C34638
		public QuickHackConditionInfo(EQuickHackSkillCondition type, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<string> extraParams, int paramsLength)
		{
		}

		// Token: 0x0401BA97 RID: 113303
		public readonly EQuickHackSkillCondition Type = type;

		// Token: 0x0401BA98 RID: 113304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly IEnumerable<string> ExtraParams = extraParams;

		// Token: 0x0401BA99 RID: 113305
		public readonly int ParamsLength = paramsLength;
	}
}
