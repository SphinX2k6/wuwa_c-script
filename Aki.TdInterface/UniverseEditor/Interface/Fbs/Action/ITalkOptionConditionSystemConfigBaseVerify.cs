using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B02 RID: 31490
	public static class ITalkOptionConditionSystemConfigBaseVerify
	{
		// Token: 0x06038B52 RID: 232274 RVA: 0x007ABE9E File Offset: 0x007AA09E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
