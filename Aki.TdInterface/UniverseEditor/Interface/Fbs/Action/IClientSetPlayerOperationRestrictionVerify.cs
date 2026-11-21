using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A67 RID: 27239
	public static class IClientSetPlayerOperationRestrictionVerify
	{
		// Token: 0x0602EBCA RID: 191434 RVA: 0x0065EB8E File Offset: 0x0065CD8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
