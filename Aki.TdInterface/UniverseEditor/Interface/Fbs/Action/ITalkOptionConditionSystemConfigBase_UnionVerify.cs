using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200732D RID: 29485
	public static class ITalkOptionConditionSystemConfigBase_UnionVerify
	{
		// Token: 0x0603582B RID: 219179 RVA: 0x0074A404 File Offset: 0x00748604
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
