using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059F0 RID: 23024
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolQuestPresentationPlan
	{
		// Token: 0x17006C57 RID: 27735
		// (get) Token: 0x06038B67 RID: 232295 RVA: 0x00FDF13F File Offset: 0x00FDD33F
		public IReadOnlyList<int> AppearingQuestIds { get; }

		// Token: 0x17006C58 RID: 27736
		// (get) Token: 0x06038B68 RID: 232296 RVA: 0x00FDF147 File Offset: 0x00FDD347
		public IReadOnlyList<int> UnlockingQuestIds { get; }

		// Token: 0x17006C59 RID: 27737
		// (get) Token: 0x06038B69 RID: 232297 RVA: 0x00FDF14F File Offset: 0x00FDD34F
		public IReadOnlyList<SolarSchoolQuestLinePlan> Lines { get; }

		// Token: 0x17006C5A RID: 27738
		// (get) Token: 0x06038B6A RID: 232298 RVA: 0x00FDF157 File Offset: 0x00FDD357
		public int LocateQuestId
		{
			get
			{
				if (this.AppearingQuestIds.Count > 0)
				{
					return this.AppearingQuestIds[0];
				}
				if (this.UnlockingQuestIds.Count <= 0)
				{
					return 0;
				}
				return this.UnlockingQuestIds[0];
			}
		}

		// Token: 0x17006C5B RID: 27739
		// (get) Token: 0x06038B6B RID: 232299 RVA: 0x00FDF190 File Offset: 0x00FDD390
		public bool HasChanges
		{
			get
			{
				return this.AppearingQuestIds.Count > 0 || this.UnlockingQuestIds.Count > 0;
			}
		}

		// Token: 0x06038B6C RID: 232300 RVA: 0x00FDF1B0 File Offset: 0x00FDD3B0
		private SolarSchoolQuestPresentationPlan(IReadOnlyList<int> appearingQuestIds, IReadOnlyList<int> unlockingQuestIds, IReadOnlyList<SolarSchoolQuestLinePlan> lines)
		{
			this.AppearingQuestIds = appearingQuestIds;
			this.UnlockingQuestIds = unlockingQuestIds;
			this.Lines = lines;
		}

		// Token: 0x06038B6D RID: 232301 RVA: 0x00FDF1D0 File Offset: 0x00FDD3D0
		public static SolarSchoolQuestPresentationPlan Build(IReadOnlyList<SolarSchoolQuestColumnData> columns, IReadOnlyDictionary<int, SolarSchoolQuestPresentationState> states)
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData in columns)
			{
				foreach (SolarSchoolQuestArrowItemData solarSchoolQuestArrowItemData in solarSchoolQuestColumnData.ArrowList)
				{
					SolarSchoolQuestPresentationState solarSchoolQuestPresentationState = states[solarSchoolQuestArrowItemData.QuestId];
					if (solarSchoolQuestPresentationState.IsShowing && !solarSchoolQuestPresentationState.IsExpired)
					{
						if (!solarSchoolQuestPresentationState.FirstShowCompleted)
						{
							list.Add(solarSchoolQuestPresentationState.QuestId);
						}
						if (solarSchoolQuestPresentationState.IsUnlocked && solarSchoolQuestPresentationState.InShowTime && !solarSchoolQuestPresentationState.FirstUnlockCompleted)
						{
							list2.Add(solarSchoolQuestPresentationState.QuestId);
						}
					}
				}
			}
			HashSet<int> hashSet = new HashSet<int>(list);
			List<SolarSchoolQuestLinePlan> list3 = new List<SolarSchoolQuestLinePlan>();
			foreach (SolarSchoolQuestColumnData solarSchoolQuestColumnData2 in columns)
			{
				foreach (SolarSchoolQuestArrowItemData solarSchoolQuestArrowItemData2 in solarSchoolQuestColumnData2.ArrowList)
				{
					ESolarSchoolQuestLineMask esolarSchoolQuestLineMask = ESolarSchoolQuestLineMask.None;
					ESolarSchoolQuestLineMask esolarSchoolQuestLineMask2 = ESolarSchoolQuestLineMask.None;
					foreach (SolarSchoolQuestEdgeData solarSchoolQuestEdgeData in solarSchoolQuestArrowItemData2.Edges)
					{
						if (hashSet.Contains(solarSchoolQuestArrowItemData2.QuestId) || hashSet.Contains(solarSchoolQuestEdgeData.ChildQuestId))
						{
							esolarSchoolQuestLineMask2 |= solarSchoolQuestEdgeData.Direction;
						}
						else
						{
							esolarSchoolQuestLineMask |= solarSchoolQuestEdgeData.Direction;
						}
					}
					esolarSchoolQuestLineMask2 &= ~esolarSchoolQuestLineMask;
					list3.Add(new SolarSchoolQuestLinePlan(solarSchoolQuestArrowItemData2.QuestId, esolarSchoolQuestLineMask, esolarSchoolQuestLineMask2));
				}
			}
			return new SolarSchoolQuestPresentationPlan(list.ToArray(), list2.ToArray(), list3.ToArray());
		}
	}
}
