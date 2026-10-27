using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062CE RID: 25294
	public static class IChangeAnimalEmotionBubbleVerify
	{
		// Token: 0x0602BB8C RID: 179084 RVA: 0x00604344 File Offset: 0x00602544
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
