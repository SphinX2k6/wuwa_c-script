using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3B RID: 28475
	public static class ISceneItemMoveMotionTypeVerify
	{
		// Token: 0x060324F0 RID: 206064 RVA: 0x006CB67A File Offset: 0x006C987A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
