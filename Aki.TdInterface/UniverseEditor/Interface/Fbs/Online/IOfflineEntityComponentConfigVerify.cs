using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Online
{
	// Token: 0x020047EB RID: 18411
	public static class IOfflineEntityComponentConfigVerify
	{
		// Token: 0x0601B31A RID: 111386 RVA: 0x003DAAC5 File Offset: 0x003D8CC5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
