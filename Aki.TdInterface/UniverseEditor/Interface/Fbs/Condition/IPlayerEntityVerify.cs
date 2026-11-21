using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005186 RID: 20870
	public static class IPlayerEntityVerify
	{
		// Token: 0x06020D70 RID: 134512 RVA: 0x0048B9A6 File Offset: 0x00489BA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
