using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D06 RID: 32006
	public static class IVehicleEnteringTarget_UnionVerify
	{
		// Token: 0x06039C18 RID: 236568 RVA: 0x007CA5A4 File Offset: 0x007C87A4
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
