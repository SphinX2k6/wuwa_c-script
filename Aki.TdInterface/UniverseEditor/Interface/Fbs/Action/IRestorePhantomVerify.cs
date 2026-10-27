using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB7 RID: 28343
	public static class IRestorePhantomVerify
	{
		// Token: 0x06032183 RID: 205187 RVA: 0x006C5F82 File Offset: 0x006C4182
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
