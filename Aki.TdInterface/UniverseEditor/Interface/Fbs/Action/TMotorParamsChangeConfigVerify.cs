using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007721 RID: 30497
	public static class TMotorParamsChangeConfigVerify
	{
		// Token: 0x060376F3 RID: 227059 RVA: 0x00781828 File Offset: 0x0077FA28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMotorSpeedUpConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMotorSpeedDownConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
