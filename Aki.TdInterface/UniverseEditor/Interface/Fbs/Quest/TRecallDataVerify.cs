using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004307 RID: 17159
	public static class TRecallDataVerify
	{
		// Token: 0x06019734 RID: 104244 RVA: 0x003A5D98 File Offset: 0x003A3F98
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
