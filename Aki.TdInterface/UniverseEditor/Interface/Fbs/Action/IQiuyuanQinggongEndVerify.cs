using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DDF RID: 28127
	public static class IQiuyuanQinggongEndVerify
	{
		// Token: 0x06031AEE RID: 203502 RVA: 0x006BA9D2 File Offset: 0x006B8BD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
