using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005906 RID: 22790
	[NullableContext(1)]
	public interface ISolarSchoolEventCheckViewHandler
	{
		// Token: 0x060382F2 RID: 230130
		void OnViewReady(SolarSchoolEventCheckView view);

		// Token: 0x060382F3 RID: 230131
		void OnChoiceSelected(int optionId);

		// Token: 0x060382F4 RID: 230132
		void OnJudgeAnimFinished();

		// Token: 0x060382F5 RID: 230133
		void OnResultConfirmed();

		// Token: 0x060382F6 RID: 230134
		void OnViewClosed();
	}
}
