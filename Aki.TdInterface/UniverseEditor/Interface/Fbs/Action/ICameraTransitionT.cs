using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691A RID: 26906
	public class ICameraTransitionT
	{
		// Token: 0x1700C60F RID: 50703
		// (get) Token: 0x0602E1A2 RID: 188834 RVA: 0x0064CB62 File Offset: 0x0064AD62
		// (set) Token: 0x0602E1A3 RID: 188835 RVA: 0x0064CB6A File Offset: 0x0064AD6A
		public ELevelSequenceTransition Type { get; set; }

		// Token: 0x1700C610 RID: 50704
		// (get) Token: 0x0602E1A4 RID: 188836 RVA: 0x0064CB73 File Offset: 0x0064AD73
		// (set) Token: 0x0602E1A5 RID: 188837 RVA: 0x0064CB7B File Offset: 0x0064AD7B
		public float Duration { get; set; }

		// Token: 0x1700C611 RID: 50705
		// (get) Token: 0x0602E1A6 RID: 188838 RVA: 0x0064CB84 File Offset: 0x0064AD84
		// (set) Token: 0x0602E1A7 RID: 188839 RVA: 0x0064CB8C File Offset: 0x0064AD8C
		public byte NullMask { get; set; }

		// Token: 0x0602E1A8 RID: 188840 RVA: 0x0064CB95 File Offset: 0x0064AD95
		public ICameraTransitionT()
		{
			this.Type = ELevelSequenceTransition.Camera;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
