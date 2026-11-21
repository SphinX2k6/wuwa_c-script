using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x02004460 RID: 17504
	[NullableContext(1)]
	public interface IEventData
	{
		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x0602C244 RID: 180804
		// (set) Token: 0x0602C245 RID: 180805
		string EventName { get; set; }

		// Token: 0x17005829 RID: 22569
		// (get) Token: 0x0602C246 RID: 180806
		// (set) Token: 0x0602C247 RID: 180807
		string EventType { get; set; }

		// Token: 0x1700582A RID: 22570
		// (get) Token: 0x0602C248 RID: 180808
		// (set) Token: 0x0602C249 RID: 180809
		bool IsAnimNotifyState { get; set; }

		// Token: 0x1700582B RID: 22571
		// (get) Token: 0x0602C24A RID: 180810
		// (set) Token: 0x0602C24B RID: 180811
		int StartFrame { get; set; }

		// Token: 0x1700582C RID: 22572
		// (get) Token: 0x0602C24C RID: 180812
		// (set) Token: 0x0602C24D RID: 180813
		int EndFrame { get; set; }

		// Token: 0x1700582D RID: 22573
		// (get) Token: 0x0602C24E RID: 180814
		// (set) Token: 0x0602C24F RID: 180815
		int RowIndex { get; set; }
	}
}
