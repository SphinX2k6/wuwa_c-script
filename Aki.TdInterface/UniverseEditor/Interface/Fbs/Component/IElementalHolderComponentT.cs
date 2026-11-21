using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005692 RID: 22162
	public class IElementalHolderComponentT
	{
		// Token: 0x17009F6A RID: 40810
		// (get) Token: 0x0602379A RID: 145306 RVA: 0x004E1649 File Offset: 0x004DF849
		// (set) Token: 0x0602379B RID: 145307 RVA: 0x004E1651 File Offset: 0x004DF851
		public bool Disabled { get; set; }

		// Token: 0x17009F6B RID: 40811
		// (get) Token: 0x0602379C RID: 145308 RVA: 0x004E165A File Offset: 0x004DF85A
		// (set) Token: 0x0602379D RID: 145309 RVA: 0x004E1662 File Offset: 0x004DF862
		public IElementalAbilityConfigT AbilityConfig { get; set; }

		// Token: 0x17009F6C RID: 40812
		// (get) Token: 0x0602379E RID: 145310 RVA: 0x004E166B File Offset: 0x004DF86B
		// (set) Token: 0x0602379F RID: 145311 RVA: 0x004E1673 File Offset: 0x004DF873
		public byte NullMask { get; set; }

		// Token: 0x060237A0 RID: 145312 RVA: 0x004E167C File Offset: 0x004DF87C
		public IElementalHolderComponentT()
		{
			this.Disabled = false;
			this.AbilityConfig = null;
			this.NullMask = 0;
		}
	}
}
