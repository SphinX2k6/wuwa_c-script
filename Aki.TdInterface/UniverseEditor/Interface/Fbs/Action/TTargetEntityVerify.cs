using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D0 RID: 30672
	public static class TTargetEntityVerify
	{
		// Token: 0x06037A3D RID: 227901 RVA: 0x00786564 File Offset: 0x00784764
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPlayerEntityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISelfEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITargetEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
