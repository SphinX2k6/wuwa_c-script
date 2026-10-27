using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F5B RID: 20315
	public class QuickHackSkillCheckTargetMatch : IQuickHackSkillCondition
	{
		// Token: 0x0603410C RID: 213260 RVA: 0x00C361AC File Offset: 0x00C343AC
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
			int targetType = skill.GetConfig().TargetType;
			return targetType == 2 || (hackType != null && targetType == (int)hackType.Value);
		}
	}
}
