using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A99 RID: 27289
	public static class IMechStuntHighSpeedVerify
	{
		// Token: 0x0602FD29 RID: 195881 RVA: 0x00681AFE File Offset: 0x0067FCFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
