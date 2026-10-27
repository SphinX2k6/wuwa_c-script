using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB9 RID: 23737
	public static class TTargetGearGroupFailureConditionVerify
	{
		// Token: 0x06028A32 RID: 166450 RVA: 0x005957E8 File Offset: 0x005939E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFailureConditionArbitraryStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFailureConditionHitTargetEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFailureConditionSequentialStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
