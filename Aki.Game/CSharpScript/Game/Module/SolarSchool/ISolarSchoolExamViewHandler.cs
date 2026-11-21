using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200590B RID: 22795
	[NullableContext(1)]
	public interface ISolarSchoolExamViewHandler
	{
		// Token: 0x06038332 RID: 230194
		void OnViewReady(SolarSchoolExamView view);

		// Token: 0x06038333 RID: 230195
		void OnChoiceSelected(int choiceId);

		// Token: 0x06038334 RID: 230196
		void OnResultConfirmed();

		// Token: 0x06038335 RID: 230197
		void OnViewClosed();
	}
}
