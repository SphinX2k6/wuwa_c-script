using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005933 RID: 22835
	internal static class SolarSchoolTearType2AnimName
	{
		// Token: 0x0603843B RID: 230459 RVA: 0x00FBB290 File Offset: 0x00FB9490
		[NullableContext(1)]
		public static string GetAnimName(ESolarSchoolTearType tearType)
		{
			string result;
			switch (tearType)
			{
			case ESolarSchoolTearType.Single:
				result = "SkipC";
				break;
			case ESolarSchoolTearType.SingleMultiple:
				result = "SkipB";
				break;
			case ESolarSchoolTearType.Double:
				result = "SkipB";
				break;
			case ESolarSchoolTearType.Super:
				result = "SkipA";
				break;
			default:
				result = "SkipC";
				break;
			}
			return result;
		}
	}
}
