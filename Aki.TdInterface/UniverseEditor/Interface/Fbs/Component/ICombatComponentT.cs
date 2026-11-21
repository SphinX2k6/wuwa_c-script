using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005521 RID: 21793
	public class ICombatComponentT
	{
		// Token: 0x17009BBD RID: 39869
		// (get) Token: 0x06022721 RID: 141089 RVA: 0x004BEE38 File Offset: 0x004BD038
		// (set) Token: 0x06022722 RID: 141090 RVA: 0x004BEE40 File Offset: 0x004BD040
		public bool Disabled { get; set; }

		// Token: 0x17009BBE RID: 39870
		// (get) Token: 0x06022723 RID: 141091 RVA: 0x004BEE49 File Offset: 0x004BD049
		// (set) Token: 0x06022724 RID: 141092 RVA: 0x004BEE51 File Offset: 0x004BD051
		public byte NullMask { get; set; }

		// Token: 0x06022725 RID: 141093 RVA: 0x004BEE5A File Offset: 0x004BD05A
		public ICombatComponentT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
