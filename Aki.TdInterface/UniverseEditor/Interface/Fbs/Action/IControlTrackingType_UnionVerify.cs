using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064E2 RID: 25826
	public static class IControlTrackingType_UnionVerify
	{
		// Token: 0x0602CCC5 RID: 183493 RVA: 0x00627D10 File Offset: 0x00625F10
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
