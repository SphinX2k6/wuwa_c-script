using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC0 RID: 19648
	public static class ISelfClientEventVerify
	{
		// Token: 0x0601F2D4 RID: 127700 RVA: 0x0045A692 File Offset: 0x00458892
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
