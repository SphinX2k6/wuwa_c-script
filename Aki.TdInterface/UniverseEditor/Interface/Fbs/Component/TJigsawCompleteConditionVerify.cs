using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006278 RID: 25208
	public static class TJigsawCompleteConditionVerify
	{
		// Token: 0x0602AE52 RID: 175698 RVA: 0x005DACC0 File Offset: 0x005D8EC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActivateAllCorrectPieceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActivateSpecifiedPieceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActiveRenjuPieceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPutInTheSpecifiedPieceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
