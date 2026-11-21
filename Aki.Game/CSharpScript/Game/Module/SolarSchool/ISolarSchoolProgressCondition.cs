using System;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058C5 RID: 22725
	public interface ISolarSchoolProgressCondition
	{
		// Token: 0x06037F52 RID: 229202
		void RestoreProgress(int progress);

		// Token: 0x06037F53 RID: 229203
		int GetSaveProgress();
	}
}
