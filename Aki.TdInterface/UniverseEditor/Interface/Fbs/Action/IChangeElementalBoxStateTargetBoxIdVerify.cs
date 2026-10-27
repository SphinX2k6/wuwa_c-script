using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062DD RID: 25309
	public static class IChangeElementalBoxStateTargetBoxIdVerify
	{
		// Token: 0x0602BBF8 RID: 179192 RVA: 0x00604E08 File Offset: 0x00603008
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
