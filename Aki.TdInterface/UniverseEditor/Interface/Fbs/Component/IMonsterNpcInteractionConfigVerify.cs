using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B21 RID: 23329
	public static class IMonsterNpcInteractionConfigVerify
	{
		// Token: 0x060265E3 RID: 157155 RVA: 0x00541852 File Offset: 0x0053FA52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
