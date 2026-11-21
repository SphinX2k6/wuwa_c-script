using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C99 RID: 19609
	public static class IBuffDurationInstantVerify
	{
		// Token: 0x0601E111 RID: 123153 RVA: 0x00436B5E File Offset: 0x00434D5E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
