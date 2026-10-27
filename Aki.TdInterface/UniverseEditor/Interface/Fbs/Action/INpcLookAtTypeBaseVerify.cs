using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD5 RID: 27605
	public static class INpcLookAtTypeBaseVerify
	{
		// Token: 0x060307F1 RID: 198641 RVA: 0x00695AB6 File Offset: 0x00693CB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
