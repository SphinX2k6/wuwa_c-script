using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007773 RID: 30579
	public static class TSceneActorEventVerify
	{
		// Token: 0x06037889 RID: 227465 RVA: 0x00783E00 File Offset: 0x00782000
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneActorMusicLightsEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISceneActorMusicPlantsEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
