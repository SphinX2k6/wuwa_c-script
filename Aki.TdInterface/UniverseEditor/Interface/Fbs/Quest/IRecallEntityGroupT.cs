using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200408F RID: 16527
	public class IRecallEntityGroupT
	{
		// Token: 0x170074A1 RID: 29857
		// (get) Token: 0x060180D1 RID: 98513 RVA: 0x00378114 File Offset: 0x00376314
		// (set) Token: 0x060180D2 RID: 98514 RVA: 0x0037811C File Offset: 0x0037631C
		public int Index { get; set; }

		// Token: 0x170074A2 RID: 29858
		// (get) Token: 0x060180D3 RID: 98515 RVA: 0x00378125 File Offset: 0x00376325
		// (set) Token: 0x060180D4 RID: 98516 RVA: 0x0037812D File Offset: 0x0037632D
		public string Source { get; set; }

		// Token: 0x170074A3 RID: 29859
		// (get) Token: 0x060180D5 RID: 98517 RVA: 0x00378136 File Offset: 0x00376336
		// (set) Token: 0x060180D6 RID: 98518 RVA: 0x0037813E File Offset: 0x0037633E
		public int LevelId { get; set; }

		// Token: 0x170074A4 RID: 29860
		// (get) Token: 0x060180D7 RID: 98519 RVA: 0x00378147 File Offset: 0x00376347
		// (set) Token: 0x060180D8 RID: 98520 RVA: 0x0037814F File Offset: 0x0037634F
		public List<int> Entities { get; set; }

		// Token: 0x060180D9 RID: 98521 RVA: 0x00378158 File Offset: 0x00376358
		public IRecallEntityGroupT()
		{
			this.Index = 0;
			this.Source = null;
			this.LevelId = 0;
			this.Entities = null;
		}
	}
}
