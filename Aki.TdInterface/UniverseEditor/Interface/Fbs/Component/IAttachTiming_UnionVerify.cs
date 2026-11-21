using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F6 RID: 21494
	public static class IAttachTiming_UnionVerify
	{
		// Token: 0x06021982 RID: 137602 RVA: 0x004A1C40 File Offset: 0x0049FE40
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
			case 4:
				result = IOnEntityStateChangeAttachTimingVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
