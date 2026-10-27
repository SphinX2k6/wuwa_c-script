using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B1 RID: 22705
	public static class ISceneItemAiPatrolTypeVerify
	{
		// Token: 0x060264EF RID: 156911 RVA: 0x00547C12 File Offset: 0x00545E12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
