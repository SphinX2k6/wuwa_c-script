using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E5 RID: 29413
	public static class INewSplineMoveTarget_UnionVerify
	{
		// Token: 0x0603349E RID: 210078 RVA: 0x006EB1CC File Offset: 0x006E93CC
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
