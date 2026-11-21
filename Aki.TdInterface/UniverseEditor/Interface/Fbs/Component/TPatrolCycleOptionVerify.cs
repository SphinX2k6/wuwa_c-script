using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062AE RID: 25262
	public static class TPatrolCycleOptionVerify
	{
		// Token: 0x0602AF56 RID: 175958 RVA: 0x005DC4B0 File Offset: 0x005DA6B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPatrolCycleOncelyVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPatrolCycleLooplyVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
