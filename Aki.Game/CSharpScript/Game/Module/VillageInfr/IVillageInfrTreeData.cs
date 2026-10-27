using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200488E RID: 18574
	public interface IVillageInfrTreeData
	{
		// Token: 0x17007930 RID: 31024
		// (get) Token: 0x0603096F RID: 199023
		// (set) Token: 0x06030970 RID: 199024
		int Id { get; set; }

		// Token: 0x17007931 RID: 31025
		// (get) Token: 0x06030971 RID: 199025
		// (set) Token: 0x06030972 RID: 199026
		InfrV2StatusPb Status { get; set; }

		// Token: 0x17007932 RID: 31026
		// (get) Token: 0x06030973 RID: 199027
		// (set) Token: 0x06030974 RID: 199028
		long CompleteTime { get; set; }
	}
}
