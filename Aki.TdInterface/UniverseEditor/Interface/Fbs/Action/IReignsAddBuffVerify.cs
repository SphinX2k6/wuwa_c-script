using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200759F RID: 30111
	public static class IReignsAddBuffVerify
	{
		// Token: 0x06034D26 RID: 216358 RVA: 0x0071A0F6 File Offset: 0x007182F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
