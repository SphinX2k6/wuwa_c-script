using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E8 RID: 29160
	public static class IModifyActorMaterialParamBySplineProgressTarget_UnionVerify
	{
		// Token: 0x06032BA1 RID: 207777 RVA: 0x006DA294 File Offset: 0x006D8494
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IModifyActorMaterialParamBySplineProgressTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IModifyActorMaterialParamByPlayerSplineProgressVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IModifyActorMaterialParamByEntitySplineProgressVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
