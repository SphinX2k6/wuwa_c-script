using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A33 RID: 31283
	public static class ISwitchEffectStateEffectBaseVerify
	{
		// Token: 0x06037207 RID: 225799 RVA: 0x0075D872 File Offset: 0x0075BA72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
