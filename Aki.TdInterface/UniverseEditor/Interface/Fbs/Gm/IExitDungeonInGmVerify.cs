using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AB2 RID: 19122
	public static class IExitDungeonInGmVerify
	{
		// Token: 0x0601CBF5 RID: 117749 RVA: 0x0040D1BE File Offset: 0x0040B3BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
