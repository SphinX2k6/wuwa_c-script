using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F30 RID: 16176
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackHighlightManager
	{
		// Token: 0x06028F9C RID: 167836 RVA: 0x00B80354 File Offset: 0x00B7E554
		public virtual void Init(QuickHackDevice config)
		{
			this.UseTargetHighlightCondition = config.UseTargetHighlightCondition;
		}

		// Token: 0x06028F9D RID: 167837 RVA: 0x00B80363 File Offset: 0x00B7E563
		public void Clear()
		{
			this.RemoveAllHighlight();
		}

		// Token: 0x06028F9E RID: 167838
		public abstract void RefreshTargetsHighlight(IEnumerable<EntityHandle> lockTargets, IEnumerable<EntityHandle> onScreenTargets);

		// Token: 0x06028F9F RID: 167839
		public abstract void RemoveAllHighlight();

		// Token: 0x06028FA0 RID: 167840 RVA: 0x00B8036C File Offset: 0x00B7E56C
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

		// Token: 0x04016479 RID: 91257
		private bool UseTargetHighlightCondition;
	}
}
