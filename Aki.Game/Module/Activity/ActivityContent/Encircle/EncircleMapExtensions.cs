using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200300F RID: 12303
	public static class EncircleMapExtensions
	{
		// Token: 0x0601D2FC RID: 119548 RVA: 0x008E9178 File Offset: 0x008E7378
		[NullableContext(1)]
		public static int[] GetColumnArray(this EncircleMap @this, int columnNumber)
		{
			int[] result;
			switch (columnNumber)
			{
			case 1:
				result = @this.GetColumn1Array();
				break;
			case 2:
				result = @this.GetColumn2Array();
				break;
			case 3:
				result = @this.GetColumn3Array();
				break;
			case 4:
				result = @this.GetColumn4Array();
				break;
			case 5:
				result = @this.GetColumn5Array();
				break;
			case 6:
				result = @this.GetColumn6Array();
				break;
			case 7:
				result = @this.GetColumn7Array();
				break;
			case 8:
				result = @this.GetColumn8Array();
				break;
			case 9:
				result = @this.GetColumn9Array();
				break;
			case 10:
				result = @this.GetColumn10Array();
				break;
			case 11:
				result = @this.GetColumn11Array();
				break;
			default:
				result = Array.Empty<int>();
				break;
			}
			return result;
		}
	}
}
