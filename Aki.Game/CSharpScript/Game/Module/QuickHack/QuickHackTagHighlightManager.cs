using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F32 RID: 16178
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackTagHighlightManager : QuickHackHighlightManager
	{
		// Token: 0x06028FA6 RID: 167846 RVA: 0x00B805A0 File Offset: 0x00B7E7A0
		public override void Init(QuickHackDevice config)
		{
			base.Init(config);
			string selectTargetTag = config.SelectTargetTag;
			string onScreenTargetTag = config.OnScreenTargetTag;
			if (!StringUtils.IsBlank(selectTargetTag))
			{
				this.LockTargetTagId = GameplayTagUtils.GetTagIdByName(selectTargetTag);
			}
			if (!StringUtils.IsBlank(onScreenTargetTag))
			{
				this.OnScreenTargetTagId = GameplayTagUtils.GetTagIdByName(onScreenTargetTag);
			}
		}

		// Token: 0x06028FA7 RID: 167847 RVA: 0x00B805EC File Offset: 0x00B7E7EC
		public override void RefreshTargetsHighlight(IEnumerable<EntityHandle> lockTargets, IEnumerable<EntityHandle> onScreenTargets)
		{
			IQuickHackHighlightPreProcessResult quickHackHighlightPreProcessResult = base.PreProcessSelectAndOnScreenTargets(lockTargets, onScreenTargets);
			HashSet<EntityHandle> newOnScreenTargetSet = quickHackHighlightPreProcessResult.NewOnScreenTargetSet;
			HashSet<EntityHandle> newLockTargetSet = quickHackHighlightPreProcessResult.NewLockTargetSet;
			if (this.OnScreenTargetTagId != 0)
			{
				this.RefreshTargetsTag(this.OnScreenTargetTagId, newOnScreenTargetSet, this.OnScreenTargetSet);
			}
			if (this.LockTargetTagId != 0)
			{
				this.RefreshTargetsTag(this.LockTargetTagId, newLockTargetSet, this.LockTargetSet);
			}
		}

		// Token: 0x06028FA8 RID: 167848 RVA: 0x00B80644 File Offset: 0x00B7E844
		public override void RemoveAllHighlight()
		{
			if (this.OnScreenTargetTagId != 0)
			{
				this.ClearTargetsTag(this.OnScreenTargetTagId, this.OnScreenTargetSet);
			}
			if (this.LockTargetTagId != 0)
			{
				this.ClearTargetsTag(this.LockTargetTagId, this.LockTargetSet);
			}
		}

		// Token: 0x06028FA9 RID: 167849 RVA: 0x00B8067C File Offset: 0x00B7E87C
		private void RefreshTargetsTag(int tagId, HashSet<EntityHandle> newTargetSet, HashSet<EntityHandle> currentTargetSet)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (EntityHandle entityHandle in currentTargetSet)
			{
				if (!newTargetSet.Remove(entityHandle))
				{
					list.Add(entityHandle);
					if (entityHandle != null && entityHandle.Valid)
					{
						BaseTagComponent component = entityHandle.Entity.GetComponent<BaseTagComponent>();
						if (component != null)
						{
							component.RemoveTag(new int?(tagId));
						}
					}
				}
			}
			foreach (EntityHandle item in list)
			{
				currentTargetSet.Remove(item);
			}
			foreach (EntityHandle entityHandle2 in newTargetSet)
			{
				if (entityHandle2 != null && entityHandle2.Valid)
				{
					BaseTagComponent component2 = entityHandle2.Entity.GetComponent<BaseTagComponent>();
					if (component2 != null)
					{
						component2.AddTag(new int?(tagId));
						currentTargetSet.Add(entityHandle2);
					}
				}
			}
		}

		// Token: 0x06028FAA RID: 167850 RVA: 0x00B807BC File Offset: 0x00B7E9BC
		private void ClearTargetsTag(int tagId, HashSet<EntityHandle> targetSet)
		{
			foreach (EntityHandle entityHandle in targetSet)
			{
				if (entityHandle != null && entityHandle.Valid)
				{
					BaseTagComponent component = entityHandle.Entity.GetComponent<BaseTagComponent>();
					if (component != null)
					{
						component.RemoveTag(new int?(tagId));
					}
				}
			}
			targetSet.Clear();
		}

		// Token: 0x0401647C RID: 91260
		private int LockTargetTagId;

		// Token: 0x0401647D RID: 91261
		private int OnScreenTargetTagId;

		// Token: 0x0401647E RID: 91262
		private readonly HashSet<EntityHandle> LockTargetSet = new HashSet<EntityHandle>();

		// Token: 0x0401647F RID: 91263
		private readonly HashSet<EntityHandle> OnScreenTargetSet = new HashSet<EntityHandle>();
	}
}
