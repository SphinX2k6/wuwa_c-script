using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BCF RID: 27599
	public static class INpcLookAtPlayerVerify
	{
		// Token: 0x060307C9 RID: 198601 RVA: 0x006956B2 File Offset: 0x006938B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
