using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DEC RID: 15852
	public class IDungeonSubTypeConditionT
	{
		// Token: 0x17006D84 RID: 28036
		// (get) Token: 0x0601627B RID: 90747 RVA: 0x0033371E File Offset: 0x0033191E
		// (set) Token: 0x0601627C RID: 90748 RVA: 0x00333726 File Offset: 0x00331926
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17006D85 RID: 28037
		// (get) Token: 0x0601627D RID: 90749 RVA: 0x0033372F File Offset: 0x0033192F
		// (set) Token: 0x0601627E RID: 90750 RVA: 0x00333737 File Offset: 0x00331937
		public int Count { get; set; }

		// Token: 0x17006D86 RID: 28038
		// (get) Token: 0x0601627F RID: 90751 RVA: 0x00333740 File Offset: 0x00331940
		// (set) Token: 0x06016280 RID: 90752 RVA: 0x00333748 File Offset: 0x00331948
		public bool IsExitDungeon { get; set; }

		// Token: 0x17006D87 RID: 28039
		// (get) Token: 0x06016281 RID: 90753 RVA: 0x00333751 File Offset: 0x00331951
		// (set) Token: 0x06016282 RID: 90754 RVA: 0x00333759 File Offset: 0x00331959
		public EDungeonSubType DungeonSubType { get; set; }

		// Token: 0x17006D88 RID: 28040
		// (get) Token: 0x06016283 RID: 90755 RVA: 0x00333762 File Offset: 0x00331962
		// (set) Token: 0x06016284 RID: 90756 RVA: 0x0033376A File Offset: 0x0033196A
		public byte NullMask { get; set; }

		// Token: 0x06016285 RID: 90757 RVA: 0x00333773 File Offset: 0x00331973
		public IDungeonSubTypeConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.Count = 0;
			this.IsExitDungeon = false;
			this.DungeonSubType = EDungeonSubType.Test;
			this.NullMask = 0;
		}
	}
}
