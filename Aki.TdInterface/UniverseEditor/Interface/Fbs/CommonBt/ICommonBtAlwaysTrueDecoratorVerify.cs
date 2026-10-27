using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA7 RID: 24231
	public static class ICommonBtAlwaysTrueDecoratorVerify
	{
		// Token: 0x06029829 RID: 170025 RVA: 0x005AFF02 File Offset: 0x005AE102
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
