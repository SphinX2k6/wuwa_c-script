using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004834 RID: 18484
	public static class IBuffDurationPermanentVerify
	{
		// Token: 0x0601C926 RID: 117030 RVA: 0x0040A386 File Offset: 0x00408586
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
