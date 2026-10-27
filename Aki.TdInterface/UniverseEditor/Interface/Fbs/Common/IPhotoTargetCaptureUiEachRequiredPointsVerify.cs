using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E38 RID: 24120
	public static class IPhotoTargetCaptureUiEachRequiredPointsVerify
	{
		// Token: 0x060294AB RID: 169131 RVA: 0x005A9866 File Offset: 0x005A7A66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
