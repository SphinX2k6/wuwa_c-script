using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F5A RID: 20314
	[NullableContext(1)]
	public interface IQuickHackSkillCondition
	{
		// Token: 0x0603410B RID: 213259
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
