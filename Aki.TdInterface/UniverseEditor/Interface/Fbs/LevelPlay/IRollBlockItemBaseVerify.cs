using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049FA RID: 18938
	public static class IRollBlockItemBaseVerify
	{
		// Token: 0x0601C64F RID: 116303 RVA: 0x00402DEA File Offset: 0x00400FEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
