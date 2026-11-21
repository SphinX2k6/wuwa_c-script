using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD1 RID: 27601
	public static class IDelayRemoveAfterSkillFinishVerify
	{
		// Token: 0x0602F82B RID: 194603 RVA: 0x0067A682 File Offset: 0x00678882
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
