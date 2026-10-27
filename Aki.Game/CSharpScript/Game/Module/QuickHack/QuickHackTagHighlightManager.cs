using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F69 RID: 20329
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackTagHighlightManager : QuickHackHighlightManager
	{
		// Token: 0x06034138 RID: 213304 RVA: 0x00C36E00 File Offset: 0x00C35000
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

		// Token: 0x06034139 RID: 213305 RVA: 0x00C36E4C File Offset: 0x00C3504C
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

		// Token: 0x0603413A RID: 213306 RVA: 0x00C36EA4 File Offset: 0x00C350A4
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

		// Token: 0x0603413B RID: 213307 RVA: 0x00C36EDC File Offset: 0x00C350DC
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

		// Token: 0x0603413C RID: 213308 RVA: 0x00C3701C File Offset: 0x00C3521C
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

		// Token: 0x0401BAA7 RID: 113319
		private int LockTargetTagId;

		// Token: 0x0401BAA8 RID: 113320
		private int OnScreenTargetTagId;

		// Token: 0x0401BAA9 RID: 113321
		private readonly HashSet<EntityHandle> LockTargetSet = new HashSet<EntityHandle>();

		// Token: 0x0401BAAA RID: 113322
		private readonly HashSet<EntityHandle> OnScreenTargetSet = new HashSet<EntityHandle>();
	}
}
