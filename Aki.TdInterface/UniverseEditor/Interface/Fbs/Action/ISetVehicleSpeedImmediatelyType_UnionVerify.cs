using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007877 RID: 30839
	public static class ISetVehicleSpeedImmediatelyType_UnionVerify
	{
		// Token: 0x060363D0 RID: 222160 RVA: 0x00743DDC File Offset: 0x00741FDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetVehicleSpeedImmediatelyTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetTotalVehicleSpeedImmediatelyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetHorizontalVerticalSpeedImmediatelyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
