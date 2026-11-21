using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064FF RID: 25855
	public static class ICommonBtDoOnceDecoratorVerify
	{
		// Token: 0x0602C012 RID: 180242 RVA: 0x005FD922 File Offset: 0x005FBB22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
