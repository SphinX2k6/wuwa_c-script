using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E44 RID: 28228
	public static class IFireBulletType_UnionVerify
	{
		// Token: 0x06030C24 RID: 199716 RVA: 0x0069E248 File Offset: 0x0069C448
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFireBulletTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFireBulletTrackTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFireBulletForwardFrontVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFireBulletTrackPositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
