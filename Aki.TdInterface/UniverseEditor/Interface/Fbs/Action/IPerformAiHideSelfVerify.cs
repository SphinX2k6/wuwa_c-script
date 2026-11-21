using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E1 RID: 29665
	public static class IPerformAiHideSelfVerify
	{
		// Token: 0x06033E54 RID: 212564 RVA: 0x006FF662 File Offset: 0x006FD862
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
