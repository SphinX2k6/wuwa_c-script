using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D9F RID: 23967
	public static class IEaseCurveType_UnionVerify
	{
		// Token: 0x06029041 RID: 168001 RVA: 0x005A1FA4 File Offset: 0x005A01A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEaseCurveTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEaseCurvePresetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEaseCurveCustomVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
