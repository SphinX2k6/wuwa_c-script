using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Guide.StepInfo
{
	// Token: 0x0200352E RID: 13614
	public class GuideStepInfoConstants
	{
		// Token: 0x0401333D RID: 78653
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

		// Token: 0x0401333E RID: 78654
		public const int GUARANTEED_TIME = 30000;

		// Token: 0x0401333F RID: 78655
		public const int OFFSET_TIME = 2000;
	}
}
