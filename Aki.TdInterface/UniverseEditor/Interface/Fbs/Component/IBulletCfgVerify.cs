using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F39 RID: 20281
	public static class IBulletCfgVerify
	{
		// Token: 0x060201B8 RID: 131512 RVA: 0x004779B9 File Offset: 0x00475BB9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
