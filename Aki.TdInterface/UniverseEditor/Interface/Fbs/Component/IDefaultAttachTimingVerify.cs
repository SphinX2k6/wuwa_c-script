using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200507D RID: 20605
	public static class IDefaultAttachTimingVerify
	{
		// Token: 0x06021082 RID: 135298 RVA: 0x00496966 File Offset: 0x00494B66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
