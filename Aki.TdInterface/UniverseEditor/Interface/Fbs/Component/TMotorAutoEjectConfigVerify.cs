using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C68 RID: 23656
	public static class TMotorAutoEjectConfigVerify
	{
		// Token: 0x060288A0 RID: 166048 RVA: 0x005932D0 File Offset: 0x005914D0
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
