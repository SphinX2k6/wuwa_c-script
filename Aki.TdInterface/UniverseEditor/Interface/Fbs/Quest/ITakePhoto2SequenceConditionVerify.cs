using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004189 RID: 16777
	public static class ITakePhoto2SequenceConditionVerify
	{
		// Token: 0x06018AC4 RID: 101060 RVA: 0x0038DBED File Offset: 0x0038BDED
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
