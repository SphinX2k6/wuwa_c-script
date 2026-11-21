using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E7 RID: 25831
	public static class ICommonBtAlwaysFalseDecoratorVerify
	{
		// Token: 0x0602BEBF RID: 179903 RVA: 0x005F8D2E File Offset: 0x005F6F2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
