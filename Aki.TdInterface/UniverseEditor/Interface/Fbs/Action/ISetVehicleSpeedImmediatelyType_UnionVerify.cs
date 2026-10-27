using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070AB RID: 28843
	public static class ISetVehicleSpeedImmediatelyType_UnionVerify
	{
		// Token: 0x0603312E RID: 209198 RVA: 0x006E37D0 File Offset: 0x006E19D0
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
