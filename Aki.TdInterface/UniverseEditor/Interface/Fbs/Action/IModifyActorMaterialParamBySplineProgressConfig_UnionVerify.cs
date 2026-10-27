using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB1 RID: 27313
	public static class IModifyActorMaterialParamBySplineProgressConfig_UnionVerify
	{
		// Token: 0x0602FDCF RID: 196047 RVA: 0x00682D34 File Offset: 0x00680F34
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IModifyActorMaterialParamBySplineProgressConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IModifyActorMaterialParamBySplineProgressEnterSplineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModifyActorMaterialParamBySplineProgressExitSplineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
