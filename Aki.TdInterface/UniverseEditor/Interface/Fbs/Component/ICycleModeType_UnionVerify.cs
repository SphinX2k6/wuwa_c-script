using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055CD RID: 21965
	public static class ICycleModeType_UnionVerify
	{
		// Token: 0x06022F22 RID: 143138 RVA: 0x004CF654 File Offset: 0x004CD854
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICycleModeTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPatrolCycleLooplyVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPatrolCycleOncelyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
