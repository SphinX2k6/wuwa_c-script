using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007009 RID: 28681
	public static class IInfrActivityUpgradeInfrastructureVerify
	{
		// Token: 0x06031B25 RID: 203557 RVA: 0x006BAE62 File Offset: 0x006B9062
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
