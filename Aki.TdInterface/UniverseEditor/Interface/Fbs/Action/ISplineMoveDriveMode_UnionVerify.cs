using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007189 RID: 29065
	public static class ISplineMoveDriveMode_UnionVerify
	{
		// Token: 0x06033873 RID: 211059 RVA: 0x006F0D14 File Offset: 0x006EEF14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISplineMoveDriveModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInputDrivenMoveDriveModeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPositionDrivenMoveDriveModeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
