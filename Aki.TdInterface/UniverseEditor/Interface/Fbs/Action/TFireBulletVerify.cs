using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D3 RID: 30419
	public static class TFireBulletVerify
	{
		// Token: 0x06037519 RID: 226585 RVA: 0x0077E888 File Offset: 0x0077CA88
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
