using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A6 RID: 26534
	public static class IFinishDoInteractVerify
	{
		// Token: 0x0602E2D1 RID: 189137 RVA: 0x0064E7EE File Offset: 0x0064C9EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
