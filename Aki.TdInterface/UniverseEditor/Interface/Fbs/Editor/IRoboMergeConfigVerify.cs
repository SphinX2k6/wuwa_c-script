using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D08 RID: 19720
	public static class IRoboMergeConfigVerify
	{
		// Token: 0x0601E84C RID: 125004 RVA: 0x00445E81 File Offset: 0x00444081
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
