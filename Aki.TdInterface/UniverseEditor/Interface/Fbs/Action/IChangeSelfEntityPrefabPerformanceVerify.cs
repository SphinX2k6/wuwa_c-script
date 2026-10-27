using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200631F RID: 25375
	public static class IChangeSelfEntityPrefabPerformanceVerify
	{
		// Token: 0x0602BE48 RID: 179784 RVA: 0x00608E83 File Offset: 0x00607083
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
