using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1F RID: 27167
	public static class IClientEventTargetVerify
	{
		// Token: 0x0602E9B2 RID: 190898 RVA: 0x0065AEC2 File Offset: 0x006590C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
