using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F3B RID: 32571
	public static class TModifyActorMaterialParamBySplineProgressTargetVerify
	{
		// Token: 0x0603ABEC RID: 240620 RVA: 0x007E61EC File Offset: 0x007E43EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IModifyActorMaterialParamByPlayerSplineProgressVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IModifyActorMaterialParamByEntitySplineProgressVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
