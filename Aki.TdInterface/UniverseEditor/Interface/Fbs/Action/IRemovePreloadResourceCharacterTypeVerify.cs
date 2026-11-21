using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075E1 RID: 30177
	public static class IRemovePreloadResourceCharacterTypeVerify
	{
		// Token: 0x06034F0B RID: 216843 RVA: 0x0071D096 File Offset: 0x0071B296
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
