using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C9 RID: 26825
	public static class IHandInItemViewStyleVerify
	{
		// Token: 0x0602EC9D RID: 191645 RVA: 0x00662A8E File Offset: 0x00660C8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
