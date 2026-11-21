using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063BE RID: 25534
	public static class IConstraintValueTypeVerify
	{
		// Token: 0x0602B5C1 RID: 177601 RVA: 0x005E88E6 File Offset: 0x005E6AE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
