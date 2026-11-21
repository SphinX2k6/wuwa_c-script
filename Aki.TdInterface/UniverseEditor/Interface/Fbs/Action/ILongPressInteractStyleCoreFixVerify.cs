using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007171 RID: 29041
	public static class ILongPressInteractStyleCoreFixVerify
	{
		// Token: 0x06032795 RID: 206741 RVA: 0x006D2662 File Offset: 0x006D0862
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
