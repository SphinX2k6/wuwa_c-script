using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F60 RID: 20320
	public class QuickHackSkillCheckAnyTargetNotBeenUsedSkill : IQuickHackSkillCondition
	{
		// Token: 0x06034116 RID: 213270 RVA: 0x00C36398 File Offset: 0x00C34598
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
			if (targets == null)
			{
				return false;
			}
			Dictionary<int, HashSet<int>> targetBeenUsedSkillRecordMap = QuickHackModel.Instance.TargetBeenUsedSkillRecordMap;
			if (targetBeenUsedSkillRecordMap == null)
			{
				return true;
			}
			int id = skill.GetConfig().Id;
			foreach (EntityHandle entityHandle in targets)
			{
				if (entityHandle.Valid)
				{
					HashSet<int> hashSet;
					if (!targetBeenUsedSkillRecordMap.TryGetValue(entityHandle.Id, out hashSet))
					{
						return true;
					}
					if (!hashSet.Contains(id))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
