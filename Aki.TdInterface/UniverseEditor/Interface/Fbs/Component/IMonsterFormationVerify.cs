using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B15 RID: 23317
	public static class IMonsterFormationVerify
	{
		// Token: 0x0602655D RID: 157021 RVA: 0x005407A1 File Offset: 0x0053E9A1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
