using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FBD RID: 20413
	public static class IColorChangeStrategyOfRGBVerify
	{
		// Token: 0x060207FE RID: 133118 RVA: 0x004854F8 File Offset: 0x004836F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
