using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008011 RID: 32785
	public static class TTeleportConfigVerify
	{
		// Token: 0x0603AFF6 RID: 241654 RVA: 0x007EC100 File Offset: 0x007EA300
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
