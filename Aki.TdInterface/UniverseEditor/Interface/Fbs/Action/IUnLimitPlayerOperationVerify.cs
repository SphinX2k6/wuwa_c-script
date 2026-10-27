using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BF RID: 29887
	public static class IUnLimitPlayerOperationVerify
	{
		// Token: 0x06036562 RID: 222562 RVA: 0x0076255E File Offset: 0x0076075E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
