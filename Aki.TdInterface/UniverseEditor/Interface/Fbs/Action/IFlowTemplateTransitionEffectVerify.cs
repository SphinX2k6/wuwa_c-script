using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200682D RID: 26669
	public static class IFlowTemplateTransitionEffectVerify
	{
		// Token: 0x0602E7E6 RID: 190438 RVA: 0x006584AA File Offset: 0x006566AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
