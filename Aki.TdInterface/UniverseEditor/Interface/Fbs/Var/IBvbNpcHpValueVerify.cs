using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E52 RID: 15954
	public static class IBvbNpcHpValueVerify
	{
		// Token: 0x060157C6 RID: 88006 RVA: 0x003198CA File Offset: 0x00317ACA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
