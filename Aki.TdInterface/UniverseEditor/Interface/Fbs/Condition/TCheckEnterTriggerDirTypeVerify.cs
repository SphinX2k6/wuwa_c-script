using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200522B RID: 21035
	public static class TCheckEnterTriggerDirTypeVerify
	{
		// Token: 0x0602121E RID: 135710 RVA: 0x0049341C File Offset: 0x0049161C
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
