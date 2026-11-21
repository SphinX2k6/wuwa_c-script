using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007096 RID: 28822
	public static class ILeisureInteractTypeVerify
	{
		// Token: 0x0603203A RID: 204858 RVA: 0x006C548E File Offset: 0x006C368E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
