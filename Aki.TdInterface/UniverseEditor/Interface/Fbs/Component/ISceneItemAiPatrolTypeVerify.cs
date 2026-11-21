using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EBE RID: 24254
	public static class ISceneItemAiPatrolTypeVerify
	{
		// Token: 0x06028A51 RID: 166481 RVA: 0x0058E75E File Offset: 0x0058C95E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
