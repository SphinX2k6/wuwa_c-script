using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007234 RID: 29236
	public static class ISummonEntityTypeVerify
	{
		// Token: 0x06033DB7 RID: 212407 RVA: 0x006FA322 File Offset: 0x006F8522
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
