using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005945 RID: 22853
	[NullableContext(1)]
	public interface ISolarSchoolScratchTicketViewHandler
	{
		// Token: 0x060384F5 RID: 230645
		[NullableContext(2)]
		SolarSchoolScratchTicketData GetData();

		// Token: 0x060384F6 RID: 230646
		void OnViewReady(SolarSchoolScratchTicketView view);

		// Token: 0x060384F7 RID: 230647
		void OnCellClicked(int index);

		// Token: 0x060384F8 RID: 230648
		void OnRevealAnimFinished();

		// Token: 0x060384F9 RID: 230649
		void OnRequestClose();

		// Token: 0x060384FA RID: 230650
		void OnViewClosed();
	}
}
