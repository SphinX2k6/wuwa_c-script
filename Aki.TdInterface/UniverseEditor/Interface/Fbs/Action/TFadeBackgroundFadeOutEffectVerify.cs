using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EDE RID: 32478
	public static class TFadeBackgroundFadeOutEffectVerify
	{
		// Token: 0x0603A9C0 RID: 240064 RVA: 0x007E2A68 File Offset: 0x007E0C68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFadeBackgroundFadeOutEffectScreenEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFadeBackgroundFadeOutEffectBlackVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
