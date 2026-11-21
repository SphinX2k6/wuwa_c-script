using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004618 RID: 17944
	public static class ITetrisPlayModeBaseVerify
	{
		// Token: 0x0601A3ED RID: 107501 RVA: 0x003BCABE File Offset: 0x003BACBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
