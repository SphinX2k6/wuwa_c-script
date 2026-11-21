using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C61 RID: 27745
	public static class IDisableSceneInteractionOperationVerify
	{
		// Token: 0x0602FC87 RID: 195719 RVA: 0x00681F1E File Offset: 0x0068011E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
