using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F4E RID: 16206
	public static class TBlackBoardVerify
	{
		// Token: 0x060160B8 RID: 90296 RVA: 0x0032A50C File Offset: 0x0032870C
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
