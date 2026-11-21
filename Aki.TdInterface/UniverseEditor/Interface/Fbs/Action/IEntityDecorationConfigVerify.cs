using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D57 RID: 27991
	public static class IEntityDecorationConfigVerify
	{
		// Token: 0x0603048F RID: 197775 RVA: 0x0068FEAA File Offset: 0x0068E0AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
