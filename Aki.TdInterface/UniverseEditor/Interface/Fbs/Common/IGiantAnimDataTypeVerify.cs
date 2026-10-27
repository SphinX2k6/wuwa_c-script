using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB7 RID: 23991
	public static class IGiantAnimDataTypeVerify
	{
		// Token: 0x06029103 RID: 168195 RVA: 0x005A3452 File Offset: 0x005A1652
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
