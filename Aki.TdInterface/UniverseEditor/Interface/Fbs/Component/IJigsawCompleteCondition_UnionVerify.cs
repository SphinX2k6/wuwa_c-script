using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A5 RID: 21669
	public static class IJigsawCompleteCondition_UnionVerify
	{
		// Token: 0x06023AA9 RID: 146089 RVA: 0x004EE2C0 File Offset: 0x004EC4C0
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
