using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B4C RID: 15180
	public static class TBlackBoardVerify
	{
		// Token: 0x06014C0E RID: 85006 RVA: 0x0030427C File Offset: 0x0030247C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBlackBoardBooleanVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBlackBoardEntityIdVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBlackBoardEntityPosVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBlackBoardFloatVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBlackBoardIntVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IBlackBoardStringVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IBlackBoardVectorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
