using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007605 RID: 30213
	public static class IResetEntityConfigVerify
	{
		// Token: 0x0603503A RID: 217146 RVA: 0x0071F3CA File Offset: 0x0071D5CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
