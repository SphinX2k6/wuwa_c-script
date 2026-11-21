using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007862 RID: 30818
	public static class ISetTimeLockStateVerify
	{
		// Token: 0x0603633D RID: 222013 RVA: 0x00742BC2 File Offset: 0x00740DC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
