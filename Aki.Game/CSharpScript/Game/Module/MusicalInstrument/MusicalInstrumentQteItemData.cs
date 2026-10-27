using System;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005375 RID: 21365
	public class MusicalInstrumentQteItemData
	{
		// Token: 0x1700835A RID: 33626
		// (get) Token: 0x06036957 RID: 223575 RVA: 0x00CECB75 File Offset: 0x00CEAD75
		// (set) Token: 0x06036958 RID: 223576 RVA: 0x00CECB7D File Offset: 0x00CEAD7D
		public int RowIndex { get; set; }

		// Token: 0x1700835B RID: 33627
		// (get) Token: 0x06036959 RID: 223577 RVA: 0x00CECB86 File Offset: 0x00CEAD86
		// (set) Token: 0x0603695A RID: 223578 RVA: 0x00CECB8E File Offset: 0x00CEAD8E
		public int ColumnIndex { get; set; }

		// Token: 0x1700835C RID: 33628
		// (get) Token: 0x0603695B RID: 223579 RVA: 0x00CECB97 File Offset: 0x00CEAD97
		// (set) Token: 0x0603695C RID: 223580 RVA: 0x00CECB9F File Offset: 0x00CEAD9F
		public bool Finished { get; set; }

		// Token: 0x1700835D RID: 33629
		// (get) Token: 0x0603695D RID: 223581 RVA: 0x00CECBA8 File Offset: 0x00CEADA8
		// (set) Token: 0x0603695E RID: 223582 RVA: 0x00CECBB0 File Offset: 0x00CEADB0
		public bool IsFocus { get; set; }
	}
}
