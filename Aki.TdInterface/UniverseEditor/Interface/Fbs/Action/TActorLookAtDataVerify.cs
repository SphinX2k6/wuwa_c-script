using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007637 RID: 30263
	public static class TActorLookAtDataVerify
	{
		// Token: 0x060371DB RID: 225755 RVA: 0x0077962C File Offset: 0x0077782C
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
