using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E05 RID: 28165
	public static class IFadeBackgroundType_UnionVerify
	{
		// Token: 0x060309F8 RID: 199160 RVA: 0x00699D04 File Offset: 0x00697F04
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFadeBackgroundTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFadeBackgroundSpineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFadeBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
