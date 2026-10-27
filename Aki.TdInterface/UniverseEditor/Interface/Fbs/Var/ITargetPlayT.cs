using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE5 RID: 15077
	public class ITargetPlayT
	{
		// Token: 0x1700676F RID: 26479
		// (get) Token: 0x060148B0 RID: 84144 RVA: 0x002FDEE2 File Offset: 0x002FC0E2
		// (set) Token: 0x060148B1 RID: 84145 RVA: 0x002FDEEA File Offset: 0x002FC0EA
		public ETargetType Type { get; set; }

		// Token: 0x060148B2 RID: 84146 RVA: 0x002FDEF3 File Offset: 0x002FC0F3
		public ITargetPlayT()
		{
			this.Type = ETargetType.Player;
		}
	}
}
