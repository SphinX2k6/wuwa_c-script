using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D5A RID: 15706
	public static class ICheckPlayerInputBaseVerify
	{
		// Token: 0x06015BAA RID: 89002 RVA: 0x0032261E File Offset: 0x0032081E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
