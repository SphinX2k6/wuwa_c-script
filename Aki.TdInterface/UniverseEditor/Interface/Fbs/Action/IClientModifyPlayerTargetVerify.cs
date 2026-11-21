using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A52 RID: 27218
	public static class IClientModifyPlayerTargetVerify
	{
		// Token: 0x0602EB18 RID: 191256 RVA: 0x0065D696 File Offset: 0x0065B896
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
