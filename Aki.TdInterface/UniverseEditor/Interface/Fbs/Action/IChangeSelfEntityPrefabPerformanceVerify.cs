using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006990 RID: 27024
	public static class IChangeSelfEntityPrefabPerformanceVerify
	{
		// Token: 0x0602E5B1 RID: 189873 RVA: 0x00653E8F File Offset: 0x0065208F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
