using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C43 RID: 19523
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillCdData
	{
		// Token: 0x06030BD4 RID: 199636 RVA: 0x00D97C46 File Offset: 0x00D95E46
		public int GenerateCdShareGroupId(int groupId)
		{
			if (groupId == 0)
			{
				this.ShareGroupGenerator++;
				return this.ShareGroupGenerator;
			}
			return groupId;
		}

		// Token: 0x06030BD5 RID: 199637 RVA: 0x00D97C61 File Offset: 0x00D95E61
		public void Clear()
		{
			this.SkillId2GroupIdMap.Clear();
			this.GroupSkillCdInfoMap.Clear();
			this.ShareGroupGenerator = 0;
		}

		// Token: 0x04019CCD RID: 105677
		public readonly Dictionary<int, int> SkillId2GroupIdMap = new Dictionary<int, int>();

		// Token: 0x04019CCE RID: 105678
		public readonly Dictionary<int, GroupSkillCdInfo> GroupSkillCdInfoMap = new Dictionary<int, GroupSkillCdInfo>();

		// Token: 0x04019CCF RID: 105679
		private int ShareGroupGenerator;

		// Token: 0x04019CD0 RID: 105680
		public readonly Dictionary<int, List<long>> ServerSkillCd = new Dictionary<int, List<long>>();

		// Token: 0x04019CD1 RID: 105681
		public readonly Dictionary<int, List<long>> ServerGroupSkillCd = new Dictionary<int, List<long>>();

		// Token: 0x04019CD2 RID: 105682
		public bool NeedTick = true;
	}
}
