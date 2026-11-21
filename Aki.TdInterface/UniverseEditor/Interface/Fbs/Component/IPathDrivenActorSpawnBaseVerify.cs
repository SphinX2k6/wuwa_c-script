using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE6 RID: 23782
	public static class IPathDrivenActorSpawnBaseVerify
	{
		// Token: 0x060277AE RID: 161710 RVA: 0x00567026 File Offset: 0x00565226
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
