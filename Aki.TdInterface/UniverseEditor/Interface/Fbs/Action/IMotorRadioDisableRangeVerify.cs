using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007269 RID: 29289
	public static class IMotorRadioDisableRangeVerify
	{
		// Token: 0x0603309D RID: 209053 RVA: 0x006E397E File Offset: 0x006E1B7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
