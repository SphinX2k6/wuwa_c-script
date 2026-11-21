using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006957 RID: 26967
	public static class IChangeEntityPrefabPerformanceVerify
	{
		// Token: 0x0602E397 RID: 189335 RVA: 0x006502E2 File Offset: 0x0064E4E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
