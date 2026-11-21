using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200511D RID: 20765
	public static class IFormationRoleInfoTypeVerify
	{
		// Token: 0x06020A56 RID: 133718 RVA: 0x00486626 File Offset: 0x00484826
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
