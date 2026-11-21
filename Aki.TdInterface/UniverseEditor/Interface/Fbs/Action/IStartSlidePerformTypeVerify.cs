using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200798E RID: 31118
	public static class IStartSlidePerformTypeVerify
	{
		// Token: 0x06036CFF RID: 224511 RVA: 0x00754E0A File Offset: 0x0075300A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
