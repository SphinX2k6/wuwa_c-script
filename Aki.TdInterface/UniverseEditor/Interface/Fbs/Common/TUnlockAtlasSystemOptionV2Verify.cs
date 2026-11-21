using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064DB RID: 25819
	public static class TUnlockAtlasSystemOptionV2Verify
	{
		// Token: 0x0602BE21 RID: 179745 RVA: 0x005F76B4 File Offset: 0x005F58B4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IUnlockGeographicalAtlasV2Verify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IUnlockNounAtlasV2Verify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IUnlockPanoramaAtlasV2Verify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IUnlockPlotPhotoAtlasV2Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
