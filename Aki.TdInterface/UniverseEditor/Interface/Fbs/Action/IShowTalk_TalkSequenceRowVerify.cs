using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D1 RID: 30929
	public static class IShowTalk_TalkSequenceRowVerify
	{
		// Token: 0x06036748 RID: 223048 RVA: 0x0074A9B9 File Offset: 0x00748BB9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
