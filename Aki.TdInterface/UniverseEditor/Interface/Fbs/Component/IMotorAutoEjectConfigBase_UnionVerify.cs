using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B48 RID: 23368
	public static class IMotorAutoEjectConfigBase_UnionVerify
	{
		// Token: 0x060266E9 RID: 157417 RVA: 0x0054338C File Offset: 0x0054158C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMotorAutoEjectConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMotorAutoEjectNextHookConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorAutoEjectPositionEntityConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
