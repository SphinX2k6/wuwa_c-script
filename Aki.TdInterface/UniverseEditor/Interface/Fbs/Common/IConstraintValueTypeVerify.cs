using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D81 RID: 23937
	public static class IConstraintValueTypeVerify
	{
		// Token: 0x06028F37 RID: 167735 RVA: 0x0059FBB6 File Offset: 0x0059DDB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
