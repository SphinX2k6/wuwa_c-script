using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C4 RID: 26564
	public static class IFireBulletType_UnionVerify
	{
		// Token: 0x0602E3DE RID: 189406 RVA: 0x00650B04 File Offset: 0x0064ED04
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
