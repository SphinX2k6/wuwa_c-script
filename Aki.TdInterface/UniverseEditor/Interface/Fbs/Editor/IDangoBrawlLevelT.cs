using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.LevelPlay;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB3 RID: 19635
	public class IDangoBrawlLevelT
	{
		// Token: 0x17008B28 RID: 35624
		// (get) Token: 0x0601E21B RID: 123419 RVA: 0x00438CFD File Offset: 0x00436EFD
		// (set) Token: 0x0601E21C RID: 123420 RVA: 0x00438D05 File Offset: 0x00436F05
		public int Id { get; set; }

		// Token: 0x17008B29 RID: 35625
		// (get) Token: 0x0601E21D RID: 123421 RVA: 0x00438D0E File Offset: 0x00436F0E
		// (set) Token: 0x0601E21E RID: 123422 RVA: 0x00438D16 File Offset: 0x00436F16
		public ETwoDimensionLevelType Type { get; set; }

		// Token: 0x17008B2A RID: 35626
		// (get) Token: 0x0601E21F RID: 123423 RVA: 0x00438D1F File Offset: 0x00436F1F
		// (set) Token: 0x0601E220 RID: 123424 RVA: 0x00438D27 File Offset: 0x00436F27
		public List<TTwoDimensionItemUnion> ItemList { get; set; }

		// Token: 0x0601E221 RID: 123425 RVA: 0x00438D30 File Offset: 0x00436F30
		public IDangoBrawlLevelT()
		{
			this.Id = 0;
			this.Type = ETwoDimensionLevelType.Marble;
			this.ItemList = null;
		}
	}
}
