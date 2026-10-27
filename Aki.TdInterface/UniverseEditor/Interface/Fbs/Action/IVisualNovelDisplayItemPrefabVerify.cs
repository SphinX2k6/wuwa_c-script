using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007588 RID: 30088
	public static class IVisualNovelDisplayItemPrefabVerify
	{
		// Token: 0x06036BC3 RID: 224195 RVA: 0x0076E4A4 File Offset: 0x0076C6A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
