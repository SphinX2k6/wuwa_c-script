using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006478 RID: 25720
	public static class IPhotoTargetCaptureUiEntityZeroVerify
	{
		// Token: 0x0602BB47 RID: 179015 RVA: 0x005F270E File Offset: 0x005F090E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
