using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ED8 RID: 32472
	public static class TFadeBackgroundVerify
	{
		// Token: 0x0603A9A8 RID: 240040 RVA: 0x007E285C File Offset: 0x007E0A5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFadeBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFadeBackgroundSpineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFadeBackgroundUiPrefabVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
