using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006220 RID: 25120
	public static class IBpActorFuncTypeBaseVerify
	{
		// Token: 0x0602B4D3 RID: 177363 RVA: 0x005F69CE File Offset: 0x005F4BCE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
