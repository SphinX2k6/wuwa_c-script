using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595B RID: 22875
	public static class ISpawnMonsterPreConditonTypeVerify
	{
		// Token: 0x06026B8C RID: 158604 RVA: 0x00554FDA File Offset: 0x005531DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
