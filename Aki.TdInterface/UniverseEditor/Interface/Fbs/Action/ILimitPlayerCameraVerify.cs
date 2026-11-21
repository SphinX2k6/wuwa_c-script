using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C9 RID: 28873
	public static class ILimitPlayerCameraVerify
	{
		// Token: 0x06032232 RID: 205362 RVA: 0x006C8BD2 File Offset: 0x006C6DD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
