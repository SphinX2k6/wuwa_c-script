using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200676A RID: 26474
	public static class IFadeBackgroundFadeInEffectTypeBase_UnionVerify
	{
		// Token: 0x0602E0E2 RID: 188642 RVA: 0x0064AEA4 File Offset: 0x006490A4
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
