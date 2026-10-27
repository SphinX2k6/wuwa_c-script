using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E3B RID: 24123
	public static class IPhotoTargetCaptureUiEntityZeroVerify
	{
		// Token: 0x060294BD RID: 169149 RVA: 0x005A99DE File Offset: 0x005A7BDE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
