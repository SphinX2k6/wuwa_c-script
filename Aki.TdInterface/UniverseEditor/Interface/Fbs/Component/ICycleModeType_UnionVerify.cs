using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200506B RID: 20587
	public static class ICycleModeType_UnionVerify
	{
		// Token: 0x06020FE8 RID: 135144 RVA: 0x004959A0 File Offset: 0x00493BA0
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
