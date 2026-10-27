using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ComboTimeline.Entry
{
	// Token: 0x02005B9F RID: 23455
	[NullableContext(2)]
	public interface IComboTimelineReplayContext
	{
		// Token: 0x0603B524 RID: 242980
		int? GetMainControlEntityId();

		// Token: 0x0603B525 RID: 242981
		Entity GetMainControlEntity();

		// Token: 0x0603B526 RID: 242982
		int GetCurrentFrame();
	}
}
