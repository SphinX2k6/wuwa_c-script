using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006948 RID: 26952
	public static class IChangeElementalBoxStatePlayerTargetVerify
	{
		// Token: 0x0602E339 RID: 189241 RVA: 0x0064FAAA File Offset: 0x0064DCAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
