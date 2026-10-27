using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D0 RID: 30416
	public static class TFadeBackgroundFadeOutEffectVerify
	{
		// Token: 0x0603750B RID: 226571 RVA: 0x0077E754 File Offset: 0x0077C954
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
