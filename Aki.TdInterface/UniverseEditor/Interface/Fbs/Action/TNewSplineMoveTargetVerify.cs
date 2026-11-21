using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F5F RID: 32607
	public static class TNewSplineMoveTargetVerify
	{
		// Token: 0x0603AC8A RID: 240778 RVA: 0x007E6F98 File Offset: 0x007E5198
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
