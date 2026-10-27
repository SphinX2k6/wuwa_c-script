using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B8 RID: 30648
	public static class TSwitchEffectStateEffectTypeVerify
	{
		// Token: 0x060379BF RID: 227775 RVA: 0x00785994 File Offset: 0x00783B94
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
