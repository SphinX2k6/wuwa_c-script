using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006439 RID: 25657
	public static class IGravityDirectionTypeVerify
	{
		// Token: 0x0602B97D RID: 178557 RVA: 0x005EF4FE File Offset: 0x005ED6FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
