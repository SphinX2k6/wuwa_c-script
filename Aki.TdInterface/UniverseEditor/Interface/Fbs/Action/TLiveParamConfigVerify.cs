using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F29 RID: 32553
	public static class TLiveParamConfigVerify
	{
		// Token: 0x0603AB90 RID: 240528 RVA: 0x007E591C File Offset: 0x007E3B1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILiveDanmakuIntervalParamVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveDanmakuTrackCountParamVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILiveForceDanmakuParamVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILiveHeatParamVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
