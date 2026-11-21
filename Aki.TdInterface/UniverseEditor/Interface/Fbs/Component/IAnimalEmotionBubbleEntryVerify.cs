using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D2 RID: 21458
	public static class IAnimalEmotionBubbleEntryVerify
	{
		// Token: 0x06021856 RID: 137302 RVA: 0x0049F88A File Offset: 0x0049DA8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
