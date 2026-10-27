using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3E RID: 27710
	public static class IOpenSystemBoardWithReturnTypeVerify
	{
		// Token: 0x06030CF9 RID: 199929 RVA: 0x006A1872 File Offset: 0x0069FA72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
