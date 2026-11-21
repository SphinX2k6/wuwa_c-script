using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702A RID: 28714
	public static class IInstrumentQteConfig_QteSequenceRowVerify
	{
		// Token: 0x06031C35 RID: 203829 RVA: 0x006BCB75 File Offset: 0x006BAD75
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
