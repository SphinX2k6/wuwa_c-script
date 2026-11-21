using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AA RID: 30378
	public static class ISceneActorEvent_UnionVerify
	{
		// Token: 0x0603549A RID: 218266 RVA: 0x00726248 File Offset: 0x00724448
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneActorEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISceneActorMusicPlantsEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneActorMusicLightsEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISceneActorProjection3dTo2dEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
