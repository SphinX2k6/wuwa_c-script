using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E45 RID: 32325
	public static class TActorLookAtDataVerify
	{
		// Token: 0x0603A680 RID: 239232 RVA: 0x007DD728 File Offset: 0x007DB928
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorLookAtEmptyDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorLookAtEntityDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorLookAtOtherActorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IActorLookAtPlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IActorLookAtPositionDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IActorLookAtTalkerDataVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IActorLookAtUnLockVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
