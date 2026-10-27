using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047F2 RID: 18418
	public static class IVoxelInfoVerify
	{
		// Token: 0x0601C7CB RID: 116683 RVA: 0x00407A12 File Offset: 0x00405C12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
