using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D6 RID: 30678
	public static class TTeleportConfigVerify
	{
		// Token: 0x06037A63 RID: 227939 RVA: 0x00786950 File Offset: 0x00784B50
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFixedPosVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGravityFlipFixedPosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INearestEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISafePosVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
