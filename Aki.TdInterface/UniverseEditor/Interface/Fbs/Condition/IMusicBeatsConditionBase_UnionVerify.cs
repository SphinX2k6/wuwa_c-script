using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005156 RID: 20822
	public static class IMusicBeatsConditionBase_UnionVerify
	{
		// Token: 0x06020C16 RID: 134166 RVA: 0x004896AC File Offset: 0x004878AC
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
