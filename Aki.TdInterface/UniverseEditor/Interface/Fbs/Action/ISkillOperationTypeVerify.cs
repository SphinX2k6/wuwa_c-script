using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007132 RID: 28978
	public static class ISkillOperationTypeVerify
	{
		// Token: 0x06033604 RID: 210436 RVA: 0x006ECAA6 File Offset: 0x006EACA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
