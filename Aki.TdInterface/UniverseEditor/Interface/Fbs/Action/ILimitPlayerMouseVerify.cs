using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1C RID: 27164
	public static class ILimitPlayerMouseVerify
	{
		// Token: 0x0602F884 RID: 194692 RVA: 0x006789F2 File Offset: 0x00676BF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
