using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3B RID: 27451
	public static class IMotorSoarInWindFieldControlType_UnionVerify
	{
		// Token: 0x060302DE RID: 197342 RVA: 0x0068C3D0 File Offset: 0x0068A5D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMotorSoarInWindFieldControlTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMotorSoarInWindFieldEnterWindFieldVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMotorSoarInWindFieldExitWindFieldVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
