using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057EF RID: 22511
	public static class IFlowerPollutionSplineConfigVerify
	{
		// Token: 0x0602463A RID: 149050 RVA: 0x004FFF91 File Offset: 0x004FE191
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
