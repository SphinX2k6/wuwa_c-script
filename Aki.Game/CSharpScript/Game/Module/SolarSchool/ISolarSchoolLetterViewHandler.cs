using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005914 RID: 22804
	[NullableContext(1)]
	public interface ISolarSchoolLetterViewHandler
	{
		// Token: 0x17006BC2 RID: 27586
		// (get) Token: 0x06038376 RID: 230262
		// (set) Token: 0x06038377 RID: 230263
		ELetterAnimType StartAnimType { get; set; }

		// Token: 0x06038378 RID: 230264
		void OnViewReady(SolarSchoolLetterView view);

		// Token: 0x06038379 RID: 230265
		void OnOpeningFinished();

		// Token: 0x0603837A RID: 230266
		void OnPageTypingFinished();

		// Token: 0x0603837B RID: 230267
		void OnContinueClicked();

		// Token: 0x0603837C RID: 230268
		void OnViewClosed();
	}
}
