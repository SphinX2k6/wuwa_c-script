using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BF0 RID: 15344
	[NullableContext(1)]
	public interface ISheriffSubTabItemData
	{
		// Token: 0x1700505C RID: 20572
		// (get) Token: 0x06027587 RID: 161159
		// (set) Token: 0x06027588 RID: 161160
		ESheriffSubTabType TabType { get; set; }

		// Token: 0x1700505D RID: 20573
		// (get) Token: 0x06027589 RID: 161161
		// (set) Token: 0x0602758A RID: 161162
		string TabIcon { get; set; }

		// Token: 0x1700505E RID: 20574
		// (get) Token: 0x0602758B RID: 161163
		// (set) Token: 0x0602758C RID: 161164
		string TabTxt { get; set; }

		// Token: 0x1700505F RID: 20575
		// (get) Token: 0x0602758D RID: 161165
		// (set) Token: 0x0602758E RID: 161166
		bool IsFinished { get; set; }
	}
}
