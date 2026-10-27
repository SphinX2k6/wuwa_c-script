using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006785 RID: 26501
	public static class IFadeBackgroundType_UnionVerify
	{
		// Token: 0x0602E1B2 RID: 188850 RVA: 0x0064C5C0 File Offset: 0x0064A7C0
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
