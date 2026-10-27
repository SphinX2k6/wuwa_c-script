using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F23 RID: 28451
	public static class ISceneActorEvent_UnionVerify
	{
		// Token: 0x06032442 RID: 205890 RVA: 0x006CA2E0 File Offset: 0x006C84E0
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
