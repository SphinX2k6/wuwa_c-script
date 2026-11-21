using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ED5 RID: 32469
	public static class TFaceExpressionConfigVerify
	{
		// Token: 0x0603A99A RID: 240026 RVA: 0x007E2704 File Offset: 0x007E0904
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFaceExpressionAnimSequenceConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFaceExpressionMorphConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFaceExpressionTextureConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFaceExpressionTextureMultiSlotConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
