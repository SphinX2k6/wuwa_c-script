using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006698 RID: 26264
	public static class IEnableTakePhotoClipVerify
	{
		// Token: 0x0602DA68 RID: 186984 RVA: 0x0063F626 File Offset: 0x0063D826
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
