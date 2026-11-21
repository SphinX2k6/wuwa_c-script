using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing.Components.TearItem;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PrizeDrawing
{
	// Token: 0x0200521F RID: 21023
	internal static class TearType2AnimName
	{
		// Token: 0x06034518 RID: 214296 RVA: 0x00EA3108 File Offset: 0x00EA1308
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
