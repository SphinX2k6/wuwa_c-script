using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005675 RID: 22133
	public static class IEffectAreaModeVerify
	{
		// Token: 0x0602365B RID: 144987 RVA: 0x004DE782 File Offset: 0x004DC982
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
