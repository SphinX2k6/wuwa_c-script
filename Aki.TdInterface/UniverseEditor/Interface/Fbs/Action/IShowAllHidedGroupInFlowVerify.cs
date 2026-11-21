using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A1 RID: 30881
	public static class IShowAllHidedGroupInFlowVerify
	{
		// Token: 0x06036524 RID: 222500 RVA: 0x00746036 File Offset: 0x00744236
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
