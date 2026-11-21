using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C77 RID: 23671
	public static class IPasserbyNpcExitTimingBase_UnionVerify
	{
		// Token: 0x0602743E RID: 160830 RVA: 0x00560B8C File Offset: 0x0055ED8C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPasserbyNpcLiftStopExitTimingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPasserbyNpcExitTimingBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
