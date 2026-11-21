using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B5 RID: 29109
	public static class IMechStuntConfigTypeVerify
	{
		// Token: 0x06032A2B RID: 207403 RVA: 0x006D7882 File Offset: 0x006D5A82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
