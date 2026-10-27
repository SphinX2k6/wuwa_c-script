using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED4 RID: 24276
	public static class ICommonBtTaskInfoBaseVerify
	{
		// Token: 0x06029B2B RID: 170795 RVA: 0x005B92EE File Offset: 0x005B74EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
