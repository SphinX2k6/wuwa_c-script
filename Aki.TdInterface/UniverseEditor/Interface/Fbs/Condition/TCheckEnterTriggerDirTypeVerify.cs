using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D2F RID: 19759
	public static class TCheckEnterTriggerDirTypeVerify
	{
		// Token: 0x0601F5D7 RID: 128471 RVA: 0x0045F48C File Offset: 0x0045D68C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckEnterTriggerDirTypeVelocityDirAngleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckEnterTriggerDirTypeForwardAngleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
