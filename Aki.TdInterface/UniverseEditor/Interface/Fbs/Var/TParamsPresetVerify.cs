using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B52 RID: 15186
	public static class TParamsPresetVerify
	{
		// Token: 0x06014C3A RID: 85050 RVA: 0x0030471C File Offset: 0x0030291C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDecalParamsVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFireBoxLampParamsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILightPlateParamsVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRushWarningEffectParamsVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IScoreDisplayMaterialParamsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ITimeDisplayMaterialParamsVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IWoodenBoxProliferateParamsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
