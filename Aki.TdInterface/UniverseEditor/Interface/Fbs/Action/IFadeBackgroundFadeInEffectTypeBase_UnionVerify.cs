using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DEA RID: 28138
	public static class IFadeBackgroundFadeInEffectTypeBase_UnionVerify
	{
		// Token: 0x06030928 RID: 198952 RVA: 0x006985E8 File Offset: 0x006967E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFadeBackgroundFadeInEffectTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFadeBackgroundFadeInEffectBlackVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFadeBackgroundFadeInEffectScreenEffectVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
