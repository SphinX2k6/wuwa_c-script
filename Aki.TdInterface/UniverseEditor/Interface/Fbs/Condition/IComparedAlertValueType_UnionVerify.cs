using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B91 RID: 19345
	public static class IComparedAlertValueType_UnionVerify
	{
		// Token: 0x0601E7E1 RID: 124897 RVA: 0x00444A18 File Offset: 0x00442C18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IComparedAlertValueTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICompareMinAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICompareMaxAlertValueVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICompareCustomAlertValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
