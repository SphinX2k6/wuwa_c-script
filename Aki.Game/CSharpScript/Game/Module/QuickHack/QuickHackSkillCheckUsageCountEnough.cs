using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F5D RID: 20317
	public class QuickHackSkillCheckUsageCountEnough : IQuickHackSkillCondition
	{
		// Token: 0x06034110 RID: 213264 RVA: 0x00C3622B File Offset: 0x00C3442B
		[NullableContext(1)]
		public bool Check(QuickHackSkillInstance skill, EQuickHackTargetType? hackType, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<EntityHandle> targets, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<string> extraParams = null, int paramsLength = 0)
		{
			return skill.GetUsageCount() != 0;
		}
	}
}
