using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Online
{
	// Token: 0x02004389 RID: 17289
	public static class IOfflineEntityComponentConfigVerify
	{
		// Token: 0x06019B8C RID: 105356 RVA: 0x003AF09D File Offset: 0x003AD29D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
