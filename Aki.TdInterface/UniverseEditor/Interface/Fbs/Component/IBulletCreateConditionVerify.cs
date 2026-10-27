using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F3C RID: 20284
	public static class IBulletCreateConditionVerify
	{
		// Token: 0x060201CE RID: 131534 RVA: 0x00477BA9 File Offset: 0x00475DA9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
