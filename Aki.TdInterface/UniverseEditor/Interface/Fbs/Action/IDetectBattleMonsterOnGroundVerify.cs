using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C19 RID: 27673
	public static class IDetectBattleMonsterOnGroundVerify
	{
		// Token: 0x0602FA08 RID: 195080 RVA: 0x0067D49E File Offset: 0x0067B69E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
