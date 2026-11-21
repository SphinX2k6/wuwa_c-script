using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1C RID: 27676
	public static class IDetectBattleStateTypeVerify
	{
		// Token: 0x0602FA1A RID: 195098 RVA: 0x0067D616 File Offset: 0x0067B816
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
