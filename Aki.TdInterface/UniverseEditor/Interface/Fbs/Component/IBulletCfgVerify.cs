using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546B RID: 21611
	public static class IBulletCfgVerify
	{
		// Token: 0x06021F28 RID: 139048 RVA: 0x004ADD4D File Offset: 0x004ABF4D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
