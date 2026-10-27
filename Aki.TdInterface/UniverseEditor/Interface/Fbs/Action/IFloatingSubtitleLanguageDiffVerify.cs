using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E8 RID: 26600
	public static class IFloatingSubtitleLanguageDiffVerify
	{
		// Token: 0x0602E4EE RID: 189678 RVA: 0x00652752 File Offset: 0x00650952
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
