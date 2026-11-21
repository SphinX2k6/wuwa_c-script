using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044C7 RID: 17607
	public class IRecallDataT
	{
		// Token: 0x17007A95 RID: 31381
		// (get) Token: 0x06019716 RID: 104214 RVA: 0x003A147C File Offset: 0x0039F67C
		// (set) Token: 0x06019717 RID: 104215 RVA: 0x003A1484 File Offset: 0x0039F684
		public ERecallDataType Type { get; set; }

		// Token: 0x17007A96 RID: 31382
		// (get) Token: 0x06019718 RID: 104216 RVA: 0x003A148D File Offset: 0x0039F68D
		// (set) Token: 0x06019719 RID: 104217 RVA: 0x003A1495 File Offset: 0x0039F695
		public int Id { get; set; }

		// Token: 0x0601971A RID: 104218 RVA: 0x003A149E File Offset: 0x0039F69E
		public IRecallDataT()
		{
			this.Type = ERecallDataType.LevelPlay;
			this.Id = 0;
		}
	}
}
