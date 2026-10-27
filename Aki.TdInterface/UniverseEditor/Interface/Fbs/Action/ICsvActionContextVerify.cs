using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064EE RID: 25838
	public static class ICsvActionContextVerify
	{
		// Token: 0x0602CD2A RID: 183594 RVA: 0x00628AB5 File Offset: 0x00626CB5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
