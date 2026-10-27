using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA5 RID: 27557
	public static class INewSplineStopTarget_UnionVerify
	{
		// Token: 0x06030666 RID: 198246 RVA: 0x00692DE0 File Offset: 0x00690FE0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INewSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcNewSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneNewItemSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPlayerNewSplineStopTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
