using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078B3 RID: 30899
	public static class IShowMessageVerify
	{
		// Token: 0x060365FC RID: 222716 RVA: 0x007478E1 File Offset: 0x00745AE1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
