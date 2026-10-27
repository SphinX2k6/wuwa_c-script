using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B9F RID: 27551
	public static class INewSplineMoveTarget_UnionVerify
	{
		// Token: 0x06030642 RID: 198210 RVA: 0x00692AA0 File Offset: 0x00690CA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISceneItemNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IVehicleNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
