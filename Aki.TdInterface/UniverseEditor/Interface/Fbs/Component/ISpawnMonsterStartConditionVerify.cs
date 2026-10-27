using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005964 RID: 22884
	public static class ISpawnMonsterStartConditionVerify
	{
		// Token: 0x06026BC8 RID: 158664 RVA: 0x0055557A File Offset: 0x0055377A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
