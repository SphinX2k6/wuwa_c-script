using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing
{
	// Token: 0x020062A1 RID: 25249
	internal static class TearType2AnimName
	{
		// Token: 0x0603F857 RID: 260183 RVA: 0x00F5C1AC File Offset: 0x00F5A3AC
		[NullableContext(1)]
		public static string GetAnimName(ETearType tearType)
		{
			string result;
			switch (tearType)
			{
			case ETearType.Single:
				result = "SkipC";
				break;
			case ETearType.SingleMultiple:
				result = "SkipB";
				break;
			case ETearType.Double:
				result = "SkipB";
				break;
			case ETearType.Super:
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
