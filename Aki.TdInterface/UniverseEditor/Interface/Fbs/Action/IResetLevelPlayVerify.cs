using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E8D RID: 28301
	public static class IResetLevelPlayVerify
	{
		// Token: 0x0603204A RID: 204874 RVA: 0x006C3E99 File Offset: 0x006C2099
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
