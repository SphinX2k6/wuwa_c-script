using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C1 RID: 26561
	public static class IFireBulletTypeVerify
	{
		// Token: 0x0602E3CE RID: 189390 RVA: 0x006509AA File Offset: 0x0064EBAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
