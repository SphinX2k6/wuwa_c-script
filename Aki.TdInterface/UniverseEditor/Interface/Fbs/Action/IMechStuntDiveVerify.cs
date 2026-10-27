using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A96 RID: 27286
	public static class IMechStuntDiveVerify
	{
		// Token: 0x0602FD17 RID: 195863 RVA: 0x00681986 File Offset: 0x0067FB86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
