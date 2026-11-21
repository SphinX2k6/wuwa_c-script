using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C2B RID: 31787
	public static class ITrackingEventTypeBase_UnionVerify
	{
		// Token: 0x060394B2 RID: 234674 RVA: 0x007BCC10 File Offset: 0x007BAE10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrackingEventTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEasterEggTrackingEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorParkourTrackingEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
