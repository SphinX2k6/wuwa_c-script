using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D5 RID: 30165
	public static class IRemoveNpcGroupPerformVerify
	{
		// Token: 0x06034EB5 RID: 216757 RVA: 0x0071C6E9 File Offset: 0x0071A8E9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
