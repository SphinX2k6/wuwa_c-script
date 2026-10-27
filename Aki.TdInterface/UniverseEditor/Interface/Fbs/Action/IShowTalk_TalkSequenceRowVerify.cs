using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007105 RID: 28933
	public static class IShowTalk_TalkSequenceRowVerify
	{
		// Token: 0x060334A6 RID: 210086 RVA: 0x006EA3AD File Offset: 0x006E85AD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
