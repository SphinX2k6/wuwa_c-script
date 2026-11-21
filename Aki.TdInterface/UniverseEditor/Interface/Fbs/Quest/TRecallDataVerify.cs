using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004766 RID: 18278
	public static class TRecallDataVerify
	{
		// Token: 0x0601AEB6 RID: 110262 RVA: 0x003D16C8 File Offset: 0x003CF8C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IQuestRecallDataVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILevelPlayRecallDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
