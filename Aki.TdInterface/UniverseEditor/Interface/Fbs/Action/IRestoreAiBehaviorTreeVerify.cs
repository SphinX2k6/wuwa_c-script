using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB4 RID: 28340
	public static class IRestoreAiBehaviorTreeVerify
	{
		// Token: 0x06032176 RID: 205174 RVA: 0x006C5E91 File Offset: 0x006C4091
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
