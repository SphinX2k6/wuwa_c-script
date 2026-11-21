using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006406 RID: 25606
	public static class IGiantResponseTypeVerify
	{
		// Token: 0x0602B80B RID: 178187 RVA: 0x005ECD86 File Offset: 0x005EAF86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
