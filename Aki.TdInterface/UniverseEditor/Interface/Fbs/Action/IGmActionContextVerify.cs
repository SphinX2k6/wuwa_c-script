using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3A RID: 28474
	public static class IGmActionContextVerify
	{
		// Token: 0x0603146B RID: 201835 RVA: 0x006ACEED File Offset: 0x006AB0ED
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
