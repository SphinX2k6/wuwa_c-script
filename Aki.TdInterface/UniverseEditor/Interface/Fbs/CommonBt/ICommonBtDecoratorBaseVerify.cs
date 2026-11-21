using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F9 RID: 25849
	public static class ICommonBtDecoratorBaseVerify
	{
		// Token: 0x0602BFEC RID: 180204 RVA: 0x005FD59A File Offset: 0x005FB79A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
