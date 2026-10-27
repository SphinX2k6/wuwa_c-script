using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062E6 RID: 25318
	public static class IChangeEntityPrefabPerformanceVerify
	{
		// Token: 0x0602BC2E RID: 179246 RVA: 0x006052D6 File Offset: 0x006034D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
