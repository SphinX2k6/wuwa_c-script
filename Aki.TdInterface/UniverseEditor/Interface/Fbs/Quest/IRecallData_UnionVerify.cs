using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044CB RID: 17611
	public static class IRecallData_UnionVerify
	{
		// Token: 0x06019729 RID: 104233 RVA: 0x003A15E8 File Offset: 0x0039F7E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRecallDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestRecallDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILevelPlayRecallDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
