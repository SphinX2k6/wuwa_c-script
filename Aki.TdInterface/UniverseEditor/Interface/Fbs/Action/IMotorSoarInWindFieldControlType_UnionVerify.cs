using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007281 RID: 29313
	public static class IMotorSoarInWindFieldControlType_UnionVerify
	{
		// Token: 0x06033135 RID: 209205 RVA: 0x006E498C File Offset: 0x006E2B8C
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
