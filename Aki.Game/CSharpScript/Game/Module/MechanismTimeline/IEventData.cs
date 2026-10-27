using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MechanismTimeline
{
	// Token: 0x0200547D RID: 21629
	[NullableContext(1)]
	public interface IEventData
	{
		// Token: 0x1700845C RID: 33884
		// (get) Token: 0x060372FB RID: 226043
		// (set) Token: 0x060372FC RID: 226044
		string EventName { get; set; }

		// Token: 0x1700845D RID: 33885
		// (get) Token: 0x060372FD RID: 226045
		// (set) Token: 0x060372FE RID: 226046
		string EventType { get; set; }

		// Token: 0x1700845E RID: 33886
		// (get) Token: 0x060372FF RID: 226047
		// (set) Token: 0x06037300 RID: 226048
		bool IsAnimNotifyState { get; set; }

		// Token: 0x1700845F RID: 33887
		// (get) Token: 0x06037301 RID: 226049
		// (set) Token: 0x06037302 RID: 226050
		int StartFrame { get; set; }

		// Token: 0x17008460 RID: 33888
		// (get) Token: 0x06037303 RID: 226051
		// (set) Token: 0x06037304 RID: 226052
		int EndFrame { get; set; }

		// Token: 0x17008461 RID: 33889
		// (get) Token: 0x06037305 RID: 226053
		// (set) Token: 0x06037306 RID: 226054
		int RowIndex { get; set; }
	}
}
