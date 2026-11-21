using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E78 RID: 32376
	public static class TCharacterLookAtDataVerify
	{
		// Token: 0x0603A782 RID: 239490 RVA: 0x007DEF54 File Offset: 0x007DD154
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICharacterLookAtEmptyDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICharacterLookAtEntityDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICharacterLookAtPlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICharacterLookAtPositionDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
