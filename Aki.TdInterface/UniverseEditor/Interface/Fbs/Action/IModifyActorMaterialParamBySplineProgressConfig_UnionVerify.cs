using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071DC RID: 29148
	public static class IModifyActorMaterialParamBySplineProgressConfig_UnionVerify
	{
		// Token: 0x06032B3B RID: 207675 RVA: 0x006D957C File Offset: 0x006D777C
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
