using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200590F RID: 22799
	[NullableContext(1)]
	public interface ISolarSchoolForumViewHandler
	{
		// Token: 0x0603835B RID: 230235
		void OnViewReady(SolarSchoolForumView view);

		// Token: 0x0603835C RID: 230236
		void OnLikeSelected();

		// Token: 0x0603835D RID: 230237
		void OnContinueClicked();

		// Token: 0x0603835E RID: 230238
		void OnViewClosed();
	}
}
