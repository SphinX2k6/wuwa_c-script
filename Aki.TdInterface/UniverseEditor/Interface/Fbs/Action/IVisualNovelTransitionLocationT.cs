using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E7 RID: 30183
	public class IVisualNovelTransitionLocationT
	{
		// Token: 0x1700E54B RID: 58699
		// (get) Token: 0x06036FB2 RID: 225202 RVA: 0x00775F34 File Offset: 0x00774134
		// (set) Token: 0x06036FB3 RID: 225203 RVA: 0x00775F3C File Offset: 0x0077413C
		public EVisualNovelTransitionType Type { get; set; }

		// Token: 0x1700E54C RID: 58700
		// (get) Token: 0x06036FB4 RID: 225204 RVA: 0x00775F45 File Offset: 0x00774145
		// (set) Token: 0x06036FB5 RID: 225205 RVA: 0x00775F4D File Offset: 0x0077414D
		public int LocationId { get; set; }

		// Token: 0x1700E54D RID: 58701
		// (get) Token: 0x06036FB6 RID: 225206 RVA: 0x00775F56 File Offset: 0x00774156
		// (set) Token: 0x06036FB7 RID: 225207 RVA: 0x00775F5E File Offset: 0x0077415E
		public int TransitionBackgroundId { get; set; }

		// Token: 0x1700E54E RID: 58702
		// (get) Token: 0x06036FB8 RID: 225208 RVA: 0x00775F67 File Offset: 0x00774167
		// (set) Token: 0x06036FB9 RID: 225209 RVA: 0x00775F6F File Offset: 0x0077416F
		public byte NullMask { get; set; }

		// Token: 0x06036FBA RID: 225210 RVA: 0x00775F78 File Offset: 0x00774178
		public IVisualNovelTransitionLocationT()
		{
			this.Type = EVisualNovelTransitionType.Location;
			this.LocationId = 0;
			this.TransitionBackgroundId = 0;
			this.NullMask = 0;
		}
	}
}
