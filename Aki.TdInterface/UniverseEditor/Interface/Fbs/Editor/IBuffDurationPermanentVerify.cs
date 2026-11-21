using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C9C RID: 19612
	public static class IBuffDurationPermanentVerify
	{
		// Token: 0x0601E123 RID: 123171 RVA: 0x00436CD6 File Offset: 0x00434ED6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
