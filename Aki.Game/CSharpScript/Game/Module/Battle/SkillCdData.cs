using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C63 RID: 23651
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillCdData
	{
		// Token: 0x0603BC89 RID: 244873 RVA: 0x00E47866 File Offset: 0x00E45A66
		public int GenerateCdShareGroupId(int groupId)
		{
			if (groupId == 0)
			{
				this.ShareGroupGenerator++;
				return this.ShareGroupGenerator;
			}
			return groupId;
		}

		// Token: 0x0603BC8A RID: 244874 RVA: 0x00E47881 File Offset: 0x00E45A81
		public void Clear()
		{
			this.SkillId2GroupIdMap.Clear();
			this.GroupSkillCdInfoMap.Clear();
			this.ShareGroupGenerator = 0;
		}

		// Token: 0x0401F21C RID: 127516
		public readonly Dictionary<int, int> SkillId2GroupIdMap = new Dictionary<int, int>();

		// Token: 0x0401F21D RID: 127517
		public readonly Dictionary<int, GroupSkillCdInfo> GroupSkillCdInfoMap = new Dictionary<int, GroupSkillCdInfo>();

		// Token: 0x0401F21E RID: 127518
		private int ShareGroupGenerator;

		// Token: 0x0401F21F RID: 127519
		public readonly Dictionary<int, List<long>> ServerSkillCd = new Dictionary<int, List<long>>();

		// Token: 0x0401F220 RID: 127520
		public readonly Dictionary<int, List<long>> ServerGroupSkillCd = new Dictionary<int, List<long>>();

		// Token: 0x0401F221 RID: 127521
		public bool NeedTick = true;
	}
}
