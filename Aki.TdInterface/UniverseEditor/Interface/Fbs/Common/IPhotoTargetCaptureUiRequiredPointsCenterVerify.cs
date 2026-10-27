using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E3E RID: 24126
	public static class IPhotoTargetCaptureUiRequiredPointsCenterVerify
	{
		// Token: 0x060294CF RID: 169167 RVA: 0x005A9B56 File Offset: 0x005A7D56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
