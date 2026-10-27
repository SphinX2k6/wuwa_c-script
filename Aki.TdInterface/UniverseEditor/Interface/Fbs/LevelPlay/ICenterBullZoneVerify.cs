using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004442 RID: 17474
	public static class ICenterBullZoneVerify
	{
		// Token: 0x06019FF3 RID: 106483 RVA: 0x003B7512 File Offset: 0x003B5712
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
