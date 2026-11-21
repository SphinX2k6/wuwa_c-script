using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200363E RID: 13886
	[NullableContext(1)]
	public interface IWuWaGoTimeStopParticipant
	{
		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x0602405E RID: 147550
		// (set) Token: 0x0602405F RID: 147551
		bool PausedByTimeStop { get; set; }

		// Token: 0x06024060 RID: 147552
		void PauseByTimeStop();

		// Token: 0x06024061 RID: 147553
		void ResumeByTimeStop();

		// Token: 0x06024062 RID: 147554
		void CancelByTimeStop(string reason);
	}
}
