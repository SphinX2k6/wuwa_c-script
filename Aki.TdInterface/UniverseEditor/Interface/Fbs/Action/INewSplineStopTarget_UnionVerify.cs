using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F1 RID: 29425
	public static class INewSplineStopTarget_UnionVerify
	{
		// Token: 0x060334E0 RID: 210144 RVA: 0x006EB780 File Offset: 0x006E9980
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
