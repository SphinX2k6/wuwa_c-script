using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EE6 RID: 24294
	public static class IBuffConfigVerify
	{
		// Token: 0x06029B89 RID: 170889 RVA: 0x005B9CEF File Offset: 0x005B7EEF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
