using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF3 RID: 27379
	public static class ICommonTip2TypeVerify
	{
		// Token: 0x0602F11D RID: 192797 RVA: 0x0066BD46 File Offset: 0x00669F46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
