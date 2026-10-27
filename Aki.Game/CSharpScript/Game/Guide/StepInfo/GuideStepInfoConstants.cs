using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x02004605 RID: 17925
	public class GuideStepInfoConstants
	{
		// Token: 0x04018CFE RID: 101630
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static string[] StateDesc = new string[]
		{
			"Init",
			"Executing",
			"Pending",
			"Break",
			"Finish",
			"End"
		};

		// Token: 0x04018CFF RID: 101631
		public const int GUARANTEED_TIME = 30000;

		// Token: 0x04018D00 RID: 101632
		public const int OFFSET_TIME = 2000;
	}
}
