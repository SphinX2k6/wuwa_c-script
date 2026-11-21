using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EF4 RID: 16116
	public static class ITimeDisplayParamsVerify
	{
		// Token: 0x06015DA9 RID: 89513 RVA: 0x00324946 File Offset: 0x00322B46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
