using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200647B RID: 25723
	public static class IPhotoTargetCaptureUiRequiredPointsCenterVerify
	{
		// Token: 0x0602BB59 RID: 179033 RVA: 0x005F2886 File Offset: 0x005F0A86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
