using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C5D RID: 19549
	public static class IMusicBeatsConditionBase_UnionVerify
	{
		// Token: 0x0601EFF4 RID: 126964 RVA: 0x00455B5C File Offset: 0x00453D5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMusicBeatsConditionBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckHcMusicBeatsVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckFlForestMusicBeatsVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
