using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FF0 RID: 32752
	public static class TSwitchEffectStateEffectTypeVerify
	{
		// Token: 0x0603AF40 RID: 241472 RVA: 0x007EAF64 File Offset: 0x007E9164
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISwitchTrailChainEffectStateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISwitchScreenEffectStateVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
