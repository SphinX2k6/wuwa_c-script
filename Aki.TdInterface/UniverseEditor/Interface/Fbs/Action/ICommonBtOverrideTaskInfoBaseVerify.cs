using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD8 RID: 27352
	public static class ICommonBtOverrideTaskInfoBaseVerify
	{
		// Token: 0x0602EFE1 RID: 192481 RVA: 0x00668BA2 File Offset: 0x00666DA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
