using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CA6 RID: 27814
	public static class IElementalBoxTargetPosTypeBase_UnionVerify
	{
		// Token: 0x0602FECF RID: 196303 RVA: 0x00686194 File Offset: 0x00684394
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IElementalBoxTargetPosTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IElementalBoxTargetPrefabPosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IElementalBoxTargetRelativePosVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
