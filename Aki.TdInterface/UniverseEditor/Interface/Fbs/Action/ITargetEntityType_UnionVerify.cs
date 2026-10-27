using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007363 RID: 29539
	public static class ITargetEntityType_UnionVerify
	{
		// Token: 0x060359D5 RID: 219605 RVA: 0x0074D290 File Offset: 0x0074B490
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITargetEntityTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITargetEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISelfEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPlayerEntityVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IVehicleEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
