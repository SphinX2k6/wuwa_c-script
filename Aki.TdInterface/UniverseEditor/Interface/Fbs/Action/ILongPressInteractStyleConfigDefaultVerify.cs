using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A46 RID: 27206
	public static class ILongPressInteractStyleConfigDefaultVerify
	{
		// Token: 0x0602FA2B RID: 195115 RVA: 0x0067BF02 File Offset: 0x0067A102
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
