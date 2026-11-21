using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005756 RID: 22358
	public static class IExploreSkillInteractTypeVerify
	{
		// Token: 0x0602408B RID: 147595 RVA: 0x004F4E82 File Offset: 0x004F3082
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
