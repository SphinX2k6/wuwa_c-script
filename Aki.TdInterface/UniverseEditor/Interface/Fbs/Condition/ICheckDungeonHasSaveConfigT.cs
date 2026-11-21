using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E9D RID: 20125
	public class ICheckDungeonHasSaveConfigT
	{
		// Token: 0x17008F91 RID: 36753
		// (get) Token: 0x0601F309 RID: 127753 RVA: 0x0045955E File Offset: 0x0045775E
		// (set) Token: 0x0601F30A RID: 127754 RVA: 0x00459566 File Offset: 0x00457766
		public ECondition Type { get; set; }

		// Token: 0x17008F92 RID: 36754
		// (get) Token: 0x0601F30B RID: 127755 RVA: 0x0045956F File Offset: 0x0045776F
		// (set) Token: 0x0601F30C RID: 127756 RVA: 0x00459577 File Offset: 0x00457777
		public int DungeonId { get; set; }

		// Token: 0x17008F93 RID: 36755
		// (get) Token: 0x0601F30D RID: 127757 RVA: 0x00459580 File Offset: 0x00457780
		// (set) Token: 0x0601F30E RID: 127758 RVA: 0x00459588 File Offset: 0x00457788
		public bool IsHasSaveConfig { get; set; }

		// Token: 0x0601F30F RID: 127759 RVA: 0x00459591 File Offset: 0x00457791
		public ICheckDungeonHasSaveConfigT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.IsHasSaveConfig = false;
		}
	}
}
