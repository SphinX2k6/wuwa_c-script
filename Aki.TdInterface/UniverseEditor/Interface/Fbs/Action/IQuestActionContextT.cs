using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF9 RID: 28153
	public class IQuestActionContextT
	{
		// Token: 0x1700D1D6 RID: 53718
		// (get) Token: 0x06031BBD RID: 203709 RVA: 0x006BBE79 File Offset: 0x006BA079
		// (set) Token: 0x06031BBE RID: 203710 RVA: 0x006BBE81 File Offset: 0x006BA081
		public string Type { get; set; }

		// Token: 0x1700D1D7 RID: 53719
		// (get) Token: 0x06031BBF RID: 203711 RVA: 0x006BBE8A File Offset: 0x006BA08A
		// (set) Token: 0x06031BC0 RID: 203712 RVA: 0x006BBE92 File Offset: 0x006BA092
		public bool IsChildQuestOfDungeon { get; set; }

		// Token: 0x1700D1D8 RID: 53720
		// (get) Token: 0x06031BC1 RID: 203713 RVA: 0x006BBE9B File Offset: 0x006BA09B
		// (set) Token: 0x06031BC2 RID: 203714 RVA: 0x006BBEA3 File Offset: 0x006BA0A3
		public byte NullMask { get; set; }

		// Token: 0x06031BC3 RID: 203715 RVA: 0x006BBEAC File Offset: 0x006BA0AC
		public IQuestActionContextT()
		{
			this.Type = null;
			this.IsChildQuestOfDungeon = false;
			this.NullMask = 0;
		}
	}
}
