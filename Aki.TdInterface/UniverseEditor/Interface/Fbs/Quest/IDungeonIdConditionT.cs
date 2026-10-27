using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DE9 RID: 15849
	public class IDungeonIdConditionT
	{
		// Token: 0x17006D79 RID: 28025
		// (get) Token: 0x06016259 RID: 90713 RVA: 0x00333372 File Offset: 0x00331572
		// (set) Token: 0x0601625A RID: 90714 RVA: 0x0033337A File Offset: 0x0033157A
		public EDungeonConditionType Type { get; set; }

		// Token: 0x17006D7A RID: 28026
		// (get) Token: 0x0601625B RID: 90715 RVA: 0x00333383 File Offset: 0x00331583
		// (set) Token: 0x0601625C RID: 90716 RVA: 0x0033338B File Offset: 0x0033158B
		public int Count { get; set; }

		// Token: 0x17006D7B RID: 28027
		// (get) Token: 0x0601625D RID: 90717 RVA: 0x00333394 File Offset: 0x00331594
		// (set) Token: 0x0601625E RID: 90718 RVA: 0x0033339C File Offset: 0x0033159C
		public bool IsExitDungeon { get; set; }

		// Token: 0x17006D7C RID: 28028
		// (get) Token: 0x0601625F RID: 90719 RVA: 0x003333A5 File Offset: 0x003315A5
		// (set) Token: 0x06016260 RID: 90720 RVA: 0x003333AD File Offset: 0x003315AD
		public int DungeonId { get; set; }

		// Token: 0x17006D7D RID: 28029
		// (get) Token: 0x06016261 RID: 90721 RVA: 0x003333B6 File Offset: 0x003315B6
		// (set) Token: 0x06016262 RID: 90722 RVA: 0x003333BE File Offset: 0x003315BE
		public byte NullMask { get; set; }

		// Token: 0x06016263 RID: 90723 RVA: 0x003333C7 File Offset: 0x003315C7
		public IDungeonIdConditionT()
		{
			this.Type = EDungeonConditionType.DungeonSubType;
			this.Count = 0;
			this.IsExitDungeon = false;
			this.DungeonId = 0;
			this.NullMask = 0;
		}
	}
}
