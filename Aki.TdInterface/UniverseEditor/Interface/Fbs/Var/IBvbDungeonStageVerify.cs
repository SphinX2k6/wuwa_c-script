using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E2E RID: 15918
	public static class IBvbDungeonStageVerify
	{
		// Token: 0x060156C5 RID: 87749 RVA: 0x00317BC6 File Offset: 0x00315DC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
