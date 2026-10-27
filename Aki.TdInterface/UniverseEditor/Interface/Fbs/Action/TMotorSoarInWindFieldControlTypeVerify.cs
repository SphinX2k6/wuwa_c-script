using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007727 RID: 30503
	public static class TMotorSoarInWindFieldControlTypeVerify
	{
		// Token: 0x0603770B RID: 227083 RVA: 0x00781A20 File Offset: 0x0077FC20
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
