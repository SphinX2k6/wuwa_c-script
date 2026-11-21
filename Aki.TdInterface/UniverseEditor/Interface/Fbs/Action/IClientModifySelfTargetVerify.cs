using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A55 RID: 27221
	public static class IClientModifySelfTargetVerify
	{
		// Token: 0x0602EB2A RID: 191274 RVA: 0x0065D80E File Offset: 0x0065BA0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
