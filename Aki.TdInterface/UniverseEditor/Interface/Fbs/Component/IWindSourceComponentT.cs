using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200619D RID: 24989
	public class IWindSourceComponentT
	{
		// Token: 0x1700BA5A RID: 47706
		// (get) Token: 0x0602A78B RID: 173963 RVA: 0x005CB159 File Offset: 0x005C9359
		// (set) Token: 0x0602A78C RID: 173964 RVA: 0x005CB161 File Offset: 0x005C9361
		public bool Disabled { get; set; }

		// Token: 0x1700BA5B RID: 47707
		// (get) Token: 0x0602A78D RID: 173965 RVA: 0x005CB16A File Offset: 0x005C936A
		// (set) Token: 0x0602A78E RID: 173966 RVA: 0x005CB172 File Offset: 0x005C9372
		public IWindDirectionalT WindSource { get; set; }

		// Token: 0x1700BA5C RID: 47708
		// (get) Token: 0x0602A78F RID: 173967 RVA: 0x005CB17B File Offset: 0x005C937B
		// (set) Token: 0x0602A790 RID: 173968 RVA: 0x005CB183 File Offset: 0x005C9383
		public byte NullMask { get; set; }

		// Token: 0x0602A791 RID: 173969 RVA: 0x005CB18C File Offset: 0x005C938C
		public IWindSourceComponentT()
		{
			this.Disabled = false;
			this.WindSource = null;
			this.NullMask = 0;
		}
	}
}
