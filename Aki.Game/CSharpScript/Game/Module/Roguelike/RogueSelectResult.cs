using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D6C RID: 15724
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueSelectResult
	{
		// Token: 0x0602838D RID: 164749 RVA: 0x00B43E48 File Offset: 0x00B42048
		public RogueSelectResult([Nullable(1)] RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, RogueGainEntry selectRogueGainEntry, bool isShowCommon = false)
		{
			this.NewRogueGainEntry = newRogueGainEntry;
			this.OldRogueGainEntry = oldRogueGainEntry;
			this.SelectRogueGainEntry = selectRogueGainEntry;
			this.IsShowCommon = isShowCommon;
		}

		// Token: 0x0602838E RID: 164750 RVA: 0x00B43E70 File Offset: 0x00B42070
		[NullableContext(1)]
		public HashSet<long> GetNewUnlockAffixEntry()
		{
			HashSet<long> hashSet = new HashSet<long>();
			List<AffixEntry> affixEntryList = this.NewRogueGainEntry.AffixEntryList;
			List<AffixEntry> affixEntryList2 = this.OldRogueGainEntry.AffixEntryList;
			if (affixEntryList != null && affixEntryList2 != null)
			{
				int num = Math.Min(affixEntryList.Count, affixEntryList2.Count);
				for (int i = 0; i < num; i++)
				{
					AffixEntry affixEntry = affixEntryList[i];
					AffixEntry affixEntry2 = affixEntryList2[i];
					if (affixEntry.IsUnlock.GetValueOrDefault() && !affixEntry2.IsUnlock.GetValueOrDefault())
					{
						hashSet.Add((long)affixEntry.Id.Value);
					}
				}
			}
			return hashSet;
		}

		// Token: 0x04015E1E RID: 89630
		[Nullable(1)]
		public RogueGainEntry NewRogueGainEntry;

		// Token: 0x04015E1F RID: 89631
		public RogueGainEntry OldRogueGainEntry;

		// Token: 0x04015E20 RID: 89632
		public RogueGainEntry SelectRogueGainEntry;

		// Token: 0x04015E21 RID: 89633
		public RogueGainEntry ExtraRogueGainEntry;

		// Token: 0x04015E22 RID: 89634
		public bool IsShowCommon;

		// Token: 0x04015E23 RID: 89635
		public Action CallBack;
	}
}
