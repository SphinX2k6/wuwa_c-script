using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200642E RID: 25646
	public class ICloseSimpleGameplayT
	{
		// Token: 0x1700BEF8 RID: 48888
		// (get) Token: 0x0602C620 RID: 181792 RVA: 0x00616EAD File Offset: 0x006150AD
		// (set) Token: 0x0602C621 RID: 181793 RVA: 0x00616EB5 File Offset: 0x006150B5
		public TCloseUiGameUnion GameplayConfig { get; set; }

		// Token: 0x0602C622 RID: 181794 RVA: 0x00616EBE File Offset: 0x006150BE
		public ICloseSimpleGameplayT()
		{
			this.GameplayConfig = null;
		}
	}
}
