using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE0 RID: 23776
	public static class IPathDrivenActorMoveBaseVerify
	{
		// Token: 0x06027790 RID: 161680 RVA: 0x00566DB2 File Offset: 0x00564FB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
