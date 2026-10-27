using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D10 RID: 27920
	public static class IPlayerSlideRailEndVerify
	{
		// Token: 0x060313BD RID: 201661 RVA: 0x006AD97E File Offset: 0x006ABB7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
