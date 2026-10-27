using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F35 RID: 28469
	public static class ISceneInteractionOperationTypeVerify
	{
		// Token: 0x060324D0 RID: 206032 RVA: 0x006CB3BA File Offset: 0x006C95BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
