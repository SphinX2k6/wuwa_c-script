using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574A RID: 22346
	public static class IPlayerAttachTargetVerify
	{
		// Token: 0x06025718 RID: 153368 RVA: 0x0052AB92 File Offset: 0x00528D92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
