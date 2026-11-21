using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D3 RID: 29139
	public static class IModifyActorMaterialParamByPlayerSplineProgressVerify
	{
		// Token: 0x06032AF9 RID: 207609 RVA: 0x006D8D4E File Offset: 0x006D6F4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
