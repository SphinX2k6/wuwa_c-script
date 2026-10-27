using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E8 RID: 30696
	public static class TTrackingEventTypeVerify
	{
		// Token: 0x06037ABF RID: 228031 RVA: 0x00787200 File Offset: 0x00785400
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
