using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C7 RID: 17095
	public class TCsvTetrisBoardDataT
	{
		// Token: 0x1700793C RID: 31036
		// (get) Token: 0x060195BB RID: 103867 RVA: 0x003A38A7 File Offset: 0x003A1AA7
		// (set) Token: 0x060195BC RID: 103868 RVA: 0x003A38AF File Offset: 0x003A1AAF
		public int Id { get; set; }

		// Token: 0x1700793D RID: 31037
		// (get) Token: 0x060195BD RID: 103869 RVA: 0x003A38B8 File Offset: 0x003A1AB8
		// (set) Token: 0x060195BE RID: 103870 RVA: 0x003A38C0 File Offset: 0x003A1AC0
		public ITetrisBoardT Data { get; set; }

		// Token: 0x060195BF RID: 103871 RVA: 0x003A38C9 File Offset: 0x003A1AC9
		public TCsvTetrisBoardDataT()
		{
			this.Id = 0;
			this.Data = null;
		}
	}
}
