using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007168 RID: 29032
	public static class ILongPressInteractStyleConfigDefaultVerify
	{
		// Token: 0x06032751 RID: 206673 RVA: 0x006D1FC2 File Offset: 0x006D01C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
