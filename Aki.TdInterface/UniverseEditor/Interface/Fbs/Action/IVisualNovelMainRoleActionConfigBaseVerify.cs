using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200758B RID: 30091
	public static class IVisualNovelMainRoleActionConfigBaseVerify
	{
		// Token: 0x06036BD5 RID: 224213 RVA: 0x0076E62A File Offset: 0x0076C82A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
