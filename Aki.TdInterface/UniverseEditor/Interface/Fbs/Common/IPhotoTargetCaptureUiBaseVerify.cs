using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E2F RID: 24111
	public static class IPhotoTargetCaptureUiBaseVerify
	{
		// Token: 0x0602946B RID: 169067 RVA: 0x005A917A File Offset: 0x005A737A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
