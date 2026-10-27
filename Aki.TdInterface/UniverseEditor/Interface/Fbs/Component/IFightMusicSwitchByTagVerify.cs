using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200524E RID: 21070
	public static class IFightMusicSwitchByTagVerify
	{
		// Token: 0x06022468 RID: 140392 RVA: 0x004C0D46 File Offset: 0x004BEF46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
