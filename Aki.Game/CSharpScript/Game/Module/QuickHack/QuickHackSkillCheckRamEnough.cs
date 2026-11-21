using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F25 RID: 16165
	public class QuickHackSkillCheckRamEnough : IQuickHackSkillCondition
	{
		// Token: 0x06028F7C RID: 167804 RVA: 0x00B7F98C File Offset: 0x00B7DB8C
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
