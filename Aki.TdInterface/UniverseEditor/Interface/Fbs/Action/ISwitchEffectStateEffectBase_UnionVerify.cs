using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A36 RID: 31286
	public static class ISwitchEffectStateEffectBase_UnionVerify
	{
		// Token: 0x06037215 RID: 225813 RVA: 0x0075D998 File Offset: 0x0075BB98
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
