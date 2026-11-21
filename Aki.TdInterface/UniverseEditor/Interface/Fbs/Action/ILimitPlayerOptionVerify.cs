using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D8 RID: 28888
	public static class ILimitPlayerOptionVerify
	{
		// Token: 0x060322AD RID: 205485 RVA: 0x006C99C2 File Offset: 0x006C7BC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
