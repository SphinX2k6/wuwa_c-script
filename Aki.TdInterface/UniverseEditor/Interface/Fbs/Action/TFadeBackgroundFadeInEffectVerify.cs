using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CD RID: 30413
	public static class TFadeBackgroundFadeInEffectVerify
	{
		// Token: 0x060374FF RID: 226559 RVA: 0x0077E658 File Offset: 0x0077C858
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFadeBackgroundFadeInEffectScreenEffectVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFadeBackgroundFadeInEffectBlackVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
