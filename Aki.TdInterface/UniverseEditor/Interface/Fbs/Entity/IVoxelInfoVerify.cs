using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C5A RID: 19546
	public static class IVoxelInfoVerify
	{
		// Token: 0x0601DFC8 RID: 122824 RVA: 0x00434362 File Offset: 0x00432562
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
