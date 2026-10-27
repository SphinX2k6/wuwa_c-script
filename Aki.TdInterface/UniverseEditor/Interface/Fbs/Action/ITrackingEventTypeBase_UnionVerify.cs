using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007438 RID: 29752
	public static class ITrackingEventTypeBase_UnionVerify
	{
		// Token: 0x060360C9 RID: 221385 RVA: 0x00759EE4 File Offset: 0x007580E4
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
