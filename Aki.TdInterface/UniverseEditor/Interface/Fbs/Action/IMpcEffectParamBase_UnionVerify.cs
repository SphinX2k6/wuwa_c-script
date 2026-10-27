using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B90 RID: 27536
	public static class IMpcEffectParamBase_UnionVerify
	{
		// Token: 0x060305BE RID: 198078 RVA: 0x00691BD4 File Offset: 0x0068FDD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPostProcessVolumeCenterPositionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMpcEffectParamBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
