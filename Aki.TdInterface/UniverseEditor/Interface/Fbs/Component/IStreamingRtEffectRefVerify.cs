using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D3 RID: 22995
	public static class IStreamingRtEffectRefVerify
	{
		// Token: 0x0602702B RID: 159787 RVA: 0x0055E4B1 File Offset: 0x0055C6B1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
