using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F24 RID: 16164
	public class QuickHackSkillCheckTargetMatch : IQuickHackSkillCondition
	{
		// Token: 0x06028F7A RID: 167802 RVA: 0x00B7F94C File Offset: 0x00B7DB4C
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
