using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D5 RID: 28885
	public static class IShowAllHidedGroupInFlowVerify
	{
		// Token: 0x06033282 RID: 209538 RVA: 0x006E5A2A File Offset: 0x006E3C2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
