using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051BC RID: 20924
	public static class ISelfClientEventVerify
	{
		// Token: 0x06020F18 RID: 134936 RVA: 0x0048E58A File Offset: 0x0048C78A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
