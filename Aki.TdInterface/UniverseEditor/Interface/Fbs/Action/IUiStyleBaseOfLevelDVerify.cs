using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074AD RID: 29869
	public static class IUiStyleBaseOfLevelDVerify
	{
		// Token: 0x060364DF RID: 222431 RVA: 0x007617BE File Offset: 0x0075F9BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
