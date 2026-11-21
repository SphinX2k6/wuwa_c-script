using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006290 RID: 25232
	public static class TMotorAutoEjectConfigVerify
	{
		// Token: 0x0602AEBC RID: 175804 RVA: 0x005DB634 File Offset: 0x005D9834
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMotorAutoEjectPositionEntityConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMotorAutoEjectNextHookConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
