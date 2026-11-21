using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BC5 RID: 27589
	public static class IDeadeyeFadeOutConfigVerify
	{
		// Token: 0x0602F7E5 RID: 194533 RVA: 0x0067A0A2 File Offset: 0x006782A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
