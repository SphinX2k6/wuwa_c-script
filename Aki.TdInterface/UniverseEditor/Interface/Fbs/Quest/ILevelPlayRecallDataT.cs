using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004341 RID: 17217
	public class ILevelPlayRecallDataT
	{
		// Token: 0x170075D5 RID: 30165
		// (get) Token: 0x060183BB RID: 99259 RVA: 0x003743D1 File Offset: 0x003725D1
		// (set) Token: 0x060183BC RID: 99260 RVA: 0x003743D9 File Offset: 0x003725D9
		public ERecallDataType Type { get; set; }

		// Token: 0x170075D6 RID: 30166
		// (get) Token: 0x060183BD RID: 99261 RVA: 0x003743E2 File Offset: 0x003725E2
		// (set) Token: 0x060183BE RID: 99262 RVA: 0x003743EA File Offset: 0x003725EA
		public int Id { get; set; }

		// Token: 0x170075D7 RID: 30167
		// (get) Token: 0x060183BF RID: 99263 RVA: 0x003743F3 File Offset: 0x003725F3
		// (set) Token: 0x060183C0 RID: 99264 RVA: 0x003743FB File Offset: 0x003725FB
		public ILevelPlayRecallConfigT RecallConfig { get; set; }

		// Token: 0x060183C1 RID: 99265 RVA: 0x00374404 File Offset: 0x00372604
		public ILevelPlayRecallDataT()
		{
			this.Type = ERecallDataType.LevelPlay;
			this.Id = 0;
			this.RecallConfig = null;
		}
	}
}
