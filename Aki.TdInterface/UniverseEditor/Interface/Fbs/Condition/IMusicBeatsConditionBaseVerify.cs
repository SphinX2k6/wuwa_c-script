using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005153 RID: 20819
	public static class IMusicBeatsConditionBaseVerify
	{
		// Token: 0x06020C08 RID: 134152 RVA: 0x00489586 File Offset: 0x00487786
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
