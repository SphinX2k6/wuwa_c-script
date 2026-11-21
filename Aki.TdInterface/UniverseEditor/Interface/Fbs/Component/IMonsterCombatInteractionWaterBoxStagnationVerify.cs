using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0C RID: 23308
	public static class IMonsterCombatInteractionWaterBoxStagnationVerify
	{
		// Token: 0x060264C9 RID: 156873 RVA: 0x0053F112 File Offset: 0x0053D312
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
