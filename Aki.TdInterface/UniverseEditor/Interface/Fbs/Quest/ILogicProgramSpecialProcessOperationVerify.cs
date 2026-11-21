using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004357 RID: 17239
	public static class ILogicProgramSpecialProcessOperationVerify
	{
		// Token: 0x06018543 RID: 99651 RVA: 0x003785C6 File Offset: 0x003767C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
