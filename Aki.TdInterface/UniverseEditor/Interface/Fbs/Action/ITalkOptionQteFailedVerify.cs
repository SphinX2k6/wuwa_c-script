using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B1D RID: 31517
	public static class ITalkOptionQteFailedVerify
	{
		// Token: 0x06038C08 RID: 232456 RVA: 0x007ACF8E File Offset: 0x007AB18E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
