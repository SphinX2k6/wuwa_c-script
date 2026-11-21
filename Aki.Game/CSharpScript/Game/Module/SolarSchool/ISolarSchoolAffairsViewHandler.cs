using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058FB RID: 22779
	[NullableContext(1)]
	public interface ISolarSchoolAffairsViewHandler
	{
		// Token: 0x06038284 RID: 230020
		void OnViewReady(SolarSchoolAffairsView view);

		// Token: 0x06038285 RID: 230021
		void OnChoiceSelected(int optionId);

		// Token: 0x06038286 RID: 230022
		void OnFinished();

		// Token: 0x06038287 RID: 230023
		void OnViewClosed();
	}
}
