using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A6 RID: 29350
	public static class ITalkBackground_UnionVerify
	{
		// Token: 0x06034136 RID: 213302 RVA: 0x006FFFAC File Offset: 0x006FE1AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITalkBackgroundVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITalkBackgroundCleanVerify.Verify(verifier, tablePos);
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
			case 6:
				result = ITalkBackgroundIconVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
