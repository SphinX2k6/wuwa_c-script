using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C2A RID: 19498
	public static class IFormationRoleInfoTypeVerify
	{
		// Token: 0x0601EE52 RID: 126546 RVA: 0x00452D4A File Offset: 0x00450F4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
