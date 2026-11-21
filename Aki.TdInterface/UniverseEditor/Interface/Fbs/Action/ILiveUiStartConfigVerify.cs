using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007150 RID: 29008
	public static class ILiveUiStartConfigVerify
	{
		// Token: 0x06032645 RID: 206405 RVA: 0x006CFC4A File Offset: 0x006CDE4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
