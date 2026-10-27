using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A23 RID: 14883
	public static class IBlackBoard_UnionVerify
	{
		// Token: 0x06014210 RID: 82448 RVA: 0x002F1CC0 File Offset: 0x002EFEC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBlackBoardVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBlackBoardBooleanVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBlackBoardIntVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBlackBoardEntityIdVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBlackBoardFloatVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBlackBoardStringVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBlackBoardVectorVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IBlackBoardEntityPosVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
