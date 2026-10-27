using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A53 RID: 14931
	public static class IBvbDungeonStageVerify
	{
		// Token: 0x060143A9 RID: 82857 RVA: 0x002F49DA File Offset: 0x002F2BDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
