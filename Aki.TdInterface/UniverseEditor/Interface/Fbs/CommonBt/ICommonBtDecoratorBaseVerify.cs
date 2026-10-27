using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB6 RID: 24246
	public static class ICommonBtDecoratorBaseVerify
	{
		// Token: 0x06029938 RID: 170296 RVA: 0x005B40B6 File Offset: 0x005B22B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
