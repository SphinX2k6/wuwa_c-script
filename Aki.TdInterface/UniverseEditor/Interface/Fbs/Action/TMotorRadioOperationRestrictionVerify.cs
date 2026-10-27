using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007724 RID: 30500
	public static class TMotorRadioOperationRestrictionVerify
	{
		// Token: 0x060376FF RID: 227071 RVA: 0x00781924 File Offset: 0x0077FB24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnableAllMotorRadioOperationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDisableAllMotorRadioOperationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
