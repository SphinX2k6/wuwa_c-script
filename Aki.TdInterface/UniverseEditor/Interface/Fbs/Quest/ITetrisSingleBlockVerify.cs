using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004627 RID: 17959
	public static class ITetrisSingleBlockVerify
	{
		// Token: 0x0601A465 RID: 107621 RVA: 0x003BD665 File Offset: 0x003BB865
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
