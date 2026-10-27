using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066FE RID: 26366
	public static class IExecBattleActionTypeVerify
	{
		// Token: 0x0602DDB0 RID: 187824 RVA: 0x00645502 File Offset: 0x00643702
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
