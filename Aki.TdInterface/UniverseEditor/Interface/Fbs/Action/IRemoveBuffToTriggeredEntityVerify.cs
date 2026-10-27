using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E42 RID: 28226
	public static class IRemoveBuffToTriggeredEntityVerify
	{
		// Token: 0x06031E15 RID: 204309 RVA: 0x006C0049 File Offset: 0x006BE249
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
