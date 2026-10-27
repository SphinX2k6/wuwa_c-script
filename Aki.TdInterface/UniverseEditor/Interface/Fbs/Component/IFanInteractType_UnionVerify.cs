using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200523C RID: 21052
	public static class IFanInteractType_UnionVerify
	{
		// Token: 0x060223D6 RID: 140246 RVA: 0x004BFCA4 File Offset: 0x004BDEA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFanInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFanInteractByHitVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFanInteractByFKeyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
