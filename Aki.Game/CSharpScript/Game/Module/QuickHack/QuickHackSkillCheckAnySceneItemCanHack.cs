using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F5F RID: 20319
	public class QuickHackSkillCheckAnySceneItemCanHack : IQuickHackSkillCondition
	{
		// Token: 0x06034114 RID: 213268 RVA: 0x00C3630C File Offset: 0x00C3450C
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
			int id = skill.GetConfig().Id;
			foreach (EntityHandle entityHandle in targets)
			{
				if (entityHandle.Valid)
				{
					SceneItemQuickHackComponent component = entityHandle.Entity.GetComponent<SceneItemQuickHackComponent>();
					if (component != null && component.CheckCanHack(id))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
