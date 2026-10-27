using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA9 RID: 20137
	public static class IAnimalEmotionBubbleEntryVerify
	{
		// Token: 0x0601FB55 RID: 129877 RVA: 0x0046A40E File Offset: 0x0046860E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
