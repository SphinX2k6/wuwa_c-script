using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EAB RID: 28331
	public static class IResetPosType_UnionVerify
	{
		// Token: 0x06032122 RID: 205090 RVA: 0x006C55D4 File Offset: 0x006C37D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IResetPosTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IResetPosByPosEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IResetPosByResetPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
