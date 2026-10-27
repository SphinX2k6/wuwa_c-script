using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006977 RID: 26999
	public static class IInstrumentQteConfig_QteSequenceRowVerify
	{
		// Token: 0x0602F265 RID: 193125 RVA: 0x0066C68D File Offset: 0x0066A88D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
