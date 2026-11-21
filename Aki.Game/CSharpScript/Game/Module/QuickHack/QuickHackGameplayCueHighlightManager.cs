using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F2D RID: 16173
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackGameplayCueHighlightManager : QuickHackHighlightManager
	{
		// Token: 0x06028F8D RID: 167821 RVA: 0x00B7FF58 File Offset: 0x00B7E158
		public override void Init(QuickHackDevice config)
		{
			base.Init(config);
			this.Config = new QuickHackDevice?(config);
		}

		// Token: 0x06028F8E RID: 167822 RVA: 0x00B7FF70 File Offset: 0x00B7E170
		public override void RefreshTargetsHighlight(IEnumerable<EntityHandle> lockTargets, IEnumerable<EntityHandle> onScreenTargets)
		{
			if (this.Config == null)
			{
				return;
			}
			IQuickHackHighlightPreProcessResult quickHackHighlightPreProcessResult = base.PreProcessSelectAndOnScreenTargets(lockTargets, onScreenTargets);
			HashSet<EntityHandle> newOnScreenTargetSet = quickHackHighlightPreProcessResult.NewOnScreenTargetSet;
			HashSet<EntityHandle> newLockTargetSet = quickHackHighlightPreProcessResult.NewLockTargetSet;
			if (this.Config.Value.OnScreenTargetGameplayCueIdsLength > 0)
			{
				this.RefreshTargetsGameplayCue(this.Config.Value.OnScreenTargetGameplayCueIdsIter(), newOnScreenTargetSet, this.OnScreenTargetToHighlightCueMap);
			}
			if (this.Config.Value.TargetGameplayCueIdsLength > 0)
			{
				this.RefreshTargetsGameplayCue(this.Config.Value.TargetGameplayCueIdsIter(), newLockTargetSet, this.TargetToHighlightCueMap);
			}
		}

		// Token: 0x06028F8F RID: 167823 RVA: 0x00B8000C File Offset: 0x00B7E20C
		private void RefreshTargetsGameplayCue(IEnumerable<long> cueIds, HashSet<EntityHandle> newTargetSet, Dictionary<EntityHandle, List<int>> currentTargetToCueMap)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (KeyValuePair<EntityHandle, List<int>> keyValuePair in currentTargetToCueMap)
			{
				EntityHandle entityHandle;
				List<int> list2;
				keyValuePair.Deconstruct(out entityHandle, out list2);
				EntityHandle entityHandle2 = entityHandle;
				List<int> list3 = list2;
				if (!newTargetSet.Remove(entityHandle2))
				{
					list.Add(entityHandle2);
					if (entityHandle2 != null && entityHandle2.Valid)
					{
						BaseGameplayCueComponent component = entityHandle2.Entity.GetComponent<BaseGameplayCueComponent>();
						if (component != null)
						{
							foreach (int num in list3)
							{
								component.RemoveCueByHandle((long)num);
							}
						}
					}
				}
			}
			foreach (EntityHandle key in list)
			{
				currentTargetToCueMap.Remove(key);
			}
			foreach (EntityHandle entityHandle3 in newTargetSet)
			{
				if (entityHandle3 != null && entityHandle3.Valid)
				{
					BaseGameplayCueComponent component2 = entityHandle3.Entity.GetComponent<BaseGameplayCueComponent>();
					if (component2 != null)
					{
						List<int> list4 = new List<int>();
						foreach (long cueId in cueIds)
						{
							int? num2 = (component2 != null) ? new int?(component2.AddCue(cueId, null)) : null;
							if (num2 != null && num2.Value > 0)
							{
								list4.Add(num2.Value);
							}
						}
						if (list4.Count > 0)
						{
							currentTargetToCueMap[entityHandle3] = list4;
						}
					}
				}
			}
		}

		// Token: 0x06028F90 RID: 167824 RVA: 0x00B8022C File Offset: 0x00B7E42C
		public override void RemoveAllHighlight()
		{
			this.ClearTargetsGameplayCue(this.TargetToHighlightCueMap);
			this.ClearTargetsGameplayCue(this.OnScreenTargetToHighlightCueMap);
		}

		// Token: 0x06028F91 RID: 167825 RVA: 0x00B80248 File Offset: 0x00B7E448
		private void ClearTargetsGameplayCue(Dictionary<EntityHandle, List<int>> targetToCueMap)
		{
			foreach (KeyValuePair<EntityHandle, List<int>> keyValuePair in targetToCueMap)
			{
				EntityHandle entityHandle;
				List<int> list;
				keyValuePair.Deconstruct(out entityHandle, out list);
				EntityHandle entityHandle2 = entityHandle;
				List<int> list2 = list;
				if (entityHandle2 != null && entityHandle2.Valid)
				{
					BaseGameplayCueComponent component = entityHandle2.Entity.GetComponent<BaseGameplayCueComponent>();
					if (component != null)
					{
						foreach (int num in list2)
						{
							component.RemoveCueByHandle((long)num);
						}
					}
				}
			}
			targetToCueMap.Clear();
		}

		// Token: 0x04016474 RID: 91252
		private QuickHackDevice? Config;

		// Token: 0x04016475 RID: 91253
		private readonly Dictionary<EntityHandle, List<int>> TargetToHighlightCueMap = new Dictionary<EntityHandle, List<int>>();

		// Token: 0x04016476 RID: 91254
		private readonly Dictionary<EntityHandle, List<int>> OnScreenTargetToHighlightCueMap = new Dictionary<EntityHandle, List<int>>();
	}
}
