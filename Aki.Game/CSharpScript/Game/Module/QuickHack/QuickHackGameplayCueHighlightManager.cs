using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F64 RID: 20324
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackGameplayCueHighlightManager : QuickHackHighlightManager
	{
		// Token: 0x0603411F RID: 213279 RVA: 0x00C367B8 File Offset: 0x00C349B8
		public override void Init(QuickHackDevice config)
		{
			base.Init(config);
			this.Config = new QuickHackDevice?(config);
		}

		// Token: 0x06034120 RID: 213280 RVA: 0x00C367D0 File Offset: 0x00C349D0
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

		// Token: 0x06034121 RID: 213281 RVA: 0x00C3686C File Offset: 0x00C34A6C
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

		// Token: 0x06034122 RID: 213282 RVA: 0x00C36A8C File Offset: 0x00C34C8C
		public override void RemoveAllHighlight()
		{
			this.ClearTargetsGameplayCue(this.TargetToHighlightCueMap);
			this.ClearTargetsGameplayCue(this.OnScreenTargetToHighlightCueMap);
		}

		// Token: 0x06034123 RID: 213283 RVA: 0x00C36AA8 File Offset: 0x00C34CA8
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

		// Token: 0x0401BA9F RID: 113311
		private QuickHackDevice? Config;

		// Token: 0x0401BAA0 RID: 113312
		private readonly Dictionary<EntityHandle, List<int>> TargetToHighlightCueMap = new Dictionary<EntityHandle, List<int>>();

		// Token: 0x0401BAA1 RID: 113313
		private readonly Dictionary<EntityHandle, List<int>> OnScreenTargetToHighlightCueMap = new Dictionary<EntityHandle, List<int>>();
	}
}
