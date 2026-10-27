using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068B8 RID: 26808
	public static class EProgressTextColorHelper
	{
		// Token: 0x06042E56 RID: 274006 RVA: 0x010492A0 File Offset: 0x010474A0
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
