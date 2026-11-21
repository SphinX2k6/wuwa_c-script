using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F39 RID: 16185
	public static class IWoodenBoxProliferateSpawnConfigVerify
	{
		// Token: 0x0601602E RID: 90158 RVA: 0x00329812 File Offset: 0x00327A12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
