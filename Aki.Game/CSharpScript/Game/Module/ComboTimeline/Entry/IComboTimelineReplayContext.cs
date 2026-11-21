using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02004B7F RID: 19327
	[NullableContext(2)]
	public interface IComboTimelineReplayContext
	{
		// Token: 0x06030471 RID: 197745
		int? GetMainControlEntityId();

		// Token: 0x06030472 RID: 197746
		Entity GetMainControlEntity();

		// Token: 0x06030473 RID: 197747
		int GetCurrentFrame();
	}
}
