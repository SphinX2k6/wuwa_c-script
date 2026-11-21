using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B05 RID: 31493
	public static class ITalkOptionConditionSystemConfigBase_UnionVerify
	{
		// Token: 0x06038B5E RID: 232286 RVA: 0x007ABF8C File Offset: 0x007AA18C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITalkOptionConditionSolarSchoolVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITalkOptionConditionSystemConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
