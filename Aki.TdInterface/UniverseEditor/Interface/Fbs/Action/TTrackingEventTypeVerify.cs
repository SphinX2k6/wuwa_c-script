using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008026 RID: 32806
	public static class TTrackingEventTypeVerify
	{
		// Token: 0x0603B05E RID: 241758 RVA: 0x007ECAAC File Offset: 0x007EACAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMotorParkourTrackingEventVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEasterEggTrackingEventVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
