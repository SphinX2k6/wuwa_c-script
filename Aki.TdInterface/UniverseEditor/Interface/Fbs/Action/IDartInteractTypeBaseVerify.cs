using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200653F RID: 25919
	public static class IDartInteractTypeBaseVerify
	{
		// Token: 0x0602CF73 RID: 184179 RVA: 0x0062C6A2 File Offset: 0x0062A8A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
