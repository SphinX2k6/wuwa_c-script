using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007719 RID: 30489
	public static class ISelfClientEventVerify
	{
		// Token: 0x060357E8 RID: 219112 RVA: 0x0072C00A File Offset: 0x0072A20A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
