using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F8 RID: 30456
	public static class ISceneUiSubtitleTextBaseVerify
	{
		// Token: 0x0603570C RID: 218892 RVA: 0x0072AB92 File Offset: 0x00728D92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
