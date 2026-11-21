using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E29 RID: 28201
	public static class IFinishDungeonVerify
	{
		// Token: 0x06030B29 RID: 199465 RVA: 0x0069C09E File Offset: 0x0069A29E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
