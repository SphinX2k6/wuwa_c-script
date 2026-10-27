using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007736 RID: 30518
	public static class TNewSplineMoveTargetVerify
	{
		// Token: 0x0603774F RID: 227151 RVA: 0x00782008 File Offset: 0x00780208
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneItemNewSplineMoveTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
