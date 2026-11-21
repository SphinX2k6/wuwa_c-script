using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E56 RID: 28246
	public static class IFixFoundationRelationVerify
	{
		// Token: 0x06030CAF RID: 199855 RVA: 0x0069F192 File Offset: 0x0069D392
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
