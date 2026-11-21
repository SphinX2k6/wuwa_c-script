using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007165 RID: 29029
	public static class ILongPressInteractStyleConfigVerify
	{
		// Token: 0x0603273F RID: 206655 RVA: 0x006D1E4A File Offset: 0x006D004A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
