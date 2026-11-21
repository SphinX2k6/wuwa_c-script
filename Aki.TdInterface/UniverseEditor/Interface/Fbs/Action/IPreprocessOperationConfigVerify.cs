using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007521 RID: 29985
	public static class IPreprocessOperationConfigVerify
	{
		// Token: 0x06034968 RID: 215400 RVA: 0x00713CF6 File Offset: 0x00711EF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
