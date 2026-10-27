using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062BC RID: 25276
	public static class ICenterTextShowTypeVerify
	{
		// Token: 0x0602BAEE RID: 178926 RVA: 0x006032DE File Offset: 0x006014DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
