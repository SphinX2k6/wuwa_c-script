using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F1 RID: 22257
	public static class IPathDrivenActorMoveBaseVerify
	{
		// Token: 0x06025329 RID: 152361 RVA: 0x00522366 File Offset: 0x00520566
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
