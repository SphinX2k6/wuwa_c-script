using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008008 RID: 32776
	public static class TTargetEntityVerify
	{
		// Token: 0x0603AFC2 RID: 241602 RVA: 0x007EBBC8 File Offset: 0x007E9DC8
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
