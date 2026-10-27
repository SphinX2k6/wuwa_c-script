using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005287 RID: 21127
	public static class IFlowerPollutionSplineConfigVerify
	{
		// Token: 0x060226A0 RID: 140960 RVA: 0x004C5421 File Offset: 0x004C3621
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
