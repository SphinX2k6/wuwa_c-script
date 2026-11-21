using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200785C RID: 30812
	public static class ISetTeleControlConfig_UnionVerify
	{
		// Token: 0x06036306 RID: 221958 RVA: 0x00742474 File Offset: 0x00740674
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetTeleControlConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenGravityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetResetPositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
