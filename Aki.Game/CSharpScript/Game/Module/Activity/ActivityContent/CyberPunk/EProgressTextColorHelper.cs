using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x02005808 RID: 22536
	public static class EProgressTextColorHelper
	{
		// Token: 0x060379AE RID: 227758 RVA: 0x00F8A8C8 File Offset: 0x00F88AC8
		[NullableContext(1)]
		public static string ToColorString(EProgressTextColor color)
		{
			string result;
			switch (color)
			{
			case EProgressTextColor.Zero:
				result = "ffffff";
				break;
			case EProgressTextColor.InProgress:
				result = "fefe22";
				break;
			case EProgressTextColor.Completed:
				result = "29ff98";
				break;
			default:
				result = "ffffff";
				break;
			}
			return result;
		}
	}
}
