using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A4A RID: 19018
	[NullableContext(1)]
	public interface ITrapDefenseBuildingDevelopTabData
	{
		// Token: 0x17007A50 RID: 31312
		// (get) Token: 0x06031597 RID: 202135
		// (set) Token: 0x06031598 RID: 202136
		ETrapDefenseBuildingDevelopTab TabType { get; set; }

		// Token: 0x17007A51 RID: 31313
		// (get) Token: 0x06031599 RID: 202137
		// (set) Token: 0x0603159A RID: 202138
		string Icon { get; set; }

		// Token: 0x17007A52 RID: 31314
		// (get) Token: 0x0603159B RID: 202139
		// (set) Token: 0x0603159C RID: 202140
		string TabName { get; set; }

		// Token: 0x17007A53 RID: 31315
		// (get) Token: 0x0603159D RID: 202141
		// (set) Token: 0x0603159E RID: 202142
		ERedDotName? RedDot { get; set; }
	}
}
