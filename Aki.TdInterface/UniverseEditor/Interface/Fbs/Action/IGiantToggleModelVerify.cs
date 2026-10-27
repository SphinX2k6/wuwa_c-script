using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006890 RID: 26768
	public static class IGiantToggleModelVerify
	{
		// Token: 0x0602EAE9 RID: 191209 RVA: 0x0065D612 File Offset: 0x0065B812
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
