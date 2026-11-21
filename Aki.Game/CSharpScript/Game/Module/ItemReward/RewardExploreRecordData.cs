using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020047A8 RID: 18344
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreRecordData : IRewardExploreRecord
	{
		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x0602E18C RID: 188812 RVA: 0x00CDEF9E File Offset: 0x00CDD19E
		// (set) Token: 0x0602E18D RID: 188813 RVA: 0x00CDEFA6 File Offset: 0x00CDD1A6
		public string TitleTextId { get; set; }

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x0602E18E RID: 188814 RVA: 0x00CDEFAF File Offset: 0x00CDD1AF
		// (set) Token: 0x0602E18F RID: 188815 RVA: 0x00CDEFB7 File Offset: 0x00CDD1B7
		public string Record { get; set; }

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x0602E190 RID: 188816 RVA: 0x00CDEFC0 File Offset: 0x00CDD1C0
		// (set) Token: 0x0602E191 RID: 188817 RVA: 0x00CDEFC8 File Offset: 0x00CDD1C8
		public int? RecordRollingTo { get; set; }

		// Token: 0x17005D83 RID: 23939
		// (get) Token: 0x0602E192 RID: 188818 RVA: 0x00CDEFD1 File Offset: 0x00CDD1D1
		// (set) Token: 0x0602E193 RID: 188819 RVA: 0x00CDEFD9 File Offset: 0x00CDD1D9
		public bool IsNewRecord { get; set; }
	}
}
