using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004ABE RID: 19134
	public static class IGetAllGraduatedPhantomVerify
	{
		// Token: 0x0601CC71 RID: 117873 RVA: 0x0040DEC6 File Offset: 0x0040C0C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
