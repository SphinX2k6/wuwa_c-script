using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075CC RID: 30156
	public static class IRemoveEntityDecorationVerify
	{
		// Token: 0x06034E73 RID: 216691 RVA: 0x0071C072 File Offset: 0x0071A272
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
