using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200673B RID: 26427
	public static class IActorLookAtData_UnionVerify
	{
		// Token: 0x0602CC68 RID: 183400 RVA: 0x006200C0 File Offset: 0x0061E2C0
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
