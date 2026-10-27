using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AFB RID: 23291
	public static class ITurntableControlType_UnionVerify
	{
		// Token: 0x06027C2D RID: 162861 RVA: 0x0057809C File Offset: 0x0057629C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITurntableControlTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFreeAngleTurntableVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFixedAngleTurntableVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
