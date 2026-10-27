using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A5 RID: 26789
	public static class IGroupAiCommunicateAddTagVerify
	{
		// Token: 0x0602EBA5 RID: 191397 RVA: 0x0065EB4F File Offset: 0x0065CD4F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
