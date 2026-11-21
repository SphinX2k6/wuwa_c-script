using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687F RID: 26751
	public static class IBlendAnimTypeBaseVerify
	{
		// Token: 0x0602DBAD RID: 187309 RVA: 0x006409E6 File Offset: 0x0063EBE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
