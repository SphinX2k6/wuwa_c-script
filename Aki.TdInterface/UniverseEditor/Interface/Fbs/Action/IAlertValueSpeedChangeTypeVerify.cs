using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FB RID: 26619
	public static class IAlertValueSpeedChangeTypeVerify
	{
		// Token: 0x0602D786 RID: 186246 RVA: 0x00639B3E File Offset: 0x00637D3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
