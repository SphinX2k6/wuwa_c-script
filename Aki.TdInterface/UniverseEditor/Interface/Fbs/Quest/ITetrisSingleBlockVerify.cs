using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CE RID: 16846
	public static class ITetrisSingleBlockVerify
	{
		// Token: 0x06018D0F RID: 101647 RVA: 0x00392211 File Offset: 0x00390411
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
