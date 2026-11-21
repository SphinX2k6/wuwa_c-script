using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E6 RID: 30438
	public static class ISceneUiSubtitlePositionBaseVerify
	{
		// Token: 0x06035674 RID: 218740 RVA: 0x007298FA File Offset: 0x00727AFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
