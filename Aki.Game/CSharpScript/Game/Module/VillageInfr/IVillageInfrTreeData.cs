using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003805 RID: 14341
	public interface IVillageInfrTreeData
	{
		// Token: 0x17004C98 RID: 19608
		// (get) Token: 0x0602549B RID: 152731
		// (set) Token: 0x0602549C RID: 152732
		int Id { get; set; }

		// Token: 0x17004C99 RID: 19609
		// (get) Token: 0x0602549D RID: 152733
		// (set) Token: 0x0602549E RID: 152734
		InfrV2StatusPb Status { get; set; }

		// Token: 0x17004C9A RID: 19610
		// (get) Token: 0x0602549F RID: 152735
		// (set) Token: 0x060254A0 RID: 152736
		long CompleteTime { get; set; }
	}
}
