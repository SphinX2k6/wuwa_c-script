using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D41 RID: 19777
	public static class TComparedAlertValueVerify
	{
		// Token: 0x0601F645 RID: 128581 RVA: 0x0045FF70 File Offset: 0x0045E170
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICompareCustomAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICompareMaxAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICompareMinAlertValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
