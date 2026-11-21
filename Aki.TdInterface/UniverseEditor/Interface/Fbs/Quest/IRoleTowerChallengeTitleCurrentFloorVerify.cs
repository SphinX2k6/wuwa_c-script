using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004501 RID: 17665
	public static class IRoleTowerChallengeTitleCurrentFloorVerify
	{
		// Token: 0x0601990E RID: 104718 RVA: 0x003A50CA File Offset: 0x003A32CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
