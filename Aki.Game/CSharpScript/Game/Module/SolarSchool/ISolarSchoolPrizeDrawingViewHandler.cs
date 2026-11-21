using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005930 RID: 22832
	[NullableContext(1)]
	public interface ISolarSchoolPrizeDrawingViewHandler
	{
		// Token: 0x06038432 RID: 230450
		void OnViewReady(SolarSchoolPrizeDrawingView view);

		// Token: 0x06038433 RID: 230451
		void OnViewClosed();
	}
}
