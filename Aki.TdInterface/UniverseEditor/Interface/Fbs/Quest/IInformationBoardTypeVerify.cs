using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DC RID: 17116
	public static class IInformationBoardTypeVerify
	{
		// Token: 0x06018072 RID: 98418 RVA: 0x0036DEEA File Offset: 0x0036C0EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
