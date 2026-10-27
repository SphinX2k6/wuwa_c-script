using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A43 RID: 27203
	public static class ILongPressInteractStyleConfigVerify
	{
		// Token: 0x0602FA19 RID: 195097 RVA: 0x0067BD8A File Offset: 0x00679F8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
