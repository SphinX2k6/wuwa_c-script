using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682B RID: 26667
	public static class IAutomaticDriveVerify
	{
		// Token: 0x0602D916 RID: 186646 RVA: 0x0063C526 File Offset: 0x0063A726
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
