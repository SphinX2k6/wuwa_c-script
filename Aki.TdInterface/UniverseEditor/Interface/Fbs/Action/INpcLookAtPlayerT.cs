using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007332 RID: 29490
	public class INpcLookAtPlayerT
	{
		// Token: 0x1700D826 RID: 55334
		// (get) Token: 0x060336E2 RID: 210658 RVA: 0x006EEF92 File Offset: 0x006ED192
		// (set) Token: 0x060336E3 RID: 210659 RVA: 0x006EEF9A File Offset: 0x006ED19A
		public ECommonTargetType Type { get; set; }

		// Token: 0x060336E4 RID: 210660 RVA: 0x006EEFA3 File Offset: 0x006ED1A3
		public INpcLookAtPlayerT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
