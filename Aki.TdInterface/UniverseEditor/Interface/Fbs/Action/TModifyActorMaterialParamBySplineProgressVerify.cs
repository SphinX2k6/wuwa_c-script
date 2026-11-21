using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F38 RID: 32568
	public static class TModifyActorMaterialParamBySplineProgressVerify
	{
		// Token: 0x0603ABE0 RID: 240608 RVA: 0x007E60F0 File Offset: 0x007E42F0
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
