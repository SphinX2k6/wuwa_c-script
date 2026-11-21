using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4D RID: 27469
	public static class IControlTrackingType_UnionVerify
	{
		// Token: 0x0602F449 RID: 193609 RVA: 0x00673E38 File Offset: 0x00672038
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IControlTrackingTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IControlTrackingSelfVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IControlTrackingOtherVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
