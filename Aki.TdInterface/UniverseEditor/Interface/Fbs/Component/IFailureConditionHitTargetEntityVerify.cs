using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005224 RID: 21028
	public static class IFailureConditionHitTargetEntityVerify
	{
		// Token: 0x060222DE RID: 139998 RVA: 0x004BDD7F File Offset: 0x004BBF7F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
