using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006635 RID: 26165
	public static class IElementalBoxTargetPosTypeBase_UnionVerify
	{
		// Token: 0x0602D6FE RID: 186110 RVA: 0x0063962C File Offset: 0x0063782C
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
