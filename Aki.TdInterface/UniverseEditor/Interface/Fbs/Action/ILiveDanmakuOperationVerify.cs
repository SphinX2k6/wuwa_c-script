using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EA RID: 28906
	public static class ILiveDanmakuOperationVerify
	{
		// Token: 0x0603232F RID: 205615 RVA: 0x006CA5E2 File Offset: 0x006C87E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
