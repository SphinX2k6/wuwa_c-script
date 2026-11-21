using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FF9 RID: 32761
	public static class TTalkBackgroundVerify
	{
		// Token: 0x0603AF70 RID: 241520 RVA: 0x007EB3D8 File Offset: 0x007E95D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkBackgroundCleanVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkBackgroundIconVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITalkBackgroundImageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITalkBackgroundImageByMcGenderVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITalkBackgroundSpineImageVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
