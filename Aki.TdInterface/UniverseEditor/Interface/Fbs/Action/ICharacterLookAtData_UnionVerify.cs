using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006342 RID: 25410
	public static class ICharacterLookAtData_UnionVerify
	{
		// Token: 0x0602BF45 RID: 180037 RVA: 0x0060A878 File Offset: 0x00608A78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICharacterLookAtDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICharacterLookAtEmptyDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICharacterLookAtEntityDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICharacterLookAtPositionDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICharacterLookAtPlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICharacterLookAtUnlockDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
