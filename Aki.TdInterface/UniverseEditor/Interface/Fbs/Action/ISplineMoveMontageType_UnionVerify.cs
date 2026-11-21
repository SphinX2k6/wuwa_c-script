using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200795E RID: 31070
	public static class ISplineMoveMontageType_UnionVerify
	{
		// Token: 0x06036B6B RID: 224107 RVA: 0x00751F2C File Offset: 0x0075012C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IThreeStageSplineMoveMontageVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISplineMoveMontageTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
