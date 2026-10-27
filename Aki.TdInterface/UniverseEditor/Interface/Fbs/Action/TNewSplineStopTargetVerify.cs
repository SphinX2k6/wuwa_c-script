using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007739 RID: 30521
	public static class TNewSplineStopTargetVerify
	{
		// Token: 0x0603775F RID: 227167 RVA: 0x00782194 File Offset: 0x00780394
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcNewSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerNewSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneNewItemSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IVehicleNewSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
