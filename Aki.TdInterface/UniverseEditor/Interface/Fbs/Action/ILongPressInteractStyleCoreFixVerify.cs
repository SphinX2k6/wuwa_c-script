using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A4F RID: 27215
	public static class ILongPressInteractStyleCoreFixVerify
	{
		// Token: 0x0602FA6F RID: 195183 RVA: 0x0067C5A2 File Offset: 0x0067A7A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
