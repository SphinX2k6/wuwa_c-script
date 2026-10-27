using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F7 RID: 22263
	public static class IPathDrivenActorSpawnBaseVerify
	{
		// Token: 0x06025347 RID: 152391 RVA: 0x005225DA File Offset: 0x005207DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
