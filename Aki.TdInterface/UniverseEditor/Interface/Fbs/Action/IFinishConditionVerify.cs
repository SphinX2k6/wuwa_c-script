using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A3 RID: 26531
	public static class IFinishConditionVerify
	{
		// Token: 0x0602E2C4 RID: 189124 RVA: 0x0064E706 File Offset: 0x0064C906
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
