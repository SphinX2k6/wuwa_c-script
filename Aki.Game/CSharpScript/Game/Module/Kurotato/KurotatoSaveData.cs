using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046EA RID: 18154
	public class KurotatoSaveData : IKurotatoSaveData
	{
		// Token: 0x17005C1B RID: 23579
		// (get) Token: 0x0602D9A5 RID: 186789 RVA: 0x00CBEF5D File Offset: 0x00CBD15D
		// (set) Token: 0x0602D9A6 RID: 186790 RVA: 0x00CBEF65 File Offset: 0x00CBD165
		public long SaveTimestamp { get; set; }

		// Token: 0x17005C1C RID: 23580
		// (get) Token: 0x0602D9A7 RID: 186791 RVA: 0x00CBEF6E File Offset: 0x00CBD16E
		// (set) Token: 0x0602D9A8 RID: 186792 RVA: 0x00CBEF76 File Offset: 0x00CBD176
		public int RoleLevel { get; set; }

		// Token: 0x17005C1D RID: 23581
		// (get) Token: 0x0602D9A9 RID: 186793 RVA: 0x00CBEF7F File Offset: 0x00CBD17F
		// (set) Token: 0x0602D9AA RID: 186794 RVA: 0x00CBEF87 File Offset: 0x00CBD187
		public int WaveNum { get; set; }
	}
}
