using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006475 RID: 25717
	public static class IPhotoTargetCaptureUiEachRequiredPointsVerify
	{
		// Token: 0x0602BB35 RID: 178997 RVA: 0x005F2596 File Offset: 0x005F0796
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
