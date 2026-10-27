using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057D1 RID: 22481
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreRecordData : IRewardExploreRecord
	{
		// Token: 0x170089B6 RID: 35254
		// (get) Token: 0x06039278 RID: 234104 RVA: 0x00D90155 File Offset: 0x00D8E355
		// (set) Token: 0x06039279 RID: 234105 RVA: 0x00D9015D File Offset: 0x00D8E35D
		public string TitleTextId { get; set; }

		// Token: 0x170089B7 RID: 35255
		// (get) Token: 0x0603927A RID: 234106 RVA: 0x00D90166 File Offset: 0x00D8E366
		// (set) Token: 0x0603927B RID: 234107 RVA: 0x00D9016E File Offset: 0x00D8E36E
		public string Record { get; set; }

		// Token: 0x170089B8 RID: 35256
		// (get) Token: 0x0603927C RID: 234108 RVA: 0x00D90177 File Offset: 0x00D8E377
		// (set) Token: 0x0603927D RID: 234109 RVA: 0x00D9017F File Offset: 0x00D8E37F
		public int? RecordRollingTo { get; set; }

		// Token: 0x170089B9 RID: 35257
		// (get) Token: 0x0603927E RID: 234110 RVA: 0x00D90188 File Offset: 0x00D8E388
		// (set) Token: 0x0603927F RID: 234111 RVA: 0x00D90190 File Offset: 0x00D8E390
		public bool IsNewRecord { get; set; }
	}
}
