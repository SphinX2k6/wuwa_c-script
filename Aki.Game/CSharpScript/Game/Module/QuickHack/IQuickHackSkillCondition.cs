using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F23 RID: 16163
	[NullableContext(1)]
	public interface IQuickHackSkillCondition
	{
		// Token: 0x06028F79 RID: 167801
		bool Check(QuickHackSkillInstance skillConfig, EQuickHackTargetType? hackType, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<EntityHandle> targets, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<string> extraParams = null, int paramsLength = 0);
	}
}
