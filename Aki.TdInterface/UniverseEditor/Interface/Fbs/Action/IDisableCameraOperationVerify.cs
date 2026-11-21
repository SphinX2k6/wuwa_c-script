using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C43 RID: 27715
	public static class IDisableCameraOperationVerify
	{
		// Token: 0x0602FB1B RID: 195355 RVA: 0x0067EE92 File Offset: 0x0067D092
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
