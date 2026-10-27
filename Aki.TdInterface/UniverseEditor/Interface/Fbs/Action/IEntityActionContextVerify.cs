using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066D7 RID: 26327
	public static class IEntityActionContextVerify
	{
		// Token: 0x0602DC42 RID: 187458 RVA: 0x00642765 File Offset: 0x00640965
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
