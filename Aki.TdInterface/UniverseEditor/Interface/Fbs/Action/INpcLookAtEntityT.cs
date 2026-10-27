using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCB RID: 27595
	public class INpcLookAtEntityT
	{
		// Token: 0x1700CD16 RID: 52502
		// (get) Token: 0x060307B2 RID: 198578 RVA: 0x006954F4 File Offset: 0x006936F4
		// (set) Token: 0x060307B3 RID: 198579 RVA: 0x006954FC File Offset: 0x006936FC
		public ECommonTargetType Type { get; set; }

		// Token: 0x1700CD17 RID: 52503
		// (get) Token: 0x060307B4 RID: 198580 RVA: 0x00695505 File Offset: 0x00693705
		// (set) Token: 0x060307B5 RID: 198581 RVA: 0x0069550D File Offset: 0x0069370D
		public int EntityId { get; set; }

		// Token: 0x060307B6 RID: 198582 RVA: 0x00695516 File Offset: 0x00693716
		public INpcLookAtEntityT()
		{
			this.Type = ECommonTargetType.Player;
			this.EntityId = 0;
		}
	}
}
