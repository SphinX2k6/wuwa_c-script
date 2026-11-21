using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200616B RID: 24939
	public static class IWaterStagnationActorConfigVerify
	{
		// Token: 0x0602A5A2 RID: 173474 RVA: 0x005C7452 File Offset: 0x005C5652
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
