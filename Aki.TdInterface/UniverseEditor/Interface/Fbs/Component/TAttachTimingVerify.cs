using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BED RID: 23533
	public static class TAttachTimingVerify
	{
		// Token: 0x0602853C RID: 165180 RVA: 0x0058A520 File Offset: 0x00588720
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOnMoveWithSplineEndAttachTimingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDefaultAttachTimingVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
