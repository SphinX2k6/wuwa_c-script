using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064EA RID: 25834
	public static class ICommonBtAlwaysTrueDecoratorVerify
	{
		// Token: 0x0602BED1 RID: 179921 RVA: 0x005F8EA6 File Offset: 0x005F70A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
