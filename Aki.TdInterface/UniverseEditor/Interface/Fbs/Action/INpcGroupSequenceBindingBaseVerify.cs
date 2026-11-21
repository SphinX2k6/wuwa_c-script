using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730C RID: 29452
	public static class INpcGroupSequenceBindingBaseVerify
	{
		// Token: 0x060335C2 RID: 210370 RVA: 0x006ED092 File Offset: 0x006EB292
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
