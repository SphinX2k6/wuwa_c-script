using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A7B RID: 31355
	public static class ITalkBackground_UnionVerify
	{
		// Token: 0x0603743A RID: 226362 RVA: 0x00761348 File Offset: 0x0075F548
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
