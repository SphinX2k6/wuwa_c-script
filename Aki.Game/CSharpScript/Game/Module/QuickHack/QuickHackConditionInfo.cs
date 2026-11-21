using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F2A RID: 16170
	public class QuickHackConditionInfo
	{
		// Token: 0x06028F86 RID: 167814 RVA: 0x00B7FBD8 File Offset: 0x00B7DDD8
		public QuickHackConditionInfo(EQuickHackSkillCondition type, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<string> extraParams, int paramsLength)
		{
		}

		// Token: 0x0401646C RID: 91244
		public readonly EQuickHackSkillCondition Type = type;

		// Token: 0x0401646D RID: 91245
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public readonly IEnumerable<string> ExtraParams = extraParams;

		// Token: 0x0401646E RID: 91246
		public readonly int ParamsLength = paramsLength;
	}
}
