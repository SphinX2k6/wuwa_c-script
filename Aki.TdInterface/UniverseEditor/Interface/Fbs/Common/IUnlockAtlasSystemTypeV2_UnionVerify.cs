using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200649F RID: 25759
	public static class IUnlockAtlasSystemTypeV2_UnionVerify
	{
		// Token: 0x0602BC9A RID: 179354 RVA: 0x005F4D74 File Offset: 0x005F2F74
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUnlockAtlasSystemTypeV2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUnlockGeographicalAtlasV2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUnlockPlotPhotoAtlasV2Verify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IUnlockNounAtlasV2Verify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IUnlockPanoramaAtlasV2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
