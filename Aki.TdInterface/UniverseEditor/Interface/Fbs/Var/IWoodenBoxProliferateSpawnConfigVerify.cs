using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B37 RID: 15159
	public static class IWoodenBoxProliferateSpawnConfigVerify
	{
		// Token: 0x06014B84 RID: 84868 RVA: 0x00303582 File Offset: 0x00301782
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
