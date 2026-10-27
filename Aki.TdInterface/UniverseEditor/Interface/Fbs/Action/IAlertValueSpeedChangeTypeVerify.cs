using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006190 RID: 24976
	public static class IAlertValueSpeedChangeTypeVerify
	{
		// Token: 0x0602B055 RID: 176213 RVA: 0x005EF2CA File Offset: 0x005ED4CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
