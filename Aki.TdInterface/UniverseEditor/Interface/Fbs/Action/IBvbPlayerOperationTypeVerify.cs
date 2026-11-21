using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C1 RID: 26817
	public static class IBvbPlayerOperationTypeVerify
	{
		// Token: 0x0602DDDC RID: 187868 RVA: 0x0064475A File Offset: 0x0064295A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
