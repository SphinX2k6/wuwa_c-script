using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC7 RID: 20167
	public static class IAttachTiming_UnionVerify
	{
		// Token: 0x0601FC3E RID: 130110 RVA: 0x0046BE80 File Offset: 0x0046A080
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAttachTimingVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDefaultAttachTimingVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOnMoveWithSplineEndAttachTimingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
