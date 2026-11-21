using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EDB RID: 32475
	public static class TFadeBackgroundFadeInEffectVerify
	{
		// Token: 0x0603A9B4 RID: 240052 RVA: 0x007E296C File Offset: 0x007E0B6C
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
