using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x0200477A RID: 18298
	public static class IAreaEntitiesVerify
	{
		// Token: 0x0601C2A4 RID: 115364 RVA: 0x003FD39D File Offset: 0x003FB59D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
