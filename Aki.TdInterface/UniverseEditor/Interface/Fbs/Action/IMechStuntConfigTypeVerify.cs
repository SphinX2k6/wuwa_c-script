using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A90 RID: 27280
	public static class IMechStuntConfigTypeVerify
	{
		// Token: 0x0602FCEF RID: 195823 RVA: 0x006815C2 File Offset: 0x0067F7C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
