using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD7 RID: 23767
	public static class TWaySplinePointTypeVerify
	{
		// Token: 0x06028ABE RID: 166590 RVA: 0x00596498 File Offset: 0x00594698
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IWaySplineStartPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWaySplineCommonPointVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
