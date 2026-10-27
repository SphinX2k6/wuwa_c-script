using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007510 RID: 29968
	public static class IVehicleEnteringTarget_UnionVerify
	{
		// Token: 0x06036803 RID: 223235 RVA: 0x00767354 File Offset: 0x00765554
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVehicleEnteringTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVehicleEnteringPlayerTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVehicleEnteringNpcTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
