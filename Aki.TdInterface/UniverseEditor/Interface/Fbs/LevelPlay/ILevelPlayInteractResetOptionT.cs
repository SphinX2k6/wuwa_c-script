using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004501 RID: 17665
	public class ILevelPlayInteractResetOptionT
	{
		// Token: 0x17007D39 RID: 32057
		// (get) Token: 0x0601A87B RID: 108667 RVA: 0x003C9F20 File Offset: 0x003C8120
		// (set) Token: 0x0601A87C RID: 108668 RVA: 0x003C9F28 File Offset: 0x003C8128
		public int Count { get; set; }

		// Token: 0x17007D3A RID: 32058
		// (get) Token: 0x0601A87D RID: 108669 RVA: 0x003C9F31 File Offset: 0x003C8131
		// (set) Token: 0x0601A87E RID: 108670 RVA: 0x003C9F39 File Offset: 0x003C8139
		public ELevelPlayInteractResetTime Type { get; set; }

		// Token: 0x0601A87F RID: 108671 RVA: 0x003C9F42 File Offset: 0x003C8142
		public ILevelPlayInteractResetOptionT()
		{
			this.Count = 0;
			this.Type = ELevelPlayInteractResetTime.Weekly;
		}
	}
}
