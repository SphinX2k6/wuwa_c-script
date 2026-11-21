using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044E9 RID: 17641
	public static class IRhythmSpaceshipConditionStepBaseVerify
	{
		// Token: 0x06019867 RID: 104551 RVA: 0x003A3F26 File Offset: 0x003A2126
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
