using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C20 RID: 27680
	public static class IOpenQteConfig_UnionVerify
	{
		// Token: 0x06030ADC RID: 199388 RVA: 0x0069BAC8 File Offset: 0x00699CC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IOpenQteConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenPanelQteQteVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IOpenLevelQteVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
