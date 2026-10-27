using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005925 RID: 22821
	public static class ISkyboxTriggerVerify
	{
		// Token: 0x0602696D RID: 158061 RVA: 0x00550942 File Offset: 0x0054EB42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
