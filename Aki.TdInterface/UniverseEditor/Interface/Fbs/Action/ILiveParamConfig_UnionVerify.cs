using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711A RID: 28954
	public static class ILiveParamConfig_UnionVerify
	{
		// Token: 0x060324C8 RID: 206024 RVA: 0x006CD1A8 File Offset: 0x006CB3A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveParamConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveHeatParamVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveDanmakuIntervalParamVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveDanmakuTrackCountParamVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILiveForceDanmakuParamVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ILiveLikeParamVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
