using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005908 RID: 22792
	public static class IHitBulletTypePlayerOrThrenodianAttackVerify
	{
		// Token: 0x06025089 RID: 151689 RVA: 0x00514FA6 File Offset: 0x005131A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
