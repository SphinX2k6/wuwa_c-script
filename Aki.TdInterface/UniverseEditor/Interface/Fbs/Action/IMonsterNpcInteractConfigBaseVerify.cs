using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE4 RID: 27364
	public static class IMonsterNpcInteractConfigBaseVerify
	{
		// Token: 0x0602FF71 RID: 196465 RVA: 0x00685B22 File Offset: 0x00683D22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
