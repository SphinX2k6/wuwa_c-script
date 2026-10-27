using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C53 RID: 23635
	public static class TJigsawCompleteConditionVerify
	{
		// Token: 0x06028844 RID: 165956 RVA: 0x00592AA8 File Offset: 0x00590CA8
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
