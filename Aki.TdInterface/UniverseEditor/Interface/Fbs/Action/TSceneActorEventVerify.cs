using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F9F RID: 32671
	public static class TSceneActorEventVerify
	{
		// Token: 0x0603ADD2 RID: 241106 RVA: 0x007E8ED0 File Offset: 0x007E70D0
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
