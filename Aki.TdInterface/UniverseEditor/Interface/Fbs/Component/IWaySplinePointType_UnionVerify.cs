using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B64 RID: 23396
	public static class IWaySplinePointType_UnionVerify
	{
		// Token: 0x0602808C RID: 163980 RVA: 0x00581158 File Offset: 0x0057F358
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWaySplinePointTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWaySplineCommonPointVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWaySplineStartPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
