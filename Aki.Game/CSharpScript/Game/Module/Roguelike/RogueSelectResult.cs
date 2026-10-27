using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DA3 RID: 19875
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueSelectResult
	{
		// Token: 0x06033520 RID: 210208 RVA: 0x00BFA84C File Offset: 0x00BF8A4C
		public RogueSelectResult([Nullable(1)] RogueGainEntry newRogueGainEntry, RogueGainEntry oldRogueGainEntry, RogueGainEntry selectRogueGainEntry, bool isShowCommon = false)
		{
			this.NewRogueGainEntry = newRogueGainEntry;
			this.OldRogueGainEntry = oldRogueGainEntry;
			this.SelectRogueGainEntry = selectRogueGainEntry;
			this.IsShowCommon = isShowCommon;
		}

		// Token: 0x06033521 RID: 210209 RVA: 0x00BFA874 File Offset: 0x00BF8A74
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

		// Token: 0x0401B44B RID: 111691
		[Nullable(1)]
		public RogueGainEntry NewRogueGainEntry;

		// Token: 0x0401B44C RID: 111692
		public RogueGainEntry OldRogueGainEntry;

		// Token: 0x0401B44D RID: 111693
		public RogueGainEntry SelectRogueGainEntry;

		// Token: 0x0401B44E RID: 111694
		public RogueGainEntry ExtraRogueGainEntry;

		// Token: 0x0401B44F RID: 111695
		public bool IsShowCommon;

		// Token: 0x0401B450 RID: 111696
		public Action CallBack;
	}
}
