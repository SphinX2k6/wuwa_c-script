using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2B RID: 23083
	public static class IJigsawCompleteCondition_UnionVerify
	{
		// Token: 0x06025B61 RID: 154465 RVA: 0x0052B334 File Offset: 0x00529534
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IJigsawCompleteConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActivateAllCorrectPieceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPutInTheSpecifiedPieceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IActiveRenjuPieceVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IActivateSpecifiedPieceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
