using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ECA RID: 16074
	public static class IScoreDisplayParamsVerify
	{
		// Token: 0x06015C29 RID: 89129 RVA: 0x0032190E File Offset: 0x0031FB0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
