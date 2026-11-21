using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F26 RID: 16166
	public class QuickHackSkillCheckUsageCountEnough : IQuickHackSkillCondition
	{
		// Token: 0x06028F7E RID: 167806 RVA: 0x00B7F9CB File Offset: 0x00B7DBCB
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
