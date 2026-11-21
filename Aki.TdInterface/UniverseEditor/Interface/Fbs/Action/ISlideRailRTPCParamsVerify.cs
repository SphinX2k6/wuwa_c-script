using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200791F RID: 31007
	public static class ISlideRailRTPCParamsVerify
	{
		// Token: 0x06036987 RID: 223623 RVA: 0x0074E781 File Offset: 0x0074C981
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
