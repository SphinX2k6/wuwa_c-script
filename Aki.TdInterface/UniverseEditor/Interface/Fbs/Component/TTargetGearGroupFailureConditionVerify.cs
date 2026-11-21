using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062EA RID: 25322
	public static class TTargetGearGroupFailureConditionVerify
	{
		// Token: 0x0602B07A RID: 176250 RVA: 0x005DDF5C File Offset: 0x005DC15C
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
