using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006851 RID: 26705
	public class IBasePos2T
	{
		// Token: 0x1700C45B RID: 50267
		// (get) Token: 0x0602DA64 RID: 186980 RVA: 0x0063EA3A File Offset: 0x0063CC3A
		// (set) Token: 0x0602DA65 RID: 186981 RVA: 0x0063EA42 File Offset: 0x0063CC42
		public EPos2 Type { get; set; }

		// Token: 0x0602DA66 RID: 186982 RVA: 0x0063EA4B File Offset: 0x0063CC4B
		public IBasePos2T()
		{
			this.Type = EPos2.Player;
		}
	}
}
