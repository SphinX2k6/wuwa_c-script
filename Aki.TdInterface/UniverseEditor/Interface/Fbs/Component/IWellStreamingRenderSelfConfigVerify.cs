using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200618F RID: 24975
	public static class IWellStreamingRenderSelfConfigVerify
	{
		// Token: 0x0602A71E RID: 173854 RVA: 0x005CA4BE File Offset: 0x005C86BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
