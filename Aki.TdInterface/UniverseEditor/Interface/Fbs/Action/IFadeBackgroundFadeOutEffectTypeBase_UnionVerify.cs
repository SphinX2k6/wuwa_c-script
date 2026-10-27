using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006779 RID: 26489
	public static class IFadeBackgroundFadeOutEffectTypeBase_UnionVerify
	{
		// Token: 0x0602E152 RID: 188754 RVA: 0x0064BA58 File Offset: 0x00649C58
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
