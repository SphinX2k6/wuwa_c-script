using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044F3 RID: 17651
	public static class ILevelPlayInfoMappingBaseVerify
	{
		// Token: 0x0601A7D6 RID: 108502 RVA: 0x003C8B5A File Offset: 0x003C6D5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
