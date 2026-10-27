using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004831 RID: 18481
	public static class IBuffDurationInstantVerify
	{
		// Token: 0x0601C914 RID: 117012 RVA: 0x0040A20E File Offset: 0x0040840E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
