using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x0200470E RID: 18190
	[NullableContext(1)]
	public interface IWuWaGoTimeStopParticipant
	{
		// Token: 0x170076C9 RID: 30409
		// (get) Token: 0x0602F898 RID: 194712
		// (set) Token: 0x0602F899 RID: 194713
		bool PausedByTimeStop { get; set; }

		// Token: 0x0602F89A RID: 194714
		void PauseByTimeStop();

		// Token: 0x0602F89B RID: 194715
		void ResumeByTimeStop();

		// Token: 0x0602F89C RID: 194716
		void CancelByTimeStop(string reason);
	}
}
