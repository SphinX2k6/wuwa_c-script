using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200617A RID: 24954
	public static class IWaySplinePointType_UnionVerify
	{
		// Token: 0x0602A650 RID: 173648 RVA: 0x005C8BE8 File Offset: 0x005C6DE8
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
