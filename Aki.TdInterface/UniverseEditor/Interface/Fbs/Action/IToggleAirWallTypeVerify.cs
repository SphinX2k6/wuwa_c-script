using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BDA RID: 31706
	public static class IToggleAirWallTypeVerify
	{
		// Token: 0x06039259 RID: 234073 RVA: 0x007B8D8E File Offset: 0x007B6F8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
