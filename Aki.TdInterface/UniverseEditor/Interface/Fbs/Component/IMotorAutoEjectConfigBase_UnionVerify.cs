using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AA RID: 21930
	public static class IMotorAutoEjectConfigBase_UnionVerify
	{
		// Token: 0x060244DC RID: 148700 RVA: 0x00502E14 File Offset: 0x00501014
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
