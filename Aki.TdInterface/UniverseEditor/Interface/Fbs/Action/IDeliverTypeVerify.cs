using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006578 RID: 25976
	public static class IDeliverTypeVerify
	{
		// Token: 0x0602D107 RID: 184583 RVA: 0x0062EDCA File Offset: 0x0062CFCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
