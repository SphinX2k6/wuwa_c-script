using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063DC RID: 25564
	public static class IEaseCurveType_UnionVerify
	{
		// Token: 0x0602B6CB RID: 177867 RVA: 0x005EACD4 File Offset: 0x005E8ED4
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
