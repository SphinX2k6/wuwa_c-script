using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200433E RID: 17214
	public static class IAcmFreeVerify
	{
		// Token: 0x06019858 RID: 104536 RVA: 0x003A7956 File Offset: 0x003A5B56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
