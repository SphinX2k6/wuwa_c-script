using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B08 RID: 31496
	public static class ITalkOptionFirstSelectVerify
	{
		// Token: 0x06038B70 RID: 232304 RVA: 0x007AC112 File Offset: 0x007AA312
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
