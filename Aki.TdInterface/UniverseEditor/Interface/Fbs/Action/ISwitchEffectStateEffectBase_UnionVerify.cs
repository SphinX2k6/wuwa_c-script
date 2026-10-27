using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007261 RID: 29281
	public static class ISwitchEffectStateEffectBase_UnionVerify
	{
		// Token: 0x06033F13 RID: 212755 RVA: 0x006FC638 File Offset: 0x006FA838
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISwitchEffectStateEffectBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISwitchScreenEffectStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISwitchTrailChainEffectStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
