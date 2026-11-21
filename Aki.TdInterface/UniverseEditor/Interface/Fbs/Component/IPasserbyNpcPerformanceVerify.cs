using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA4 RID: 23716
	public static class IPasserbyNpcPerformanceVerify
	{
		// Token: 0x0602757E RID: 161150 RVA: 0x00562C21 File Offset: 0x00560E21
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
