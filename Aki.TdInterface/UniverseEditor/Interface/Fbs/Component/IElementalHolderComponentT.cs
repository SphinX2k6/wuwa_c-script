using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200512D RID: 20781
	public class IElementalHolderComponentT
	{
		// Token: 0x1700977D RID: 38781
		// (get) Token: 0x06021846 RID: 137286 RVA: 0x004A76BD File Offset: 0x004A58BD
		// (set) Token: 0x06021847 RID: 137287 RVA: 0x004A76C5 File Offset: 0x004A58C5
		public bool Disabled { get; set; }

		// Token: 0x1700977E RID: 38782
		// (get) Token: 0x06021848 RID: 137288 RVA: 0x004A76CE File Offset: 0x004A58CE
		// (set) Token: 0x06021849 RID: 137289 RVA: 0x004A76D6 File Offset: 0x004A58D6
		public IElementalAbilityConfigT AbilityConfig { get; set; }

		// Token: 0x1700977F RID: 38783
		// (get) Token: 0x0602184A RID: 137290 RVA: 0x004A76DF File Offset: 0x004A58DF
		// (set) Token: 0x0602184B RID: 137291 RVA: 0x004A76E7 File Offset: 0x004A58E7
		public byte NullMask { get; set; }

		// Token: 0x0602184C RID: 137292 RVA: 0x004A76F0 File Offset: 0x004A58F0
		public IElementalHolderComponentT()
		{
			this.Disabled = false;
			this.AbilityConfig = null;
			this.NullMask = 0;
		}
	}
}
