using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A1 RID: 28833
	public class ISetupMoraleSystemT
	{
		// Token: 0x1700D637 RID: 54839
		// (get) Token: 0x060330E5 RID: 209125 RVA: 0x006E2DD0 File Offset: 0x006E0FD0
		// (set) Token: 0x060330E6 RID: 209126 RVA: 0x006E2DD8 File Offset: 0x006E0FD8
		public int MoralePlayId { get; set; }

		// Token: 0x1700D638 RID: 54840
		// (get) Token: 0x060330E7 RID: 209127 RVA: 0x006E2DE1 File Offset: 0x006E0FE1
		// (set) Token: 0x060330E8 RID: 209128 RVA: 0x006E2DE9 File Offset: 0x006E0FE9
		public bool IsOn { get; set; }

		// Token: 0x060330E9 RID: 209129 RVA: 0x006E2DF2 File Offset: 0x006E0FF2
		public ISetupMoraleSystemT()
		{
			this.MoralePlayId = 0;
			this.IsOn = false;
		}
	}
}
