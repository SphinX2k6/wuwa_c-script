using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E5F RID: 24159
	public static class IUnlockAtlasSystemTypeV2_UnionVerify
	{
		// Token: 0x060295FE RID: 169470 RVA: 0x005ABECC File Offset: 0x005AA0CC
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
