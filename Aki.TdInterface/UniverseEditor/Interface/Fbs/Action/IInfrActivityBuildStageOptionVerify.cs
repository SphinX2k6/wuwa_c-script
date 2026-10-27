using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200694A RID: 26954
	public static class IInfrActivityBuildStageOptionVerify
	{
		// Token: 0x0602F109 RID: 192777 RVA: 0x0066A2BA File Offset: 0x006684BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
