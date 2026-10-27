using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7A RID: 27770
	public static class IPerformAiHideSelfVerify
	{
		// Token: 0x06030EF9 RID: 200441 RVA: 0x006A5162 File Offset: 0x006A3362
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
