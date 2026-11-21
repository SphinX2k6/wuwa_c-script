using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF9 RID: 28153
	public static class IFadeBackgroundFadeOutEffectTypeBase_UnionVerify
	{
		// Token: 0x06030998 RID: 199064 RVA: 0x0069919C File Offset: 0x0069739C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFadeBackgroundFadeOutEffectTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFadeBackgroundFadeOutEffectBlackVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFadeBackgroundFadeOutEffectScreenEffectVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
