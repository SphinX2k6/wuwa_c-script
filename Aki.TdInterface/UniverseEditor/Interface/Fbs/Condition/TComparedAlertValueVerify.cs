using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200523D RID: 21053
	public static class TComparedAlertValueVerify
	{
		// Token: 0x0602128E RID: 135822 RVA: 0x00493F44 File Offset: 0x00492144
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
