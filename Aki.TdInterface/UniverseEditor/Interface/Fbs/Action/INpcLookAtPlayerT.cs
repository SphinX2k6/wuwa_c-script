using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCE RID: 27598
	public class INpcLookAtPlayerT
	{
		// Token: 0x1700CD1A RID: 52506
		// (get) Token: 0x060307C6 RID: 198598 RVA: 0x00695692 File Offset: 0x00693892
		// (set) Token: 0x060307C7 RID: 198599 RVA: 0x0069569A File Offset: 0x0069389A
		public ECommonTargetType Type { get; set; }

		// Token: 0x060307C8 RID: 198600 RVA: 0x006956A3 File Offset: 0x006938A3
		public INpcLookAtPlayerT()
		{
			this.Type = ECommonTargetType.Player;
		}
	}
}
