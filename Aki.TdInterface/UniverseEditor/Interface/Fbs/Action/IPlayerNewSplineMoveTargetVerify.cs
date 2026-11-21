using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007482 RID: 29826
	public static class IPlayerNewSplineMoveTargetVerify
	{
		// Token: 0x06034377 RID: 213879 RVA: 0x00708932 File Offset: 0x00706B32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
