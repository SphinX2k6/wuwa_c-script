using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EBC RID: 24252
	public static class ICommonBtDoOnceDecoratorVerify
	{
		// Token: 0x0602995E RID: 170334 RVA: 0x005B443E File Offset: 0x005B263E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
