using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C80 RID: 23680
	public static class TPatrolCycleOptionVerify
	{
		// Token: 0x0602891C RID: 166172 RVA: 0x00593E74 File Offset: 0x00592074
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
