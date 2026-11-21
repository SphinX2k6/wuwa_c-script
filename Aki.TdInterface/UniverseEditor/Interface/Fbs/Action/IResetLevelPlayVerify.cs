using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007611 RID: 30225
	public static class IResetLevelPlayVerify
	{
		// Token: 0x0603508A RID: 217226 RVA: 0x0071FBCD File Offset: 0x0071DDCD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
