using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051EE RID: 20974
	public static class IExploreSkillInteractTypeVerify
	{
		// Token: 0x060220F7 RID: 139511 RVA: 0x004BA402 File Offset: 0x004B8602
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
