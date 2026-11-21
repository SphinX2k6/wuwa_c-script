using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC7 RID: 28615
	public static class IHideWorldMonsterAndMonsterTreasureVerify
	{
		// Token: 0x0603192B RID: 203051 RVA: 0x006B7BD6 File Offset: 0x006B5DD6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
