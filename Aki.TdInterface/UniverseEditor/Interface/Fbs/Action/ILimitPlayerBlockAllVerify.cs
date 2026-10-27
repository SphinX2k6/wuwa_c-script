using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A16 RID: 27158
	public static class ILimitPlayerBlockAllVerify
	{
		// Token: 0x0602F860 RID: 194656 RVA: 0x00678702 File Offset: 0x00676902
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
