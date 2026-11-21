using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039F2 RID: 14834
	[NullableContext(1)]
	public interface ITrapDefenseBuildingDevelopTabData
	{
		// Token: 0x17004DFD RID: 19965
		// (get) Token: 0x06026327 RID: 156455
		// (set) Token: 0x06026328 RID: 156456
		ETrapDefenseBuildingDevelopTab TabType { get; set; }

		// Token: 0x17004DFE RID: 19966
		// (get) Token: 0x06026329 RID: 156457
		// (set) Token: 0x0602632A RID: 156458
		string Icon { get; set; }

		// Token: 0x17004DFF RID: 19967
		// (get) Token: 0x0602632B RID: 156459
		// (set) Token: 0x0602632C RID: 156460
		string TabName { get; set; }

		// Token: 0x17004E00 RID: 19968
		// (get) Token: 0x0602632D RID: 156461
		// (set) Token: 0x0602632E RID: 156462
		ERedDotName? RedDot { get; set; }
	}
}
