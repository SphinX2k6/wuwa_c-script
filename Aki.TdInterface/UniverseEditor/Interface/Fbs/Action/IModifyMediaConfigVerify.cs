using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071FA RID: 29178
	public static class IModifyMediaConfigVerify
	{
		// Token: 0x06032C27 RID: 207911 RVA: 0x006DB33E File Offset: 0x006D953E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
