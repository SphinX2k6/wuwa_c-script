using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CCC RID: 19660
	public static class ISkillUseTypeVerify
	{
		// Token: 0x0601F31A RID: 127770 RVA: 0x0045AC86 File Offset: 0x00458E86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
