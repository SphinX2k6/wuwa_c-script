using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F50 RID: 32592
	public static class TMotorSoarInWindFieldControlTypeVerify
	{
		// Token: 0x0603AC46 RID: 240710 RVA: 0x007E69B0 File Offset: 0x007E4BB0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMotorSoarInWindFieldExitWindFieldVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMotorSoarInWindFieldEnterWindFieldVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
