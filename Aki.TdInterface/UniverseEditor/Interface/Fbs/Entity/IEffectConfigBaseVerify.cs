using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004BEE RID: 19438
	public static class IEffectConfigBaseVerify
	{
		// Token: 0x0601DAF7 RID: 121591 RVA: 0x0042A4DA File Offset: 0x004286DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
