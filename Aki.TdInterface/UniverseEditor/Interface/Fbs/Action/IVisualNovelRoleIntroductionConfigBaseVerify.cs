using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D9 RID: 30169
	public static class IVisualNovelRoleIntroductionConfigBaseVerify
	{
		// Token: 0x06036F53 RID: 225107 RVA: 0x007755D6 File Offset: 0x007737D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
