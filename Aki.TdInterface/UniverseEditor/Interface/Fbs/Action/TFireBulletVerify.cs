using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EE1 RID: 32481
	public static class TFireBulletVerify
	{
		// Token: 0x0603A9CE RID: 240078 RVA: 0x007E2B9C File Offset: 0x007E0D9C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFireBulletForwardFrontVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFireBulletTrackPositionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFireBulletTrackTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
