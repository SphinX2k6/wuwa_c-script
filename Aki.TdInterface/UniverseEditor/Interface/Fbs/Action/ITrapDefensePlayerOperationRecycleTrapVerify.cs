using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C55 RID: 31829
	public static class ITrapDefensePlayerOperationRecycleTrapVerify
	{
		// Token: 0x060395FE RID: 235006 RVA: 0x007BF0EA File Offset: 0x007BD2EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
