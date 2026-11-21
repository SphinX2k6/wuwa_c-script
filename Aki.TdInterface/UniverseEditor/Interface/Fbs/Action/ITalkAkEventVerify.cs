using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A66 RID: 31334
	public static class ITalkAkEventVerify
	{
		// Token: 0x06037396 RID: 226198 RVA: 0x00760432 File Offset: 0x0075E632
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
