using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066B9 RID: 26297
	public static class IEnterMovieModeDurationTypeVerify
	{
		// Token: 0x0602DB69 RID: 187241 RVA: 0x006411EE File Offset: 0x0063F3EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
