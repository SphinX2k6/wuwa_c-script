using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045DC RID: 17884
	public static class ITakePhoto2SequenceConditionVerify
	{
		// Token: 0x0601A1FA RID: 107002 RVA: 0x003B8D81 File Offset: 0x003B6F81
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
