using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DBA RID: 23994
	public static class IPullingFoundationTypeVerify
	{
		// Token: 0x06028007 RID: 163847 RVA: 0x00578A86 File Offset: 0x00576C86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
