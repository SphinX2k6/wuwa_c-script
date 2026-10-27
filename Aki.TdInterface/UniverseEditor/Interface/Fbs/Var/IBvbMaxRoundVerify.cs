using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A68 RID: 14952
	public static class IBvbMaxRoundVerify
	{
		// Token: 0x06014450 RID: 83024 RVA: 0x002F5F86 File Offset: 0x002F4186
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
