using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6B RID: 27755
	public static class IPathLineFacingTypeVerify
	{
		// Token: 0x06030E6E RID: 200302 RVA: 0x006A4176 File Offset: 0x006A2376
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
