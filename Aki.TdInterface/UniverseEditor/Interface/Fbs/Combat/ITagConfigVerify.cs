using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EF2 RID: 24306
	public static class ITagConfigVerify
	{
		// Token: 0x06029BEB RID: 170987 RVA: 0x005BA7C6 File Offset: 0x005B89C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
