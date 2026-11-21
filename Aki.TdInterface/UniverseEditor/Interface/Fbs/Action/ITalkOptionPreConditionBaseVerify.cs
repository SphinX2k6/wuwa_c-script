using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B14 RID: 31508
	public static class ITalkOptionPreConditionBaseVerify
	{
		// Token: 0x06038BC6 RID: 232390 RVA: 0x007AC922 File Offset: 0x007AAB22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
