using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC5 RID: 20421
	public class ICombatComponentT
	{
		// Token: 0x170093E5 RID: 37861
		// (get) Token: 0x0602082D RID: 133165 RVA: 0x00485954 File Offset: 0x00483B54
		// (set) Token: 0x0602082E RID: 133166 RVA: 0x0048595C File Offset: 0x00483B5C
		public bool Disabled { get; set; }

		// Token: 0x170093E6 RID: 37862
		// (get) Token: 0x0602082F RID: 133167 RVA: 0x00485965 File Offset: 0x00483B65
		// (set) Token: 0x06020830 RID: 133168 RVA: 0x0048596D File Offset: 0x00483B6D
		public byte NullMask { get; set; }

		// Token: 0x06020831 RID: 133169 RVA: 0x00485976 File Offset: 0x00483B76
		public ICombatComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
