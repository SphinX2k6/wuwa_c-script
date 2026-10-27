using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F67 RID: 20327
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackHighlightManager
	{
		// Token: 0x0603412E RID: 213294 RVA: 0x00C36BB4 File Offset: 0x00C34DB4
		public virtual void Init(QuickHackDevice config)
		{
			this.UseTargetHighlightCondition = config.UseTargetHighlightCondition;
		}

		// Token: 0x0603412F RID: 213295 RVA: 0x00C36BC3 File Offset: 0x00C34DC3
		public void Clear()
		{
			this.RemoveAllHighlight();
		}

		// Token: 0x06034130 RID: 213296
		public abstract void RefreshTargetsHighlight(IEnumerable<EntityHandle> lockTargets, IEnumerable<EntityHandle> onScreenTargets);

		// Token: 0x06034131 RID: 213297
		public abstract void RemoveAllHighlight();

		// Token: 0x06034132 RID: 213298 RVA: 0x00C36BCC File Offset: 0x00C34DCC
		protected IQuickHackHighlightPreProcessResult PreProcessSelectAndOnScreenTargets(IEnumerable<EntityHandle> lockTargets, IEnumerable<EntityHandle> onScreenTargets)
		{
			HashSet<EntityHandle> hashSet = new HashSet<EntityHandle>(onScreenTargets);
			HashSet<EntityHandle> hashSet2 = new HashSet<EntityHandle>(lockTargets);
			QuickHackSkillInstance currentSelectSkill = QuickHackModel.Instance.CurrentSelectSkill;
			foreach (EntityHandle entityHandle in hashSet2)
			{
				if (this.UseTargetHighlightCondition && currentSelectSkill != null && !currentSelectSkill.CheckTargetExtraConditions(entityHandle))
				{
					hashSet2.Remove(entityHandle);
					hashSet.Add(entityHandle);
				}
				else
				{
					hashSet.Remove(entityHandle);
				}
			}
			return new QuickHackHighlightPreProcessResult
			{
				NewOnScreenTargetSet = hashSet,
				NewLockTargetSet = hashSet2
			};
		}

		// Token: 0x0401BAA4 RID: 113316
		private bool UseTargetHighlightCondition;
	}
}
