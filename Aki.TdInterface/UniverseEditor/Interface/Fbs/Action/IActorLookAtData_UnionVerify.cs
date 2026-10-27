using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060D9 RID: 24793
	public static class IActorLookAtData_UnionVerify
	{
		// Token: 0x0602A587 RID: 173447 RVA: 0x005D6118 File Offset: 0x005D4318
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IActorLookAtDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IActorLookAtLockableVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IActorLookAtTalkerDataVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IActorLookAtEmptyDataVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IActorLookAtEntityDataVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IActorLookAtPositionDataVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IActorLookAtPlayerDataVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IActorLookAtOtherActorVerify.Verify(verifier, tablePos);
				break;
			case 9:
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
