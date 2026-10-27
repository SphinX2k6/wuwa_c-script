using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007715 RID: 30485
	public static class TModifyActorMaterialParamBySplineProgressVerify
	{
		// Token: 0x060376C3 RID: 227011 RVA: 0x00781438 File Offset: 0x0077F638
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IModifyActorMaterialParamBySplineProgressExitSplineVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IModifyActorMaterialParamBySplineProgressEnterSplineVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
