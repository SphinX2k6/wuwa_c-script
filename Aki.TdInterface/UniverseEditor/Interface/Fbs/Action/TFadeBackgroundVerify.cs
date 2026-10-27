using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076CA RID: 30410
	public static class TFadeBackgroundVerify
	{
		// Token: 0x060374F3 RID: 226547 RVA: 0x0077E548 File Offset: 0x0077C748
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
