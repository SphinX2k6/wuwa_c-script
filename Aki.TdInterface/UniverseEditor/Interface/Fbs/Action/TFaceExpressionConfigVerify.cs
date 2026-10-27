using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C7 RID: 30407
	public static class TFaceExpressionConfigVerify
	{
		// Token: 0x060374E5 RID: 226533 RVA: 0x0077E3F0 File Offset: 0x0077C5F0
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
