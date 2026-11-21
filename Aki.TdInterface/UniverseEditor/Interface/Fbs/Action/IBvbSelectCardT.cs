using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CC RID: 26828
	public class IBvbSelectCardT
	{
		// Token: 0x1700C532 RID: 50482
		// (get) Token: 0x0602DE55 RID: 187989 RVA: 0x006454CD File Offset: 0x006436CD
		// (set) Token: 0x0602DE56 RID: 187990 RVA: 0x006454D5 File Offset: 0x006436D5
		public EBvbPlayerOperationType Type { get; set; }

		// Token: 0x1700C533 RID: 50483
		// (get) Token: 0x0602DE57 RID: 187991 RVA: 0x006454DE File Offset: 0x006436DE
		// (set) Token: 0x0602DE58 RID: 187992 RVA: 0x006454E6 File Offset: 0x006436E6
		public List<int> CardIdList { get; set; }

		// Token: 0x1700C534 RID: 50484
		// (get) Token: 0x0602DE59 RID: 187993 RVA: 0x006454EF File Offset: 0x006436EF
		// (set) Token: 0x0602DE5A RID: 187994 RVA: 0x006454F7 File Offset: 0x006436F7
		public byte NullMask { get; set; }

		// Token: 0x0602DE5B RID: 187995 RVA: 0x00645500 File Offset: 0x00643700
		public IBvbSelectCardT()
		{
			this.Type = EBvbPlayerOperationType.BvbDeploy;
			this.CardIdList = null;
			this.NullMask = 0;
		}
	}
}
