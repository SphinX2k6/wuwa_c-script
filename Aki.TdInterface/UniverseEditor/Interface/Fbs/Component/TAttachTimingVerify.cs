using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006206 RID: 25094
	public static class TAttachTimingVerify
	{
		// Token: 0x0602AB0E RID: 174862 RVA: 0x005D20E8 File Offset: 0x005D02E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDefaultAttachTimingVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOnEntityStateChangeAttachTimingVerify.Verify(verifier, tablePos);
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
