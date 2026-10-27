using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F5C RID: 20316
	public class QuickHackSkillCheckRamEnough : IQuickHackSkillCondition
	{
		// Token: 0x0603410E RID: 213262 RVA: 0x00C361EC File Offset: 0x00C343EC
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
			QuickHackRamManager ramManager = QuickHackModel.Instance.RamManager;
			return ramManager != null && ramManager.GetCurrentRam() >= (float)skill.GetConfig().RamCost;
		}
	}
}
