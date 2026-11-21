using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2F RID: 28207
	public static class IFinishTalkVerify
	{
		// Token: 0x06030B43 RID: 199491 RVA: 0x0069C27E File Offset: 0x0069A47E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
