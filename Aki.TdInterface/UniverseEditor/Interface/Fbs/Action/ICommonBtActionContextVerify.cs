using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200645E RID: 25694
	public static class ICommonBtActionContextVerify
	{
		// Token: 0x0602C76B RID: 182123 RVA: 0x00619129 File Offset: 0x00617329
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
