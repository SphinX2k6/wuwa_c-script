using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005922 RID: 22818
	public static class ISkyboxGlobalTriggerVerify
	{
		// Token: 0x0602695B RID: 158043 RVA: 0x005507CA File Offset: 0x0054E9CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
