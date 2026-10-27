using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006560 RID: 25952
	public static class IDelayRemoveAfterSkillFinishVerify
	{
		// Token: 0x0602D06F RID: 184431 RVA: 0x0062DEBE File Offset: 0x0062C0BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
