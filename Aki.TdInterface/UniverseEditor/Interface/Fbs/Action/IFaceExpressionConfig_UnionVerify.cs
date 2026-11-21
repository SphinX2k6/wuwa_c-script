using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCF RID: 28111
	public static class IFaceExpressionConfig_UnionVerify
	{
		// Token: 0x0603085E RID: 198750 RVA: 0x00697158 File Offset: 0x00695358
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFaceExpressionConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFaceExpressionMorphConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFaceExpressionTextureConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFaceExpressionAnimSequenceConfigVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
